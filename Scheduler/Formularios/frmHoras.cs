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
    public partial class frmHoras : Form {
        public frmHoras() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Hora nuevaHora =  new Hora();
            nuevaHora.horaInicio = dtpHoraInicio.Value.TimeOfDay;
            nuevaHora.horaFinal = dtpHoraFin.Value.TimeOfDay;
            //MessageBox.Show(nuevaHora.horaInicio + " " + nuevaHora.horaFinal);
            bool res = nuevaHora.Agregar();
            //MessageBox.Show(res + " ");
            cargarHoras();
        }

        private void frmHoras_Load(object sender, EventArgs e) {
            dgvHoras.CellFormatting += dataGridView1_CellFormatting;
            cargarHoras();
            ActivarBotonAgregar();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            // Verificar si la columna actual es la que contiene las fechas
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2) {
                // Verificar si la celda actual no está vacía
                if (e.Value != null) {
                    // Convertir el valor de la celda a DateTime
                    if (DateTime.TryParse(e.Value.ToString(), out DateTime dateValue)) {
                        // Formatear la fecha para mostrar solo la parte de la hora
                        e.Value = dateValue.ToString("HH:mm:ss");
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void cargarHoras() {
            Hora nuevaHora = new Hora();
            DataTable dt = new DataTable();
            dt = nuevaHora.Listar();
            dgvHoras.DataSource = dt;
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e) {
            limpiarHoras();
            ActivarBotonAgregar();
        }

        private void limpiarHoras() {
            DateTime date1 = DateTime.ParseExact("1900-01-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact("1900-01-01 01:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            dtpHoraInicio.Value = date1;
            dtpHoraFin.Value = date2;
        }

        private void dgvHoras_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvHoras.SelectedRows.Count == 1) {
                limpiarHoras();
                DataGridViewRow MiDgvFila = dgvHoras.SelectedRows[0];
                int Idhora = Convert.ToInt32(MiDgvFila.Cells["ColIdHora"].Value);

                Hora nuevaHora = new Hora();
                nuevaHora = nuevaHora.ConsultarPorID(Idhora);

                if (nuevaHora != null && nuevaHora.idhora > 0) {
                    string horas = nuevaHora.horaInicio.Hours.ToString();
                    string minutos = nuevaHora.horaInicio.Minutes.ToString();
                    string segundos = nuevaHora.horaInicio.Seconds.ToString();
                    if (horas.Length == 1) {
                        horas = "0" + horas;
                    }
                    if (minutos.Length == 1) {
                        minutos = "0" + minutos;
                    }
                    if (segundos.Length == 1) {
                        segundos = "0" + segundos;
                    }

                    string final = "1900-01-01 " + horas + ":" + minutos + ":" + segundos;
                    DateTime date = DateTime.ParseExact(final, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    dtpHoraInicio.Value = date;

                    string horas2 = nuevaHora.horaFinal.Hours.ToString();
                    string minutos2 = nuevaHora.horaFinal.Minutes.ToString();
                    string segundos2 = nuevaHora.horaFinal.Seconds.ToString();
                    if (horas2.Length == 1) {
                        horas2 = "0" + horas2;
                    }
                    if (minutos2.Length == 1) {
                        minutos2 = "0" + minutos2;
                    }
                    if (segundos2.Length == 1) {
                        segundos2 = "0" + segundos2;
                    }
                    string final2 = "1900-01-01 " + horas2 + ":" + minutos2 + ":" + segundos2;
                    DateTime date2 = DateTime.ParseExact(final2, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    dtpHoraFin.Value = date2;
                    ActiviarBotonesModificarYEliminar();
                }
            }
        }

        private void ActiviarBotonesModificarYEliminar() {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void ActivarBotonAgregar() {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dgvHoras_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            dgvHoras.ClearSelection();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            Hora nuevaHora = new Hora();
            if (dgvHoras.SelectedRows.Count == 1) {
                DataGridViewRow MiDgvFila = dgvHoras.SelectedRows[0];
                int Idhora = Convert.ToInt32(MiDgvFila.Cells["ColIdHora"].Value);
                nuevaHora.horaInicio = dtpHoraInicio.Value.TimeOfDay;
                nuevaHora.horaFinal = dtpHoraFin.Value.TimeOfDay;
                nuevaHora.idhora = Idhora;
                if (nuevaHora.ConsultarPorID()) {
                    DialogResult resp = MessageBox.Show("Desea modificar la hora?", "???", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes) {
                        if (nuevaHora.Actualizar()) {
                            MessageBox.Show("Hora modificada correctamente!", ":)", MessageBoxButtons.OK);
                            cargarHoras();
                            ActivarBotonAgregar();
                            limpiarHoras();
                        }
                    }
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (dgvHoras.SelectedRows.Count == 1) {
                DataGridViewRow MiDgvFila = dgvHoras.SelectedRows[0];
                int Idhora = Convert.ToInt32(MiDgvFila.Cells["ColIdHora"].Value);
                if (Idhora > 0) {
                    string msg = string.Format("Esta seguro de eliminar la hora {0}?", Idhora);
                    DialogResult respuesta = MessageBox.Show(msg, "Confirmacion requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Hora nuevaHora = new Hora();
                    nuevaHora.idhora = Idhora;
                    if (respuesta == DialogResult.Yes && nuevaHora.Eliminar()) {
                        MessageBox.Show("La hora ha sido eliminada", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarHoras();
                        cargarHoras();
                        ActivarBotonAgregar();
                    }
                }
                
            }
        }
    }
}
