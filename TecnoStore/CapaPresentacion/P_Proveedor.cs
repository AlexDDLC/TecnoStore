using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_Proveedor : Form
    {
        private string V_IDProveedor = null;
        private bool V_Editar = false;

        public P_Proveedor()
        {
            InitializeComponent();
        }

        public void MET_MostrarProveedor()
        {
            CN_Acciones INST_MostrarProveedor = new CN_Acciones();
            DtvProveedor.DataSource = INST_MostrarProveedor.MET_MostrarTablaProveedor();
        }

        public void MET_Limpiar()
        {
            TxtNombreProveedor.Clear();
            TxtNombreContacto.Clear();
            MtbTelefonoContacto.Clear();
            TxtDireccionWeb.Clear();
        }

        public void MET_LblInvisibles()
        {
            LblErrorNombre.Visible = false;
            LblErrorNombreContacto.Visible = false;
            LblErrorTelefonoContacto.Visible = false;
            LblErrorDireccionWeb.Visible = false;
        }

        private void TxtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtNombreContacto.Focus();
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

        private void TxtNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                MtbTelefonoContacto.Focus();
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

        private void MtbTelefonoContacto_Enter(object sender, EventArgs e)
        {
            MtbTelefonoContacto.PromptChar = ' ';
        }

        private void MtbTelefonoContacto_MouseClick(object sender, MouseEventArgs e)
        {
            MtbTelefonoContacto.SelectionStart = 0;
        }

        private void TxtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarProveedor.Text != "")
            {
                DtvProveedor.CurrentCell = null;
                foreach (DataGridViewRow Filas in DtvProveedor.Rows)
                {
                    Filas.Visible = false;
                }
                foreach (DataGridViewRow Filas in DtvProveedor.Rows)
                {
                    foreach (DataGridViewCell Celdas in Filas.Cells)
                    {
                        if ((Celdas.Value.ToString().ToUpper()).IndexOf(TxtBuscarProveedor.Text.ToUpper()) == 0)
                        {
                            Filas.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                MET_MostrarProveedor();
            }
        }

        private void P_Proveedor_Load(object sender, EventArgs e)
        {
            MET_MostrarProveedor();
        }

        private void BtnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (DtvProveedor.SelectedRows.Count > 0)
            {
                V_Editar = true;
                DtvProveedor.Visible = false;
                BtnAgregarProveedor.Visible = false;
                BtnBorrarProveedor.Visible = false;
                BtnGuardarProveedor.Visible = true;
                BtnCancelarGuardado.Visible = true;
                BtnEditarProveedor.Visible = false;
                TxtNombreProveedor.Text = DtvProveedor.CurrentRow.Cells["Proveedor"].Value.ToString();
                TxtNombreContacto.Text = DtvProveedor.CurrentRow.Cells["Contacto"].Value.ToString();
                MtbTelefonoContacto.Text = DtvProveedor.CurrentRow.Cells["Telefono_Contacto"].Value.ToString();
                TxtDireccionWeb.Text = DtvProveedor.CurrentRow.Cells["DireccionWeb"].Value.ToString();
                V_IDProveedor = DtvProveedor.CurrentRow.Cells["ID_Proveedor"].Value.ToString();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONE EL PROVEEDOR PRODUCTO QUE DESEA EDITAR");
            }
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            DtvProveedor.Visible = false;
            TxtNombreProveedor.Focus();
            BtnGuardarProveedor.Visible = true;
            BtnAgregarProveedor.Visible = false;
            BtnEditarProveedor.Visible = false;
            BtnBorrarProveedor.Visible = false;
            BtnCancelarGuardado.Visible = true;
        }

        CN_Acciones INST_EliminarProveedor = new CN_Acciones();
        private void BtnBorrarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (DtvProveedor.SelectedRows.Count > 0)
                {
                    V_IDProveedor = DtvProveedor.CurrentRow.Cells["ID_Proveedor"].Value.ToString();
                    INST_EliminarProveedor.MET_EliminarProveedor(V_IDProveedor);
                    MET_MostrarProveedor();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Este proveedor no se puede eliminar porque ha se han realizado movimientos con sus datos. La accion fue bloqueada para mantener la integridad de los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Hay Un error en los datos introducidos. Revise y vuelva a intentarlo " + Error + " LLAME A SOPORTE TECNICO");
                return;
            }
        }

        private void BtnCancelarGuardado_Click(object sender, EventArgs e)
        {
            MET_Limpiar();
            DtvProveedor.Visible = true;
            BtnGuardarProveedor.Visible = false;
            BtnEditarProveedor.Visible = true;
            BtnBorrarProveedor.Visible = true;
            BtnCancelarGuardado.Visible = false;
            BtnAgregarProveedor.Visible = true;
        }

        private void BtnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (V_Editar == false)
            {
                try
                {
                    if (TxtNombreContacto.Text == "")
                    {
                        LblErrorNombre.Visible = true;
                        LblErrorNombreContacto.Visible = false;
                        LblErrorTelefonoContacto.Visible = false;
                        LblErrorDireccionWeb.Visible = false;
                        TxtNombreProveedor.Focus();
                        return;
                    }
                    else if (TxtNombreContacto.Text == "")
                    {
                        LblErrorNombre.Visible = false;
                        LblErrorNombreContacto.Visible = true;
                        LblErrorTelefonoContacto.Visible = false;
                        LblErrorDireccionWeb.Visible = false;
                        TxtNombreContacto.Focus();
                        return;
                    }
                    else if (MtbTelefonoContacto.MaskFull != true)
                    {
                        LblErrorNombre.Visible = false;
                        LblErrorNombreContacto.Visible = false;
                        LblErrorTelefonoContacto.Visible = true;
                        LblErrorDireccionWeb.Visible = false;
                        MtbTelefonoContacto.Focus();
                        return;
                    }
                    else if (TxtDireccionWeb.Text == "")
                    {
                        LblErrorNombre.Visible = false;
                        LblErrorNombreContacto.Visible = false;
                        LblErrorTelefonoContacto.Visible = false;
                        LblErrorDireccionWeb.Visible = true;
                        TxtDireccionWeb.Focus();
                        return;
                    }
                    else
                    {
                        CN_Acciones INST_InsertarProveedor = new CN_Acciones();
                        INST_InsertarProveedor.MET_InsertarDatosProveedor(TxtNombreProveedor.Text,
                            TxtNombreContacto.Text, MtbTelefonoContacto.Text, TxtDireccionWeb.Text);

                        MessageBox.Show("SE INSERTO CORRECTAMENTE");

                        MET_Limpiar();
                        MET_LblInvisibles();
                        DtvProveedor.Visible = true;
                        BtnGuardarProveedor.Visible = false;
                        BtnEditarProveedor.Visible = true;
                        BtnBorrarProveedor.Visible = true;
                        BtnCancelarGuardado.Visible = false;
                        BtnAgregarProveedor.Visible = true;
                        MET_MostrarProveedor();
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
                    if (TxtNombreContacto.Text == "")
                    {
                        LblErrorNombre.Visible = true;
                        LblErrorNombreContacto.Visible = false;
                        LblErrorTelefonoContacto.Visible = false;
                        LblErrorDireccionWeb.Visible = false;
                        TxtNombreProveedor.Focus();
                        return;
                    }
                    else if (TxtNombreContacto.Text == "")
                    {
                        LblErrorNombre.Visible = false;
                        LblErrorNombreContacto.Visible = true;
                        LblErrorTelefonoContacto.Visible = false;
                        LblErrorDireccionWeb.Visible = false;
                        TxtNombreContacto.Focus();
                        return;
                    }
                    else if (MtbTelefonoContacto.MaskFull != true)
                    {
                        LblErrorNombre.Visible = false;
                        LblErrorNombreContacto.Visible = false;
                        LblErrorTelefonoContacto.Visible = true;
                        LblErrorDireccionWeb.Visible = false;
                        MtbTelefonoContacto.Focus();
                        return;
                    }
                    else if (TxtDireccionWeb.Text == "")
                    {
                        LblErrorNombre.Visible = false;
                        LblErrorNombreContacto.Visible = false;
                        LblErrorTelefonoContacto.Visible = false;
                        LblErrorDireccionWeb.Visible = true;
                        TxtDireccionWeb.Focus();
                        return;
                    }
                    else
                    {
                        CN_Acciones INST_EditaProveedor = new CN_Acciones();
                        if (DtvProveedor.SelectedRows.Count > 0)
                        {
                            INST_EditaProveedor.MET_EditarDatosProveedor(TxtNombreProveedor.Text,
                                TxtNombreContacto.Text, MtbTelefonoContacto.Text, TxtDireccionWeb.Text,
                                V_IDProveedor);

                            MessageBox.Show("SE EDITO CORRECTAMENTE");

                            MET_Limpiar();
                            MET_LblInvisibles();
                            DtvProveedor.Visible = true;
                            BtnGuardarProveedor.Visible = false;
                            BtnEditarProveedor.Visible = true;
                            BtnBorrarProveedor.Visible = true;
                            BtnCancelarGuardado.Visible = false;
                            BtnAgregarProveedor.Visible = true;
                            MET_MostrarProveedor();
                            V_Editar = false;
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

        private void MtbTelefonoContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                TxtDireccionWeb.Focus();
            }
        }

        private void TxtBuscarProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }
    }
}