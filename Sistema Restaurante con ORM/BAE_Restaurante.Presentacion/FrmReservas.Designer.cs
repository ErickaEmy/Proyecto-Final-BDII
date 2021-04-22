namespace BAE_Restaurante.Presentacion
{
    partial class FrmReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dteFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFin = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnActualizarMesas = new System.Windows.Forms.Button();
            this.btnDetalleMesa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiarMesa = new System.Windows.Forms.Button();
            this.btnAgregarReserva = new System.Windows.Forms.Button();
            this.txtIDReserva = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtInicio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodMesa = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvReserva_Mesa = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdCliente = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumento = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnDia = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva_Mesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "GESTIONAR RESERVAS";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AllowUserToResizeColumns = false;
            this.dgvReservas.AllowUserToResizeRows = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(33, 118);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.Size = new System.Drawing.Size(564, 283);
            this.dgvReservas.TabIndex = 3;
            this.dgvReservas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reservas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(28, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Agregar Reserva";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha";
            // 
            // dteFecha
            // 
            this.dteFecha.BackColor = System.Drawing.Color.White;
            this.dteFecha.BorderRadius = 0;
            this.dteFecha.ForeColor = System.Drawing.Color.Black;
            this.dteFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFecha.FormatCustom = null;
            this.dteFecha.Location = new System.Drawing.Point(401, 553);
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Size = new System.Drawing.Size(150, 23);
            this.dteFecha.TabIndex = 14;
            this.dteFecha.Value = new System.DateTime(2020, 12, 29, 16, 2, 35, 192);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hora Fin";
            // 
            // txtFin
            // 
            this.txtFin.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFin.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtFin.Location = new System.Drawing.Point(536, 492);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(103, 23);
            this.txtFin.TabIndex = 17;
            // 
            // btnActualizarMesas
            // 
            this.btnActualizarMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnActualizarMesas.FlatAppearance.BorderSize = 0;
            this.btnActualizarMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMesas.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarMesas.ForeColor = System.Drawing.Color.White;
            this.btnActualizarMesas.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarMesas.Image")));
            this.btnActualizarMesas.Location = new System.Drawing.Point(603, 335);
            this.btnActualizarMesas.Name = "btnActualizarMesas";
            this.btnActualizarMesas.Size = new System.Drawing.Size(30, 30);
            this.btnActualizarMesas.TabIndex = 23;
            this.btnActualizarMesas.UseVisualStyleBackColor = false;
            this.btnActualizarMesas.Click += new System.EventHandler(this.btnActualizarMesas_Click);
            // 
            // btnDetalleMesa
            // 
            this.btnDetalleMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnDetalleMesa.FlatAppearance.BorderSize = 0;
            this.btnDetalleMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleMesa.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleMesa.ForeColor = System.Drawing.Color.White;
            this.btnDetalleMesa.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalleMesa.Image")));
            this.btnDetalleMesa.Location = new System.Drawing.Point(603, 371);
            this.btnDetalleMesa.Name = "btnDetalleMesa";
            this.btnDetalleMesa.Size = new System.Drawing.Size(30, 30);
            this.btnDetalleMesa.TabIndex = 22;
            this.btnDetalleMesa.UseVisualStyleBackColor = false;
            this.btnDetalleMesa.Click += new System.EventHandler(this.btnDetalleMesa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(548, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiarMesa
            // 
            this.btnLimpiarMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.btnLimpiarMesa.FlatAppearance.BorderSize = 0;
            this.btnLimpiarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarMesa.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.btnLimpiarMesa.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarMesa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarMesa.Image")));
            this.btnLimpiarMesa.Location = new System.Drawing.Point(512, 605);
            this.btnLimpiarMesa.Name = "btnLimpiarMesa";
            this.btnLimpiarMesa.Size = new System.Drawing.Size(30, 30);
            this.btnLimpiarMesa.TabIndex = 25;
            this.btnLimpiarMesa.UseVisualStyleBackColor = false;
            this.btnLimpiarMesa.Click += new System.EventHandler(this.btnLimpiarMesa_Click);
            // 
            // btnAgregarReserva
            // 
            this.btnAgregarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnAgregarReserva.FlatAppearance.BorderSize = 0;
            this.btnAgregarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReserva.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.btnAgregarReserva.ForeColor = System.Drawing.Color.White;
            this.btnAgregarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarReserva.Image")));
            this.btnAgregarReserva.Location = new System.Drawing.Point(476, 605);
            this.btnAgregarReserva.Name = "btnAgregarReserva";
            this.btnAgregarReserva.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarReserva.TabIndex = 24;
            this.btnAgregarReserva.UseVisualStyleBackColor = false;
            this.btnAgregarReserva.Click += new System.EventHandler(this.btnAgregarMesa_Click);
            // 
            // txtIDReserva
            // 
            this.txtIDReserva.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtIDReserva.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtIDReserva.Location = new System.Drawing.Point(33, 656);
            this.txtIDReserva.Name = "txtIDReserva";
            this.txtIDReserva.Size = new System.Drawing.Size(22, 23);
            this.txtIDReserva.TabIndex = 27;
            this.txtIDReserva.Visible = false;
            // 
            // txtInicio
            // 
            this.txtInicio.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInicio.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtInicio.Location = new System.Drawing.Point(401, 492);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(103, 23);
            this.txtInicio.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(398, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hora Inicio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(750, 580);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Código de la Mesa";
            // 
            // txtCodMesa
            // 
            this.txtCodMesa.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCodMesa.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtCodMesa.Location = new System.Drawing.Point(750, 603);
            this.txtCodMesa.Name = "txtCodMesa";
            this.txtCodMesa.Size = new System.Drawing.Size(158, 23);
            this.txtCodMesa.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(774, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 29);
            this.label11.TabIndex = 31;
            this.label11.Text = "Lista de Mesas";
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.AllowUserToOrderColumns = true;
            this.dgvMesas.AllowUserToResizeColumns = false;
            this.dgvMesas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Location = new System.Drawing.Point(720, 118);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.Size = new System.Drawing.Size(284, 228);
            this.dgvMesas.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(747, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 29);
            this.label12.TabIndex = 33;
            this.label12.Text = "Mesas de la Reserva";
            // 
            // dgvReserva_Mesa
            // 
            this.dgvReserva_Mesa.AllowUserToAddRows = false;
            this.dgvReserva_Mesa.AllowUserToDeleteRows = false;
            this.dgvReserva_Mesa.AllowUserToOrderColumns = true;
            this.dgvReserva_Mesa.AllowUserToResizeColumns = false;
            this.dgvReserva_Mesa.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva_Mesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReserva_Mesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva_Mesa.Location = new System.Drawing.Point(1042, 341);
            this.dgvReserva_Mesa.Name = "dgvReserva_Mesa";
            this.dgvReserva_Mesa.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva_Mesa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReserva_Mesa.RowHeadersVisible = false;
            this.dgvReserva_Mesa.Size = new System.Drawing.Size(142, 177);
            this.dgvReserva_Mesa.TabIndex = 32;
            this.dgvReserva_Mesa.Visible = false;
            this.dgvReserva_Mesa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(959, 596);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(191)))), ((int)(((byte)(46)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(923, 596);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 36;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(692, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 547);
            this.panel1.TabIndex = 35;
            // 
            // dgvRM
            // 
            this.dgvRM.AllowUserToAddRows = false;
            this.dgvRM.AllowUserToDeleteRows = false;
            this.dgvRM.AllowUserToOrderColumns = true;
            this.dgvRM.AllowUserToResizeColumns = false;
            this.dgvRM.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Asientos});
            this.dgvRM.Location = new System.Drawing.Point(763, 418);
            this.dgvRM.Name = "dgvRM";
            this.dgvRM.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRM.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRM.RowHeadersVisible = false;
            this.dgvRM.Size = new System.Drawing.Size(203, 150);
            this.dgvRM.TabIndex = 37;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Asientos
            // 
            this.Asientos.HeaderText = "Asientos";
            this.Asientos.Name = "Asientos";
            this.Asientos.ReadOnly = true;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtIdCliente.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtIdCliente.Location = new System.Drawing.Point(252, 426);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(115, 23);
            this.txtIdCliente.TabIndex = 38;
            this.txtIdCliente.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(205, 661);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "ID del Cliente";
            this.label13.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(383, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 166);
            this.panel2.TabIndex = 40;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(149, 488);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 30);
            this.btnBuscar.TabIndex = 91;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
            this.cboTipo.Location = new System.Drawing.Point(213, 493);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(154, 24);
            this.cboTipo.TabIndex = 90;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 89;
            this.label4.Text = "Tipo de Documento";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(33, 589);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(62, 16);
            this.lblApellidos.TabIndex = 88;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtApellidos.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtApellidos.Location = new System.Drawing.Point(33, 612);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(334, 23);
            this.txtApellidos.TabIndex = 87;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(33, 530);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(62, 16);
            this.lblNombres.TabIndex = 86;
            this.lblNombres.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNombres.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtNombres.Location = new System.Drawing.Point(33, 553);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(334, 23);
            this.txtNombres.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 84;
            this.label5.Text = "Nro. Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDocumento.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtDocumento.Location = new System.Drawing.Point(33, 493);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(109, 23);
            this.txtDocumento.TabIndex = 83;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(179, 315);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(411, 86);
            this.dgvClientes.TabIndex = 92;
            this.dgvClientes.Visible = false;
            // 
            // btnDia
            // 
            this.btnDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnDia.FlatAppearance.BorderSize = 0;
            this.btnDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDia.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.btnDia.ForeColor = System.Drawing.Color.White;
            this.btnDia.Location = new System.Drawing.Point(465, -3);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(83, 48);
            this.btnDia.TabIndex = 41;
            this.btnDia.Text = "Reservas del Día";
            this.btnDia.UseVisualStyleBackColor = false;
            this.btnDia.Visible = false;
            // 
            // btnTodo
            // 
            this.btnTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnTodo.FlatAppearance.BorderSize = 0;
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.btnTodo.ForeColor = System.Drawing.Color.White;
            this.btnTodo.Location = new System.Drawing.Point(554, -3);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(85, 48);
            this.btnTodo.TabIndex = 77;
            this.btnTodo.Text = "Todas las Reservas";
            this.btnTodo.UseVisualStyleBackColor = false;
            this.btnTodo.Visible = false;
            this.btnTodo.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 683);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.dgvRM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvReserva_Mesa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodMesa);
            this.Controls.Add(this.txtIDReserva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiarMesa);
            this.Controls.Add(this.btnAgregarReserva);
            this.Controls.Add(this.btnActualizarMesas);
            this.Controls.Add(this.btnDetalleMesa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.dteFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReservas";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva_Mesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker dteFecha;
        private System.Windows.Forms.Label label8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtFin;
        private System.Windows.Forms.Button btnActualizarMesas;
        private System.Windows.Forms.Button btnDetalleMesa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiarMesa;
        private System.Windows.Forms.Button btnAgregarReserva;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIDReserva;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCodMesa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvReserva_Mesa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asientos;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIdCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblApellidos;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtApellidos;
        private System.Windows.Forms.Label lblNombres;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNombres;
        private System.Windows.Forms.Label label5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDocumento;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnTodo;
    }
}