using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_Devoluciones : Form
    {
        private string V_IDCliente = null;
        private string V_IDEmpleado = null;
        private string V_PrecioProducto = null;
        private string V_IDProducto = null;
        private string V_IDDetalleVenta = null;
        private string V_ID_Devolucion = null;
        private string V_CantidadProductoDetalle = null;
        private double TotalVenta = 0, TotalITBIS = 0, TotalSUBTOTAL = 0, TotalCredito = 0;

        public P_Devoluciones()
        {
            InitializeComponent();
        }

        private void P_Devoluciones_Load(object sender, EventArgs e)
        {

        }

        public void MET_MostrarDevolucionImpresa()
        {
            P_ReportesNotaCredito PRDNC = new P_ReportesNotaCredito();
            PRDNC.ID_Devolucion = Convert.ToInt32(V_ID_Devolucion);
            PRDNC.ShowDialog();
        }

        public void MET_MostrarInformacionVenta()
        {
            CN_Acciones INST_MostrarTablaInformacionVenta = new CN_Acciones();
            DtvDatosFactura.DataSource = INST_MostrarTablaInformacionVenta.MET_MostrarInformacionDeLaVenta(TxtIDFactura.Text);
        }

        public void Limpiar()
        {
            BtnDevolver.Visible = false;
            BtnBuscar.Visible = true;
            BtnListo.Visible = false;
            TotalCredito = 0;
            TotalVenta = 0;
            TotalITBIS = 0;
            TotalSUBTOTAL = 0;
            TxtITBIS.Text = "0";
            TxtSUBTOTAL.Text = "0";
            TxtTotal.Text = "0";
            TxtCliente.Clear();
            TxtCredito.Text = "0";
            TxtFechaVenta.Clear();
            TxtIDFactura.Clear();
            TxtTipoVenta.Clear();
            TxtEmpleado.Clear();
            DtvDatosFactura.DataSource = "";
            DtvDatosFactura.Columns.Clear();
            DtvDetallesVenta.DataSource = "";
            DtvDetallesVenta.Columns.Clear();
            DtvIDDevolucion.DataSource = "";
            DtvIDDevolucion.Columns.Clear();
            TxtIDFactura.ReadOnly = false;

        }
        public void MET_MostrarDetalleVenta()
        {
            CN_Acciones INST_MostrarTablaDetalleVenta = new CN_Acciones();
            DtvDetallesVenta.DataSource = INST_MostrarTablaDetalleVenta.MET_MostrarDetallesVentas(TxtIDFactura.Text);
        }

        public void MET_SacarIDDeolucion()
        {
            CN_Acciones INST_SacarIDDevolucion = new CN_Acciones();
            DtvIDDevolucion.DataSource = INST_SacarIDDevolucion.MET_Mostrar_IDDevolucion();
        }

        public void MET_CalcularITBIS_SUBTOTAL()
        {
            foreach (DataGridViewRow Fila in DtvDetallesVenta.Rows)
            {
                TotalITBIS += Convert.ToDouble(Fila.Cells["ITBIS"].Value);
                TotalSUBTOTAL += Convert.ToDouble(Fila.Cells["SUBTOTAL"].Value);
                TotalVenta += TotalITBIS + TotalSUBTOTAL;
            }
            TxtITBIS.Text = Convert.ToString(TotalITBIS);
            TxtSUBTOTAL.Text = Convert.ToString(TotalSUBTOTAL);
            TxtTotal.Text = Convert.ToString(TotalVenta);
        }

        private void BtnDevolver_Click(object sender, EventArgs e)
        {
            BtnBuscar.Visible = false;
            BtnListo.Visible = true;
            TxtIDFactura.ReadOnly = true;

            if (DtvDetallesVenta.SelectedRows.Count > 0)
            {
                V_IDDetalleVenta = DtvDetallesVenta.CurrentRow.Cells["ID_DetalleVenta"].Value.ToString();
                V_IDProducto = DtvDetallesVenta.CurrentRow.Cells["ID_Producto"].Value.ToString();
                V_CantidadProductoDetalle = DtvDetallesVenta.CurrentRow.Cells["Cantidad"].Value.ToString();
                V_PrecioProducto = DtvDetallesVenta.CurrentRow.Cells["Precio"].Value.ToString();

                if (Convert.ToInt32(TxtCantidadADevolver.Text) == Convert.ToInt32(V_CantidadProductoDetalle))
                {
                    //ELIMINA EL PRODUCTO DE LOS DETALLES DE VENTA SI SE DEVUELVE TODO
                    CN_Acciones INST_DevolverTodoProductoDetalleVenta = new CN_Acciones();
                    INST_DevolverTodoProductoDetalleVenta.MET_EliminarProductoDetalleVenta(V_IDDetalleVenta,
                        V_IDProducto, V_CantidadProductoDetalle);

                    try
                    {
                        CN_Acciones INST_Insertar_Detalle_Devolucion = new CN_Acciones();
                        INST_Insertar_Detalle_Devolucion.MET_InsertarDetalleDevolucion(Convert.ToInt32(V_ID_Devolucion),
                            Convert.ToInt32(TxtIDFactura.Text), Convert.ToInt32(V_IDDetalleVenta),
                            Convert.ToInt32(V_IDProducto), Convert.ToDouble(V_PrecioProducto),
                            Convert.ToInt32(TxtCantidadADevolver.Text));

                        MET_MostrarDetalleVenta();
                        MET_CalcularITBIS_SUBTOTAL();
                    }
                    catch (Exception Error)
                    {
                        MessageBox.Show("OCURRIO UN ERROR " + Error);
                    }
                    try
                    {
                        //EDITA LA FACTURA SI SE ELIMINA SI SE DEVUELDE UN EL PRODUCTO
                        CN_Acciones INST_EditarFacturaDevolucion = new CN_Acciones();
                        INST_EditarFacturaDevolucion.MET_EditarFacturaDevolucion(
                            Convert.ToDouble(TxtITBIS.Text),
                            Convert.ToDouble(TxtSUBTOTAL.Text),
                            Convert.ToDouble(TxtTotal.Text),
                            TxtIDFactura.Text);

                        MessageBox.Show("SE EDITO LA FACTURA");
                    }
                    catch (Exception Error)
                    {
                        MessageBox.Show("OCURRIO UN ERROR " + Error);
                    }

                    TotalCredito += (Convert.ToDouble(V_PrecioProducto) * Convert.ToInt32(TxtCantidadADevolver.Text));
                    TxtCredito.Text = Convert.ToString(TotalCredito);

                    try
                    {
                        CN_Acciones INST_EditarDevolucionAgregarCredito = new CN_Acciones();
                        INST_EditarDevolucionAgregarCredito.MET_EditarDevolucionAgregarCredito(
                            Convert.ToDouble(TxtCredito.Text), Convert.ToInt32(V_ID_Devolucion));
                    }
                    catch (Exception Error)
                    {
                        MessageBox.Show("OCURRIO UN ERROR " + Error);
                    }
                }
                else if (Convert.ToInt32(TxtCantidadADevolver.Text) > Convert.ToInt32(V_CantidadProductoDetalle))
                {
                    MessageBox.Show("LA ANTIDAD A DEVOLVER NO PUEDE SER MAYOR QUE LA CANTIDAD DE PRODUCTO VENDIDA");
                    return;
                }
                else if (Convert.ToInt32(TxtCantidadADevolver.Text) < Convert.ToInt32(V_CantidadProductoDetalle))
                {
                    try
                    {
                        CN_Acciones INST_DevolverMenosProductoDetalleVenta = new CN_Acciones();
                        INST_DevolverMenosProductoDetalleVenta.MET_InsertarDetalleDevolucionCuandoNoSeDevuelveTodo(
                            Convert.ToInt32(V_ID_Devolucion), Convert.ToInt32(TxtIDFactura.Text),
                            Convert.ToInt32(V_IDDetalleVenta), Convert.ToInt32(V_IDProducto),
                            Convert.ToDouble(V_PrecioProducto), Convert.ToInt32(TxtCantidadADevolver.Text));

                        MET_MostrarDetalleVenta();
                        MET_CalcularITBIS_SUBTOTAL();
                    }
                    catch (Exception Error)
                    {
                        MessageBox.Show("OCURRIO UN ERROR " + Error);
                    }
                    try
                    {
                        //EDITA LA FACTURA SI SE ELIMINA SI SE DEVUELDE UN EL PRODUCTO
                        CN_Acciones INST_EditarFacturaDevolucion = new CN_Acciones();
                        INST_EditarFacturaDevolucion.MET_EditarFacturaDevolucion(
                            Convert.ToDouble(TxtITBIS.Text),
                            Convert.ToDouble(TxtSUBTOTAL.Text),
                            Convert.ToDouble(TxtTotal.Text),
                            TxtIDFactura.Text);

                        MessageBox.Show("SE EDITO LA FACTURA");
                    }
                    catch (Exception Error)
                    {
                        MessageBox.Show("OCURRIO UN ERROR " + Error);
                    }
                }

                TotalCredito += (Convert.ToDouble(V_PrecioProducto) * Convert.ToInt32(TxtCantidadADevolver.Text));
                TxtCredito.Text = Convert.ToString(TotalCredito);

                try
                {
                    CN_Acciones INST_EditarDevolucionAgregarCredito = new CN_Acciones();
                    INST_EditarDevolucionAgregarCredito.MET_EditarDevolucionAgregarCredito(
                        Convert.ToDouble(TxtCredito.Text), Convert.ToInt32(V_ID_Devolucion));
                }
                catch (Exception Error)
                {
                    MessageBox.Show("OCURRIO UN ERROR " + Error);
                }

                MessageBox.Show("SE DEVOLVIO EL PRODUCTO");
                //MET_MostrarDetalleVenta();
                //MET_CalcularITBIS_SUBTOTAL();
            }
            else
            {
                MessageBox.Show("SELECCIONE EL PRODUCTO QUE DESEA ELIMINAR DE LA FACTURA");
            }
            MET_MostrarDevolucionImpresa();
        }

        private void TxtCantidadADevolver_Enter(object sender, EventArgs e)
        {
            TxtCantidadADevolver.Clear();
        }

        private void TxtIDFactura_KeyPress(object sender, KeyPressEventArgs e)
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
            if (TxtIDFactura.Text == "")
            {
                MessageBox.Show("INTRODUZCA EL ID DE LA VENTA");
                return;
            }
            else
            {
                MET_MostrarInformacionVenta();
                MET_MostrarDetalleVenta();

                if (DtvDatosFactura.Rows.Count > 0)
                {
                    TxtCliente.Text = DtvDatosFactura.CurrentRow.Cells["NombreCliente"].Value.ToString();
                    TxtEmpleado.Text = DtvDatosFactura.CurrentRow.Cells["NombreEmpleado"].Value.ToString();
                    TxtTipoVenta.Text = DtvDatosFactura.CurrentRow.Cells["TipoVenta"].Value.ToString();
                    TxtFechaVenta.Text = DtvDatosFactura.CurrentRow.Cells["FechaVenta"].Value.ToString();
                    V_IDCliente = DtvDatosFactura.CurrentRow.Cells["ID_Cliente"].Value.ToString();
                    V_IDEmpleado = DtvDatosFactura.CurrentRow.Cells["ID_Empleado"].Value.ToString();
                    BtnDevolver.Visible = true;
                    MET_CalcularITBIS_SUBTOTAL();
                }
            }
            if (DtvDatosFactura.Rows.Count != 0)
            {
                try
                {
                    CN_Acciones INST_InsertarDevolucion = new CN_Acciones();
                    INST_InsertarDevolucion.MET_InsertarDevolucion(Convert.ToInt32(TxtIDFactura.Text),
                    Convert.ToInt32(V_IDCliente), Convert.ToInt32(V_IDEmpleado), LblFecha.Text,
                    Convert.ToDouble(TxtCredito.Text));

                    MET_SacarIDDeolucion();
                    V_ID_Devolucion = DtvIDDevolucion.CurrentRow.Cells["ID"].Value.ToString();
                }
                catch (Exception)
                {
                    //MessageBox.Show("OCURRIO UN ERROR " + Error);
                    MessageBox.Show("Hay Un error en los datos introducidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void BtnListo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtIDFactura.Text == "")
            {
                MessageBox.Show("INTRODUZCA EL ID DE LA VENTA");
                return;
            }
            else
            {
                MET_MostrarInformacionVenta();
                MET_MostrarDetalleVenta();

                if (DtvDatosFactura.Rows.Count > 0)
                {
                    TxtCliente.Text = DtvDatosFactura.CurrentRow.Cells["NombreCliente"].Value.ToString();
                    TxtEmpleado.Text = DtvDatosFactura.CurrentRow.Cells["NombreEmpleado"].Value.ToString();
                    TxtTipoVenta.Text = DtvDatosFactura.CurrentRow.Cells["TipoVenta"].Value.ToString();
                    TxtFechaVenta.Text = DtvDatosFactura.CurrentRow.Cells["FechaVenta"].Value.ToString();
                    V_IDCliente = DtvDatosFactura.CurrentRow.Cells["ID_Cliente"].Value.ToString();
                    V_IDEmpleado = DtvDatosFactura.CurrentRow.Cells["ID_Empleado"].Value.ToString();
                    BtnDevolver.Visible = true;
                    MET_CalcularITBIS_SUBTOTAL();
                }
            }
            if (DtvDatosFactura.Rows.Count != 0)
            {
                try
                {
                    CN_Acciones INST_InsertarDevolucion = new CN_Acciones();
                    INST_InsertarDevolucion.MET_InsertarDevolucion(Convert.ToInt32(TxtIDFactura.Text),
                    Convert.ToInt32(V_IDCliente), Convert.ToInt32(V_IDEmpleado), LblFecha.Text,
                    Convert.ToDouble(TxtCredito.Text));

                    MET_SacarIDDeolucion();
                    V_ID_Devolucion = DtvIDDevolucion.CurrentRow.Cells["ID"].Value.ToString();
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