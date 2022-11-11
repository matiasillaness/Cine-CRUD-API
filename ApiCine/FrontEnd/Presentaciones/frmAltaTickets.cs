using Backend.Datos;
using Backend.Dominio;
using Backend.Servicios;
using Backend.Servicios.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrontEnd.Presentaciones
{
    public partial class frmAltaTickets : Form
    {
        private IServicio servicio;

        private DetalleTicket detalle;

        private Ticket oTicket;

        private Cliente cliente;

        private static frmAltaTickets instancia = null;

        public static frmAltaTickets ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmAltaTickets();
            }
            
            return instancia;
        }

        public frmAltaTickets()
        {
            InitializeComponent();
            servicio = new FabricaServiciosImp().CrearServicio();
            oTicket = new Ticket();
            detalle = new DetalleTicket();
        }

        private void frmAltaTickets_Load(object sender, EventArgs e)
        {
            cargarFunciones();
            cargarTipoPago();
            cargarClientes();
            textooTicket();
        }

        private async Task cargarFunciones()
        {
            string url = "https://localhost:7066/consultaFunciones";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Funcion>>(data);
            cboFuncion.DataSource = lst;
            cboFuncion.DisplayMember = "Pelicula";
            cboFuncion.ValueMember = "id_funcion";
            cboFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async Task cargarTipoPago()
        {
            string url = "https://localhost:7066/consultaTipoPago";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoPago>>(data);
            cboTipoPagos.DataSource = lst;
            cboTipoPagos.DisplayMember = "nombreTipo";
            cboTipoPagos.ValueMember = "idTipoPago ";
            cboTipoPagos.DropDownStyle = ComboBoxStyle.DropDownList;
      
        }
        private async Task cargarClientes()
        {
            string url = "https://localhost:7066/consultarClientes";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(data);
            cboClientes.DataSource = lst;
            cboClientes.DisplayMember ="Dni";
            cboClientes.ValueMember = "Id_Cliente";
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async Task<List<Cliente>> cargarClientes2()
        {
            string url = "https://localhost:7066/consultarClientes";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(data);
            return lst;
        }
        private async Task insertarTicket()
        {

        }
        private async Task insertarDetalles()
        {

        }

      

        private bool Validar()
        {
            bool ok = true;

            if (cboButaca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione butaca");
                cboButaca.Focus();
                ok = false;
            }
            if (cboFuncion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione función");
                cboFuncion.Focus();
                ok = false;
            }
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["id_pelicula"].Value.ToString().Equals(cboFuncion.Text) && row.Cells["id_butaca"].Value.ToString().Equals(cboButaca.Text))
                {
                    MessageBox.Show("Butaca ya reservada");
                    ok = false;
                }
            }
            if (txtDescuento.Text == "")
            {
                MessageBox.Show("Seleccionar descuento");
                txtDescuento.Focus();
                ok = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDescuento.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Solo números");
                    txtDescuento.Focus();
                    ok = false;
                }
            }
            return ok;
        }

        private void limpiar()
        {
            cboFuncion.SelectedValue = -1;
            cboButaca.SelectedValue = -1;
            cboClientes.SelectedValue = -1;
            cboTipoPagos.SelectedValue = -1;
            txtDescuento.Text = Convert.ToString(0);
            dgvDetalles.Rows.Clear();
           
        }

        private async void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (Validar())
            {
                //DataRowView item = (DataRowView)cboFuncion.SelectedItem;
                //int numbutaca = Convert.ToInt32(cboButaca.SelectedItem);
                //string funcion = item.Row.ItemArray[1].ToString();
                //double costo = Convert.ToDouble(item.Row.ItemArray[2]);
                //double descuento = Convert.ToDouble(txtDescuento.Text);

                //dgvDetalles.Rows.Add(new object[] { cboButaca.SelectedValue,cboFuncion.SelectedValue,cboTipoPagos.SelectedValue,txtCosto.Text,txtDescuento.Text });
                //List<Cliente> lst = await cargarClientes2();
                //for (int i = 0; i < lst.Count; i++)
                //{     
                //    string nombre = Convert.ToString(lst[i].Nombre);
                //    long dni = (int)lst[i].Dni;
                //    int id = (int)lst[i].Id_Cliente;
                //    string apellido = Convert.ToString(lst[i].Apellido);
                //    string email = Convert.ToString(lst[i].Email);
                //    string calle = Convert.ToString(lst[i].Calle);
                //    int altura = (int)lst[i].Altura;
                //    long telefono = (long)lst[i].Telefono;
                //    Cliente cliente = new Cliente(id, nombre, apellido, dni, email, calle, altura, telefono);


                //}
               
                //TRACKEAR LAS PELICULAS Y FUNCIONES ASI PODEMOS CARGAR EN LA DATAGRIDVIEW LOS DATOS CORRESPONDIENTES PARA UNA MEJOR VISUALIZACION
                
                int Butaca = (int)cboButaca.SelectedIndex;
                double Descuento = Convert.ToDouble(txtDescuento.Text);
                double Costo = Convert.ToDouble(txtCosto2.Text);
                int Funcion = Convert.ToInt32(cboFuncion.SelectedValue);
                DetalleTicket dt = new DetalleTicket(Costo,Butaca,Funcion,Descuento);

                oTicket.AgregarDetalle(dt);
                dgvDetalles.Rows.Add(new object[] { dt.Descuento, dt.Costo, dt.Funcion, dt.Butaca});






            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        private async Task textooTicket()
        {
            string url = "https://localhost:7066/proximoTicket";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            int lst = JsonConvert.DeserializeObject<int>(data);
            lblProximoTicket.Text = "TICKET Nº " + lst;
        }
    }
}
