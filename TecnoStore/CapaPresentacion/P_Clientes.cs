using CapaNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_Clientes : Form
    {
        private string V_IDCuentaPorCobrar = null;
        //VARIABLE PARA GUARDAR EL ID DEL CLIENTE AL SELECCIONARLO PARA SER EDITADO
        private string V_IDCliente = null;
        //VARIABLE QUE SE VUELVE VERDADERA CUANDO SE QUIERE EDITAR UN CLIENTE  
        private bool V_Editar = false;
        //
        //private bool V_Pago = false;
        //VARIABLE QUE ESPECIFICA SI UN CLIENTE DEBE DINERO PARA ASI MOSTRARLO EN EL DTV
        private bool V_Deudor = false;
        int V_Edad = 0;

        public double Deuda = 0, Pago = 0, DeudaRestante = 0;

        public P_Clientes()
        {
            InitializeComponent();
        }

        //MUESTRA LA TABLA CLIENTE DESDE QUE EL FORMULARIO CARGA
        private void P_Clientes_Load(object sender, EventArgs e)
        {
            MET_MostrarClientes();
            V_Deudor = false;
        }

        //METODO PARA MOSTRAR LOS CLIENTES 
        private void MET_MostrarClientes()
        {
            CN_Acciones MostrarTablaClientes = new CN_Acciones();
            DtvClientes.DataSource = MostrarTablaClientes.MostrarCliente();
        }

        private void MET_MostrarClientesCobro()
        {
            CN_Acciones MostrarTablaClientesCobro = new CN_Acciones();
            DtvCliente2.DataSource = MostrarTablaClientesCobro.MostrarClientesCobro(V_IDCliente);
        }

        private void MET_MostrarDeudaCliente()
        {
            CN_Acciones MostrarTablaDeudaCliente = new CN_Acciones();
            DtvDeuda.DataSource = MostrarTablaDeudaCliente.MostrarDeudaCliente(V_IDCuentaPorCobrar);
        }

        //METODO PARA MOSTRAR A LOS CLIENTES QUE TIENEN DEUDAS
        private void MET_MostrarClienteaDeudores()
        {
            CN_Acciones MostrarTablaClientesDeudores = new CN_Acciones();
            DtvClientes.DataSource = MostrarTablaClientesDeudores.MostrarClientesDeudores();
        }

        //METODO PARA LIMPPIAR TODOS LOS TEXTBOX QUE SE ENCUENTRAN EN EL
        public void MET_LimpiarTextBox()
        {
            MtbCedula.Clear();
            TxtNombreCliente.Clear();
            TxtApellidoCliente.Clear();
            MtbTelefono.Clear();
            TxtDireccionCliente.Clear();
            TxtDeuda.Clear();
            TxtPago.Clear();
            TxtDeudaRestante.Clear();
            LblErrorCedula.Visible = false;
            LblErrorNombre.Visible = false;
            LblErrorApellido.Visible = false;
            LblErrorTelefono.Visible = false;
            LblErrorDireccion.Visible = false;
            LblErrorPago.Visible = false;
            LblErrorFechaNacimiento.Visible = false;
        }

        /*//METODO  PARA HACER INVISIBLES LOS LABELS QUE SE ENCUENTRAN EN EL
        public void MET_LblInvisibles()
        {
            LblErrorCedula.Visible = false;
            LblErrorNombre.Visible = false;
            LblErrorApellido.Visible = false;
            LblErrorTelefono.Visible = false;
            LblErrorDireccion.Visible = false;
            LblErrorPago.Visible = false;
        }*/

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            ActivarTextBoxDeInsertadoYEditado();
            DtvClientes.Visible = false;
            MtbCedula.Focus();
            BtnGuardarCliente.Visible = true;
            BtnAgregarCliente.Visible = false;
            BtnEditarCliente.Visible = false;
            BtnBorrarCliente.Visible = false;
            BtnCancelarGuardado.Visible = true;
        }

        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (V_Editar == false)
            {
                try
                {
                    if (MtbCedula.MaskFull != true)
                    {
                        LblErrorCedula.Visible = true;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        MtbCedula.Focus();
                        return;
                    }
                    else if (TxtNombreCliente.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = true;
                        LblErrorApellido.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        TxtNombreCliente.Focus();
                        return;
                    }
                    else if (TxtApellidoCliente.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = true;
                        LblErrorDireccion.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        TxtApellidoCliente.Focus();
                        return;
                    }
                    else if (TxtDireccionCliente.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorDireccion.Visible = true;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = false;
                        TxtDireccionCliente.Focus();
                        return;
                    }
                    else if (MtbTelefono.MaskFull != true)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorTelefono.Visible = true;
                        LblErrorFechaNacimiento.Visible = false;
                        MtbTelefono.Focus();
                        return;
                    }
                    else if (V_Edad < 18)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Visible = true;
                        LblErrorFechaNacimiento.Text = "EL CLIENTE NO DE DEBE SER MENOR DE 18 AÑOS";
                        return;
                    }
                    else
                    {
                        CN_Acciones InsertarCliente = new CN_Acciones();
                        InsertarCliente.InsertarDatosCliente(MtbCedula.Text,
                            TxtNombreCliente.Text, TxtApellidoCliente.Text,
                            TxtDireccionCliente.Text, MtbTelefono.Text,
                            DtpFechaNacimiento.Text);

                        MessageBox.Show("SE INSERTO CORRECTAMENTE");

                        MET_LimpiarTextBox();
                        //MET_LblInvisibles();
                        DtvClientes.Visible = true;
                        BtnGuardarCliente.Visible = false;
                        BtnEditarCliente.Visible = true;
                        BtnBorrarCliente.Visible = true;
                        BtnCancelarGuardado.Visible = false;
                        BtnAgregarCliente.Visible = true;
                        MET_MostrarClientes();
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Hay Un error en los datos introducidos. Revise y vuelva a intentarlo " + Error + " LLAME A SOPORTE TECNICO");
                    MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
                        LblErrorDireccion.Visible = false;
                        LblErrorTelefono.Visible = false;
                        MtbCedula.Focus();
                        return;
                    }
                    else if (TxtNombreCliente.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = true;
                        LblErrorApellido.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorTelefono.Visible = false;
                        TxtNombreCliente.Focus();
                        return;
                    }
                    else if (TxtApellidoCliente.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = true;
                        LblErrorDireccion.Visible = false;
                        LblErrorTelefono.Visible = false;
                        TxtApellidoCliente.Focus();
                        return;
                    }
                    else if (TxtDireccionCliente.Text == "")
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorDireccion.Visible = true;
                        LblErrorTelefono.Visible = false;
                        TxtDireccionCliente.Focus();
                        return;
                    }
                    else if (MtbTelefono.MaskFull != true)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorTelefono.Visible = true;
                        MtbTelefono.Focus();
                        return;
                    }
                    else if (V_Edad < 18)
                    {
                        LblErrorCedula.Visible = false;
                        LblErrorNombre.Visible = false;
                        LblErrorApellido.Visible = false;
                        LblErrorDireccion.Visible = false;
                        LblErrorTelefono.Visible = false;
                        LblErrorFechaNacimiento.Text = "EL CLIENTE DE DEBE SER MENOR DE 18 AÑOS";
                        LblErrorFechaNacimiento.Visible = true;
                        return;
                    }
                    else
                    {
                        CN_Acciones EditarCliente = new CN_Acciones();
                        if (DtvClientes.SelectedRows.Count > 0)
                        {
                            EditarCliente.EditarDatosClientes(MtbCedula.Text,
                                TxtNombreCliente.Text, TxtApellidoCliente.Text,
                                TxtDireccionCliente.Text, MtbTelefono.Text,
                                DtpFechaNacimiento.Text, V_IDCliente);

                            MessageBox.Show("SE EDITO CORRECTAMENTE");

                            MET_LimpiarTextBox();
                            //MET_LblInvisibles();
                            DtvClientes.Visible = true;
                            BtnGuardarCliente.Visible = false;
                            BtnEditarCliente.Visible = true;
                            BtnBorrarCliente.Visible = true;
                            BtnCancelarGuardado.Visible = false;
                            BtnCancelarEditado.Visible = false;
                            BtnAgregarCliente.Visible = true;
                            V_Editar = false;
                            MET_MostrarClientes();
                        }
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Hay Un error en los datos introducidos. Revise y vuelva a intentarlo " + Error + " LLAME A SOPORTE TECNICO");
                    MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void BtnCancelarGuardado_Click(object sender, EventArgs e)
        {
            MET_LimpiarTextBox();
            DtvClientes.Visible = true;
            BtnGuardarCliente.Visible = false;
            BtnEditarCliente.Visible = true;
            BtnBorrarCliente.Visible = true;
            BtnCancelarGuardado.Visible = false;
            BtnAgregarCliente.Visible = true;
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            if (DtvClientes.SelectedRows.Count > 0)
            {
                V_Editar = true;
                DtvClientes.Visible = false;
                BtnAgregarCliente.Visible = false;
                BtnBorrarCliente.Visible = false;
                BtnGuardarCliente.Visible = true;
                BtnCancelarEditado.Visible = true;
                BtnEditarCliente.Visible = false;
                MtbCedula.Text = DtvClientes.CurrentRow.Cells["Cedula"].Value.ToString();
                TxtNombreCliente.Text = DtvClientes.CurrentRow.Cells["Nombres"].Value.ToString();
                TxtApellidoCliente.Text = DtvClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                TxtDireccionCliente.Text = DtvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                MtbTelefono.Text = DtvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                DtpFechaNacimiento.Text = DtvClientes.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                V_IDCliente = DtvClientes.CurrentRow.Cells["ID_CLIENTE"].Value.ToString();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONE EL CLIENTE PRODUCTO QUE DESEA EDITAR");
            }
        }

        private void BtnCancelarEditado_Click(object sender, EventArgs e)
        {
            MET_LimpiarTextBox();
            BtnGuardarCliente.Visible = false;
            BtnBorrarCliente.Visible = true;
            BtnCancelarEditado.Visible = false;
            BtnAgregarCliente.Visible = true;
            BtnEditarCliente.Visible = true;
        }

        CN_Acciones INST_EliminarCliente = new CN_Acciones();
        private void BtnBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (DtvClientes.SelectedRows.Count > 0)
                {
                    V_IDCliente = DtvClientes.CurrentRow.Cells["ID_CLIENTE"].Value.ToString();
                    INST_EliminarCliente.MET_EliminarCliente(V_IDCliente);
                    MessageBox.Show("SE ELIMINO CORECTAMENTE");
                    MET_MostrarClientes();
                }
                else
                {
                    MessageBox.Show("SELECCIONE EL CLIENTE QUE DESEA ELIMINAR");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Este proveedor no se puede eliminar porque ha se han realizado movimientos con sus datos. La accion fue bloqueada para mantener la integridad de los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            V_Deudor = false;
            BtnBorrarCliente.Visible = true;
            BtnEditarCliente.Visible = true;
            BtnAgregarCliente.Visible = true;
            BtnClientes.Visible = false;
            BtnDeudores.Visible = true;
            BtnCobrar.Visible = false;
            BtnCalcularDeuda.Visible = false;
            DtvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MET_MostrarClientes();
        }

        private void BtnDeudores_Click(object sender, EventArgs e)
        {
            V_Deudor = true;
            BtnBorrarCliente.Visible = false;
            BtnEditarCliente.Visible = false;
            BtnAgregarCliente.Visible = false;
            BtnCobrar.Visible = true;
            BtnDeudores.Visible = false;
            BtnClientes.Visible = true;
            DtvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            MET_MostrarClienteaDeudores();
        }

        private void BtnCancelarCobro_Click(object sender, EventArgs e)
        {
            MET_LimpiarTextBox();
            //MET_LblInvisibles();
            BtnAgregarCliente.Visible = false;
            BtnGuardarCliente.Visible = false;
            BtnCalcularDeuda.Visible = false;
            BtnCobrar.Visible = true;
            BtnCancelarCobro.Visible = false;
            BtnClientes.Visible = true;
            DtvClientes.Visible = true;
        }

        private void DesactivarTextBoxDeInsertadoYEditado()
        {
            MtbCedula.ReadOnly = true;
            TxtNombreCliente.ReadOnly = true;
            TxtApellidoCliente.ReadOnly = true;
            DtpFechaNacimiento.Enabled = false;
            TxtDireccionCliente.ReadOnly = true;
            MtbTelefono.ReadOnly = true;
        }

        private void ActivarTextBoxDeInsertadoYEditado()
        {
            MtbCedula.ReadOnly = false;
            TxtNombreCliente.ReadOnly = false;
            TxtApellidoCliente.ReadOnly = false;
            DtpFechaNacimiento.Enabled = true;
            TxtDireccionCliente.ReadOnly = false;
            MtbTelefono.ReadOnly = false;
        }

        private void ActivarElementosDeCobro()
        {
            LblDeuda.Visible = true;
            TxtDeuda.Visible = true;
            LspDeuda.Visible = true;
            LblPago.Visible = true;
            TxtPago.Visible = true;
            LspPago.Visible = true;
            LblDeudaRestante.Visible = true;
            TxtDeudaRestante.Visible = true;
            LspDeudaRestante.Visible = true;
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            if (DtvClientes.SelectedRows.Count > 0)
            {
                BtnCalcularDeuda.Visible = true;
                BtnBorrarCliente.Visible = false;
                BtnEditarCliente.Visible = false;
                BtnAgregarCliente.Visible = false;
                BtnCobrar.Visible = false;
                BtnClientes.Visible = false;
                BtnCancelarCobro.Visible = true;
                ActivarElementosDeCobro();

                V_IDCuentaPorCobrar = DtvClientes.CurrentRow.Cells["ID_CuentaPorCobrar"].Value.ToString();
                V_IDCliente = DtvClientes.CurrentRow.Cells["ID_Cliente"].Value.ToString();

                MET_MostrarClientesCobro();
                MET_MostrarDeudaCliente();

                //V_IDCuentaPorCobrar = DtvDeuda.CurrentRow.Cells["ID_CuentaPorCobrar"].Value.ToString();
                TxtDeuda.Text = DtvDeuda.CurrentRow.Cells["Deuda"].Value.ToString();
                MtbCedula.Text = DtvCliente2.CurrentRow.Cells["Cedula"].Value.ToString();
                TxtNombreCliente.Text = DtvCliente2.CurrentRow.Cells["Nombres"].Value.ToString();
                TxtApellidoCliente.Text = DtvCliente2.CurrentRow.Cells["Apellidos"].Value.ToString();
                TxtDireccionCliente.Text = DtvCliente2.CurrentRow.Cells["Direccion"].Value.ToString();
                MtbTelefono.Text = DtvCliente2.CurrentRow.Cells["Telefono"].Value.ToString();
                DtpFechaNacimiento.Text = DtvCliente2.CurrentRow.Cells["FechaNacimiento"].Value.ToString();

                DesactivarTextBoxDeInsertadoYEditado();
                DtvClientes.Visible = false;
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONE EL CLIENTE AL QUE DESEA REALIZAR EL COBRO");
            }
        }

        private void BtnCalcularDeuda_Click(object sender, EventArgs e)
        {
            if (TxtPago.Text == "")
            {
                LblErrorPago.Visible = true;
                return;
            }
            else if (Convert.ToDouble(TxtPago.Text) <= 0)
            {
                LblErrorPago.Text = "CANTIDAD INCORECTA";
                LblErrorPago.Visible = true;
                return;
            }
            else if (Convert.ToDouble(TxtDeuda.Text) < Convert.ToDouble(TxtPago.Text))
            {
                LblErrorPago.Text = "EL PAGO ES MAYOR QUE LA DEUDA";
                LblErrorPago.Visible = true;
                return;
            }
            else if (Convert.ToDouble(TxtPago.Text) <= Convert.ToDouble(TxtDeuda.Text))
            {
                Deuda = Convert.ToDouble(TxtDeuda.Text);
                Pago = Convert.ToDouble(TxtPago.Text);
                DeudaRestante = Deuda - Pago;
                TxtDeudaRestante.Text = DeudaRestante.ToString();

                try
                {
                    CN_Acciones INST_InsertarPagoDeCuenta = new CN_Acciones();
                    INST_InsertarPagoDeCuenta.MET_InsertarPagoDeCuenta(Convert.ToInt32(V_IDCuentaPorCobrar),
                        Convert.ToDouble(TxtDeudaRestante.Text));

                    MessageBox.Show("SE HA COMPLETADO LA TRANSACCION");
                    DtvClientes.Visible = true;
                    MET_MostrarClienteaDeudores();
                    MET_LimpiarTextBox();
                    DtvClientes.Visible = true;
                    BtnEditarCliente.Visible = true;
                    BtnBorrarCliente.Visible = true;
                    BtnAgregarCliente.Visible = true;
                    BtnClientes.Visible = true;
                    BtnCalcularDeuda.Visible = false;
                    DtvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception)
                {
                    //MessageBox.Show("Hay Un error en los datos introducidos. Revise y vuelva a intentarlo " + Error + " LLAME A SOPORTE TECNICO");
                    MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void MtbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void TxtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.TxtPago.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void MtbCedula_Enter(object sender, EventArgs e)
        {
            MtbCedula.PromptChar = ' ';
        }

        private void MtbCedula_MouseClick(object sender, MouseEventArgs e)
        {
            MtbCedula.SelectionStart = 0;
        }

        private void MtbTelefono_Enter(object sender, EventArgs e)
        {
            MtbTelefono.PromptChar = ' ';
        }

        private void MtbTelefono_MouseClick(object sender, MouseEventArgs e)
        {
            MtbTelefono.SelectionStart = 0;
        }

        private void DtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            V_Edad = (DateTime.Today.AddTicks(-DtpFechaNacimiento.Value.Ticks).Year - 1);
        }

        private void MtbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtDireccionCliente.Focus();
            }
        }

        private void TxtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarCliente.Text != "")
            {
                DtvClientes.CurrentCell = null;
                foreach (DataGridViewRow Filas in DtvClientes.Rows)
                {
                    Filas.Visible = false;
                }
                foreach (DataGridViewRow Filas in DtvClientes.Rows)
                {
                    foreach (DataGridViewCell Celdas in Filas.Cells)
                    {
                        if ((Celdas.Value.ToString().ToUpper()).IndexOf(TxtBuscarCliente.Text.ToUpper()) == 0)
                        {
                            Filas.Visible = true;
                            break;
                        }
                    }
                }
            }
            else if (V_Deudor == false)
            {
                MET_MostrarClientes();
            }
            else if (V_Deudor == true)
            {
                MET_MostrarClienteaDeudores();
            }
        }

        private void TxtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtApellidoCliente.Focus();
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
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}