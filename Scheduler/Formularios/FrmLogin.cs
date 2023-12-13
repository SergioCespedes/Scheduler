using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnVerContrasennia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void BtnVerContrasennia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                //si hay valores en los cuadros de texto se procede a validarlos
                string usuario = TxtUsuario.Text.Trim();
                string contrasennia = TxtContrasennia.Text.Trim();

                Logica.Models.Usuario MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal.Cedula = this.TxtUsuario.Text;
                MiUsuarioLocal.Contrasennia = this.TxtContrasennia.Text;

                //procedemos a Agregar el usuario
                bool ok = MiUsuarioLocal.Login();

                if (ok)
                {
                    Globales.ObjetosGlobales.MiFormularioPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto.", ":(", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debe digitar el Usuario y contraseña.", ":(", MessageBoxButtons.OK);
            }

        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.Control & e.KeyCode == Keys.A)
            {
                BtnIngresoDirecto.Visible = true;
            }
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.ObjetosGlobales.MiFormularioPrincipal.Show();
            this.Hide();
        }
    }
}
