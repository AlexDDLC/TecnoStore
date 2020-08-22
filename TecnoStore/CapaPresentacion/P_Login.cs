using CapaNegocio;
using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_Login : Form
    {
        public P_Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Txtusuario_Enter(object sender, EventArgs e)
        {
            if (Txtusuario.Text == "USUARIO")
            {
                Txtusuario.Clear();
            }
        }

        private void Txtusuario_Leave(object sender, EventArgs e)
        {
            if (Txtusuario.Text == "")
            {
                Txtusuario.Text = "USUARIO";
                Lblerrorusuario.Visible = false;
            }
            if (Txtusuario.Text != "USUARIO")
            {
                Lblerrorusuario.Visible = false;
            }
        }

        private void Txtcontrasena_Enter(object sender, EventArgs e)
        {
            if (Txtcontrasena.Text == "CONTRASEÑA")
            {
                Txtcontrasena.Clear();
                Txtcontrasena.PasswordChar = '*';
            }
        }

        private void Txtcontrasena_Leave(object sender, EventArgs e)
        {
            if (Txtcontrasena.Text == "")
            {
                Txtcontrasena.Text = "CONTRASEÑA";
                Lblerrorcontrasena.Visible = false;
                Txtcontrasena.PasswordChar = '\0';
            }
            if (Txtusuario.Text != "CONTRASEÑA")
            {
                Lblerrorcontrasena.Visible = false;
            }
        }

        private void Txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                Txtcontrasena.Focus();
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txtcontrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txtcontrasena.PasswordChar = '*';
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    CN_Acciones LoguearUsuario = new CN_Acciones();
                    SqlDataReader Loguear;
                    LoguearUsuario.Usuario = Txtusuario.Text;
                    LoguearUsuario.Contrasena = Txtcontrasena.Text;
                    if (LoguearUsuario.Usuario == Txtusuario.Text)
                    {
                        Lblerrorusuario.Visible = false;

                        if (LoguearUsuario.Contrasena == Txtcontrasena.Text)
                        {
                            Lblerrorcontrasena.Visible = false;

                            Loguear = LoguearUsuario.IniciarSesion();

                            if (Loguear.Read() == true)
                            {
                                this.Hide();
                                P_MenuPrincipal Pantalla = new P_MenuPrincipal();
                                Program.Cargo = Convert.ToInt32(Loguear["Cargo"].ToString());
                                Program.Status = Convert.ToInt32(Loguear["Estado"].ToString());
                                Program.NombreEmpleado = (Loguear["Nombre"].ToString() + " " + Loguear["Apellido"].ToString());
                                Program.ID_Empleados = Convert.ToInt32(Loguear["ID_Empleado"].ToString());
                                if (Program.Status != 2)
                                {
                                    MessageBox.Show("USTED NO TIENE ACCESO AL SISTEMA");
                                    P_Login P = new P_Login();
                                    P.Show();
                                    return;
                                }
                                Pantalla.Show();
                            }
                            else
                            {
                                Lblerrorlogin.Text = "Usuario o contraseña incorrectos. Intentelo de nuevo";
                                Lblerrorlogin.Visible = true;
                                Txtcontrasena.Clear();
                                BtnMostrarContrasena.Visible = false;
                                BtnocultarContrasena.Visible = false;
                                Txtcontrasena_Leave(null, e);
                                Txtusuario.Clear();
                                Txtusuario.Focus();
                            }
                        }
                        else
                        {
                            Lblerrorcontrasena.Text = "Por favor ingrese su contraseña";
                            Lblerrorcontrasena.Visible = true;
                            Lblerrorlogin.Visible = false;
                            Txtcontrasena.Focus();
                        }
                    }
                    else
                    {
                        Lblerrorusuario.Text = "Por favor ingrese su nombre de usuario";
                        Lblerrorusuario.Visible = true;
                        Lblerrorlogin.Visible = false;
                        Txtusuario.Focus();
                    }
                }
                catch (Exception Error)
                {
                    MessageBox.Show("No se pudo hacer la coneccion, comuniquese con servicio tecnico" + Error);
                }
            }
            else if (Txtcontrasena.Text == "")
            {
                BtnMostrarContrasena.Visible = false;
                BtnocultarContrasena.Visible = false;
            }
            else if (Txtcontrasena.Text != "")
            {
                BtnMostrarContrasena.Visible = true;
                BtnocultarContrasena.Visible = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void P_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btnacceder_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Acciones LoguearUsuario = new CN_Acciones();
                SqlDataReader Loguear;
                LoguearUsuario.Usuario = Txtusuario.Text;
                LoguearUsuario.Contrasena = Txtcontrasena.Text;
                if (LoguearUsuario.Usuario == Txtusuario.Text)
                {
                    Lblerrorusuario.Visible = false;

                    if (LoguearUsuario.Contrasena == Txtcontrasena.Text)
                    {
                        Lblerrorcontrasena.Visible = false;

                        Loguear = LoguearUsuario.IniciarSesion();
                        if (Loguear.Read() == true)
                        {
                            this.Hide();
                            P_MenuPrincipal Pantalla = new P_MenuPrincipal();
                            Program.Cargo = Convert.ToInt32(Loguear["Cargo"].ToString());
                            Program.Status = Convert.ToInt32(Loguear["Estado"].ToString());
                            if (Program.Status != 2)
                            {
                                MessageBox.Show("USTED NO TIENE ACCESO AL SISTEMA");
                                P_Login P = new P_Login();
                                P.Show();
                                return;
                            }
                            Pantalla.Show();
                        }
                        else
                        {
                            Lblerrorlogin.Text = "Usuario o contraseña incorrectos. Intentelo de nuevo";
                            Lblerrorlogin.Visible = true;
                            Txtcontrasena.Clear();
                            BtnMostrarContrasena.Visible = false;
                            BtnocultarContrasena.Visible = false;
                            Txtcontrasena_Leave(null, e);
                            Txtusuario.Clear();
                            Txtusuario.Focus();
                        }
                    }
                    else
                    {
                        Lblerrorcontrasena.Text = "Por favor ingrese su contraseña";
                        Lblerrorcontrasena.Visible = true;
                        Lblerrorlogin.Visible = false;
                        Txtcontrasena.Focus();
                    }
                }
                else
                {
                    Lblerrorusuario.Text = "Por favor ingrese su nombre de usuario";
                    Lblerrorusuario.Visible = true;
                    Lblerrorlogin.Visible = false;
                    Txtusuario.Focus();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se pudo hacer la coneccion, comuniquese con servicio tecnico" + Error);
            }
        }

        private void BtnocultarContrasena_Click(object sender, EventArgs e)
        {
            Txtcontrasena.PasswordChar = '*';
            BtnocultarContrasena.Visible = false;
            BtnMostrarContrasena.Visible = true;
            Txtcontrasena.Focus();
        }

        private void BtnMostrarContrasena_Click(object sender, EventArgs e)
        {
            Txtcontrasena.PasswordChar = '\0';
            BtnMostrarContrasena.Visible = false;
            BtnocultarContrasena.Visible = true;
            Txtcontrasena.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txtusuario.Focus();
        }
    }
}