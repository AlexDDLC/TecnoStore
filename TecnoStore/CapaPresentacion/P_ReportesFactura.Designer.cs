namespace CapaPresentacion
{
    partial class P_ReportesFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDatosFactura = new CapaPresentacion.DataSetDatosFactura();
            this.RpvFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESTableAdapter = new CapaPresentacion.DataSetDatosFacturaTableAdapters.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDatosFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // EP_MOSTRA_FACTURA_JUNTO_A_DETALLESBindingSource
            // 
            this.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESBindingSource.DataMember = "EP_MOSTRA_FACTURA_JUNTO_A_DETALLES";
            this.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESBindingSource.DataSource = this.DataSetDatosFactura;
            // 
            // DataSetDatosFactura
            // 
            this.DataSetDatosFactura.DataSetName = "DataSetDatosFactura";
            this.DataSetDatosFactura.EnforceConstraints = false;
            this.DataSetDatosFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RpvFactura
            // 
            this.RpvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDatosFacturas";
            reportDataSource1.Value = this.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESBindingSource;
            this.RpvFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.RpvFactura.LocalReport.ReportEmbeddedResource = "CapaPresentacion.InformeFactura.rdlc";
            this.RpvFactura.Location = new System.Drawing.Point(0, 0);
            this.RpvFactura.Name = "RpvFactura";
            this.RpvFactura.ServerReport.BearerToken = null;
            this.RpvFactura.Size = new System.Drawing.Size(884, 561);
            this.RpvFactura.TabIndex = 0;
            // 
            // EP_MOSTRA_FACTURA_JUNTO_A_DETALLESTableAdapter
            // 
            this.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESTableAdapter.ClearBeforeFill = true;
            // 
            // P_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.RpvFactura);
            this.Name = "P_Factura";
            this.Text = "P_Factura";
            this.Load += new System.EventHandler(this.P_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDatosFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RpvFactura;
        private System.Windows.Forms.BindingSource EP_MOSTRA_FACTURA_JUNTO_A_DETALLESBindingSource;
        private DataSetDatosFactura DataSetDatosFactura;
        private DataSetDatosFacturaTableAdapters.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESTableAdapter EP_MOSTRA_FACTURA_JUNTO_A_DETALLESTableAdapter;
    }
}