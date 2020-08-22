using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_ReportesFactura : Form
    {
        public P_ReportesFactura()
        {
            InitializeComponent();
        }

        public int ID_Factura { set; get; }

        private void P_Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetDatosFactura.EP_MOSTRA_FACTURA_JUNTO_A_DETALLES' Puede moverla o quitarla según sea necesario.
            this.EP_MOSTRA_FACTURA_JUNTO_A_DETALLESTableAdapter.Fill(this.DataSetDatosFactura.EP_MOSTRA_FACTURA_JUNTO_A_DETALLES,ID_Factura);

            this.RpvFactura.RefreshReport();
        }
    }
}
