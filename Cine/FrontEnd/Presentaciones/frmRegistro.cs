using Backend.Dominio;
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

namespace FrontEnd.Presentaciones
{
    public partial class frmRegistro : Form
    {
        private IServicio servicio;
        public frmRegistro()
        {
            InitializeComponent();
            servicio = new FabricaServiciosImp().CrearServicio();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
            txtConfContra.UseSystemPasswordChar = true;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Usuario u1 = new Usuario();
            u1.nombre = txtNombreUsuario.Text;
            u1.contra = txtContra.Text;
            if (validaOk())
            {
                if (servicio.getInsertarUsuarios(u1))
                {
                    MessageBox.Show("Se insertó usuario.");
                    limpiarRegistro();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el usuario.");
                }

            }
        }

        private bool validaOk()
        {
            if (txtContra.Text != txtConfContra.Text)
            {
                MessageBox.Show("debe coincidir la contraseña con la confirmacion");
                return false;
            }
            if (txtContra.Text == null || txtNombreUsuario.Text == null || txtConfContra.Text == null)
            {
                MessageBox.Show("debe ingresar todos los datos");
                return false;
            }
            return true;

        }
        private void limpiarRegistro()
        {
            txtNombreUsuario.Text = "";
            txtContra.Text = "";
            txtConfContra.Text = "";
        }

        private void btnVer2_Click(object sender, EventArgs e)
        {
            if (txtContra.UseSystemPasswordChar == true)
            {
                txtContra.UseSystemPasswordChar = false;

            }
            else
                txtContra.UseSystemPasswordChar = true;


            if (txtConfContra.UseSystemPasswordChar == true)
            {
                txtConfContra.UseSystemPasswordChar = false;
            }
            else
                txtConfContra.UseSystemPasswordChar = true;
        }
    }
}
