using Backend.Dominio;
using Backend.Servicios.Implementaciones;
using Backend.Servicios;
using Backend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Datos;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace FrontEnd.Presentaciones
{
    public partial class frmAltaClientes : Form
    {
        private Cliente cliente;
        public frmAltaClientes()
        {
            InitializeComponent();
            servicio = new FabricaServiciosImp().CrearServicio();
            cliente = new Cliente();
        }
        private IServicio servicio;


        private static frmAltaClientes instancia = null;

        public static frmAltaClientes ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmAltaClientes();
            }
            return instancia;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAltaClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }
        private async Task cargarClientes()
        {
            string url = "https://localhost:7066/consultaClientes";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(data);
            dataGridView1.DataSource = lst;
        }

        private async Task insertarClientesAsync()
        {
            
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Dni = Convert.ToInt64(txtDni.Text);
            cliente.Calle = txtCalle.Text;
            cliente.Altura = Convert.ToInt32(txtAltura.Text);
            cliente.Email = txtEmail.Text;
            cliente.Telefono = Convert.ToInt64(txtTelefono.Text);



            string bodyContent = JsonConvert.SerializeObject(cliente);
            string url = "https://localhost:7066/cliente";
            var result = await ClientSingleton.GetInstancia().PostAsync(url, bodyContent);

            if (result.Equals("1"))
            {
                MessageBox.Show("Cliente Registrado",
                    "Informe",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cargarClientes();
            }
            else
            {
                MessageBox.Show("Cliente no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validarCliente())
            {
                insertarClientesAsync();
            }

        }

        private bool validarCliente()
        {
            bool ok = true;

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Insertar nombre.");
                txtNombre.Focus();
                ok = false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingresar apellido.");
                txtApellido.Focus();
                ok = false;
            }
            if(txtDni.Text == "")
            {
                MessageBox.Show("Ingresar DNI.");
                txtDni.Focus();
                ok = false;
            }
            else
            {
                try
                {
                    Convert.ToInt64(txtDni.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese un número válido");
                    txtDni.Clear();
                    txtDni.Focus();
                    ok = false;
                }
            }
            if (txtCalle.Text == "")
            {
                MessageBox.Show("Ingresar calle.");
                txtCalle.Focus();
                ok = false;
            }
            if (txtAltura.Text == "")
            {
                MessageBox.Show("Ingresar altura.");
                txtAltura.Focus();
                ok = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtAltura.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese un número válido");
                    txtAltura.Clear();
                    txtAltura.Focus();
                    ok = false;
                }
            }
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo válido");
                txtEmail.Clear();
                txtEmail.Focus();
                ok = false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingresar teléfono.");
                txtTelefono.Focus();
                ok = false;
            }
            else
            {
                try
                {
                    Convert.ToInt64(txtTelefono.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese un número válido");
                    txtTelefono.Clear();
                    txtTelefono.Focus();
                    ok = false;
                }
            }

            return ok;
        }

        private void limpiar()
        {
            txtAltura.Text = "";
            txtApellido.Text= "";
            txtCalle.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
            
        }
        private async Task eliminarCliente(int id)
        {
            var url = "https://localhost:7066/eliminarCliente?id=" + id;
            var result = await ClientSingleton.GetInstancia().DeleteAsync(url);
            //COMPLETAR
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int entero;
            if (dataGridView1.CurrentCell.ColumnIndex == 0) 
            {
                entero = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                await eliminarCliente(entero);
            }           
            await cargarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea limpiar los campos?", "CANCELANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpiar();
            }      
        }
    }
}
