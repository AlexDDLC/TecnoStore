using CapaDatos;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_MenuPrincipal : Form
    {
        CD_ConexionSQL Conexion = new CD_ConexionSQL();

        public P_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void P_MenuPrincipal_Load(object sender, EventArgs e)
        {
            PrivilegiosUsuarios();
            AbrirFormProductosEnPanel(new P_Inicio());
            BtnInicio.BackColor = Color.White;
        }

        private void PrivilegiosUsuarios()
        {
            if (Program.Cargo != 2)
            {
                BtnEmpleados.Visible = false;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (PnlMenu.Width == 50)
            {
                PnlMenu.Width = 250;
                BtnAbrirMenu.Visible = false;
                BtnCerrarMenu.Visible = true;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnPantallaNormal.Visible = true;
        }

        private void BtnPantallaNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnPantallaNormal.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnCerrarMenu_Click(object sender, EventArgs e)
        {
            if (PnlMenu.Width == 250)
            {
                PnlMenu.Width = 50;
                BtnCerrarMenu.Visible = false;
                BtnAbrirMenu.Visible = true;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conexion.CerrarConexion();
            P_Login Login = new P_Login();
            Login.Show();
        }

        private void PnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormProductosEnPanel(object FormHijo)
        {
            if (PnlContenedor.Controls.Count > 0)
            {
                this.PnlContenedor.Controls.RemoveAt(0);
                Form FH = FormHijo as Form;
                FH.TopLevel = false;
                FH.Dock = DockStyle.Fill;
                this.PnlContenedor.Controls.Add(FH);
                this.PnlContenedor.Tag = FH;
                FH.Show();
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            BtnCerrarMenu.Visible = false;
            BtnAbrirMenu.Visible = true;
            PnlMenu.Width = 50;
            BtnProductos.BackColor = Color.White;
            BtnVentas.BackColor = Color.DodgerBlue;
            BtnClientes.BackColor = Color.DodgerBlue;
            BtnProveedores.BackColor = Color.DodgerBlue;
            BtnEmpleados.BackColor = Color.DodgerBlue;
            BtnAnadir.BackColor = Color.DodgerBlue;
            BtnDevoluciones.BackColor = Color.DodgerBlue;
            BtnInicio.BackColor = Color.DodgerBlue;
            AbrirFormProductosEnPanel(new P_Productos());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            BtnCerrarMenu.Visible = false;
            BtnAbrirMenu.Visible = true;
            PnlMenu.Width = 50;
            BtnProductos.BackColor = Color.DodgerBlue;
            BtnVentas.BackColor = Color.White;
            BtnClientes.BackColor = Color.DodgerBlue;
            BtnProveedores.BackColor = Color.DodgerBlue;
            BtnEmpleados.BackColor = Color.DodgerBlue;
            BtnAnadir.BackColor = Color.DodgerBlue;
            BtnDevoluciones.BackColor = Color.DodgerBlue;
            BtnInicio.BackColor = Color.DodgerBlue;
            AbrirFormProductosEnPanel(new P_Venta());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            BtnCerrarMenu.Visible = false;
            BtnAbrirMenu.Visible = true;
            PnlMenu.Width = 50;
            BtnProductos.BackColor = Color.DodgerBlue;
            BtnVentas.BackColor = Color.DodgerBlue;
            BtnClientes.BackColor = Color.White;
            BtnProveedores.BackColor = Color.DodgerBlue;
            BtnEmpleados.BackColor = Color.DodgerBlue;
            BtnAnadir.BackColor = Color.DodgerBlue;
            BtnDevoluciones.BackColor = Color.DodgerBlue;
            BtnInicio.BackColor = Color.DodgerBlue;
            AbrirFormProductosEnPanel(new P_Clientes());
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            BtnCerrarMenu.Visible = false;
            BtnAbrirMenu.Visible = true;
            PnlMenu.Width = 50;
            BtnProductos.BackColor = Color.DodgerBlue;
            BtnVentas.BackColor = Color.DodgerBlue;
            BtnClientes.BackColor = Color.DodgerBlue;
            BtnProveedores.BackColor = Color.White;
            BtnEmpleados.BackColor = Color.DodgerBlue;
            BtnAnadir.BackColor = Color.DodgerBlue;
            BtnDevoluciones.BackColor = Color.DodgerBlue;
            BtnInicio.BackColor = Color.DodgerBlue;
            AbrirFormProductosEnPanel(new P_Proveedor());
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            LblHoraActual.Text = DateTime.Now.ToLongTimeString();
            LblFehaActual.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            BtnCerrarMenu.Visible = false;
            BtnAbrirMenu.Visible = true;
            PnlMenu.Width = 50;
            BtnProductos.BackColor = Color.DodgerBlue;
            BtnVentas.BackColor = Color.DodgerBlue;
            BtnClientes.BackColor = Color.DodgerBlue;
            BtnProveedores.BackColor = Color.DodgerBlue;
            BtnEmpleados.BackColor = Color.White;
            BtnAnadir.BackColor = Color.DodgerBlue;
            BtnDevoluciones.BackColor = Color.DodgerBlue;
            BtnInicio.BackColor = Color.DodgerBlue;
            AbrirFormProductosEnPanel(new P_Empleados());
        }

        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            BtnCerrarMenu.Visible = false;
            BtnAbrirMenu.Visible = true;
            PnlMenu.Width = 50;
            BtnProductos.BackColor = Color.DodgerBlue;
            BtnVentas.BackColor = Color.DodgerBlue;
            BtnClientes.BackColor = Color.DodgerBlue;
            BtnProveedores.BackColor = Color.DodgerBlue;
            BtnEmpleados.BackColor = Color.DodgerBlue;
            BtnAnadir.BackColor = Color.White;
            BtnDevoluciones.BackColor = Color.DodgerBlue;
            BtnInicio.BackColor = Color.DodgerBlue;
            AbrirFormProductosEnPanel(new P_Anadir());
        }

        private void BtnDevoluciones_Click(object sender, EventArgs e)
        {
            BtnCerrarMenu.Visible = false;
            BtnAbrirMenu.Visible = true;
            PnlMenu.Width = 50;
            BtnProductos.BackColor = Color.DodgerBlue;
            BtnVentas.BackColor = Color.DodgerBlue;
            BtnClientes.BackColor = Color.DodgerBlue;
            BtnProveedores.BackColor = Color.DodgerBlue;
            BtnEmpleados.BackColor = Color.DodgerBlue;
            BtnAnadir.BackColor = Color.DodgerBlue;
            BtnDevoluciones.BackColor = Color.White;
            BtnInicio.BackColor = Color.DodgerBlue;
            AbrirFormProductosEnPanel(new P_Devoluciones());
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            BtnCerrarMenu.Visible = false;
            BtnAbrirMenu.Visible = true;
            PnlMenu.Width = 50;
            BtnProductos.BackColor = Color.DodgerBlue;
            BtnVentas.BackColor = Color.DodgerBlue;
            BtnClientes.BackColor = Color.DodgerBlue;
            BtnProveedores.BackColor = Color.DodgerBlue;
            BtnEmpleados.BackColor = Color.DodgerBlue;
            BtnAnadir.BackColor = Color.DodgerBlue;
            BtnDevoluciones.BackColor = Color.DodgerBlue;
            BtnInicio.BackColor = Color.White;
            AbrirFormProductosEnPanel(new P_Inicio());
        }
    }
}