namespace Scheduler
{
    partial class frmHorarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreHorario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoHorario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHora);
            this.groupBox1.Controls.Add(this.cmbDia);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(50, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(412, 19);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(207, 21);
            this.cmbHora.TabIndex = 7;
            // 
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(88, 19);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(207, 21);
            this.cmbDia.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(195, 73);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 32);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(37, 73);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 32);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(346, 73);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 32);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(500, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 32);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(343, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Día";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHorarios);
            this.groupBox2.Location = new System.Drawing.Point(50, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domingo,
            this.lunes,
            this.martes,
            this.miercoles,
            this.jueves,
            this.viernes,
            this.sabado});
            this.dgvHorarios.Location = new System.Drawing.Point(6, 19);
            this.dgvHorarios.MultiSelect = false;
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.ShowEditingIcon = false;
            this.dgvHorarios.Size = new System.Drawing.Size(651, 302);
            this.dgvHorarios.TabIndex = 0;
            this.dgvHorarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoras_CellClick);
            this.dgvHorarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvHoras_DataBindingComplete);
            // 
            // domingo
            // 
            this.domingo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.domingo.HeaderText = "Domingo";
            this.domingo.Name = "domingo";
            this.domingo.ReadOnly = true;
            // 
            // lunes
            // 
            this.lunes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lunes.HeaderText = "Lunes";
            this.lunes.Name = "lunes";
            this.lunes.ReadOnly = true;
            // 
            // martes
            // 
            this.martes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.martes.HeaderText = "Martes";
            this.martes.Name = "martes";
            this.martes.ReadOnly = true;
            // 
            // miercoles
            // 
            this.miercoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.miercoles.HeaderText = "Miércoles";
            this.miercoles.Name = "miercoles";
            this.miercoles.ReadOnly = true;
            // 
            // jueves
            // 
            this.jueves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jueves.HeaderText = "Jueves";
            this.jueves.Name = "jueves";
            this.jueves.ReadOnly = true;
            // 
            // viernes
            // 
            this.viernes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.viernes.HeaderText = "Viernes";
            this.viernes.Name = "viernes";
            this.viernes.ReadOnly = true;
            // 
            // sabado
            // 
            this.sabado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sabado.HeaderText = "Sábado";
            this.sabado.Name = "sabado";
            this.sabado.ReadOnly = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(217, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre del Horario";
            // 
            // txtNombreHorario
            // 
            this.txtNombreHorario.Location = new System.Drawing.Point(357, 27);
            this.txtNombreHorario.Name = "txtNombreHorario";
            this.txtNombreHorario.Size = new System.Drawing.Size(203, 20);
            this.txtNombreHorario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(217, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código del Horario";
            // 
            // txtCodigoHorario
            // 
            this.txtCodigoHorario.Location = new System.Drawing.Point(357, 57);
            this.txtCodigoHorario.Name = "txtCodigoHorario";
            this.txtCodigoHorario.Size = new System.Drawing.Size(203, 20);
            this.txtCodigoHorario.TabIndex = 5;
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(766, 541);
            this.Controls.Add(this.txtCodigoHorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreHorario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHorarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.TextBox txtNombreHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn domingo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoHorario;
    }
}