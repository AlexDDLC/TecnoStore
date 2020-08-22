using CapaDatos;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_Empleados : Form
    {
        private string V_IDEmpleado = null;
        private bool V_Editar = false;
        private bool V_Despedir = false;
        int V_Edad = 0;

        public P_Empleados()
        {
            InitializeComponent();
        }

        private void P_Empleados_Load(object sender, EventArgs e)
        {
            MET_MostrarEmpleados();
            MET_Listar_Cargo();
            MET_Listar_Status();
            MET_PrivilegiosUsuario();
        }

        public void MET_MostrarEmpleados()
        {
            CN_Acciones INST_MostrarEmpleados = new CN_Acciones();
            DtvEmpleados.DataSource = INST_MostrarEmpleados.MET_MostrarTablaEmpleados();
        }

        public void MET_MostrarEmpleadoDespedido()
        {
            CN_Acciones INST_MostrarEmpleadosDespedidos = new CN_Acciones();
            DtvEmpleados.DataSource = INST_MostrarEmpleadosDespedidos.MET_MostrarTablaEmpleadosDespedidos();
        }

        private void MET_PrivilegiosUsuario()
        {
            if (Program.Cargo != 2)
            {
                BtnAgregarEmpleado.Visible = false;
                BtnEditarEmpleado.Visible = false;
                BtnBorrarEmpleado.Visible = false;
                BtnDespedir.Visible = false;
            }
        }

        public void MET_Listar_Cargo()
        {
            CD_Consultas INST_Lista_Cargo = new CD_Consultas();
            CbbCargo.DataSource = INST_Lista_Cargo.MET_ListarCargo();
            CbbCargo.DisplayMember = "Cargo";
            CbbCargo.ValueMember = "ID_Cargo";
        }

        public void MET_Listar_Status()
        {
            CD_Consultas INST_Lista_Status = new CD_Consultas();
            CbbStatus.DataSource = INST_Lista_Status.MET_ListarStatus();
            CbbStatus.DisplayMember = "Estado";
            CbbStatus.ValueMember = "ID_Status";
        }

        public void MET_LimpiarTextBox()
        {
            MtbCedula.Clear();
            TxtNombreEmpleado.Clear();
            TxtApellidoEmpleado.Clear();
            RdbMasculino.Checked = false;
            RdbFemenino.Checked = false;
            MtbTelefono.Clear();
            CbbCargo.SelectedIndex = 0;
            CbbStatus.SelectedIndex = 0;
            TxtDireccionEmpleado.Clear();
            //MtbFechaNacimiento.Clear();
            //MtbFachaEntrada.Clear();
            TxtUsuarioEmpleado.Clear();
            TxtContrasenaEmpleado.Clear();
            //MtbFachaSalida.Clear();
            TxtSueldo.Clear();
        }

        public void MET_LblInvisibles()
        {
            LblErrorCedula.Visible = false;
            LblErrorNombre.Visible = false;
            LblErrorApellido.Visible = false;
            LblErrorSexo.Visible = false;
            LblErrorTelefono.Visible = false;
            LblErrorFechaNacimiento.Visible = false;
            LblErrorDireccion.Visible = false;
            LblErrorStatus.Visible = false;
            LblErrorFechaEntrada.Visible = false;
            LblErrorCargo.Visible = false;
            LblErrorUsuarioEmpleado.Visible = false;
            LblErrorContrasenaEmpleado.Visible = false;
            LblErrorSueldo.Visible = false;
        }

        public void MET_DesactivarElementosDeInsertado_ActivarElementosDeDespido()
        {
            MtbCedula.Enabled = false;
            TxtNombreEmpleado.Enabled = false;
            TxtApellidoEmpleado.Enabled = false;
            MtbTelefono.Enabled = false;
            DtpFechaNacimiento.Enabled = false;
            CbbCargo.Enabled = false;
            TxtDireccionEmpleado.Enabled = false;
            CbbStatus.Enabled = true;
            DtpFechaEntrada.Enabled = false;
            TxtUsuarioEmpleado.Enabled = false;
            TxtContrasenaEmpleado.Enabled = false; ;
            TxtSueldo.Enabled = false;
            LblFechaSalida.Visible = true;
            DtpFechaSalida.Visible = true;
        }

        public void MET_ActivarElementosDeInsertado_DesactivarElementosDeDespido()
        {
            MtbCedula.Enabled = true;
            TxtNombreEmpleado.Enabled = true;
            TxtApellidoEmpleado.Enabled = true;
            RdbMasculino.Enabled = true;
            RdbFemenino.Enabled = true;
            MtbTelefono.Enabled = true;
            DtpFechaNacimiento.Enabled = true;
            TxtDireccionEmpleado.Enabled = true;
            CbbStatus.Enabled = true;
            DtpFechaEntrada.Enabled = true;
            TxtUsuarioEmpleado.Enabled = true;
            TxtContrasenaEmpleado.Enabled = true;
            TxtSueldo.Enabled = true;
            LblFechaSalida.Visible = false;
            DtpFechaSalida.Visible = false;
        }

        private void TxtUsuarioEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtContrasenaEmpleado.Focus();
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtApellidoEmpleado.Focus();
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                MtbTelefono.Focus();
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            if (V_Editar == false && V_Despedir == false)
            {
                try
                {
                    if (MtbCedula.MaskFull != true)
                    {
                        LblErrorCedula.Visible = true;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        MtbCedula.Focus();
                        return;
                    }
                    else if (TxtNombreEmpleado.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = true;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        TxtNombreEmpleado.Focus();
                        return;
                    }
                    else if (TxtApellidoEmpleado.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = true;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        TxtApellidoEmpleado.Focus();
                        return;
                    }
                    else if (RdbMasculino.Checked != true && RdbFemenino.Checked != true)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = true;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        return;
                    }
                    else if (MtbTelefono.MaskFull != true)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = true;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        MtbTelefono.Focus();
                        return;
                    }
                    else if (TxtDireccionEmpleado.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = true;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        TxtDireccionEmpleado.Focus();
                        return;
                    }
                    else if (V_Edad < 18)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = true;
                        LblErrorFechaNacimiento.Text = "EL EMPLEADO NO DEBES SER MENOR DE 18 AÑOS";
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        return;
                    }
                    else if (DtpFechaEntrada.Value.Date < DateTime.Now.Date)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = true;
                        LblErrorFechaEntrada.Text = "LA FECHA DE ENTRADA NO PUEDE SER MENOR A LA DE HOY";
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        return;
                    }
                    else if (TxtUsuarioEmpleado.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = true;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        TxtUsuarioEmpleado.Focus();
                        return;
                    }
                    else if (TxtContrasenaEmpleado.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = true;
                        LblErrorSueldo.Visible = false;
                        TxtContrasenaEmpleado.Focus();
                        return;
                    }
                    else if (TxtSueldo.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = true;
                        TxtSueldo.Focus();
                        return;
                    }
                    else
                    {
                        MET_ActivarElementosDeInsertado_DesactivarElementosDeDespido();
                        CN_Acciones INST_InsertarEmpleado = new CN_Acciones();
                        INST_InsertarEmpleado.MET_InsertarDatosEmpleado(MtbCedula.Text,
                            TxtNombreEmpleado.Text, TxtApellidoEmpleado.Text,
                            RdbMasculino.Checked == true ? "M" : "F", MtbTelefono.Text,
                            TxtDireccionEmpleado.Text, DtpFechaNacimiento.Text,
                            Convert.ToInt32(CbbCargo.SelectedValue), DtpFechaEntrada.Text,
                            TxtUsuarioEmpleado.Text, TxtContrasenaEmpleado.Text, DtpFechaSalida.Text,
                            Convert.ToInt32(CbbStatus.SelectedValue), TxtSueldo.Text);

                        MessageBox.Show("SE INSERTO CORRECTAMENTE");

                        DtvEmpleados.Visible = true;
                        MET_LimpiarTextBox();
                        MET_LblInvisibles();
                        BtnGuardarEmpleado.Visible = false;
                        BtnCancelarGuardado.Visible = false;
                        BtnAgregarEmpleado.Visible = true;
                        BtnEditarEmpleado.Visible = true;
                        BtnBorrarEmpleado.Visible = true;
                        BtnDespedir.Visible = true;
                        MET_MostrarEmpleados();
                    }
                }
                catch (Exception Error)
                {
                    MessageBox.Show("Hay Un error en los datos introducidos. Revise y vuelva a intentarlo " + Error + "/n LLAME A SOPORTE TECNICO");
                }
            }
            if (V_Editar == true)
            {
                try
                {
                    if (MtbCedula.MaskFull != true)
                    {
                        LblErrorCedula.Visible = true;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        MtbCedula.Focus();
                        return;
                    }
                    else if (TxtNombreEmpleado.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = true;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        TxtNombreEmpleado.Focus();
                        return;
                    }
                    else if (TxtApellidoEmpleado.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = true;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        TxtApellidoEmpleado.Focus();
                        return;
                    }
                    else if (RdbMasculino.Checked != true && RdbFemenino.Checked != true)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = true;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        return;
                    }
                    else if (MtbTelefono.MaskFull != true)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = true;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        MtbTelefono.Focus();
                        return;
                    }
                    else if (TxtDireccionEmpleado.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = true;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        TxtDireccionEmpleado.Focus();
                        return;
                    }
                    else if (V_Edad < 18)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = true;
                        LblErrorFechaNacimiento.Text = "EL EMPLEADO NO DEBES SER MENOR DE 18 AÑOS";
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        return;
                    }
                    else if (DtpFechaEntrada.Value.Date < DateTime.Now.Date)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = true;
                        LblErrorFechaEntrada.Text = "LA FECHA DE ENTRADA NO PUEDE SER MENOR A LA DE HOY";
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        return;
                    }
                    else if (TxtUsuarioEmpleado.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = true;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = false;
                        TxtUsuarioEmpleado.Focus();
                        return;
                    }
                    else if (TxtContrasenaEmpleado.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = true;
                        LblErrorSueldo.Visible = false;
                        TxtContrasenaEmpleado.Focus();
                        return;
                    }
                    else if (TxtSueldo.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorSexo.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorStatus.Visible = false;
                        LblErrorFechaEntrada.Visible = false;
                        LblErrorCargo.Visible = false;
                        LblErrorUsuarioEmpleado.Visible = false;
                        LblErrorContrasenaEmpleado.Visible = false;
                        LblErrorSueldo.Visible = true;
                        TxtSueldo.Focus();
                        return;
                    }
                    else
                    {
                        CN_Acciones INST_EditarEmpleado = new CN_Acciones();
                        if (DtvEmpleados.SelectedRows.Count > 0)
                        {
                            INST_EditarEmpleado.MET_EditarEmpleado(MtbCedula.Text,
                                TxtNombreEmpleado.Text, TxtApellidoEmpleado.Text, RdbMasculino.Checked == true ? "M" : "F",
                                MtbTelefono.Text, TxtDireccionEmpleado.Text, DtpFechaNacimiento.Text,
                                Convert.ToInt32(CbbCargo.SelectedValue), DtpFechaEntrada.Text, TxtUsuarioEmpleado.Text,
                                TxtContrasenaEmpleado.Text, DtpFechaSalida.Text,
                                Convert.ToInt32(CbbStatus.SelectedValue), TxtSueldo.Text, V_IDEmpleado);

                            MessageBox.Show("SE EDITO CORRECTAMENTE");

                            DtvEmpleados.Visible = true;
                            MET_LimpiarTextBox();
                            MET_LblInvisibles();
                            V_Editar = false;
                            LblBuscar.Visible = true;
                            TxtBuscarEmpleado.Visible = true;
                            LspBuscar.Visible = true;
                            BtnGuardarEmpleado.Visible = false;
                            BtnCancelarGuardado.Visible = false;
                            BtnAgregarEmpleado.Visible = true;
                            BtnEditarEmpleado.Visible = true;
                            BtnBorrarEmpleado.Visible = true;
                            BtnDespedir.Visible = true;
                            MET_MostrarEmpleados();
                        }
                    }
                }
                catch (Exception Error)
                {
                    MessageBox.Show("Hay Un error en los datos introducidos. Revise y vuelva a intentarlo " + Error + "/n LLAME A SOPORTE TECNICO");
                }
            }
            if (V_Despedir == true)
            {
                try
                {
                    if (DtpFechaSalida.Value.Date > DateTime.Now.Date || DtpFechaSalida.Value.Date < DateTime.Now.Date)
                    {
                        LblErrorFechaSalida.Visible = true;
                        LblErrorFechaSalida.Text = "LA FECHA DE SALIDA DEBE SER IGUAL A LA DE HOY";
                        return;
                    }
                    else if (CbbStatus.SelectedIndex <= 0)
                    {
                        LblErrorStatus.Visible = true;
                        LblErrorFechaSalida.Visible = false;
                        return;
                    }
                    else
                    {
                        CN_Acciones INST_EditarEmpleado = new CN_Acciones();
                        if (DtvEmpleados.SelectedRows.Count > 0)
                        {
                            INST_EditarEmpleado.MET_EditarEmpleado(MtbCedula.Text,
                                TxtNombreEmpleado.Text, TxtApellidoEmpleado.Text, RdbMasculino.Checked == true ? "M" : "F",
                                MtbTelefono.Text, TxtDireccionEmpleado.Text, DtpFechaNacimiento.Text,
                                Convert.ToInt32(CbbCargo.SelectedValue), DtpFechaEntrada.Text, TxtUsuarioEmpleado.Text,
                                TxtContrasenaEmpleado.Text, DtpFechaSalida.Text,
                                Convert.ToInt32(CbbStatus.SelectedValue), TxtSueldo.Text, V_IDEmpleado);

                            MessageBox.Show("EL EMPLEADO FUE DESPEDIDO");

                            DtvEmpleados.Visible = true;
                            MET_LimpiarTextBox();
                            MET_LblInvisibles();
                            V_Despedir = false;
                            LblBuscar.Visible = true;
                            TxtBuscarEmpleado.Visible = true;
                            LspBuscar.Visible = true;
                            BtnGuardarEmpleado.Visible = false;
                            BtnCancelarGuardado.Visible = false;
                            BtnAgregarEmpleado.Visible = true;
                            BtnEditarEmpleado.Visible = true;
                            BtnBorrarEmpleado.Visible = true;
                            BtnDespedir.Visible = true;
                            MET_MostrarEmpleados();
                        }
                    }
                }
                catch (Exception Error)
                {
                    MessageBox.Show("Hay Un error en los datos introducidos. Revise y vuelva a intentarlo " + Error + "/n LLAME A SOPORTE TECNICO");
                }
            }
        }

        private void BtnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (DtvEmpleados.SelectedRows.Count > 0)
            {
                V_Editar = true;
                LblBuscar.Visible = false;
                TxtBuscarEmpleado.Visible = false;
                LspBuscar.Visible = false;
                DtvEmpleados.Visible = false;
                BtnEditarEmpleado.Visible = false;
                BtnBorrarEmpleado.Visible = false;
                BtnAgregarEmpleado.Visible = false;
                BtnGuardarEmpleado.Visible = true;
                BtnCancelarGuardado.Visible = true;
                BtnDespedir.Visible = false;
                MtbCedula.Text = DtvEmpleados.CurrentRow.Cells["Cedula"].Value.ToString();
                TxtNombreEmpleado.Text = DtvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtApellidoEmpleado.Text = DtvEmpleados.CurrentRow.Cells["Apellido"].Value.ToString();
                if (DtvEmpleados.CurrentRow.Cells["Sexo"].Value.ToString() == "M")
                {
                    RdbMasculino.Checked = true;
                }
                else
                {
                    RdbFemenino.Checked = true;
                }
                MtbTelefono.Text = DtvEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();
                TxtDireccionEmpleado.Text = DtvEmpleados.CurrentRow.Cells["Direccion"].Value.ToString();
                DtpFechaNacimiento.Text = DtvEmpleados.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                Convert.ToInt32(CbbCargo.SelectedValue);
                DtpFechaEntrada.Text = DtvEmpleados.CurrentRow.Cells["FechaEntrada"].Value.ToString();
                TxtUsuarioEmpleado.Text = DtvEmpleados.CurrentRow.Cells["Usuario"].Value.ToString();
                TxtContrasenaEmpleado.Text = DtvEmpleados.CurrentRow.Cells["Contraseña"].Value.ToString();
                Convert.ToInt32(CbbStatus.SelectedValue);
                TxtSueldo.Text = DtvEmpleados.CurrentRow.Cells["Sueldo"].Value.ToString();
                V_IDEmpleado = DtvEmpleados.CurrentRow.Cells["ID_Empleado"].Value.ToString();
                MET_ActivarElementosDeInsertado_DesactivarElementosDeDespido();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONE EL EMPLEADO QUE DESEA EDITAR");
            }
        }

        private void BtnDespedir_Click(object sender, EventArgs e)
        {
            if (DtvEmpleados.SelectedRows.Count > 0)
            {
                V_Despedir = true;
                LblBuscar.Visible = false;
                TxtBuscarEmpleado.Visible = false;
                LspBuscar.Visible = false;
                DtvEmpleados.Visible = false;
                BtnEditarEmpleado.Visible = false;
                BtnBorrarEmpleado.Visible = false;
                BtnAgregarEmpleado.Visible = false;
                BtnGuardarEmpleado.Visible = true;
                BtnCancelarGuardado.Visible = true;
                BtnDespedir.Visible = false;
                MtbCedula.Text = DtvEmpleados.CurrentRow.Cells["Cedula"].Value.ToString();
                TxtNombreEmpleado.Text = DtvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtApellidoEmpleado.Text = DtvEmpleados.CurrentRow.Cells["Apellido"].Value.ToString();
                if (DtvEmpleados.CurrentRow.Cells["Sexo"].Value.ToString() == "M")
                {
                    RdbMasculino.Checked = true;
                    RdbFemenino.Visible = false;
                }
                else
                {
                    RdbFemenino.Checked = true;
                    RdbMasculino.Visible = false;
                }
                MtbTelefono.Text = DtvEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();
                TxtDireccionEmpleado.Text = DtvEmpleados.CurrentRow.Cells["Direccion"].Value.ToString();
                DtpFechaNacimiento.Text = DtvEmpleados.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                Convert.ToInt32(CbbCargo.SelectedValue);
                DtpFechaEntrada.Text = DtvEmpleados.CurrentRow.Cells["FechaEntrada"].Value.ToString();
                TxtUsuarioEmpleado.Text = DtvEmpleados.CurrentRow.Cells["Usuario"].Value.ToString();
                TxtContrasenaEmpleado.Text = DtvEmpleados.CurrentRow.Cells["Contraseña"].Value.ToString();
                Convert.ToInt32(CbbStatus.SelectedValue);
                TxtSueldo.Text = DtvEmpleados.CurrentRow.Cells["Sueldo"].Value.ToString();
                V_IDEmpleado = DtvEmpleados.CurrentRow.Cells["ID_Empleado"].Value.ToString();
                MET_DesactivarElementosDeInsertado_ActivarElementosDeDespido();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONE EL EMPLEADO QUE DESEA DESPEDIR");
            }
        }

        CN_Acciones INST_EliminarEmpleado = new CN_Acciones();
        private void BtnBorrarEmpleado_Click(object sender, EventArgs e)
        {
            if (DtvEmpleados.SelectedRows.Count > 0)
            {
                V_IDEmpleado = DtvEmpleados.CurrentRow.Cells["ID_Empleado"].Value.ToString();
                INST_EliminarEmpleado.MET_EliminarEmpleado(V_IDEmpleado);
                MessageBox.Show("SE ELIMINO CORECTAMENTE");
                MET_MostrarEmpleados();
            }
            else
            {
                MessageBox.Show("SELECCIONE EL EMPLEADO QUE DESEA ELIMINAR");
            }
        }

        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            LblBuscar.Visible = false;
            TxtBuscarEmpleado.Visible = false;
            LspBuscar.Visible = false;
            DtvEmpleados.Visible = false;
            BtnDespedir.Visible = false;
            BtnGuardarEmpleado.Visible = true;
            BtnEditarEmpleado.Visible = false;
            BtnBorrarEmpleado.Visible = false;
            BtnAgregarEmpleado.Visible = false;
            BtnCancelarGuardado.Visible = true;
        }

        private void BtnCancelarGuardado_Click(object sender, EventArgs e)
        {
            MET_LimpiarTextBox();
            MET_LblInvisibles();
            LblBuscar.Visible = true;
            TxtBuscarEmpleado.Visible = true;
            LspBuscar.Visible = true;
            BtnCancelarGuardado.Visible = false;
            BtnEditarEmpleado.Visible = true;
            BtnBorrarEmpleado.Visible = true;
            DtvEmpleados.Visible = true;
            BtnGuardarEmpleado.Visible = false;
            BtnAgregarEmpleado.Visible = true;
            BtnDespedir.Visible = true;
        }

        private void TxtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarEmpleado.Text != "")
            {
                DtvEmpleados.CurrentCell = null;
                foreach (DataGridViewRow Filas in DtvEmpleados.Rows)
                {
                    Filas.Visible = false;
                }
                foreach (DataGridViewRow Filas in DtvEmpleados.Rows)
                {
                    foreach (DataGridViewCell Celdas in Filas.Cells)
                    {
                        if ((Celdas.Value.ToString().ToUpper()).IndexOf(TxtBuscarEmpleado.Text.ToUpper()) == 0)
                        {
                            Filas.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                MET_MostrarEmpleados();
            }
        }

        private void MtbCedula_Enter(object sender, EventArgs e)
        {
            MtbCedula.PromptChar = ' ';
        }

        private void MtbTelefono_Enter(object sender, EventArgs e)
        {
            MtbTelefono.PromptChar = ' ';
        }

        private void MtbCedula_MouseClick(object sender, MouseEventArgs e)
        {
            MtbCedula.SelectionStart = 0;
        }

        private void MtbTelefono_MouseClick(object sender, MouseEventArgs e)
        {
            MtbTelefono.SelectionStart = 0;
        }

        private void BtnEmpleadosInactivos_Click(object sender, EventArgs e)
        {
            MET_MostrarEmpleadoDespedido();
            BtnEditarEmpleado.Visible = false;
            BtnBorrarEmpleado.Visible = false;
            BtnAgregarEmpleado.Visible = false;
            BtnDespedir.Visible = false;
        }

        private void BtnEmpleadosActivos_Click(object sender, EventArgs e)
        {
            MET_MostrarEmpleados();
            BtnEditarEmpleado.Visible = true;
            BtnBorrarEmpleado.Visible = true;
            BtnAgregarEmpleado.Visible = true;
            BtnDespedir.Visible = true;
        }

        private void DtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            V_Edad = (DateTime.Today.AddTicks(-DtpFechaNacimiento.Value.Ticks).Year - 1);
        }

        private void TxtBuscarEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }
    }
}