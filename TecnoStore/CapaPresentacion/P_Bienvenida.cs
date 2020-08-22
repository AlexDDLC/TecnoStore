using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_Bienvenida : Form
    {

        public P_Bienvenida()
        {
            InitializeComponent();
        }

        private void P_Bienvenida_Load(object sender, EventArgs e)
        {
            P_Bienvenida PB = new P_Bienvenida();
            LblProgreso.Parent = PB;
            LblProgreso.BackColor = Color.DodgerBlue;
        }

        public void Fin()
        {
            PgbProgreso.Increment(1);
            LblProgreso.Text = PgbProgreso.Value.ToString() + "%";
            if (PgbProgreso.Value == PgbProgreso.Maximum)
            {
                timer1.Stop();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fin();
        }
    }
}
