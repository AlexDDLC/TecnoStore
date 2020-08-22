using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Acciones
    {
        //CONSULTA EN LA BASE DE DATOS DE USUARIO
        #region
        private CD_Consultas LoguearUsuario = new CD_Consultas();
        private String _Usuario;
        private String _Contrasena;

        public String Usuario
        {
            set
            {
                if(value == "USUARIO")
                {
                    _Usuario = null;
                }
                else
                {
                    _Usuario = value;
                }
            }
            get { return _Usuario; }
        }
        public String Contrasena
        {
            set
            {
                if(value == "CONTRASEÑA")
                {
                    _Contrasena = null;
                }
                else
                {
                    _Contrasena = value;
                }
            }

            get { return _Contrasena; }
        }
        //public CN_Acciones() { }
        #endregion

        //LOGUEA A UN USUARIO
        #region
        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = LoguearUsuario.IniciarSesion(Usuario, Contrasena);
            return Loguear;
        }
        #endregion

        //MUESTRA EL MENU DE LOS PRODUCTOS PARA EL USUARIO ADMINISTRADOR
        #region
        private CD_Consultas Mostrar_Productos = new CD_Consultas();
        public DataTable MostrarProductos()
        {
            DataTable TablaProductos = new DataTable();
            TablaProductos = Mostrar_Productos.MostrarTablaProductosAdministrador();
            return TablaProductos;
        }
        #endregion

        //MUESTRA EL MENU LOS PRODUCTOS PARA EL USUARIO CAJERO
        #region
        private CD_Consultas INST_Mostrar_ProductosCajero = new CD_Consultas();
        public DataTable MostrarProductosCajero()
        {
            DataTable TablaProductosCajero = new DataTable();
            TablaProductosCajero = INST_Mostrar_ProductosCajero.MostrarTablaProductosCajero();
            return TablaProductosCajero;
        }
        #endregion

        //MUESTRA LOS CLIENTES DESDE LA BASE DE DATOS
        #region
        private CD_Consultas Mostrar_Cliente = new CD_Consultas();
        public DataTable MostrarCliente()
        {
            DataTable TablaCliente = new DataTable();
            TablaCliente = Mostrar_Cliente.MostrarTablaCliente();
            return TablaCliente;
        }
        #endregion

        //MOSTRAR CLIENTES CON CREDITO
        private CD_Consultas INST_MostrarClientesConCredito = new CD_Consultas();
        public DataTable MET_MostrarClientesConCredito()
        {
            DataTable TablaClientesConCredito = new DataTable();
            TablaClientesConCredito = INST_MostrarClientesConCredito.MET_MostrarClientesConCredito();
            return TablaClientesConCredito;
        }

        //MUESTRA LOS CLIENTES DEUDORES DESDE LA BASE DE DATOS

        private CD_Consultas Mostrar_ClientesDeudores = new CD_Consultas();
        public DataTable MostrarClientesDeudores()
        {
            DataTable TablaClientesDeudores = new DataTable();
            TablaClientesDeudores = Mostrar_ClientesDeudores.MostrarTablaClientesDeudores();
            return TablaClientesDeudores;
        }

        //MOSTRAR CLIENTES COBRO
        private CD_Consultas Mostrar_ClientesCobro = new CD_Consultas();
        public DataTable MostrarClientesCobro(string ID_Cuenta)
        {
            DataTable TablaClientesCobro = new DataTable();
            TablaClientesCobro = Mostrar_ClientesCobro.MostrarTablaClientesCobro(Convert.ToInt32(ID_Cuenta));
            return TablaClientesCobro;
        }

        //MOSTRAR DEUDA CLIENTES
        private CD_Consultas Mostrar_DeudaCliente = new CD_Consultas();
        public DataTable MostrarDeudaCliente(string ID_Cuenta)
        {
            DataTable TablaDeudaCliente = new DataTable();
            TablaDeudaCliente = Mostrar_DeudaCliente.MostrarTablaDeudaCliente(Convert.ToInt32(ID_Cuenta));
            return TablaDeudaCliente;
        }

        //MOSTRAR EMPLEADOS
        #region
        private CD_Consultas INST_MostrarEmpleados = new CD_Consultas();
        public DataTable MET_MostrarTablaEmpleados()
        {
            DataTable TablaEmpleados = new DataTable();
            TablaEmpleados = INST_MostrarEmpleados.MET_MostrarEmpleados();
            return TablaEmpleados;
        }
        #endregion

        //MOSTRAR EMPLEADOS DESPEDIDOS
        #region
        private CD_Consultas INST_MostrarEmpleadosDespedidos = new CD_Consultas();
        public DataTable MET_MostrarTablaEmpleadosDespedidos()
        {
            DataTable TablaEmpleadosDespedidos = new DataTable();
            TablaEmpleadosDespedidos = INST_MostrarEmpleadosDespedidos.MET_MostrarEmpleadosDespedidos();
            return TablaEmpleadosDespedidos;
        }
        #endregion

        //MOSTRAR PROVEEDORES
        #region
        private CD_Consultas INST_MostrarProveedor = new CD_Consultas();
        public DataTable MET_MostrarTablaProveedor()
        {
            DataTable TablaProveedor = new DataTable();
            TablaProveedor = INST_MostrarProveedor.MET_MostrarProveedores();
            return TablaProveedor;
        }
        #endregion

        //MOSTRAR MARCAS
        private CD_Consultas INST_MostrarMarcas = new CD_Consultas();
        public DataTable MET_MostrarMarcas()
        {
            DataTable TablaDeMarcas = new DataTable();
            TablaDeMarcas = INST_MostrarMarcas.MET_MostrarMarcas();
            return TablaDeMarcas;
        }

        //MOSTRAR LAS CATEGORIAS
        private CD_Consultas INST_MostrarCategoria = new CD_Consultas();
        public DataTable MET_MostrarCategoria()
        {
            DataTable TablaDeCategorias = new DataTable();
            TablaDeCategorias = INST_MostrarCategoria.MET_MostrarCategorias();
            return TablaDeCategorias;
        }

        //MOSTRAR LOS CARGOS DE LOS EMPLEADOS
        private CD_Consultas INST_MostrarCargos = new CD_Consultas();
        public DataTable MET_MostrarCargos()
        {
            DataTable TablaDeCargos = new DataTable();
            TablaDeCargos = INST_MostrarCargos.MET_MostrarCargos();
            return TablaDeCargos;
        }

        //MOSTRAR DETALLES DE LA VENTA
        #region
        private CD_Consultas INST_Mostrar_DetalleVenta = new CD_Consultas();
        public DataTable MET_MostrarDetallesVentas(string ID_Venta)
        {
            DataTable TablaDetalleVenta = new DataTable();
            TablaDetalleVenta = INST_Mostrar_DetalleVenta.MET_MostrarTablaDetalleVenta(Convert.ToInt32(ID_Venta));
            return TablaDetalleVenta;
        }
        #endregion

        //MOSTRAR EL STOCK DEL PRODUCTO
        private CD_Consultas INST_Mostrar_Stock = new CD_Consultas();
        public DataTable MET_MostrarStock(string ID_Producto)
        {
            DataTable TablaStock = new DataTable();
            TablaStock = INST_Mostrar_Stock.MET_MostrarStock(Convert.ToInt32(ID_Producto));
            return TablaStock;
        }

        //MOSTRAR INFORMACION DE LA VENTA
        private CD_Consultas INST_MostrarInformacionVenta = new CD_Consultas();
        public DataTable MET_MostrarInformacionDeLaVenta(string ID_Venta)
        {
            DataTable TablaInformacionVenta = new DataTable();
            TablaInformacionVenta = INST_MostrarInformacionVenta.MET_MostrarInformacionVenta(Convert.ToInt32(ID_Venta));
            return TablaInformacionVenta;
        }

        //MOSTRAR LOS DATOS EN LA FACTURA IMPRESA
        private CD_Consultas INST_MostrarInformacionFactiraImpresa = new CD_Consultas();
        public DataTable MET_MostrarInformacionFacturaImpresa(string ID_Venta)
        {
            DataTable TablaInformacionImpresaFactura = new DataTable();
            TablaInformacionImpresaFactura = INST_MostrarInformacionFactiraImpresa.MET_MostrarInformacionFacturaImpresa(Convert.ToInt32(ID_Venta));
            return TablaInformacionImpresaFactura;
        }

        //MOSTRAR DATOS DE LA DEVOLUCION IMPRESA
        private CD_Consultas INST_MostrarInformacionDevolucionImpresa = new CD_Consultas();
        public DataTable MET_MostrarInformacionDevolucionImpresa(string ID_Devolucion)
        {
            DataTable TablaInformacionImpresaDecolucion = new DataTable();
            TablaInformacionImpresaDecolucion = INST_MostrarInformacionDevolucionImpresa.MET_MostrarInformacioDevolucionImpresa(Convert.ToInt32(ID_Devolucion));
            return TablaInformacionImpresaDecolucion;
        }

        //MOSTRAR EL ULTIMO ID DE FACTURA CREADA
        #region
        private CD_Consultas INST_Mostrar_IDFactura = new CD_Consultas();
        public DataTable MET_Mostrar_IDFactura()
        {
            DataTable TablaIDVenta = new DataTable();
            TablaIDVenta = INST_Mostrar_IDFactura.MET_MostrarIDFactura();
            return TablaIDVenta;
        }
        #endregion

        //MOSTRAR EL ULTIMO ID DE DEVOLUCION CREADO
        private CD_Consultas INST_Mostrar_IDDevolucion = new CD_Consultas();
        public DataTable MET_Mostrar_IDDevolucion()
        {
            DataTable TablaIDDevolucion = new DataTable();
            TablaIDDevolucion = INST_Mostrar_IDDevolucion.MET_MostrarIDDevolucion();
            return TablaIDDevolucion;
        }

        //INSERTAR DATOS DE LOS PRODUCTOS
        #region
        private CD_Consultas InsertarProductos = new CD_Consultas();
        public void InsertarDatosProductos(int Categoria, int Marca, string Modelo, 
            string Descripcion, string Stock, double PrecioCompra, double PrecioVenta,
            int Proveedor)
        {
            InsertarProductos.InsertarDatosProducto(Convert.ToInt32(Categoria),
                Convert.ToInt32(Marca), Modelo, Descripcion, Convert.ToInt32(Stock), 
                Convert.ToDouble(PrecioCompra), Convert.ToDouble(PrecioVenta),
                Convert.ToInt32(Proveedor));
        }
        #endregion

        //INSERTAR DATOS DEL CLIENTE
        #region
        private CD_Consultas InsertarCliente = new CD_Consultas();
        public void InsertarDatosCliente(string Cedula, string Nombre, string Apellido, 
             string Direccion, string Telefono, string FechaNacimiento)
        {
            InsertarCliente.InsertarDatosCliente(Cedula, Nombre, Apellido, 
                Direccion, Telefono, FechaNacimiento);
        }
        #endregion

        //INSERTAR DEVOLUCION
        private CD_Consultas INST_InsertarDevolucion = new CD_Consultas();
        public void MET_InsertarDevolucion(int Factura, int Cliente,
            int Empleado, string FechaDevolucion, double Credito)
        {
            INST_InsertarDevolucion.MET_InsertarDevolucion(Convert.ToInt32(Factura),
                Convert.ToInt32(Cliente), Convert.ToInt32(Empleado), FechaDevolucion,
                Convert.ToDouble(Credito));
        }

        //INSERTAR PAGO DE CUENTA
        private CD_Consultas INST_InsertarPagoDeCuenta = new CD_Consultas();
        public void MET_InsertarPagoDeCuenta(int ID_Cuenta, double Pago)
        {
            INST_InsertarPagoDeCuenta.MET_InsertarPagoDeCuenta(Convert.ToInt32(ID_Cuenta),
                Convert.ToDouble(Pago));
        }

        //INSERTAR MACA DE PRODUCTOS
        private CD_Consultas INST_InsertarMarca = new CD_Consultas();
        public void MET_InsertarMarca(string Marca)
        {
            INST_InsertarMarca.MET_InsertarMarca(Marca);
        }

        //INSERTAR CATEGORIA DE PRODUCTOS
        private CD_Consultas INST_InsertarCategoria = new CD_Consultas();
        public void MET_InsertarCategoria(string Categoria)
        {
            INST_InsertarCategoria.MET_InsertarCategoria(Categoria);
        }

        //INSERTAR MACA DE PRODUCTOS
        private CD_Consultas INST_InsertarCargo = new CD_Consultas();
        public void MET_InsertarCargo(string Cargo)
        {
            INST_InsertarCargo.MET_InsertarCargo(Cargo);
        }

        //INSERTAR EMPLEADOS
        #region
        private CD_Consultas INST_InsertarEmpleado = new CD_Consultas();
        public void MET_InsertarDatosEmpleado(string Cedula, string Nombre, string Apellido, string Sexo,
            string Telefono, string Direccion, string FechaNacimiento, int Cargo, string FechaEntrada,
            string NombreUsuario, string Contrasena, string FechaSalida, int Status, string Sueldo)
        {
            INST_InsertarEmpleado.MET_InsertarEmpleado(Cedula, Nombre, Apellido, Sexo,
                Telefono, Direccion, FechaNacimiento, Convert.ToInt32(Cargo), FechaEntrada,
                NombreUsuario, Contrasena, FechaSalida, Convert.ToInt32(Status), Convert.ToInt32(Sueldo));
        }
        #endregion

        //INSERTAR PROVEEDOR
        #region
        private CD_Consultas INST_InsertarProveedor = new CD_Consultas();
        public void MET_InsertarDatosProveedor(string Nombre, string NombreContacto,
            string Telefono, string DireccionWeb)
        {
            INST_InsertarProveedor.MET_InsertarProveedor(Nombre, NombreContacto, Telefono, DireccionWeb);
        }
        #endregion

        //INSERTAR DETALLES DE VENTA
        #region
        private CD_Consultas INST_InsertarDetalleVenta = new CD_Consultas();
        public void MET_InsertarDetallesVenta(int IDVenta, int IDProducto, string Cantidad, 
            double ITBIS, double SUBTOTAL)
        {
            INST_InsertarDetalleVenta.MET_InsertarDetalleVenta(Convert.ToInt32(IDVenta), 
                Convert.ToInt32(IDProducto), Convert.ToInt32(Cantidad),
                Convert.ToDouble(ITBIS), Convert.ToDouble(SUBTOTAL));
        }
        #endregion

        //INSERTAR CANTIDAD MAYOR PRODUCTO FACTURA
        private CD_Consultas INST_InsertarMayorCantidadProducto = new CD_Consultas();
        public void MET_InsertarMayorCantidadProducto(int ID_Producto, int CantidadNueva,
            double ITBIS, double SUBTOTAL, int ID_Detalle)
        {
            INST_InsertarMayorCantidadProducto.MET_InsertarCantidadMayorProducto(Convert.ToInt32(ID_Producto),
                Convert.ToInt32(CantidadNueva), Convert.ToDouble(ITBIS),Convert.ToDouble(SUBTOTAL),Convert.ToInt32(ID_Detalle));
        }

        //INSERTAR CANTIDAD MENOR PRODUCTO FACTURA
        private CD_Consultas INST_InsertarMenorCantidadProducto = new CD_Consultas();
        public void MET_InsertarMenorCantidadProducto(int ID_Producto, int CantidadNueva,
            double ITBIS, double SUBTOTAL, int ID_Detalle)
        {
            INST_InsertarMenorCantidadProducto.MET_InsertarCantidadMenorProducto(Convert.ToInt32(ID_Producto),
                Convert.ToInt32(CantidadNueva), Convert.ToDouble(ITBIS), Convert.ToDouble(SUBTOTAL), Convert.ToInt32(ID_Detalle));
        }

        //INSERTAR DETALLES DE LA DEVOLUCION
        private CD_Consultas INST_InsertarDetalleDevoluion = new CD_Consultas();
        public void MET_InsertarDetalleDevolucion(int ID_Devolucion,int Venta, int Detalle, int Producto,
            double Precio, int Cantidad)
        {
            INST_InsertarDetalleDevoluion.MET_InsertarDetalleDevolucion(Convert.ToInt32(ID_Devolucion),
                Convert.ToInt32(Venta), Convert.ToInt32(Detalle), Convert.ToInt32(Producto), 
                Convert.ToDouble(Precio), Convert.ToInt32(Cantidad));
        }

        //INSERTAR DETALLE DEVOLUCION CUANDO NO SE DEVUELVE TODO
        private CD_Consultas INST_InsertarDetalleDevolucionCuandoNoSeDevuelveTodo = new CD_Consultas();
        public void MET_InsertarDetalleDevolucionCuandoNoSeDevuelveTodo(int ID_Devolucion, int Venta, int Detalle,
            int Producto, double Precio, int Cantidad)
        {
            INST_InsertarDetalleDevolucionCuandoNoSeDevuelveTodo.MET_INST_InsertarDetalleDevolucionCuandoNoSeDevuelveTodo(
                Convert.ToInt32(ID_Devolucion),Convert.ToInt32(Venta),
                Convert.ToInt32(Detalle),Convert.ToInt32(Producto), Convert.ToDouble(Precio),
                Convert.ToInt32(Cantidad));
        }

        //INSERTAR CUENTAS POR COBRAR
        #region
        private CD_Consultas INST_InsertarCuentasPorCobrar = new CD_Consultas();
        public void MET_InsertarCuentasProdCobrar(int ID_Venta, int Cliente, int Empleado,
            string Fecha, double Deuda)
        {
            INST_InsertarCuentasPorCobrar.MET_InsertarCuentaPorCobrar(
                Convert.ToInt32(ID_Venta), Convert.ToInt32(Cliente), Convert.ToInt32(Empleado),
                Fecha, Convert.ToDouble(Deuda));
        }
        #endregion

        //INSERTAR DATOS DE FACTURA
        #region
        private CD_Consultas INST_InsertarVenta = new CD_Consultas();
        public void MET_InsertarVenta(int Empleado, int Cliente,
            int TipoVenta, string FechaVenta, double ITBIS, double SUBTOTAL, 
            double TOTAL)
        {
            INST_InsertarVenta.MET_InsertarVenta(Convert.ToInt32(Empleado),
                Convert.ToInt32(Cliente), Convert.ToInt32(TipoVenta),FechaVenta,
                Convert.ToDouble(ITBIS), Convert.ToDouble(SUBTOTAL), 
                Convert.ToDouble(TOTAL));
        }
        #endregion

        //EDITAR DATOS DE LOS PRODUCTOS
        #region
        private CD_Consultas EditarDatosProductos = new CD_Consultas();
        public void EditarDatosProducto(int Categoria, int Marca, string Modelo, 
            string Descripcion, string Stock, double PrecioCompra, 
            double PrecioVenta, int Proveedor, string ID_Producto)
        {
            InsertarProductos.EditarDatosProducto(Convert.ToInt32(Categoria), 
                Convert.ToInt32(Marca), Modelo, Descripcion, Convert.ToInt32(Stock), 
                Convert.ToDouble(PrecioCompra), Convert.ToDouble(PrecioVenta), 
                Convert.ToInt32(Proveedor),Convert.ToInt32(ID_Producto));
        }
        #endregion

        //EDITAR DATOS DE LOS CLIENTES
        #region
        private CD_Consultas EditarDatosCliente = new CD_Consultas();
        public void EditarDatosClientes(string Cedula, string Nombre, string Apellido, 
            string Direccion, string Telefono, string FechaNacimiento, string ID_Cliente)
        {
            EditarDatosCliente.EditarDatosCliente(Cedula, Nombre, Apellido, Direccion, 
                Telefono, FechaNacimiento, Convert.ToInt32(ID_Cliente));
        }
        #endregion

        //EDITAR DATOS FACTURA FINAL
        #region
        private CD_Consultas INST_EditarFacturaFinal = new CD_Consultas();
        public void MET_EditarFacturaFinal(int TipoVenta, double ITBIS, 
            double SUBTOTAL, double Total, string ID_Venta)
        {
            INST_EditarFacturaFinal.MET_EditarFacturaFinal(Convert.ToInt32(TipoVenta),
                Convert.ToDouble(ITBIS), Convert.ToDouble(SUBTOTAL), Convert.ToDouble(Total),
                Convert.ToInt32(ID_Venta));
        }
        #endregion

        //EDITAR FACTURA DEVOLUCION
        private CD_Consultas INST_EditarFacturaDevolucion = new CD_Consultas();
        public void MET_EditarFacturaDevolucion(double ITBIS,
            double SUBTOTAL, double Total, string ID_Venta)
        {
            INST_EditarFacturaDevolucion.MET_EditarFacturaDevolucion(Convert.ToDouble(ITBIS),
                Convert.ToDouble(SUBTOTAL), Convert.ToDouble(Total),
                Convert.ToInt32(ID_Venta));
        }

        //EDITAR DEVOLUCION PARA AGREGAR EL CREDITO
        private CD_Consultas INST_EditarDevolucionAgregarCredito = new CD_Consultas();
        public void MET_EditarDevolucionAgregarCredito(double Credito, int ID_Devolucion)
        {
            INST_EditarDevolucionAgregarCredito.MET_EditarDevolucionAgregarCredito(
                Convert.ToDouble(Credito), Convert.ToInt32(ID_Devolucion));
        }

        //EDITAR CLIENTE DE LA FACTURA
        #region
        private CD_Consultas INST_EditarClienteFactura = new CD_Consultas();
        public void MET_EditarClienteFactura(int ID_Cliente, string ID_Factura)
        {
            INST_EditarClienteFactura.MET_EditarClienteFactura(Convert.ToInt32(ID_Cliente),
                Convert.ToInt32(ID_Factura));
        }
        #endregion

        //EDITAR DATOS DE LOS EMPLEADOS
        #region
        private CD_Consultas INST_EditarDatosEmpleado = new CD_Consultas();
        public void MET_EditarEmpleado(string Cedula, string Nombre, string Apellido, string Sexo,
            string Telefono, string Direccion, string FechaNacimiento, int Cargo, string FechaEntrada,
            string NombreUsuario, string Contrasena, string FechaSalida, int Status, string Sueldo,
            string ID_Empleado)
        {
            INST_EditarDatosEmpleado.MET_EditarDatosEmpleado(Cedula, Nombre, Apellido, Sexo,
                Telefono, Direccion,FechaNacimiento, Convert.ToInt32(Cargo), FechaEntrada,
                NombreUsuario, Contrasena, FechaSalida, Convert.ToInt32(Status), Convert.ToInt32(Sueldo),
                Convert.ToInt32(ID_Empleado));
        }
        #endregion

        //EDITAR DATOS PROVEEDOR
        #region
        private CD_Consultas INST_EditarProveedor = new CD_Consultas();
        public void MET_EditarDatosProveedor(string Nombre, string NombreContacto,
            string Telefono, string DireccionWeb, string ID_Proveedor)
        {
            INST_EditarProveedor.MET_EditarProveedor(Nombre, NombreContacto, Telefono, DireccionWeb,
                Convert.ToInt32(ID_Proveedor));
        }
        #endregion

        //EDITAR CREDITO
        private CD_Consultas INST_EditarCredito = new CD_Consultas();
        public void MET_EditarCredito(double Crediro, int ID_Credito)
        {
            INST_EditarCredito.MET_EditarCredito(Convert.ToDouble(Crediro), 
                Convert.ToInt32(ID_Credito));
        }

        //ELIMINAR PRODUCTO DE LOS DETALLES DE VENTA
        #region
        private CD_Consultas INST_EliminarProductoDetalleVenta = new CD_Consultas();
        public void MET_EliminarProductoDetalleVenta(string ID_Detalle, string ID_Producto,
            string Cantidad)
        {
            INST_EliminarProductoDetalleVenta.MET_EliminarProductoDetalleVenta(
                Convert.ToInt32(ID_Detalle), Convert.ToInt32(ID_Producto),
                Convert.ToInt32(Cantidad));
        }
        #endregion

        //ELIMINAR PRODUCTO
        #region
        private CD_Consultas INST_EliminarProducto = new CD_Consultas();
        public void MET_EliminarProductos(string ID_Producto)
        {
            INST_EliminarProducto.EliminarProducto(Convert.ToInt32(ID_Producto));
        }
        #endregion

        //ELIMINAR CLIENTE
        #region
        private CD_Consultas INST_EliminarCliente = new CD_Consultas();
        public void MET_EliminarCliente(string ID_Cliente)
        {
            INST_EliminarCliente.MET_EliminarClientes(Convert.ToInt32(ID_Cliente));
        }
        #endregion

        //ELIMINAR EMPLEADO
        #region
        private CD_Consultas INST_EliminarEmpleado = new CD_Consultas();
        public void MET_EliminarEmpleado(string ID_Empleado)
        {
            INST_EliminarEmpleado.MET_EliminarEmpleado(Convert.ToInt32(ID_Empleado));
        }
        #endregion

        //ELIMINAR PROVEEDOR
        #region
        private CD_Consultas INST_EliminarProveedor = new CD_Consultas();
        public void MET_EliminarProveedor(string ID_Proveedor)
        {
            INST_EliminarProveedor.MET_EliminarProveedor(Convert.ToInt32(ID_Proveedor));
        }
        #endregion
    }
}