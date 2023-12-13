namespace Scheduler.Formularios
{
    partial class FrmUsuariosGestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.DgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.ColUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CbUsuarioActivo = new System.Windows.Forms.CheckBox();
            this.TxtUsuarioDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUsuarioTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUsuarioContrasennia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboxUsuarioTipoRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUsuarioCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUsuarioCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuarioCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(207, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar...";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(277, 11);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(255, 20);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.ForeColor = System.Drawing.Color.Silver;
            this.CbVerActivos.Location = new System.Drawing.Point(641, 13);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(124, 17);
            this.CbVerActivos.TabIndex = 2;
            this.CbVerActivos.Text = "Ver Usuarios Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            this.CbVerActivos.CheckedChanged += new System.EventHandler(this.CbVerActivos_CheckedChanged);
            // 
            // DgvListaUsuarios
            // 
            this.DgvListaUsuarios.AllowUserToAddRows = false;
            this.DgvListaUsuarios.AllowUserToDeleteRows = false;
            this.DgvListaUsuarios.AllowUserToOrderColumns = true;
            this.DgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUsuarioID,
            this.ColCedula,
            this.ColNombre,
            this.ColCorreo,
            this.ColTelefono,
            this.ColRol});
            this.DgvListaUsuarios.Location = new System.Drawing.Point(21, 50);
            this.DgvListaUsuarios.MultiSelect = false;
            this.DgvListaUsuarios.Name = "DgvListaUsuarios";
            this.DgvListaUsuarios.ReadOnly = true;
            this.DgvListaUsuarios.RowHeadersVisible = false;
            this.DgvListaUsuarios.RowHeadersWidth = 51;
            this.DgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaUsuarios.Size = new System.Drawing.Size(744, 216);
            this.DgvListaUsuarios.TabIndex = 3;
            this.DgvListaUsuarios.VirtualMode = true;
            this.DgvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaUsuarios_CellClick);
            this.DgvListaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DgvListaUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaUsuarios_DataBindingComplete);
            // 
            // ColUsuarioID
            // 
            this.ColUsuarioID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUsuarioID.DataPropertyName = "UsuarioID";
            this.ColUsuarioID.HeaderText = "CODIGO";
            this.ColUsuarioID.MinimumWidth = 6;
            this.ColUsuarioID.Name = "ColUsuarioID";
            this.ColUsuarioID.ReadOnly = true;
            this.ColUsuarioID.Width = 80;
            // 
            // ColCedula
            // 
            this.ColCedula.DataPropertyName = "Cedula";
            this.ColCedula.HeaderText = "CÉDULA";
            this.ColCedula.MinimumWidth = 6;
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.ReadOnly = true;
            this.ColCedula.Width = 125;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "NOMBRE";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColCorreo
            // 
            this.ColCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCorreo.DataPropertyName = "Correo";
            this.ColCorreo.HeaderText = "CORREO";
            this.ColCorreo.MinimumWidth = 6;
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.ReadOnly = true;
            this.ColCorreo.Width = 120;
            // 
            // ColTelefono
            // 
            this.ColTelefono.DataPropertyName = "Telefono";
            this.ColTelefono.HeaderText = "TELÉFONO";
            this.ColTelefono.MinimumWidth = 6;
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            this.ColTelefono.Width = 125;
            // 
            // ColRol
            // 
            this.ColRol.DataPropertyName = "Rol";
            this.ColRol.HeaderText = "ROL DE USUARIO";
            this.ColRol.MinimumWidth = 6;
            this.ColRol.Name = "ColRol";
            this.ColRol.ReadOnly = true;
            this.ColRol.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CbUsuarioActivo);
            this.groupBox1.Controls.Add(this.TxtUsuarioDireccion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtUsuarioTelefono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtUsuarioContrasennia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CboxUsuarioTipoRol);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtUsuarioCorreo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtUsuarioNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtUsuarioCedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtUsuarioCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(21, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 221);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Usuario...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(444, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Datos Requeridos...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(423, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(489, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(489, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(50, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(50, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(50, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "*";
            // 
            // CbUsuarioActivo
            // 
            this.CbUsuarioActivo.AutoSize = true;
            this.CbUsuarioActivo.Enabled = false;
            this.CbUsuarioActivo.ForeColor = System.Drawing.Color.Silver;
            this.CbUsuarioActivo.Location = new System.Drawing.Point(319, 33);
            this.CbUsuarioActivo.Name = "CbUsuarioActivo";
            this.CbUsuarioActivo.Size = new System.Drawing.Size(56, 17);
            this.CbUsuarioActivo.TabIndex = 16;
            this.CbUsuarioActivo.Text = "Activo";
            this.CbUsuarioActivo.UseVisualStyleBackColor = true;
            // 
            // TxtUsuarioDireccion
            // 
            this.TxtUsuarioDireccion.Location = new System.Drawing.Point(426, 113);
            this.TxtUsuarioDireccion.Multiline = true;
            this.TxtUsuarioDireccion.Name = "TxtUsuarioDireccion";
            this.TxtUsuarioDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtUsuarioDireccion.Size = new System.Drawing.Size(298, 75);
            this.TxtUsuarioDireccion.TabIndex = 15;
            this.TxtUsuarioDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuarioDireccion_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(423, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dirección";
            // 
            // TxtUsuarioTelefono
            // 
            this.TxtUsuarioTelefono.Location = new System.Drawing.Point(9, 191);
            this.TxtUsuarioTelefono.Name = "TxtUsuarioTelefono";
            this.TxtUsuarioTelefono.Size = new System.Drawing.Size(366, 20);
            this.TxtUsuarioTelefono.TabIndex = 13;
            this.TxtUsuarioTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuarioTelefono_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Teléfono";
            // 
            // TxtUsuarioContrasennia
            // 
            this.TxtUsuarioContrasennia.Location = new System.Drawing.Point(426, 71);
            this.TxtUsuarioContrasennia.Name = "TxtUsuarioContrasennia";
            this.TxtUsuarioContrasennia.Size = new System.Drawing.Size(264, 20);
            this.TxtUsuarioContrasennia.TabIndex = 11;
            this.TxtUsuarioContrasennia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuarioContrasennia_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(423, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contraseña";
            // 
            // CboxUsuarioTipoRol
            // 
            this.CboxUsuarioTipoRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxUsuarioTipoRol.FormattingEnabled = true;
            this.CboxUsuarioTipoRol.Location = new System.Drawing.Point(426, 31);
            this.CboxUsuarioTipoRol.Name = "CboxUsuarioTipoRol";
            this.CboxUsuarioTipoRol.Size = new System.Drawing.Size(298, 21);
            this.CboxUsuarioTipoRol.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(423, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo Usuario";
            // 
            // TxtUsuarioCorreo
            // 
            this.TxtUsuarioCorreo.Location = new System.Drawing.Point(9, 152);
            this.TxtUsuarioCorreo.Name = "TxtUsuarioCorreo";
            this.TxtUsuarioCorreo.Size = new System.Drawing.Size(366, 20);
            this.TxtUsuarioCorreo.TabIndex = 7;
            this.TxtUsuarioCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuarioCorreo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Correo";
            // 
            // TxtUsuarioNombre
            // 
            this.TxtUsuarioNombre.Location = new System.Drawing.Point(9, 113);
            this.TxtUsuarioNombre.Name = "TxtUsuarioNombre";
            this.TxtUsuarioNombre.Size = new System.Drawing.Size(366, 20);
            this.TxtUsuarioNombre.TabIndex = 5;
            this.TxtUsuarioNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuarioNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // TxtUsuarioCedula
            // 
            this.TxtUsuarioCedula.Location = new System.Drawing.Point(9, 71);
            this.TxtUsuarioCedula.Name = "TxtUsuarioCedula";
            this.TxtUsuarioCedula.Size = new System.Drawing.Size(366, 20);
            this.TxtUsuarioCedula.TabIndex = 3;
            this.TxtUsuarioCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuarioCedula_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula";
            // 
            // TxtUsuarioCodigo
            // 
            this.TxtUsuarioCodigo.Enabled = false;
            this.TxtUsuarioCodigo.Location = new System.Drawing.Point(9, 31);
            this.TxtUsuarioCodigo.Name = "TxtUsuarioCodigo";
            this.TxtUsuarioCodigo.Size = new System.Drawing.Size(304, 20);
            this.TxtUsuarioCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de Usuario";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(21, 499);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(139, 31);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Location = new System.Drawing.Point(166, 499);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(139, 31);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Location = new System.Drawing.Point(311, 499);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(139, 31);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(484, 499);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(139, 31);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(629, 499);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(139, 31);
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmUsuariosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(782, 543);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaUsuarios);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUsuariosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerActivos;
        private System.Windows.Forms.DataGridView DgvListaUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsuarioNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUsuarioCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuarioCodigo;
        private System.Windows.Forms.ComboBox CboxUsuarioTipoRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUsuarioCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUsuarioDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUsuarioTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUsuarioContrasennia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CbUsuarioActivo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRol;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}