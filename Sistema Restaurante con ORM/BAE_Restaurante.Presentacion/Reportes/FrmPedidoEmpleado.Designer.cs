﻿namespace BAE_Restaurante.Presentacion.Reportes
{
    partial class FrmPedidoEmpleado
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fechaFin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.fechaInicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFlujoCaja = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsBAE_Restaurante = new BAE_Restaurante.Presentacion.Reportes.DsBAE_Restaurante();
            this.usp_Pedidos_EmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_Pedidos_EmpleadosTableAdapter = new BAE_Restaurante.Presentacion.Reportes.DsBAE_RestauranteTableAdapters.usp_Pedidos_EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsBAE_Restaurante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_Pedidos_EmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(329, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 16);
            this.label15.TabIndex = 169;
            this.label15.Text = "Fecha Fin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 168;
            this.label14.Text = "Fecha Inicio";
            // 
            // fechaFin
            // 
            this.fechaFin.BackColor = System.Drawing.Color.White;
            this.fechaFin.BorderRadius = 0;
            this.fechaFin.ForeColor = System.Drawing.Color.Black;
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFin.FormatCustom = null;
            this.fechaFin.Location = new System.Drawing.Point(332, 93);
            this.fechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(200, 23);
            this.fechaFin.TabIndex = 167;
            this.fechaFin.Value = new System.DateTime(2020, 12, 29, 16, 2, 35, 192);
            // 
            // fechaInicio
            // 
            this.fechaInicio.BackColor = System.Drawing.Color.White;
            this.fechaInicio.BorderRadius = 0;
            this.fechaInicio.ForeColor = System.Drawing.Color.Black;
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.FormatCustom = null;
            this.fechaInicio.Location = new System.Drawing.Point(29, 93);
            this.fechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(243, 23);
            this.fechaInicio.TabIndex = 166;
            this.fechaInicio.Value = new System.DateTime(2020, 12, 29, 16, 2, 35, 192);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 42);
            this.label1.TabIndex = 165;
            this.label1.Text = "REPORTE - VENTAS POR EMPLEADO";
            // 
            // btnFlujoCaja
            // 
            this.btnFlujoCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnFlujoCaja.FlatAppearance.BorderSize = 0;
            this.btnFlujoCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlujoCaja.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F);
            this.btnFlujoCaja.ForeColor = System.Drawing.Color.White;
            this.btnFlujoCaja.Location = new System.Drawing.Point(955, 68);
            this.btnFlujoCaja.Name = "btnFlujoCaja";
            this.btnFlujoCaja.Size = new System.Drawing.Size(117, 48);
            this.btnFlujoCaja.TabIndex = 170;
            this.btnFlujoCaja.Text = "Ver";
            this.btnFlujoCaja.UseVisualStyleBackColor = false;
            this.btnFlujoCaja.Click += new System.EventHandler(this.btnFlujoCaja_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DtPedidoEmpleado";
            reportDataSource3.Value = this.usp_Pedidos_EmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BAE_Restaurante.Presentacion.Reportes.RptPedidoEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 137);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1043, 416);
            this.reportViewer1.TabIndex = 171;
            // 
            // DsBAE_Restaurante
            // 
            this.DsBAE_Restaurante.DataSetName = "DsBAE_Restaurante";
            this.DsBAE_Restaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_Pedidos_EmpleadosBindingSource
            // 
            this.usp_Pedidos_EmpleadosBindingSource.DataMember = "usp_Pedidos_Empleados";
            this.usp_Pedidos_EmpleadosBindingSource.DataSource = this.DsBAE_Restaurante;
            // 
            // usp_Pedidos_EmpleadosTableAdapter
            // 
            this.usp_Pedidos_EmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPedidoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 583);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnFlujoCaja);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedidoEmpleado";
            this.Text = "FrmPedidoEmpleado";
            this.Load += new System.EventHandler(this.FrmPedidoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsBAE_Restaurante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_Pedidos_EmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuDatepicker fechaFin;
        private Bunifu.Framework.UI.BunifuDatepicker fechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFlujoCaja;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usp_Pedidos_EmpleadosBindingSource;
        private DsBAE_Restaurante DsBAE_Restaurante;
        private DsBAE_RestauranteTableAdapters.usp_Pedidos_EmpleadosTableAdapter usp_Pedidos_EmpleadosTableAdapter;
    }
}