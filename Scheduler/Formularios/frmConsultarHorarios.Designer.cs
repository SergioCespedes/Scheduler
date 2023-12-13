
namespace Scheduler
{
    partial class frmConsultarHorarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acciones = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLista
            // 
            this.dtgLista.AllowUserToAddRows = false;
            this.dtgLista.AllowUserToDeleteRows = false;
            this.dtgLista.AllowUserToResizeColumns = false;
            this.dtgLista.AllowUserToResizeRows = false;
            this.dtgLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLista.ColumnHeadersHeight = 29;
            this.dtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_categoria,
            this.nombre,
            this.descripcion,
            this.acciones});
            this.dtgLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dtgLista.Location = new System.Drawing.Point(0, 0);
            this.dtgLista.Name = "dtgLista";
            this.dtgLista.ReadOnly = true;
            this.dtgLista.RowHeadersWidth = 45;
            this.dtgLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLista.Size = new System.Drawing.Size(700, 457);
            this.dtgLista.TabIndex = 2;
            this.dtgLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLista_CellContentClick);
            this.dtgLista.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgLista_CellFormatting);
            this.dtgLista.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgLista_CellPainting);
            this.dtgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgLista_DataBindingComplete);
            // 
            // id_categoria
            // 
            this.id_categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_categoria.HeaderText = "ID";
            this.id_categoria.MinimumWidth = 6;
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Código";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // acciones
            // 
            this.acciones.HeaderText = "Acciones";
            this.acciones.MinimumWidth = 6;
            this.acciones.Name = "acciones";
            this.acciones.ReadOnly = true;
            this.acciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acciones.Width = 125;
            // 
            // frmConsultarHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(700, 457);
            this.Controls.Add(this.dtgLista);
            this.Name = "frmConsultarHorarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgLista;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewImageColumn acciones;
    }
}