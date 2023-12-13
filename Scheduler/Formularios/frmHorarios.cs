using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler {
    public partial class frmHorarios : Form {
        frmMain GetForm;
        int codigoHorario = 0;
        string valorCelda = "";
        string nombreColumna = "";
        
        public frmHorarios(int codigoHorario = 0, frmMain main = null) {
            InitializeComponent();
            CargarComboDias();
            CargarComboHoras();
            CargarTablaHorario();
            if (dgvHorarios.RowHeadersVisible)
            {
                dgvHorarios.RowHeadersVisible = false;
            }
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            GetForm = main;
            codigoHorario = codigoHorario;
            if (codigoHorario != 0)
            {
                Horario horario = new Horario();
                List<Horario> listaHorarios = horario.ConsultarPorID(codigoHorario);
                PintarTabla(listaHorarios);
                txtCodigoHorario.Text = Convert.ToString(listaHorarios[0].codigoHorario);
                txtNombreHorario.Text = Convert.ToString(listaHorarios[0].nombre);
                txtCodigoHorario.Enabled = false;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
            }
        }
        public void Limpiar() 
        {
            txtCodigoHorario.Text = "";
            txtNombreHorario.Text = "";
            txtCodigoHorario.Enabled = true;
            txtNombreHorario.Enabled = true;
            CargarTablaHorario();
            cmbDia.SelectedIndex = -1;
            cmbHora.SelectedIndex = -1;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

        }

        private void dgvHoras_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                valorCelda = Convert.ToString(dgvHorarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                // Obtener el valor del encabezado de la columna
                nombreColumna = dgvHorarios.Columns[e.ColumnIndex].HeaderText;

                // Seleccionar el valor en el ComboBox si el nombre de la columna coincide con el valor
                cmbDia.SelectedItem = nombreColumna;
                cmbHora.SelectedItem = valorCelda;
            }   
        }

        private void ActiviarBotonesModificarYEliminar() {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void dgvHoras_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            dgvHorarios.ClearSelection();
        }

        private void CargarTablaHorario() 
        {
            List<string> horas = new List<string>();
            horas = ObtenerHorasDelDia();
            List<string> dias = new List<string>();
            dias = ObtenerDiasDeLaSemana();
            ConfigurarDataGridView(dgvHorarios, horas, dias);
            dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PintarTabla(List<Horario> listaHorarios)
        {
            for (int i = 0; i < listaHorarios.Count(); i++)
            {
                BuscarCeldaEnColumna(listaHorarios[i].dia, listaHorarios[i].horaInicio);
            }
        }

        private void BuscarCeldaEnColumna(string nombreColumna, string valorBuscado)
        {
            foreach (DataGridViewRow row in dgvHorarios.Rows)
            {
                // Obtener el índice de la columna por su nombre
                int columnIndex = dgvHorarios.Columns.Cast<DataGridViewColumn>()
                    .First(c => c.Name == nombreColumna).Index;

                // Verificar si el valor de la celda en la columna deseada coincide con el valor buscado
                if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() == valorBuscado)
                {
                    row.Cells[columnIndex].Style.BackColor = System.Drawing.Color.Red;
                }
            }
        }


        private List<string> ObtenerHorasDelDia()
        {
            List<string> horas = new List<string>();

            for (int hora = 0; hora < 24; hora++)
            {
                // Agregar horas en formato de dos dígitos y minutos en formato de dos dígitos (HH:mm)
                horas.Add($"{hora:D2}:{00:D2}");

            }

            return horas;
        }
        public List<string> ObtenerDiasDeLaSemana()
        {
            // Puedes personalizar los días según tus necesidades
            return new List<string> { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        } 
        static void ConfigurarDataGridView(DataGridView dataGridView, List<string> horasDelDia, List<string> diasDeLaSemana)
        {
            // Limpiar las columnas existentes en el DataGridView
            dataGridView.Columns.Clear();

            // Agregar columnas por cada día de la semana
            foreach (var dia in diasDeLaSemana)
            {
                dataGridView.Columns.Add(dia, dia);
            }

            // Agregar filas al DataGridView y llenarlas con las horas
            foreach (var hora in horasDelDia)
            {
                // Crear una fila para cada hora
                DataGridViewRow row = new DataGridViewRow();

                // Agregar celdas con la misma hora a cada columna (día de la semana)
                foreach (var dia in diasDeLaSemana)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = hora });
                }

                // Agregar la fila completa al DataGridView
                dataGridView.Rows.Add(row);
            }
        }

        private void CargarComboDias()
        {
            Dia dia = new Dia();

            DataTable dt = new DataTable();

            dt = dia.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                //una asegurado que el dt tiene valores, los "dibujo" en el combobox
                cmbDia.ValueMember = "IdDia";
                cmbDia.DisplayMember = "Descripcion";

                cmbDia.DataSource = dt;

                cmbDia.SelectedIndex = -1;

            }
        }

        private void CargarComboHoras()
        {
            Hora Hora = new Hora();

            DataTable dt = new DataTable();

            dt = Hora.ListarCmb();

            if (dt != null && dt.Rows.Count > 0)
            {
                //una asegurado que el dt tiene valores, los "dibujo" en el combobox
                cmbHora.ValueMember = "idhora";
                cmbHora.DisplayMember = "Horas";

                cmbHora.DataSource = dt;

                cmbHora.SelectedIndex = -1;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Horario nuevaHorario = new Horario();
            nuevaHorario.codigoHorario = Convert.ToInt32(txtCodigoHorario.Text);
            nuevaHorario.nombre = txtNombreHorario.Text;
            nuevaHorario.idDia = Convert.ToInt32(cmbDia.SelectedValue);
            nuevaHorario.idHora = Convert.ToInt32(cmbHora.SelectedValue);
            nuevaHorario.idUser = 1;
            if (ValidarCampos())
            {
                bool ok = nuevaHorario.Agregar();

                if (ok)
                {
                    MessageBox.Show("Horario ingresado correctamente!", ":)", MessageBoxButtons.OK);

                    CargarTablaHorario();
                    Horario horario = new Horario();
                    List<Horario> listaHorarios = horario.ConsultarPorID(codigoHorario);
                    PintarTabla(listaHorarios);

                }
                else
                {
                    MessageBox.Show("El horario no se pudo agregar...", ":(", MessageBoxButtons.OK);
                }
            }

        }

        private bool ValidarCampos()
        {
            // Verificar si el campo txtCodigoHorario contiene datos
            if (string.IsNullOrWhiteSpace(txtCodigoHorario.Text))
            {
                MessageBox.Show("Por favor, ingresa un código de horario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar si el campo txtNombreHorario contiene datos
            if (string.IsNullOrWhiteSpace(txtNombreHorario.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre de horario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar si se ha seleccionado un valor en cmbDia
            if (cmbDia.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un día.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar si se ha seleccionado un valor en cmbHora
            if (cmbHora.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona una hora.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Todos los campos contienen datos, la validación es exitosa
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Horario nuevaHorario = new Horario();
            nuevaHorario.codigoHorario = Convert.ToInt32(txtCodigoHorario.Text);
            nuevaHorario.nombre = txtNombreHorario.Text;
            nuevaHorario.idDia = Convert.ToInt32(cmbDia.SelectedValue);
            nuevaHorario.idHora = Convert.ToInt32(cmbHora.SelectedValue);
            if (ValidarCampos())
            {
                bool ok = nuevaHorario.Actualizar();

                if (ok)
                {
                    MessageBox.Show("Horario ingresado correctamente!", ":)", MessageBoxButtons.OK);

                    CargarTablaHorario();
                    Horario horario = new Horario();
                    List<Horario> listaHorarios = horario.ConsultarPorID(nuevaHorario.codigoHorario);
                    PintarTabla(listaHorarios);
                    btnModificar.Enabled = true;
                    btnAgregar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El horario no se pudo agregar...", ":(", MessageBoxButtons.OK);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
