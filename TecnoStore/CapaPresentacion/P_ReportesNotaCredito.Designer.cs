namespace CapaPresentacion
{
    partial class P_ReportesNotaCredito
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
            this.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDevolucion = new CapaPresentacion.DataSetDevolucion();
            this.RpvNotaDeCredito = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONTableAdapter = new CapaPresentacion.DataSetDevolucionTableAdapters.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONBindingSource
            // 
            this.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONBindingSource.DataMember = "EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCION";
            this.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONBindingSource.DataSource = this.DataSetDevolucion;
            // 
            // DataSetDevolucion
            // 
            this.DataSetDevolucion.DataSetName = "DataSetDevolucion";
            this.DataSetDevolucion.EnforceConstraints = false;
            this.DataSetDevolucion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RpvNotaDeCredito
            // 
            this.RpvNotaDeCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDevolucion";
            reportDataSource1.Value = this.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONBindingSource;
            this.RpvNotaDeCredito.LocalReport.DataSources.Add(reportDataSource1);
            this.RpvNotaDeCredito.LocalReport.ReportEmbeddedResource = "CapaPresentacion.InformeDevolucion.rdlc";
            this.RpvNotaDeCredito.Location = new System.Drawing.Point(0, 0);
            this.RpvNotaDeCredito.Name = "RpvNotaDeCredito";
            this.RpvNotaDeCredito.ServerReport.BearerToken = null;
            this.RpvNotaDeCredito.Size = new System.Drawing.Size(884, 561);
            this.RpvNotaDeCredito.TabIndex = 0;
            // 
            // EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONTableAdapter
            // 
            this.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONTableAdapter.ClearBeforeFill = true;
            // 
            // P_ReportesNotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.RpvNotaDeCredito);
            this.Name = "P_ReportesNotaCredito";
            this.Text = "P_ReporteCredito";
            this.Load += new System.EventHandler(this.P_ReportesNotaCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDevolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONBindingSource;
        private DataSetDevolucion DataSetDevolucion;
        private DataSetDevolucionTableAdapters.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONTableAdapter EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer RpvNotaDeCredito;
    }
}