using CapaDatos;
using CapaNegocio;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_Productos : Form
    {
        private string V_IDProducto = null;
        private bool V_Editar = false;

        public P_Productos()
        {
            InitializeComponent();
        }

        private void P_Productos_Load(object sender, EventArgs e)
        {
            MET_MostrarProductos();
            MET_PrivilegiosUsuario();
            MET_ListarCategorias();
            MET_ListarMarcas();
            MET_ListarProveedores();
        }

        private void MET_MostrarProductos()
        {
            CN_Acciones MostrarTablaDeProductos = new CN_Acciones();
            DtvProductos.DataSource = MostrarTablaDeProductos.MostrarProductos();
        }

        private void MET_PrivilegiosUsuario()
        {
            if (Program.Cargo != 2)
            {
                BtnAgregar.Visible = false;
                BtnBorrar.Visible = false;
                BtnEditarProducto.Visible = false;
                CN_Acciones MostrarTablaDeProductos2 = new CN_Acciones();
                DtvProductos.DataSource = MostrarTablaDeProductos2.MostrarProductosCajero();
            }
        }

        public void MET_ListarCategorias()
        {
            CD_Consultas INST_Lista_Categoria = new CD_Consultas();
            CbbCategoriaProducto.DataSource = INST_Lista_Categoria.MET_ListarCategoria();
            CbbCategoriaProducto.DisplayMember = "Categoria";
            CbbCategoriaProducto.ValueMember = "ID_Categoria";
        }

        public void MET_ListarMarcas()
        {
            CD_Consultas Lista_Marca = new CD_Consultas();
            CbbMarcaProducto.DataSource = Lista_Marca.MET_ListarMarca();
            CbbMarcaProducto.DisplayMember = "Marca";
            CbbMarcaProducto.ValueMember = "ID_Marca";
        }

        public void MET_ListarProveedores()
        {
            CD_Consultas INST_Listar_Proveedor = new CD_Consultas();
            CbbProveedor.DataSource = INST_Listar_Proveedor.MET_MostrarListaProveedores();
            CbbProveedor.DisplayMember = "Proveedor";
            CbbProveedor.ValueMember = "ID_Proveedor";
        }

        public void MET_LimpiarTextBox()
        {
            CbbCategoriaProducto.Text = "";
            CbbMarcaProducto.Text = "";
            TxtModeloProducto.Clear();
            TxtStockProducto.Clear();
            TxtPrecioCompraProducto.Clear();
            TxtPrecioVentaProducto.Clear();
            TxtDescripcionProducto.Clear();
            CbbCategoriaProducto.SelectedIndex = 0;
            CbbMarcaProducto.SelectedIndex = 0;
            CbbProveedor.SelectedIndex = 0;
        }

        public void MET_LblInvisibles()
        {
            LblErrorCategoria.Visible = false;
            LblErrorMarca.Visible = false;
            LblErrorModelo.Visible = false;
            LblErrorStock.Visible = false;
            LblErrorPrecioCompra.Visible = false;
            LblErrorPrecioVenta.Visible = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LblBuscar.Visible = false;
            TxtBuscarProducto.Visible = false;
            LspBuscar.Visible = false;
            DtvProductos.Visible = false;
            BtnGuardar.Visible = true;
            BtnEditarProducto.Visible = false;
            BtnBorrar.Visible = false;
            BtnAgregar.Visible = false;
            BtnCancelarInsertado.Visible = true;
        }

        private void BtnGuardad_Click(object sender, EventArgs e)
        {
            if (V_Editar == false)
            {
                try
                {
                    if (CbbCategoriaProducto.SelectedIndex <= 0)
                    {
                        LblErrorCategoria.Visible = true;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = false;
                        return;
                    }
                    else if (CbbMarcaProducto.SelectedIndex <= 0)
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = true;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = false;
                        return;
                    }
                    else if (TxtModeloProducto.Text == "")
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = true;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = false;
                        TxtModeloProducto.Focus();
                        return;
                    }
                    else if (TxtStockProducto.Text == "")
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = true;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = false;
                        TxtStockProducto.Focus();
                        return;
                    }
                    else if (TxtPrecioCompraProducto.Text == "")
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = true;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = false;
                        TxtPrecioCompraProducto.Focus();
                        return;
                    }
                    else if (TxtPrecioVentaProducto.Text == "")
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = true;
                        LblErrorProveedor.Visible = false;
                        TxtPrecioVentaProducto.Focus();
                        return;
                    }
                    else if (CbbProveedor.SelectedIndex <= 0)
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = true;
                        return;
                    }
                    else
                    {
                        CN_Acciones InsertarProducto = new CN_Acciones();
                        InsertarProducto.InsertarDatosProductos(
                            Convert.ToInt32(CbbCategoriaProducto.SelectedValue),
                            Convert.ToInt32(CbbMarcaProducto.SelectedValue),
                            TxtModeloProducto.Text,
                            TxtDescripcionProducto.Text,
                            TxtStockProducto.Text,
                            Convert.ToDouble(TxtPrecioCompraProducto.Text),
                            Convert.ToDouble(TxtPrecioVentaProducto.Text),
                            Convert.ToInt32(CbbProveedor.SelectedValue));

                        MessageBox.Show("SE INSERTO CORRECTAMENTE");

                        DtvProductos.Visible = true;
                        MET_LimpiarTextBox();
                        MET_LblInvisibles();
                        BtnGuardar.Visible = false;
                        BtnCancelarInsertado.Visible = false;
                        BtnAgregar.Visible = true;
                        BtnEditarProducto.Visible = true;
                        BtnBorrar.Visible = true;
                        LblBuscar.Visible = true;
                        LspBuscar.Visible = true;
                        TxtBuscarProducto.Visible = true;
                        MET_MostrarProductos();
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Hay Un error en los datos introducidos. Revise y vuelva a intentarlo " + Error + "/n LLAME A SOPORTE TECNICO");   
                    MessageBox.Show("Hay Un error en los datos introducidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (V_Editar == true)
            {
                try
                {
                    if (CbbCategoriaProducto.SelectedIndex <= 0)
                    {
                        LblErrorCategoria.Visible = true;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = false;
                        return;
                    }
                    else if (CbbMarcaProducto.SelectedIndex <= 0)
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = true;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = false;
                        return;
                    }
                    else if (TxtModeloProducto.Text == "")
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = true;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = false;
                        TxtModeloProducto.Focus();
                        return;
                    }
                    else if (TxtStockProducto.Text == "")
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = true;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = false;
                        TxtStockProducto.Focus();
                        return;
                    }
                    else if (TxtPrecioCompraProducto.Text == "")
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = true;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = false;
                        TxtPrecioCompraProducto.Focus();
                        return;
                    }
                    else if (TxtPrecioVentaProducto.Text == "")
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = true;
                        LblErrorProveedor.Visible = false;
                        TxtPrecioVentaProducto.Focus();
                        return;
                    }
                    else if (CbbProveedor.SelectedIndex <= 0)
                    {
                        LblErrorCategoria.Visible = false;
                        LblErrorMarca.Visible = false;
                        LblErrorModelo.Visible = false;
                        LblErrorStock.Visible = false;
                        LblErrorPrecioCompra.Visible = false;
                        LblErrorPrecioVenta.Visible = false;
                        LblErrorProveedor.Visible = true;
                        return;
                    }
                    else
                    {
                        CN_Acciones EditarProducto = new CN_Acciones();
                        if (DtvProductos.SelectedRows.Count > 0)
                        {
                            EditarProducto.EditarDatosProducto(Convert.ToInt32(CbbCategoriaProducto.SelectedValue),
                                Convert.ToInt32(CbbMarcaProducto.SelectedValue),
                                TxtModeloProducto.Text,
                                TxtDescripcionProducto.Text,
                                TxtStockProducto.Text,
                                Convert.ToDouble(TxtPrecioCompraProducto.Text),
                                Convert.ToDouble(TxtPrecioVentaProducto.Text),
                                Convert.ToInt32(CbbProveedor.SelectedValue), V_IDProducto);

                            MessageBox.Show("SE EDITO CORRECTAMENTE");

                            DtvProductos.Visible = true;
                            MET_LimpiarTextBox();
                            MET_LblInvisibles();
                            BtnGuardar.Visible = false;
                            BtnCancelarEditado.Visible = false;
                            V_Editar = false;
                            MET_MostrarProductos();
                        }
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Hay Un error en los datos introducidos. Revise y vuelva a intentarlo " + Error + "/n LLAME A SOPORTE TECNICO");   
                    MessageBox.Show("Hay Un error en los datos introducidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void TxtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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

        private void TxtPrecioCompraProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.TxtPrecioCompraProducto.Text.Contains('.'))
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

        private void TxtPrecioVentaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.TxtPrecioVentaProducto.Text.Contains('.'))
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MET_LimpiarTextBox();
            LblBuscar.Visible = true;
            TxtBuscarProducto.Visible = true;
            LspBuscar.Visible = true;
            DtvProductos.Visible = true;
            BtnGuardar.Visible = false;
            BtnCancelarInsertado.Visible = false;
            BtnAgregar.Visible = true;
            BtnEditarProducto.Visible = true;
            BtnBorrar.Visible = true;
        }

        private void BtnEditarProducto_Click(object sender, EventArgs e)
        {
            if (DtvProductos.SelectedRows.Count > 0)
            {
                V_Editar = true;
                LblBuscar.Visible = false;
                TxtBuscarProducto.Visible = false;
                LspBuscar.Visible = false;
                DtvProductos.Visible = false;
                BtnEditarProducto.Visible = false;
                BtnBorrar.Visible = false;
                BtnAgregar.Visible = false;
                BtnGuardar.Visible = true;
                BtnCancelarEditado.Visible = true;
                Convert.ToInt32(CbbCategoriaProducto.SelectedValue);
                Convert.ToInt32(CbbMarcaProducto.SelectedValue);
                TxtModeloProducto.Text = DtvProductos.CurrentRow.Cells["Modelo"].Value.ToString();
                TxtDescripcionProducto.Text = DtvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                TxtStockProducto.Text = DtvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                TxtPrecioCompraProducto.Text = DtvProductos.CurrentRow.Cells["PrecioCompra"].Value.ToString();
                TxtPrecioVentaProducto.Text = DtvProductos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                V_IDProducto = DtvProductos.CurrentRow.Cells["ID_Producto"].Value.ToString();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONE EL PRODUCTO QUE DESEA EDITAR");
            }
        }

        private void BtnCancelarEditado_Click(object sender, EventArgs e)
        {
            MET_LimpiarTextBox();
            LblBuscar.Visible = true;
            TxtBuscarProducto.Visible = true;
            LspBuscar.Visible = true;
            BtnEditarProducto.Visible = true;
            BtnBorrar.Visible = true;
            DtvProductos.Visible = true;
            BtnGuardar.Visible = false;
            BtnCancelarEditado.Visible = false;
            BtnAgregar.Visible = true;
        }

        CN_Acciones INST_EliminarProducto = new CN_Acciones();
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DtvProductos.SelectedRows.Count > 0)
                {
                    V_IDProducto = DtvProductos.CurrentRow.Cells["ID_Producto"].Value.ToString();
                    INST_EliminarProducto.MET_EliminarProductos(V_IDProducto);
                    MessageBox.Show("SE ELIMINO CORECTAMENTE");
                    MET_MostrarProductos();
                }
                else
                {
                    MessageBox.Show("SELECCIONE EL PRODUCTO QUE DESEA ELIMINAR");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Este producto no se puede eliminar porque ha se han realizado movimientos con sus datos. La accion fue bloqueada para mantener la integridad de los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DtvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DtvProductos.Columns[e.ColumnIndex].Name == "Stock")
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

        private void TxtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarProducto.Text != "")
            {
                DtvProductos.CurrentCell = null;
                foreach (DataGridViewRow Filas in DtvProductos.Rows)
                {
                    Filas.Visible = false;
                }
                foreach (DataGridViewRow Filas in DtvProductos.Rows)
                {
                    foreach (DataGridViewCell Celdas in Filas.Cells)
                    {
                        if ((Celdas.Value.ToString().ToUpper()).IndexOf(TxtBuscarProducto.Text.ToUpper()) == 0)
                        {
                            Filas.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                MET_MostrarProductos();
            }
        }

        private void DtvProductos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DtvProductos.Columns[e.ColumnIndex].Name == "Stock")
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
    }
}