using CapaNegocio;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_Venta : Form
    {
        private string V_IDCrediro = null;
        private string V_IDProducto = null;
        private string V_IDDetalleVenta = null;
        private string V_IDFactura = null;
        private string V_IDCliente = null;
        private string V_PrecioProducto = null;
        private string V_Stock = null;
        private string V_CantidadProductoDetalle = null;
        private string V_CantidadNuevaProducto = null;
        private string V_IDProductoDetalle = null;
        private bool V_EditarCliente = false, V_ConSaldo = false;
        //private bool V_EditarTipoVenta = false;
        double V_ITBIS = 0, V_SUBTOTAL = 0, V_Pago = 0, V_SALDO = 0,
            TotalITBIS = 0, TotalSUBTOTAL = 0, TotalVenta = 0, PagoMasCredito = 0,
            Devuelta = 0;

        public P_Venta()
        {
            InitializeComponent();
        }

        public void MET_MostrarClientes()
        {
            CN_Acciones INST_MostrarTablaClientes = new CN_Acciones();
            DtvBusqueda.DataSource = INST_MostrarTablaClientes.MostrarCliente();
        }

        public void MET_MostrarDetalleVenta()
        {
            CN_Acciones INST_MostrarTablaDetalleVenta = new CN_Acciones();
            DtvFactura.DataSource = INST_MostrarTablaDetalleVenta.MET_MostrarDetallesVentas(V_IDFactura);
        }

        public void MET_MostrarFacturaImpresa()
        {
            //CN_Acciones INST_MostrarFacturaImpresa = new CN_Acciones();
            P_ReportesFactura PF = new P_ReportesFactura();
            PF.ID_Factura = Convert.ToInt32(TxtIDFactura.Text);
            PF.ShowDialog();
        }

        public void MET_MostrarStock()
        {
            CN_Acciones INST_MostrarStock = new CN_Acciones();
            DtvStock.DataSource = INST_MostrarStock.MET_MostrarStock(V_IDProducto);
        }

        public void MET_MostrarProductos()
        {
            CN_Acciones MostrarTablaDeProductos2 = new CN_Acciones();
            DtvBusqueda.DataSource = MostrarTablaDeProductos2.MostrarProductosCajero();
        }

        public void MET_MostrarClientesConCredito()
        {
            CN_Acciones INST_MostrarClientesConCredito = new CN_Acciones();
            DtvBusqueda.DataSource = INST_MostrarClientesConCredito.MET_MostrarClientesConCredito();
        }

        public void MET_CalcularITBIS_SUBTOTAL()
        {
            foreach (DataGridViewRow Fila in DtvFactura.Rows)
            {
                TotalITBIS += Convert.ToDouble(Fila.Cells["ITBIS"].Value);
                TotalSUBTOTAL += Convert.ToDouble(Fila.Cells["SUBTOTAL"].Value);
                TotalVenta = TotalITBIS + TotalSUBTOTAL;
            }
            TxtITBIS.Text = Convert.ToString(TotalITBIS);
            TxtSUBTOTAL.Text = Convert.ToString(TotalSUBTOTAL);
            TxtTotal.Text = Convert.ToString(TotalVenta);
        }

        public void MET_NuevaFactura()
        {
            TxtBuscar.Clear();
            TxtCantidad.Text = "1";
            TxtCliente.Clear();
            TxtCedulaCliente.Clear();
            TxtITBIS.Clear();
            TxtSUBTOTAL.Clear();
            TxtIDFactura.Clear();
            TxtTotal.Clear();
            TxtPago.Clear();
            TxtDebuelta.Clear();
            TxtSaldo.Clear();
            //DtvBusqueda.Refresh();
            DtvFactura.DataSource = "";
            DtvFactura.Columns.Clear();
            BtnAgregarProducto.Visible = false;
            BtnAgregarCliente.Visible = true;
            BtnCambiarCliente.Visible = false;
            RdbAlContado.Checked = true;
            MET_MostrarClientes();
            LblErrorPago.Visible = false;
            P_Venta PV = new P_Venta();
            PV.Update();
        }

        public void MET_SacarIDFactura()
        {
            CN_Acciones INST_SacarIDFactura = new CN_Acciones();
            DtvIDFactura.DataSource = INST_SacarIDFactura.MET_Mostrar_IDFactura();
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            BtnQuitarProducto.Visible = false;
            TxtCantidad.Visible = false;
            LspCantidad.Visible = false;
            BtnFacturar.Visible = true;
            MET_MostrarClientes();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            BtnQuitarProducto.Visible = true;
            TxtCantidad.Visible = true;
            LspCantidad.Visible = true;
            BtnFacturar.Visible = false;
        }

        private void P_Ventas_Load(object sender, EventArgs e)
        {
            MET_MostrarClientes();
            LblNombreEmpleado.Text = Program.NombreEmpleado;
            //RdbAlContado.Checked = true;
        }

        private void DtvBusqueda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DtvBusqueda.Columns[e.ColumnIndex].Name == "Stock")
            {
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.SelectionBackColor = Color.Yellow;
                    e.CellStyle.SelectionForeColor = Color.Red;
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
                DtvBusqueda.CurrentCell = null;
                foreach (DataGridViewRow Filas in DtvBusqueda.Rows)
                {
                    Filas.Visible = false;
                }
                foreach (DataGridViewRow Filas in DtvBusqueda.Rows)
                {
                    foreach (DataGridViewCell Celdas in Filas.Cells)
                    {
                        if ((Celdas.Value.ToString().ToUpper()).IndexOf(TxtBuscar.Text.ToUpper()) == 0)
                        {
                            Filas.Visible = true;
                            break;
                        }
                    }
                }
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (DtvBusqueda.SelectedRows.Count > 0)
            {
                V_IDProducto = DtvBusqueda.CurrentRow.Cells["ID_Producto"].Value.ToString();
                V_Stock = DtvBusqueda.CurrentRow.Cells["Stock"].Value.ToString();
                V_PrecioProducto = DtvBusqueda.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                TxtCantidad.Text = "1";
                TotalITBIS = 0;
                TotalSUBTOTAL = 0;
                TotalVenta = 0;
                MET_CalcularITBIS_SUBTOTAL();
            }
            else
            {
                MessageBox.Show("SELECCIONE EL PRODUCTO QUE DESEA VENDER");
                return;
            }
            try
            {
                int Stock = Convert.ToInt32(V_Stock);
                double PrecioProducto = Convert.ToDouble(V_PrecioProducto);
                int CantidadProducto = Convert.ToInt32(TxtCantidad.Text);

                if (TxtCantidad.Text == "" || CantidadProducto == 0)
                {
                    LblErrorCantidad.Text = "ESTE CAMPO NO PUEDE ESTAR VACIO NI SER IGUAL A 0";
                    return;
                }
                else if (TxtCantidad.Text != "")
                {
                    if (Stock < CantidadProducto)
                    {
                        MessageBox.Show("LA CANTIDAD DEL PRODUCTO NO PUEDE SER MAYOR QUE LA DEL STOCK");
                        return;
                    }
                    else
                    {
                        V_ITBIS = PrecioProducto * CantidadProducto * 0.18;
                        V_SUBTOTAL = PrecioProducto * CantidadProducto;

                        CN_Acciones INST_InsertarDetalleVenta = new CN_Acciones();
                        INST_InsertarDetalleVenta.MET_InsertarDetallesVenta(
                            Convert.ToInt32(V_IDFactura),
                            Convert.ToInt32(V_IDProducto),
                            TxtCantidad.Text,
                            Convert.ToDouble(V_ITBIS),
                            Convert.ToDouble(V_SUBTOTAL));

                        //MET_MostrarDetalleVenta();
                        BtnAgregarCliente.Visible = false;
                        MET_MostrarDetalleVenta();
                        MET_MostrarProductos();
                        TotalITBIS = 0;
                        TotalSUBTOTAL = 0;
                        TotalVenta = 0;
                        MET_CalcularITBIS_SUBTOTAL();
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("OCURRIO UN ERROR" + Error);
            }
        }

        CN_Acciones INST_EliminarProductoDetalleVenta = new CN_Acciones();
        private void BtnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (DtvFactura.Rows.Count > 0)
            {
                try
                {
                    if (DtvFactura.SelectedRows.Count > 0)
                    {
                        V_IDDetalleVenta = DtvFactura.CurrentRow.Cells["ID_DetalleVenta"].Value.ToString();
                        V_IDProductoDetalle = DtvFactura.CurrentRow.Cells["ID_Producto"].Value.ToString();
                        V_CantidadProductoDetalle = DtvFactura.CurrentRow.Cells["Cantidad"].Value.ToString();
                        INST_EliminarProductoDetalleVenta.MET_EliminarProductoDetalleVenta(V_IDDetalleVenta,
                            V_IDProductoDetalle, V_CantidadProductoDetalle);
                        MessageBox.Show("SE ELIMINO EL PRODUCTO DE LA FACTURA");
                        MET_MostrarProductos();
                        MET_MostrarDetalleVenta();
                        TotalITBIS = 0;
                        TotalSUBTOTAL = 0;
                        TotalVenta = 0;
                        MET_CalcularITBIS_SUBTOTAL();

                        if (DtvFactura.Rows.Count <= 0)
                        {
                            TxtITBIS.Clear();
                            TxtSUBTOTAL.Clear();
                            TxtTotal.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("SELECCIONE EL PRODUCTO QUE DESEA ELIMINAR DE LA FACTURA");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hay Un error en los datos introducidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (DtvFactura.Rows.Count <= 0)
            {
                MessageBox.Show("NO HAY NINGUN PRODUCTO QUE ELIMINAR");
                return;
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (DtvBusqueda.SelectedRows.Count > 0)
            {
                if (V_ConSaldo == true)
                {
                    TxtCliente.Text = DtvBusqueda.CurrentRow.Cells["Nombre_Cliente"].Value.ToString();
                    TxtCedulaCliente.Text = DtvBusqueda.CurrentRow.Cells["Cedula"].Value.ToString();
                    V_IDCliente = DtvBusqueda.CurrentRow.Cells["ID_Cliente"].Value.ToString();
                    TxtSaldo.Text = DtvBusqueda.CurrentRow.Cells["Credito"].Value.ToString();
                    V_IDCrediro = DtvBusqueda.CurrentRow.Cells["ID_Devolucion"].Value.ToString();
                    TxtSaldo.Visible = true;
                    LblSaldo.Visible = true;
                    LspSaldo.Visible = true;
                    BtnConDinero.Visible = false;
                    BtnConSaldo.Visible = false;
                    BtnAgregarProducto.Visible = true;
                }
                else if (V_ConSaldo == false)
                {
                    TxtCliente.Text = DtvBusqueda.CurrentRow.Cells["Nombres"].Value.ToString() + " " + DtvBusqueda.CurrentRow.Cells["Apellidos"].Value.ToString();
                    TxtCedulaCliente.Text = DtvBusqueda.CurrentRow.Cells["Cedula"].Value.ToString();
                    V_IDCliente = DtvBusqueda.CurrentRow.Cells["ID_Cliente"].Value.ToString();
                    TxtSaldo.Visible = false;
                    TxtSaldo.Text = "0";
                    LblSaldo.Visible = false;
                    LspSaldo.Visible = false;
                    BtnConSaldo.Visible = false;
                    BtnConDinero.Visible = false;
                    BtnAgregarProducto.Visible = true;
                }
                if (V_EditarCliente == false)
                {
                    try
                    {
                        CN_Acciones INST_InsertarVenta = new CN_Acciones();
                        INST_InsertarVenta.MET_InsertarVenta(Program.ID_Empleados,
                            Convert.ToInt32(V_IDCliente),
                            RdbAlContado.Checked == true ? 1 : 2, LblFecha.Text,
                            Convert.ToDouble(TxtITBIS.Text),
                            Convert.ToDouble(TxtSUBTOTAL.Text),
                            Convert.ToDouble(TxtTotal.Text));

                        //MessageBox.Show("LOS DATOS FUERON INGRESADOS");
                        BtnAgregarProducto.Visible = true;
                        MET_SacarIDFactura();
                        TxtIDFactura.Text = DtvIDFactura.CurrentRow.Cells["ID"].Value.ToString();
                        V_IDFactura = DtvIDFactura.CurrentRow.Cells["ID"].Value.ToString();

                        BtnAgregarCliente.Visible = false;
                        BtnCambiarCliente.Visible = true;
                        MET_MostrarProductos();
                    }
                    catch (Exception Error)
                    {
                        MessageBox.Show("OCURRIO UN ERROR " + Error);
                    }
                }
                else if (V_EditarCliente == true)
                {
                    try
                    {
                        CN_Acciones INST_EditarClienteFactura = new CN_Acciones();
                        if (DtvBusqueda.SelectedRows.Count > 0)
                        {
                            INST_EditarClienteFactura.MET_EditarClienteFactura(
                                Convert.ToInt32(V_IDCliente), V_IDFactura);
                            //MessageBox.Show("SE CAMBIO EL CLIENTE");
                            BtnAgregarCliente.Visible = false;
                            BtnCambiarCliente.Visible = true;
                            MET_MostrarProductos();
                            V_EditarCliente = false;
                        }
                    }
                    catch (Exception Error)
                    {
                        MessageBox.Show("OCURRIO UN ERROR " + Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONE AL CLIENTE AL QUE SE LE VA A VENDER");
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

        private void TxtCantidad_Enter(object sender, EventArgs e)
        {
            TxtCantidad.Clear();
        }

        private void TxtCantidad_Leave(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "")
            {
                TxtCantidad.Text = "1";
            }
        }

        private void TxtPago_Leave(object sender, EventArgs e)
        {
            if (TxtPago.Text == "")
            {
                TxtPago.Text = "0";
            }
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void BtnCambiarCliente_Click(object sender, EventArgs e)
        {
            if (V_ConSaldo == false)
            {
                MET_MostrarClientes();
                BtnConSaldo.Visible = true;
                BtnConDinero.Visible = false;
            }
            else if (V_ConSaldo == true)
            {
                MET_MostrarClientesConCredito();
                BtnConDinero.Visible = true;
                BtnConSaldo.Visible = false;
            }
            TxtCedulaCliente.Clear();
            TxtCliente.Clear();
            BtnAgregarProducto.Visible = false;
            BtnCambiarCliente.Visible = false;
            BtnAgregarCliente.Visible = true;
            V_EditarCliente = true;
            //MET_MostrarClientes();
        }

        /*private void TxtCambiarProducto_Click(object sender, EventArgs e)
        {
            BtnAgregarProducto.Visible = false;
            LblErrorCantidad.Visible = false;
            MET_MostrarProductos();
        }*/

        private void TxtPago_Enter(object sender, EventArgs e)
        {
            TxtPago.Clear();
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            if (TxtIDFactura.Text == "")
            {
                MessageBox.Show("NO SE HA SELECCIONADO AL CLIENTE");
                return;
            }
            if (DtvFactura.Rows.Count > 0)
            {
                if (TxtIDFactura.Text == "")
                {
                    MessageBox.Show("NO SE HA GENERADO LA FACTURA");
                    return;
                }
                if (Convert.ToDouble(TxtITBIS.Text) == 0)
                {
                    MessageBox.Show("NO SE HA ELEGIDO NINGUN PRODUCTO");
                    return;
                }
                if (V_ConSaldo == false)
                {
                    if (TxtPago.Text == "")
                    {
                        LblErrorPago.Text = "INTRODUZCA LA CANTIDAD A PAGAR";
                        LblErrorPago.Visible = true;
                        return;
                    }
                    if (Convert.ToDouble(TxtPago.Text) == 0)
                    {
                        LblErrorPago.Visible = true;
                        return;
                    }
                    else if (Convert.ToDouble(TxtPago.Text) <= 0)
                    {
                        LblErrorPago.Text = "LA CANTIDAD A PAGAR NO DEBE SER 0";
                        LblErrorPago.Visible = true;
                        return;
                    }
                    else if (Convert.ToDouble(TxtPago.Text) < Convert.ToDouble(TxtTotal.Text))
                    {
                        LblErrorPago.Text = "LA CANTIDAD A PAGAR NO PUEDE SER MENOR";
                        LblErrorPago.Visible = true;
                        return;
                    }
                    else if (Convert.ToDouble(TxtPago.Text) >= Convert.ToDouble(TxtTotal.Text))
                    {
                        V_Pago = Convert.ToDouble(TxtPago.Text);
                        TotalVenta = Convert.ToDouble(TxtTotal.Text);
                        Devuelta = V_Pago - TotalVenta;
                        TxtDebuelta.Text = Devuelta.ToString();
                        LblDevuelta.Visible = true;
                        LspDevuelta.Visible = true;
                        TxtDebuelta.Visible = true;

                        if (RdbACredito.Checked == true)
                        {
                            try
                            {
                                CN_Acciones INST_EditarFacturaFinal = new CN_Acciones();
                                INST_EditarFacturaFinal.MET_EditarFacturaFinal(
                                    RdbACredito.Checked == true ? 2 : 1,
                                    Convert.ToDouble(TxtITBIS.Text),
                                    Convert.ToDouble(TxtSUBTOTAL.Text),
                                    Convert.ToDouble(TxtTotal.Text),
                                    V_IDFactura);

                                MessageBox.Show("INGRESO FACTURA");
                                MET_MostrarFacturaImpresa();
                            }
                            catch (Exception)
                            {
                                //MessageBox.Show("OCURRIO UN ERROR " + Error);
                                MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            try
                            {
                                CN_Acciones INST_InsertarCuentaPorCobrar = new CN_Acciones();
                                INST_InsertarCuentaPorCobrar.MET_InsertarCuentasProdCobrar(
                                    Convert.ToInt32(V_IDFactura), Convert.ToInt32(V_IDCliente),
                                    Convert.ToInt32(Program.ID_Empleados), LblFecha.Text,
                                    Convert.ToInt32(TxtTotal.Text));

                                MessageBox.Show("INGRESO CUENTA POR COBRAR");
                            }
                            catch (Exception)
                            {
                                //MessageBox.Show("OCURRIO UN ERROR " + Error);
                                MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else if (RdbAlContado.Checked == true)
                        {
                            try
                            {
                                CN_Acciones INST_EditarFacturaFinal = new CN_Acciones();
                                INST_EditarFacturaFinal.MET_EditarFacturaFinal(
                                    RdbAlContado.Checked == true ? 1 : 2,
                                    Convert.ToDouble(TxtITBIS.Text),
                                    Convert.ToDouble(TxtSUBTOTAL.Text),
                                    Convert.ToDouble(TxtTotal.Text),
                                    V_IDFactura);

                                MessageBox.Show("INGRESO FACTURA");
                                MET_MostrarFacturaImpresa();
                            }
                            catch (Exception)
                            {
                                //MessageBox.Show("OCURRIO UN ERROR " + Error);
                                MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                else if (V_ConSaldo == true)
                {
                    if (TxtPago.Text == "")
                    {
                        MessageBox.Show("NO HA INTRODUCIDO EL PAGO");
                        return;
                    }
                    else if (Convert.ToDouble(TxtPago.Text) <= 0)
                    {
                        LblErrorPago.Text = "LA CANTIDAD A PAGAR NO DEBE SER NEGATIVA O IGUAL A 0";
                        LblErrorPago.Visible = true;
                        return;
                    }
                    else if ((Convert.ToDouble(TxtPago.Text) + Convert.ToDouble(TxtSaldo.Text)) < Convert.ToDouble(TxtTotal.Text))
                    {
                        LblErrorPago.Text = "LA CANTIDAD INTRODUCIDA NO ES SUFICIENTE PARA PAGAR";
                        LblErrorPago.Visible = true;
                        return;
                    }
                    else if ((Convert.ToDouble(TxtSaldo.Text) + Convert.ToDouble(TxtPago.Text)) >= Convert.ToDouble(TxtTotal.Text))
                    {
                        V_SALDO = Convert.ToDouble(TxtSaldo.Text);
                        V_Pago = Convert.ToDouble(TxtPago.Text);
                        TotalVenta = Convert.ToDouble(TxtTotal.Text);
                        PagoMasCredito = V_Pago + V_SALDO;
                        TxtSaldo.Text = "0";
                        Devuelta = PagoMasCredito - TotalVenta;
                        TxtDebuelta.Text = Devuelta.ToString();
                        LblDevuelta.Visible = true;
                        LspDevuelta.Visible = true;
                        TxtDebuelta.Visible = true;
                    }
                    else if (Convert.ToDouble(TxtSaldo.Text) > Convert.ToDouble(TxtTotal.Text))
                    {
                        V_SALDO = Convert.ToDouble(TxtSaldo.Text);
                        V_Pago = Convert.ToDouble(TxtPago.Text);
                        TotalVenta = Convert.ToDouble(TxtTotal.Text);
                        PagoMasCredito = V_Pago + V_SALDO;
                        TxtSaldo.Text = Convert.ToString(TotalVenta - V_SALDO);
                        MessageBox.Show("EL CREDITO RESTANTE ES " + Convert.ToString(TotalVenta - V_SALDO));
                    }
                    if (RdbACredito.Checked == true)
                    {
                        try
                        {
                            CN_Acciones INST_EditarFacturaFinal = new CN_Acciones();
                            INST_EditarFacturaFinal.MET_EditarFacturaFinal(
                                RdbACredito.Checked == true ? 2 : 1,
                                Convert.ToDouble(TxtITBIS.Text),
                                Convert.ToDouble(TxtSUBTOTAL.Text),
                                Convert.ToDouble(TxtTotal.Text),
                                V_IDFactura);

                            MessageBox.Show("INGRESO FACTURA");
                            MET_MostrarFacturaImpresa();
                        }
                        catch (Exception)
                        {
                            //MessageBox.Show("OCURRIO UN ERROR " + Error);
                            MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        try
                        {
                            CN_Acciones INST_InsertarCuentaPorCobrar = new CN_Acciones();
                            INST_InsertarCuentaPorCobrar.MET_InsertarCuentasProdCobrar(
                                Convert.ToInt32(V_IDFactura), Convert.ToInt32(V_IDCliente),
                                Convert.ToInt32(Program.ID_Empleados), LblFecha.Text,
                                Convert.ToInt32(TxtTotal.Text));

                            MessageBox.Show("INGRESO CUENTA POR COBRAR");
                        }
                        catch (Exception)
                        {
                            //MessageBox.Show("OCURRIO UN ERROR " + Error);
                            MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (RdbAlContado.Checked == true)
                    {
                        try
                        {
                            CN_Acciones INST_EditarFacturaFinal = new CN_Acciones();
                            INST_EditarFacturaFinal.MET_EditarFacturaFinal(
                                RdbAlContado.Checked == true ? 1 : 2,
                                Convert.ToDouble(TxtITBIS.Text),
                                Convert.ToDouble(TxtSUBTOTAL.Text),
                                Convert.ToDouble(TxtTotal.Text),
                                V_IDFactura);

                            MessageBox.Show("INGRESO FACTURA");
                            MET_MostrarFacturaImpresa();
                        }
                        catch (Exception)
                        {
                            //MessageBox.Show("OCURRIO UN ERROR " + Error);
                            MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        try
                        {
                            CN_Acciones INST_EditarCrediro = new CN_Acciones();
                            INST_EditarCrediro.MET_EditarCredito(Convert.ToDouble(TxtSaldo.Text),
                                Convert.ToInt32(V_IDCrediro));

                            MessageBox.Show("SE REDUJO EL CREDITO");
                        }
                        catch (Exception)
                        {
                            //MessageBox.Show("OCURRIO UN ERROR " + Error);
                            MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("NO HAY NINGUN PRODUCTO SELECCIONADO");
                return;
            }
            MET_NuevaFactura();
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void DtvFactura_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DtvFactura.SelectedRows.Count > 0)
            {
                V_PrecioProducto = DtvFactura.CurrentRow.Cells["Precio"].Value.ToString();
                TxtCantidad.Text = DtvFactura.CurrentRow.Cells["Cantidad"].Value.ToString();
                V_IDDetalleVenta = DtvFactura.CurrentRow.Cells["ID_DetalleVenta"].Value.ToString();
                V_CantidadProductoDetalle = DtvFactura.CurrentRow.Cells["Cantidad"].Value.ToString();
                //V_IDProducto = DtvBusqueda.CurrentRow.Cells["ID_Producto"].Value.ToString();
                V_IDProductoDetalle = DtvFactura.CurrentRow.Cells["ID_Producto"].Value.ToString();
                V_IDProducto = DtvFactura.CurrentRow.Cells["ID_Producto"].Value.ToString();
                MET_MostrarStock();
                //TxtCantidad.Text = DtvFactura.CurrentRow.Cells["Cantidad"].Value.ToString();
                TxtCantidad.Clear();
                TxtCantidad.Focus();
                LblErrorCantidad.Text = "INTRODUZCA LA CANTIDAD";
                LblErrorCantidad.Visible = true;
                BtnConfirmarCantidad.Visible = true;
            }
        }

        private void BtnConDinero_Click(object sender, EventArgs e)
        {
            MET_MostrarClientes();
            BtnConDinero.Visible = false;
            BtnConSaldo.Visible = true;
            RdbACredito.Visible = true;
            V_ConSaldo = false;
        }

        private void BtnConSaldo_Click(object sender, EventArgs e)
        {
            MET_MostrarClientesConCredito();
            BtnConDinero.Visible = true;
            BtnConSaldo.Visible = false;
            RdbACredito.Visible = false;
            V_ConSaldo = true;
        }

        private void BtnConfirmarCantidad_Click(object sender, EventArgs e)
        {
            V_CantidadNuevaProducto = TxtCantidad.Text;
            V_IDProducto = DtvFactura.CurrentRow.Cells["ID_Producto"].Value.ToString();
            MET_MostrarStock();
            V_Stock = DtvStock.CurrentRow.Cells["Stock"].Value.ToString();
            double PrecioProducto = Convert.ToDouble(V_PrecioProducto);
            int CantidadProducto = Convert.ToInt32(TxtCantidad.Text);

            V_ITBIS = PrecioProducto * CantidadProducto * 0.18;
            V_SUBTOTAL = PrecioProducto * CantidadProducto;

            if (Convert.ToInt32(V_CantidadNuevaProducto) > Convert.ToInt32(V_CantidadProductoDetalle))
            {
                try
                {
                    CN_Acciones INST_AumentarCantidadProductoVenta = new CN_Acciones();
                    INST_AumentarCantidadProductoVenta.MET_InsertarMayorCantidadProducto(
                        Convert.ToInt32(V_IDProducto), Convert.ToInt32(V_CantidadNuevaProducto),
                        Convert.ToDouble(V_ITBIS), Convert.ToDouble(V_SUBTOTAL),
                        Convert.ToInt32(V_IDDetalleVenta));

                    TxtCantidad.Text = "1";
                    MET_MostrarDetalleVenta();
                    MET_MostrarProductos();
                    BtnConfirmarCantidad.Visible = false;
                    LblErrorCantidad.Visible = false;
                    TotalITBIS = 0;
                    TotalSUBTOTAL = 0;
                    TotalVenta = 0;
                    MET_CalcularITBIS_SUBTOTAL();
                }
                catch (Exception)
                {
                    //MessageBox.Show("OCURRIO UN ERROR " + Error);
                    MessageBox.Show("Hay Un error en los datos introducidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (Convert.ToInt32(V_CantidadNuevaProducto) < Convert.ToInt32(V_CantidadProductoDetalle))
            {
                if (TxtCantidad.Text != "")
                {
                    try
                    {
                        CN_Acciones INST_DisminuirCantidadProductoVenta = new CN_Acciones();
                        INST_DisminuirCantidadProductoVenta.MET_InsertarMenorCantidadProducto(
                            Convert.ToInt32(V_IDProducto), Convert.ToInt32(V_CantidadNuevaProducto),
                            Convert.ToDouble(V_ITBIS), Convert.ToDouble(V_SUBTOTAL),
                            Convert.ToInt32(V_IDDetalleVenta));

                        TxtCantidad.Text = "1";
                        MET_MostrarDetalleVenta();
                        MET_MostrarProductos();
                        //DtvStock.Rows.Clear();
                        BtnConfirmarCantidad.Visible = false;
                        LblErrorCantidad.Visible = false;
                        TotalITBIS = 0;
                        TotalSUBTOTAL = 0;
                        TotalVenta = 0;
                        MET_CalcularITBIS_SUBTOTAL();
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("OCURRIO UN ERROR " + Error);
                        MessageBox.Show("Hay Un error en los datos introducidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}