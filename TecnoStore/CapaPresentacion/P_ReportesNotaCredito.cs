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
    public partial class P_ReportesNotaCredito : Form
    {
        public P_ReportesNotaCredito()
        {
            InitializeComponent();
        }

        public int ID_Devolucion { set; get; }

        private void P_ReportesNotaCredito_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetDevolucion.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCION' Puede moverla o quitarla según sea necesario.
            this.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCIONTableAdapter.Fill(this.DataSetDevolucion.EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCION, ID_Devolucion);

            this.RpvNotaDeCredito.RefreshReport();
        }
    }
}
