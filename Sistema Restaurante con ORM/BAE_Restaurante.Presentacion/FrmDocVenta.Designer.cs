namespace BAE_Restaurante.Presentacion
{
    partial class FrmDocVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocVenta));
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.txtComentario = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.lblFechaf = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPedidoID = new System.Windows.Forms.Label();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.lblMi = new System.Windows.Forms.Label();
            this.txtDireccionf = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombref = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFactura
            // 
            this.pnlFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFactura.Controls.Add(this.txtComentario);
            this.pnlFactura.Controls.Add(this.btnGuardar);
            this.pnlFactura.Controls.Add(this.label20);
            this.pnlFactura.Controls.Add(this.dgvFactura);
            this.pnlFactura.Controls.Add(this.lblFechaf);
            this.pnlFactura.Controls.Add(this.txtTotal);
            this.pnlFactura.Controls.Add(this.label19);
            this.pnlFactura.Controls.Add(this.groupBox4);
            this.pnlFactura.Controls.Add(this.txtRUC);
            this.pnlFactura.Controls.Add(this.txtIGV);
            this.pnlFactura.Controls.Add(this.lblMi);
            this.pnlFactura.Controls.Add(this.txtDireccionf);
            this.pnlFactura.Controls.Add(this.label18);
            this.pnlFactura.Controls.Add(this.label3);
            this.pnlFactura.Controls.Add(this.txtNombref);
            this.pnlFactura.Controls.Add(this.txtSubtotal);
            this.pnlFactura.Controls.Add(this.label2);
            this.pnlFactura.Controls.Add(this.label12);
            this.pnlFactura.Controls.Add(this.label11);
            this.pnlFactura.Location = new System.Drawing.Point(12, 12);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.Size = new System.Drawing.Size(537, 411);
            this.pnlFactura.TabIndex = 65;
            this.pnlFactura.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFactura_Paint);
            // 
            // txtComentario
            // 
            this.txtComentario.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtComentario.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.txtComentario.Location = new System.Drawing.Point(25, 312);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(279, 48);
            this.txtComentario.TabIndex = 100;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(25, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(324, 379);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 17);
            this.label20.TabIndex = 43;
            this.label20.Text = "Total";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.AllowUserToResizeColumns = false;
            this.dgvFactura.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(25, 174);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersVisible = false;
            this.dgvFactura.Size = new System.Drawing.Size(478, 132);
            this.dgvFactura.TabIndex = 38;
            // 
            // lblFechaf
            // 
            this.lblFechaf.AutoSize = true;
            this.lblFechaf.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaf.Location = new System.Drawing.Point(22, 76);
            this.lblFechaf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaf.Name = "lblFechaf";
            this.lblFechaf.Size = new System.Drawing.Size(43, 17);
            this.lblFechaf.TabIndex = 21;
            this.lblFechaf.Text = "fecha";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(389, 374);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.MaxLength = 8;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(114, 22);
            this.txtTotal.TabIndex = 44;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(324, 353);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = "I.G.V.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPedidoID);
            this.groupBox4.Controls.Add(this.lblNumFactura);
            this.groupBox4.Controls.Add(this.lblTipo);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(353, 9);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(166, 83);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // lblPedidoID
            // 
            this.lblPedidoID.AutoSize = true;
            this.lblPedidoID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoID.Location = new System.Drawing.Point(89, 58);
            this.lblPedidoID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedidoID.Name = "lblPedidoID";
            this.lblPedidoID.Size = new System.Drawing.Size(12, 17);
            this.lblPedidoID.TabIndex = 12;
            this.lblPedidoID.Text = "-";
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.Location = new System.Drawing.Point(64, 58);
            this.lblNumFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(22, 17);
            this.lblNumFactura.TabIndex = 11;
            this.lblNumFactura.Text = "N°";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(56, 37);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(61, 17);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "FACTURA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "R.U.C. : 20601520801";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtRUC
            // 
            this.txtRUC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.Location = new System.Drawing.Point(389, 107);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(2);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.ReadOnly = true;
            this.txtRUC.Size = new System.Drawing.Size(114, 22);
            this.txtRUC.TabIndex = 19;
            // 
            // txtIGV
            // 
            this.txtIGV.BackColor = System.Drawing.SystemColors.Info;
            this.txtIGV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGV.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtIGV.Location = new System.Drawing.Point(389, 348);
            this.txtIGV.Margin = new System.Windows.Forms.Padding(2);
            this.txtIGV.MaxLength = 8;
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.ReadOnly = true;
            this.txtIGV.Size = new System.Drawing.Size(114, 22);
            this.txtIGV.TabIndex = 42;
            // 
            // lblMi
            // 
            this.lblMi.AutoSize = true;
            this.lblMi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMi.Location = new System.Drawing.Point(342, 110);
            this.lblMi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMi.Name = "lblMi";
            this.lblMi.Size = new System.Drawing.Size(41, 17);
            this.lblMi.TabIndex = 18;
            this.lblMi.Text = "R.U.C.";
            // 
            // txtDireccionf
            // 
            this.txtDireccionf.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionf.Location = new System.Drawing.Point(92, 137);
            this.txtDireccionf.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionf.Name = "txtDireccionf";
            this.txtDireccionf.ReadOnly = true;
            this.txtDireccionf.Size = new System.Drawing.Size(411, 22);
            this.txtDireccionf.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(324, 327);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 17);
            this.label18.TabIndex = 39;
            this.label18.Text = "Sub Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dirección";
            // 
            // txtNombref
            // 
            this.txtNombref.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombref.Location = new System.Drawing.Point(92, 107);
            this.txtNombref.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombref.Name = "txtNombref";
            this.txtNombref.ReadOnly = true;
            this.txtNombref.Size = new System.Drawing.Size(246, 22);
            this.txtNombref.TabIndex = 15;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtSubtotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSubtotal.Location = new System.Drawing.Point(389, 322);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.MaxLength = 8;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(114, 22);
            this.txtSubtotal.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Urb. Monterrico #136";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 27);
            this.label11.TabIndex = 8;
            this.label11.Text = "BAE Restaurante S.A.C.";
            // 
            // FrmDocVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 435);
            this.Controls.Add(this.pnlFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDocVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documento de Venta";
            this.pnlFactura.ResumeLayout(false);
            this.pnlFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFactura;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblPedidoID;
        public System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.Label lblMi;
        public System.Windows.Forms.TextBox txtRUC;
        public System.Windows.Forms.TextBox txtDireccionf;
        public System.Windows.Forms.TextBox txtNombref;
        public System.Windows.Forms.Label lblFechaf;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtComentario;
        public System.Windows.Forms.Button btnGuardar;
    }
}