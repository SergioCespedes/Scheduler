using Scheduler.Formularios;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelHoras.Visible = false;
            panelUsuarios.Visible = false;
            panelHorarios.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        #region Horas

        private void btnHoras_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHoras);
        }

        private void btnGestionHoras_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoras());
        }

        #endregion


        #region Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUsuarios);
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmUsuariosGestion());
        }

        #endregion


        #region Horarios
        private void btnHorarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHorarios);
        }
        private void btnGestionarHorarios_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHorarios());
        }
        private void btnConsultarHorario_Click(object sender, EventArgs e)
        {
            openChildForm(new frmConsultarHorarios(this));
        }
        #endregion



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
