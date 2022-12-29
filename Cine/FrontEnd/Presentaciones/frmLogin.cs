using Backend.Servicios;
using Backend.Servicios.Interfaces;
using Backend.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Presentaciones
{
    public partial class frmLogin : Form
    {
        List<Usuario> lstUsuarios;
        private IServicio servicio;
        
        public frmLogin()
        {
            InitializeComponent();
            lstUsuarios = new List<Usuario>();
            servicio = new FabricaServiciosImp().CrearServicio();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
            cargarLista();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            cargarLista();
            bool flag_inicio = false;
            bool inicioExitoso = false;

            if (txtUsuario.Text != "" && txtContra.Text != "")
            {
                foreach (Usuario oUsuario in lstUsuarios)
                {
                    if (txtUsuario.Text == oUsuario.pnombre && txtContra.Text == oUsuario.pcontraseña)
                    {
                        this.Close();
                        var frm = new frmAtajos();
                        frm.Show();                       
                        inicioExitoso = true;
                    }
                }
            }
            if (inicioExitoso == false && txtContra.Text != string.Empty && txtUsuario.Text != string.Empty)
            {
                MessageBox.Show("Datos incorrectos.");
            }
            if (txtContra.Text == string.Empty && txtUsuario.Text == string.Empty && inicioExitoso == false)
            {
                MessageBox.Show("Ingrese nombre y contraseña.");
            }
        }

        private void cargarLista()
        {
            lstUsuarios.Clear();
            listBox1.Items.Clear();
            DataTable T1 = servicio.getConsultarUsuarios();
            foreach (DataRow fila in T1.Rows)
            {
                Usuario u = new Usuario();
                u.pnombre = Convert.ToString(fila["usuario"]);
                u.pcontraseña = Convert.ToString(fila["contras"]);

                lstUsuarios.Add(u);
                listBox1.Items.Add(u.pnombre.ToString());
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtContra.UseSystemPasswordChar == true)
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else
                txtContra.UseSystemPasswordChar = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCampos(int posicion)
        {

            Usuario m = new Usuario();
            txtContra.Text = lstUsuarios[posicion].pcontraseña.ToString();
            txtUsuario.Text = lstUsuarios[posicion].pnombre.ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(listBox1.SelectedIndex);
            btnVer.Enabled = false;
        }
    }
}
