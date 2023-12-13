using Logica.Models;
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
    public partial class frmConsultarHorarios : Form
    {
        frmMain GetForm;
        public frmConsultarHorarios(frmMain main)
        {
            InitializeComponent();
            dtgLista.RowHeadersVisible = false;
            dtgLista.AllowUserToResizeRows = false;
            dtgLista.Dock = DockStyle.Fill;
            CargarTabla();
            GetForm = main;
        }
        private void dtgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgLista.ClearSelection();
        }
        public void CargarTabla()
        {
            try
            {
                Horario horario = new Horario();
                List<Horario> listaHorarios = new List<Horario>();
                listaHorarios = horario.Listar();
                if (listaHorarios.Count() > 0)
                {
                    foreach (Horario horariu in listaHorarios)
                    {
                        int rowIndex = dtgLista.Rows.Add();
                        dtgLista.Rows[rowIndex].Cells[0].Value = horariu.idHorario.ToString();
                        dtgLista.Rows[rowIndex].Cells[1].Value = horariu.nombre.ToString();
                        dtgLista.Rows[rowIndex].Cells[2].Value = horariu.codigoHorario.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Sin resultados", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los Horarios");
                Console.WriteLine(ex.ToString());
            }

        }

        private void dtgLista_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1) // Encabezado de columna
            {

                e.CellStyle.Font = new Font("Arial", 10, FontStyle.Bold);


                // Alineación centrada del texto en el encabezado
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(e.Value?.ToString(), e.CellStyle.Font, Brushes.White, e.CellBounds, sf);
                }


                e.Handled = true;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == acciones.Index) // Reemplaza "columnaEditar" con el nombre de tu columna
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                Image imagenEditar = Properties.Resources.edit_icon; // Cambia "edit_icon" con el nombre de tu imagen en los recursos

                int nuevoAncho = 20; // Nuevo ancho deseado del ícono
                int nuevoAlto = 20;  // Nuevo alto deseado del ícono

                //Escala la imagen al nuevo tamaño
                Bitmap imagenEscalar = new Bitmap(imagenEditar, nuevoAncho, nuevoAlto);

                // Convierte la imagen escalada en un objeto Icon
                Icon iconoEditar = Icon.FromHandle(imagenEscalar.GetHicon());


                // Escala el ícono al nuevo tamaño
                Bitmap iconoEscalar = new Bitmap(iconoEditar.ToBitmap(), nuevoAncho, nuevoAlto);

                // Calcula la posición para centrar el ícono en la celda
                int x = e.CellBounds.Left + (e.CellBounds.Width - nuevoAncho) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - nuevoAlto) / 2;

                // Dibuja el ícono escalado
                e.Graphics.DrawImage(iconoEscalar, new Rectangle(x, y, nuevoAncho, nuevoAlto));

                e.Handled = true;
            }
        }

        private void dtgLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Cambiar estilo para filas pares
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
            else // Cambiar estilo para filas impares
            {
                e.CellStyle.BackColor = Color.White;
            }

            // También puedes cambiar el color de fuente, por ejemplo:
            e.CellStyle.ForeColor = Color.Black;
        }

        private void dtgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == acciones.Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dtgLista.Rows[e.RowIndex].Cells[2].Value.ToString());
                GetForm.openChildForm(new frmHorarios(id, GetForm));
            }
        }
    }
}
