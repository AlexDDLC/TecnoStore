using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Consultas
    {
        //LOGUEO DE LOS USUARIOS
        #region
        private CD_ConexionSQL Conxion = new CD_ConexionSQL();
        private SqlDataReader Leer;
        private SqlCommand Comando = new SqlCommand();
        public SqlDataReader IniciarSesion(string Usuario, string Contrasena)
        {
            SqlCommand ComandoUsuario = new SqlCommand("EP_LOGUEAR_USUARIO_3", Conxion.AbrirConexion());
            ComandoUsuario.CommandType = CommandType.StoredProcedure;
            ComandoUsuario.Parameters.AddWithValue("@Usuario", Usuario);
            ComandoUsuario.Parameters.AddWithValue("@Contrasena", Contrasena);
            Leer = ComandoUsuario.ExecuteReader();
            return Leer;
        }
        #endregion

        //MOSTRAR PRODUCTOS ADMINISTRADOR
        #region
        private CD_ConexionSQL MostrarProductosAdministrador = new CD_ConexionSQL();
        private DataTable TablaProductosAdministrador = new DataTable();
        public DataTable MostrarTablaProductosAdministrador()
        {
            Comando.Connection = MostrarProductosAdministrador.AbrirConexion();
            Comando.CommandText = "EP_MOSTRA_PRODUCTOS_ADMINISTRADOR";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaProductosAdministrador.Load(Leer);
            MostrarProductosAdministrador.CerrarConexion();
            return TablaProductosAdministrador; 
        }
        #endregion

        //MOSTRAR PRODUCTOS CAJERO
        #region
        private CD_ConexionSQL MostrarProductosCajero = new CD_ConexionSQL();
        private DataTable TablaProductosCajero = new DataTable();
        public DataTable MostrarTablaProductosCajero()
        {
            Comando.Connection = MostrarProductosCajero.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_PRODUCTOS_CAJERO";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaProductosCajero.Load(Leer);
            MostrarProductosCajero.CerrarConexion();
            return TablaProductosCajero;
        }
        #endregion

        //MOSTRAR CLIENTES
        #region
        private CD_ConexionSQL MostrarClientes = new CD_ConexionSQL();
        private DataTable TablaClientes = new DataTable();
        public DataTable MostrarTablaCliente()
        {
            Comando.Connection = MostrarClientes.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_CLIENTES";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaClientes.Load(Leer);
            MostrarClientes.CerrarConexion();
            return TablaClientes;
        }
        #endregion

        //MOSTRAR CLIENTES CON CREDITO
        #region
        private CD_ConexionSQL INST_MostrarClientesConCredito = new CD_ConexionSQL();
        private DataTable TablaClientesConCredito = new DataTable();
        public DataTable MET_MostrarClientesConCredito()
        {
            Comando.Connection = INST_MostrarClientesConCredito.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_CLIENTES_CON_CREDITO";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaClientesConCredito.Load(Leer);
            INST_MostrarClientesConCredito.CerrarConexion();
            return TablaClientesConCredito;
        }
        #endregion

        private CD_ConexionSQL MostrarClientesDeudores = new CD_ConexionSQL();
        private DataTable TablaClientesDeudores = new DataTable();
        public DataTable MostrarTablaClientesDeudores()
        {
            Comando.Connection = MostrarClientesDeudores.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_CLIENTES_DEUDORES";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaClientesDeudores.Load(Leer);
            MostrarClientesDeudores.CerrarConexion();
            return TablaClientesDeudores;
        }

        //MOSTRAR CLIENTE COBRO
        private CD_ConexionSQL MostrarClientesCobro = new CD_ConexionSQL();
        private DataTable TablaClientesCobro = new DataTable();
        public DataTable MostrarTablaClientesCobro(int ID_Cuenta)
        {
            Comando.Connection = MostrarClientesCobro.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_CLIENTE_COBRO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_CLIENTE", ID_Cuenta);
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaClientesCobro.Load(Leer);
            MostrarClientesCobro.CerrarConexion();
            return TablaClientesCobro;
        }

        //MOSTRAR DEUDA CLIENTE
        private CD_ConexionSQL MostrarDeudaCliente = new CD_ConexionSQL();
        private DataTable TablaDeudaCliente = new DataTable();
        public DataTable MostrarTablaDeudaCliente(int ID_Cuenta)
        {
            Comando.Connection = MostrarDeudaCliente.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_DEUDA_CLIENTE";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_CUENTA", ID_Cuenta);
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaDeudaCliente.Load(Leer);
            MostrarDeudaCliente.CerrarConexion();
            return TablaDeudaCliente;
        }

        //MOSTRAR EMPLEADOS
        #region
        private CD_ConexionSQL INST_MostrarEmpleados = new CD_ConexionSQL();
        private DataTable TablaEmpleados = new DataTable();
        public DataTable MET_MostrarEmpleados()
        {
            Comando.Connection = INST_MostrarEmpleados.AbrirConexion();
            Comando.CommandText = "EP_MOSTRA_EMPLEADOS";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaEmpleados.Load(Leer);
            INST_MostrarEmpleados.CerrarConexion();
            return TablaEmpleados;
        }
        #endregion

        private CD_ConexionSQL INST_MostrarCategoriasDeProducto = new CD_ConexionSQL();
        private DataTable TablaDeCategoria = new DataTable();
        public DataTable MET_MostrarCategorias()
        {
            Comando.Connection = INST_MostrarCategoriasDeProducto.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_CATEGORIA";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaDeCategoria.Load(Leer);
            INST_MostrarCategoriasDeProducto.CerrarConexion();
            return TablaDeCategoria;
        }

        private CD_ConexionSQL INST_MostrarMarcasDeProductos = new CD_ConexionSQL();
        private DataTable TablaDeMarcas = new DataTable();
        public DataTable MET_MostrarMarcas()
        {
            Comando.Connection = INST_MostrarMarcasDeProductos.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_MARCAS";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaDeMarcas.Load(Leer);
            INST_MostrarMarcasDeProductos.CerrarConexion();
            return TablaDeMarcas;
        }

        private CD_ConexionSQL INST_MostrarCargosEmpleados = new CD_ConexionSQL();
        private DataTable TablaCargos = new DataTable();
        public DataTable MET_MostrarCargos()
        {
            Comando.Connection = INST_MostrarCargosEmpleados.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_CARGO";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaCargos.Load(Leer);
            INST_MostrarCargosEmpleados.CerrarConexion();
            return TablaCargos;
        }

        //MOSTRAR EMPLEADOS DESPEDIDOS
        #region
        private CD_ConexionSQL INST_MostrarEmpleadosDespedidos = new CD_ConexionSQL();
        private DataTable TablaEmpleadosDespedidos = new DataTable();
        public DataTable MET_MostrarEmpleadosDespedidos()
        {
            Comando.Connection = INST_MostrarEmpleadosDespedidos.AbrirConexion();
            Comando.CommandText = "EP_MOSTRA_EMPLEADOS_DESPEDIDOS";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaEmpleadosDespedidos.Load(Leer);
            INST_MostrarEmpleadosDespedidos.CerrarConexion();
            return TablaEmpleadosDespedidos;
        }
        #endregion

        //MOSTRAR LISTA DE PROVEEDORES
        #region
        private CD_ConexionSQL INST_MostrarListaProveedor = new CD_ConexionSQL();
        private DataTable TablaListaProveedores = new DataTable();
        public DataTable MET_MostrarListaProveedores()
        {
            Comando.Connection = INST_MostrarListaProveedor.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_LISTA_PROVEEDORES";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaListaProveedores.Load(Leer);
            INST_MostrarListaProveedor.CerrarConexion();
            return TablaListaProveedores;
        }
        #endregion

        //MOSTRAR ID DE LA ULTIMA FACTURA CREADA
        #region
        private CD_ConexionSQL INST_MostrarIDFactura = new CD_ConexionSQL();
        private DataTable TablaMostrarIDFactura = new DataTable();
        public DataTable MET_MostrarIDFactura()
        {
            Comando.Connection = INST_MostrarIDFactura.AbrirConexion();
            Comando.CommandText = "EP_MOSTRA_ID_FACTURA";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaMostrarIDFactura.Load(Leer);
            INST_MostrarIDFactura.CerrarConexion();
            return TablaMostrarIDFactura;
        }
        #endregion

        //MOSTRAR EL STOCK DE LOS PRODUCTOS
        #region
        private CD_ConexionSQL INST_MostrarStock = new CD_ConexionSQL();
        private DataTable TablaMostrarStock = new DataTable();
        public DataTable MET_MostrarStock(int ID_Producto)
        {
            Comando.Connection = INST_MostrarStock.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_STOCK_PRODUCTO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_PRODUCTO", ID_Producto);
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaMostrarStock.Load(Leer);
            INST_MostrarStock.CerrarConexion();
            return TablaMostrarStock;
        }
        #endregion

        //MOSTRAR ID DE LA ULTIMA DEVOLUCION
        #region
        private CD_ConexionSQL INST_MostrarIDDevolucion = new CD_ConexionSQL();
        private DataTable TablaMostrarIDDevolucion = new DataTable();
        public DataTable MET_MostrarIDDevolucion()
        {
            Comando.Connection = INST_MostrarIDDevolucion.AbrirConexion();
            Comando.CommandText = "EP_MOSTRA_ID_DEVOLUCION";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaMostrarIDDevolucion.Load(Leer);
            INST_MostrarIDDevolucion.CerrarConexion();
            return TablaMostrarIDDevolucion;
        }
        #endregion

        //MOSTRAR TABLA DE PROVEEDORES
        #region
        private CD_ConexionSQL INST_MostrarProveedor = new CD_ConexionSQL();
        private DataTable TablaProveedores = new DataTable();
        public DataTable MET_MostrarProveedores()
        {
            Comando.Connection = INST_MostrarProveedor.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_PROVEEDORES";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaProveedores.Load(Leer);
            INST_MostrarProveedor.CerrarConexion();
            return TablaProveedores;
        }
        #endregion

        //MOSTRAR DETALLES DE LAS VENTAS
        #region
        private CD_ConexionSQL INST_MostrarDetalleVenta = new CD_ConexionSQL();
        private DataTable TablaDetalleVenta = new DataTable();
        public DataTable MET_MostrarTablaDetalleVenta(int ID_Venta)
        {
            Comando.Connection = INST_MostrarDetalleVenta.AbrirConexion();
            Comando.CommandText = "EP_MOSTRA_DETALLE_VENTA_E";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_VENTA_DETALLE", ID_Venta);
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaDetalleVenta.Load(Leer);
            INST_MostrarDetalleVenta.CerrarConexion();
            return TablaDetalleVenta;
        }
        #endregion

        //MOSTRAR DATOS DE LA FACTURA
        #region
        private CD_ConexionSQL INST_MostrarDatosDeLaVenta = new CD_ConexionSQL();
        private DataTable TablaInformacionVenta = new DataTable();
        public DataTable MET_MostrarInformacionVenta(int ID_Venta)
        {
            Comando.Connection = INST_MostrarDatosDeLaVenta.AbrirConexion();
            Comando.CommandText = "EP_MOSTRA_INFORMACION_FACTURA";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_VENTA", ID_Venta);
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaInformacionVenta.Load(Leer);
            INST_MostrarDatosDeLaVenta.CerrarConexion();
            return TablaInformacionVenta;
        }
        #endregion

        //MUESTRA LOS DATOS EN LA FACTURA IMPRESA
        #region
        private CD_ConexionSQL INST_MostrarInformacionFactura = new CD_ConexionSQL();
        private DataTable TablaInformacionFactura = new DataTable();
        public DataTable MET_MostrarInformacionFacturaImpresa(int ID_Venta)
        {
            Comando.Connection = INST_MostrarInformacionFactura.AbrirConexion();
            Comando.CommandText = "EP_MOSTRA_FACTURA_JUNTO_A_DETALLES";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_VENTA", ID_Venta);
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaInformacionFactura.Load(Leer);
            INST_MostrarInformacionFactura.CerrarConexion();
            return TablaInformacionFactura;
        }
        #endregion

        //MUESTRA LOS DATOS DE LA DEVOLUCION IMPRESA
        private CD_ConexionSQL INST_MostrarInformacionDevolucion = new CD_ConexionSQL();
        private DataTable TablaInformacionDevolucion = new DataTable();
        public DataTable MET_MostrarInformacioDevolucionImpresa(int ID_Devolucion)
        {
            Comando.Connection = INST_MostrarInformacionDevolucion.AbrirConexion();
            Comando.CommandText = "EP_MOSTRA_DEVOLUCION_JUNTO_A_DETALLES_DEVOLUCION";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_DEVOLUCION", ID_Devolucion);
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaInformacionDevolucion.Load(Leer);
            INST_MostrarInformacionDevolucion.CerrarConexion();
            return TablaInformacionDevolucion;
        }

        //INSERTAR PRODUCTOS
        #region
        private CD_ConexionSQL InsertarProductos = new CD_ConexionSQL();
        public void InsertarDatosProducto(int Categoria, int Marca, string Modelo, 
            string Descripcion, int Stock, double PrecioCompra, double PrecioVenta, 
            int Proveedor)
        {
            Comando.Connection = InsertarProductos.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_PRODUCTOS";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_CATEGORIA", Categoria);
            Comando.Parameters.AddWithValue("@ID_MARCA", Marca);
            Comando.Parameters.AddWithValue("@MODELO", Modelo);
            Comando.Parameters.AddWithValue("@DESCRIPCION", Descripcion);
            Comando.Parameters.AddWithValue("@STOCK", Stock);
            Comando.Parameters.AddWithValue("@PRECIO_COMPRA", PrecioCompra);
            Comando.Parameters.AddWithValue("@PRECIO_VENTA", PrecioVenta);
            Comando.Parameters.AddWithValue("@PROVEEDOR", Proveedor);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        private CD_ConexionSQL INST_InsertarPagoDeCuenta = new CD_ConexionSQL();
        public void MET_InsertarPagoDeCuenta(int ID_Cuenta, double Pago)
        {
            Comando.Connection = INST_InsertarPagoDeCuenta.AbrirConexion();
            Comando.CommandText = "EP_ACTUALIZAR_CUENTA_POR_COBRAR";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_CUENTA_PO_COBRAR", ID_Cuenta);
            Comando.Parameters.AddWithValue("@PAGO", Pago);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        //ISERTAR MARCA DE PRODUCTO
        private CD_ConexionSQL INST_InsertarMarca = new CD_ConexionSQL();
        public void MET_InsertarMarca(string Marca)
        {
            Comando.Connection = INST_InsertarMarca.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_MARCA";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@MARCA", Marca);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        //INSERTAR CATEGORIA DE PRODUCTO
        private CD_ConexionSQL INST_InsertarCaregoria = new CD_ConexionSQL();
        public void MET_InsertarCategoria(string Categoria)
        {
            Comando.Connection = INST_InsertarCaregoria.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_CATEGORIA";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@CATEGORIA", Categoria);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        //INSERTAR CARGO DE LOS EMPLEADOS
        private CD_ConexionSQL INST_InsertarCargo = new CD_ConexionSQL();
        public void MET_InsertarCargo(string Cargo)
        {
            Comando.Connection = INST_InsertarCargo.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_CARGO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@CARGO", Cargo);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        //INSERTAR CLIENTES
        #region
        private CD_ConexionSQL InsertarCiente = new CD_ConexionSQL();
        public void InsertarDatosCliente(string Cedula, string Nombre, string Apellido, 
             string Direccion, string Telefono, string FechaNacimiento)
        {
            Comando.Connection = InsertarCiente.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_CLIENTES";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@CEDULA", Cedula);
            Comando.Parameters.AddWithValue("@NOMBRE", Nombre);
            Comando.Parameters.AddWithValue("@APELLIDO", Apellido);
            Comando.Parameters.AddWithValue("@DIRECCION", Direccion);
            Comando.Parameters.AddWithValue("@TELEFONO", Telefono);
            Comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", FechaNacimiento);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //INSERTAR DEVOLUCIONES
        private CD_ConexionSQL INST_InsertarDevolucion = new CD_ConexionSQL();
        public void MET_InsertarDevolucion(int Factura, int Cliente,
            int Empleado, string FechaDevolucion,double Credito)
        {
            Comando.Connection = INST_InsertarDevolucion.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_DEVOLUCION";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@FACTURA", Factura);
            Comando.Parameters.AddWithValue("@CLIENTE", Cliente);
            Comando.Parameters.AddWithValue("@EMPLEADO", Empleado);
            Comando.Parameters.AddWithValue("@FECHADEVOLUCION", FechaDevolucion);
            Comando.Parameters.AddWithValue("@CREDITO", Credito);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        //INSERTAR CANTIDAD MAYOR DE PRODUCTO EN LA VENTA
        #region
        private CD_ConexionSQL INST_InsertarCantidadMayorProducto = new CD_ConexionSQL();
        public void MET_InsertarCantidadMayorProducto(int ID_Producto, int CantidadNueva,
            double ITBIS, double SUBTOTAL, int ID_Detalle)
        {
            Comando.Connection = INST_InsertarCantidadMayorProducto.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_AUMENTAR_CANTIDAD_PRODUCTO_FACTURA";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_PRODUCTO", ID_Producto);
            Comando.Parameters.AddWithValue("@CANTIDAD_NUEVA", CantidadNueva);
            Comando.Parameters.AddWithValue("@ITBIS", ITBIS);
            Comando.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
            Comando.Parameters.AddWithValue("@ID_DETALLE_VENTA", ID_Detalle);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //INSERTAR CANTIDAD MENOR DE PRODUCTO EN LA VENTA
        #region
        private CD_ConexionSQL INST_InsertarCantidadMenorProducto = new CD_ConexionSQL();
        public void MET_InsertarCantidadMenorProducto(int ID_Producto, int CantidadNueva,
            double ITBIS, double SUBTOTAL, int ID_Detalle)
        {
            Comando.Connection = INST_InsertarCantidadMenorProducto.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_DISMINUIR_CANTIDAD_PRODUCTO_FACTURA";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_PRODUCTO", ID_Producto);
            Comando.Parameters.AddWithValue("@CANTIDAD_NUEVA", CantidadNueva);
            Comando.Parameters.AddWithValue("@ITBIS", ITBIS);
            Comando.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
            Comando.Parameters.AddWithValue("@ID_DETALLE_VENTA", ID_Detalle);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //INSERTAR EMPLEADO
        #region
        private CD_ConexionSQL INST_InsertarEmpleado = new CD_ConexionSQL();
        public void MET_InsertarEmpleado(string Cedula, string Nombre, string Apellido, string Sexo, 
            string Telefono, string Direccion, string FechaNacimiento,int Cargo,string FechaEntrada,
            string NombreUsuario, string Contrasena, string FechaSalida, int Status, int Sueldo)
        {
            Comando.Connection = INST_InsertarEmpleado.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_EMPLEADO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@CEDULA", Cedula);
            Comando.Parameters.AddWithValue("@NOMBRE", Nombre);
            Comando.Parameters.AddWithValue("@APELLIDO", Apellido);
            Comando.Parameters.AddWithValue("@SEXO", Sexo);
            Comando.Parameters.AddWithValue("@TELEFONO", Telefono);
            Comando.Parameters.AddWithValue("@DIRECCION", Direccion);
            Comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", FechaNacimiento);
            Comando.Parameters.AddWithValue("@CARGO", Cargo);
            Comando.Parameters.AddWithValue("@FECHA_ENTRADA", FechaEntrada);
            Comando.Parameters.AddWithValue("@USUARIO", NombreUsuario);
            Comando.Parameters.AddWithValue("@CONTRASENA", Contrasena);
            Comando.Parameters.AddWithValue("@FECHA_SALIDA", FechaSalida);
            Comando.Parameters.AddWithValue("@STATUS", Status);
            Comando.Parameters.AddWithValue("@SUELDO", Sueldo);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //INSERTAR PROVEEDOR
        #region
        private CD_ConexionSQL INST_InsertarProveedor = new CD_ConexionSQL();
        public void MET_InsertarProveedor(string Nombre, string NombreContacto,
            string Telefono, string DireccionWeb)
        {
            Comando.Connection = INST_InsertarProveedor.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_PROVEEDOR";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@PROVEEDOR", Nombre);
            Comando.Parameters.AddWithValue("@CONTACTO", NombreContacto);
            Comando.Parameters.AddWithValue("@TELEFONO", Telefono);
            Comando.Parameters.AddWithValue("@DIRECCION", DireccionWeb);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //INSERTA LOS DETALLES DE FACTURA EN LA BASE DE DATOS
        #region
        private CD_ConexionSQL INST_InsertarDetalleVenta = new CD_ConexionSQL();
        public void MET_InsertarDetalleVenta(int ID_Venta, int IDProducto, int Cantidad, 
            double ITBIS, double SUBTOTAL)
        {
            Comando.Connection = INST_InsertarDetalleVenta.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_DETALLES_VENTA_E2";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDVENTA", ID_Venta);
            Comando.Parameters.AddWithValue("@IDPRODUCTO", IDProducto);
            Comando.Parameters.AddWithValue("@CANTIDAD", Cantidad);
            Comando.Parameters.AddWithValue("@ITBIS", ITBIS);
            Comando.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //INSERTAR LOS DETALLES DE LA DEVOLUCION
        #region
        private CD_ConexionSQL INST_InsertarDetalleDevolucion = new CD_ConexionSQL();
        public void MET_InsertarDetalleDevolucion(int ID_Devolucion,int Venta, int Detalle, int Producto,
            double Precio, int Cantidad)
        {
            Comando.Connection = INST_InsertarDetalleDevolucion.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_DETALLE_DEVOLUCION";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_DEVOLUCION", ID_Devolucion);
            Comando.Parameters.AddWithValue("@ID_VENTA", Venta);
            Comando.Parameters.AddWithValue("@ID_DETALLE_VENTA", Detalle);
            Comando.Parameters.AddWithValue("@ID_PRODUCTO", Producto);
            Comando.Parameters.AddWithValue("@PRECIO", Precio);
            Comando.Parameters.AddWithValue("@CANTIDAD_DEVUELTA", Cantidad);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //INSERTAR DETALLE DEVOLUCION CUANDO NO SE DEVUELVE TODO
        private CD_ConexionSQL INST_InsertarDetalleDevolucionCuandoNoSeDevuelveTodo = new CD_ConexionSQL();
        public void MET_INST_InsertarDetalleDevolucionCuandoNoSeDevuelveTodo(int ID_Devolucion ,int Venta, int Detalle,
            int Producto, double Precio, int Cantidad)
        {
            Comando.Connection = INST_InsertarDetalleDevolucionCuandoNoSeDevuelveTodo.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_DETALLE_DEVOLUCION_CUANDO_NO_SE_DEVUELVE_TODO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_DEVOLUCION", ID_Devolucion);
            Comando.Parameters.AddWithValue("@ID_VENTA", Venta);
            Comando.Parameters.AddWithValue("@ID_DETALLE_VENTA", Detalle);
            Comando.Parameters.AddWithValue("@ID_PRODUCTO", Producto);
            Comando.Parameters.AddWithValue("@PRECIO", Precio);
            Comando.Parameters.AddWithValue("@CANTIDAD_DEVUELTA", Cantidad);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        //INSERTAR DATOS DE FACTURA
        #region
        private CD_ConexionSQL INST_InsertarVenta = new CD_ConexionSQL();
        public void MET_InsertarVenta(int Empleado, int Cliente,
            int TipoVenta, string FechaVenta, double ITBIS, double SUBTOTAL,
            double TOTAL)
        {
            Comando.Connection = INST_InsertarDetalleVenta.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_DATOS_FACTURA_E1";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_EMPLEADO", Empleado);
            Comando.Parameters.AddWithValue("@ID_CLIENTE", Cliente);
            Comando.Parameters.AddWithValue("@TIPO_VENTA", TipoVenta);
            Comando.Parameters.AddWithValue("@FECHA_VENTA", FechaVenta);
            Comando.Parameters.AddWithValue("@ITBIS", ITBIS);
            Comando.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
            Comando.Parameters.AddWithValue("@TOTAL", TOTAL);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //INSERTAR CUENTAS POR COBRAR
        #region
        private CD_ConexionSQL INST_InsertarCuentaPorCobrar = new CD_ConexionSQL();
        public void MET_InsertarCuentaPorCobrar(int ID_Venta, int Cliente, int Empleado,
            string Fecha, double Deuda)
        {
            Comando.Connection = INST_InsertarDetalleVenta.AbrirConexion();
            Comando.CommandText = "EP_INSERTAR_CUENTAS_POR_COBRAR";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDVENTA", ID_Venta);
            Comando.Parameters.AddWithValue("@ID_CLIENTE", Cliente);
            Comando.Parameters.AddWithValue("@ID_EMPLEADO", Empleado);
            Comando.Parameters.AddWithValue("@FECHA", Fecha);
            Comando.Parameters.AddWithValue("@DEUDA", Deuda);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //EDITAR PRODUCTO
        #region
        private CD_ConexionSQL EditarProducto = new CD_ConexionSQL();
        public void EditarDatosProducto(int Categoria, int Marca, string Modelo, 
            string Descripcion, int Stock, double PrecioCompra, double PrecioVenta, 
            int Proveedor, int ID_Producto)
        {
            Comando.Connection = EditarProducto.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_PRODUCTO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_CATEGORIA", Categoria);
            Comando.Parameters.AddWithValue("@ID_MARCA", Marca);
            Comando.Parameters.AddWithValue("@MODELO", Modelo);
            Comando.Parameters.AddWithValue("@DESCRIPCION", Descripcion);
            Comando.Parameters.AddWithValue("@STOCK", Stock);
            Comando.Parameters.AddWithValue("@PRECIO_COMPRA", PrecioCompra);
            Comando.Parameters.AddWithValue("@PRECIO_VENTA", PrecioVenta);
            Comando.Parameters.AddWithValue("@PROVEEDOR", Proveedor);
            Comando.Parameters.AddWithValue("@ID_Producto", ID_Producto);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //EDITAR CLIENTE
        #region
        private CD_ConexionSQL EditarCliente = new CD_ConexionSQL();
        public void EditarDatosCliente(string Cedula, string Nombre, string Apellido, 
            string Direccion, string Telefono, string FechaNacimiento, int ID_Ciente)
        {
            Comando.Connection = EditarCliente.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_CLIENTE";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@CEDULA", Cedula);
            Comando.Parameters.AddWithValue("@NOMBRE", Nombre);
            Comando.Parameters.AddWithValue("@APELLIDO", Apellido);
            Comando.Parameters.AddWithValue("@DIRECCION", Direccion);
            Comando.Parameters.AddWithValue("@TELEFONO", Telefono);
            Comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", FechaNacimiento);
            Comando.Parameters.AddWithValue("@ID_CLIENTE", ID_Ciente);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //EDITAR CREDITO
        private CD_ConexionSQL INST_EditarCredito = new CD_ConexionSQL();
        public void MET_EditarCredito(double Crediro, int ID_Credito)
        {
            Comando.Connection = INST_EditarCredito.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_CREDITO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@CREDITO_NUEVO", Crediro);
            Comando.Parameters.AddWithValue("@ID_CREDITO", ID_Credito);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        //EDITAR EL CLIENTE DE LA FACTURA
        #region
        private CD_ConexionSQL INST_EditarClienteFactura = new CD_ConexionSQL();
        public void MET_EditarClienteFactura(int ID_Cliente, int ID_Factura)
        {
            Comando.Connection = INST_EditarClienteFactura.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_CLIENTE_FACTURA";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_CLIENTE", ID_Cliente);
            Comando.Parameters.AddWithValue("@ID_FACTURA", ID_Factura);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //EDITAL FACTURA FINAL
        #region
        private CD_ConexionSQL INST_EditarFacturaFinal = new CD_ConexionSQL();
        public void MET_EditarFacturaFinal(int TipoVenta, double ITBIS,
            double SUBTOTAL, double TOTAL, int ID_Venta)
        {
            Comando.Connection = INST_EditarFacturaFinal.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_DATOS_FACTURA_FINAL";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@TIPO_VENTA", TipoVenta);
            Comando.Parameters.AddWithValue("@ITBIS", ITBIS);
            Comando.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
            Comando.Parameters.AddWithValue("@TOTAL", TOTAL);
            Comando.Parameters.AddWithValue("@ID_VENTA", ID_Venta);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //EDITAR FACTURA DE DEVOLUCION
        #region
        private CD_ConexionSQL INST_EditarFacturaDevolucion = new CD_ConexionSQL();
        public void MET_EditarFacturaDevolucion(double ITBIS,
            double SUBTOTAL, double TOTAL, int ID_Venta)
        {
            Comando.Connection = INST_EditarFacturaDevolucion.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_DATOS_FACTURA_DEVOLUCION";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ITBIS", ITBIS);
            Comando.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
            Comando.Parameters.AddWithValue("@TOTAL", TOTAL);
            Comando.Parameters.AddWithValue("@ID_VENTA", ID_Venta);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //EDITAR DEVOLUCION PARA AGREGAR EL CREDITO
        private CD_ConexionSQL INST_EditarDevolucionAgregarCredito = new CD_ConexionSQL();
        public void MET_EditarDevolucionAgregarCredito(double Credito, int ID_Devolucion)
        {
            Comando.Connection = INST_EditarDevolucionAgregarCredito.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_DEVOLUCION";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@TOTAL", Credito);
            Comando.Parameters.AddWithValue("@ID_DEVOLUCION", ID_Devolucion);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        //EDITAR EMPLEADO
        #region
        private CD_ConexionSQL INST_EditarEmpleado = new CD_ConexionSQL();
        public void MET_EditarDatosEmpleado(string Cedula, string Nombre, string Apellido, string Sexo,
            string Telefono, string Direccion, string FechaNacimiento, int Cargo, string FechaEntrada,
            string NombreUsuario, string Contrasena, string FechaSalida, int Status, int Sueldo, 
            int ID_Empleado)
        {
            Comando.Connection = INST_EditarEmpleado.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_EMPLEADO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@CEDULA", Cedula);
            Comando.Parameters.AddWithValue("@NOMBRE", Nombre);
            Comando.Parameters.AddWithValue("@APELLIDO", Apellido);
            Comando.Parameters.AddWithValue("@SEXO", Sexo);
            Comando.Parameters.AddWithValue("@TELEFONO", Telefono);
            Comando.Parameters.AddWithValue("@DIRECCION", Direccion);
            Comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", FechaNacimiento);
            Comando.Parameters.AddWithValue("@CARGO", Cargo);
            Comando.Parameters.AddWithValue("@FECHA_ENTRADA", FechaEntrada);
            Comando.Parameters.AddWithValue("@USUARIO", NombreUsuario);
            Comando.Parameters.AddWithValue("@CONTRASENA", Contrasena);
            Comando.Parameters.AddWithValue("@FECHA_SALIDA", FechaSalida);
            Comando.Parameters.AddWithValue("@STATUS", Status);
            Comando.Parameters.AddWithValue("@SUELDO", Sueldo);
            Comando.Parameters.AddWithValue("@ID_EMPLEADO", ID_Empleado);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //EDITAR PROVEEDOR
        #region
        private CD_ConexionSQL INST_EditarProveedor = new CD_ConexionSQL();
        public void MET_EditarProveedor(string Nombre, string NombreContacto,
            string Telefono, string DireccionWeb, int ID_Proveedor)
        {
            Comando.Connection = INST_EditarProveedor.AbrirConexion();
            Comando.CommandText = "EP_EDITAR_PROVEEDOR";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@PROVEEDOR", Nombre);
            Comando.Parameters.AddWithValue("@CONTACTO", NombreContacto);
            Comando.Parameters.AddWithValue("@TELEFONO", Telefono);
            Comando.Parameters.AddWithValue("@DIRECCION", DireccionWeb);
            Comando.Parameters.AddWithValue("@ID_PROVEEDOR", ID_Proveedor);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //ELIINAR PRODUCTO
        #region
        private CD_ConexionSQL EliminarProductos = new CD_ConexionSQL();
        public void EliminarProducto(int ID_Producto)
        {
            Comando.Connection = EliminarProductos.AbrirConexion();
            Comando.CommandText = "EP_ELIMINAR_PRODUCTO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_Producto", ID_Producto);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //ELIMINAR CLIENTE
        #region
        private CD_ConexionSQL INST_EliminarCliente = new CD_ConexionSQL();
        public void MET_EliminarClientes(int ID_Cliente)
        {
            Comando.Connection = INST_EliminarCliente.AbrirConexion();
            Comando.CommandText = "EP_ELIMINAR_CLIENTE";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_CLIENTE", ID_Cliente);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //ELIMINAR EMPLEADO
        #region
        private CD_ConexionSQL INST_EliminarEmpleado = new CD_ConexionSQL();
        public void MET_EliminarEmpleado(int ID_Empleado)
        {
            Comando.Connection = INST_EliminarEmpleado.AbrirConexion();
            Comando.CommandText = "EP_ELIMINAR_EMPLEADO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_EMPLEADO", ID_Empleado);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //ELIMINAR PRODUCTO DE DETALLES DE VENTA
        #region
        private CD_ConexionSQL INST_EliminarProductoDetalleVenta = new CD_ConexionSQL();
        public void MET_EliminarProductoDetalleVenta(int ID_Detalle, int ID_Producto,
            int Cantidad)
        {
            Comando.Connection = INST_EliminarProductoDetalleVenta.AbrirConexion();
            Comando.CommandText = "EP_ELIMINAR_DETALLE_VENTA";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_DETALLEVENTA", ID_Detalle);
            Comando.Parameters.AddWithValue("@ID_PRODUCTO", ID_Producto);
            Comando.Parameters.AddWithValue("@CANTIDAD", Cantidad);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //ELIMINAR PROVEEDOR
        #region
        private CD_ConexionSQL INST_EliminarProveedor = new CD_ConexionSQL();
        public void MET_EliminarProveedor(int ID_Proveedor)
        {
            Comando.Connection = INST_EliminarProveedor.AbrirConexion();
            Comando.CommandText = "EP_ELIMINAR_PROVEEDOR";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ID_PROVEEDOR", ID_Proveedor);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        #endregion

        //MOSTRAR LISTA CATEGORIA
        #region
        private CD_ConexionSQL INST_MostrarCatgorias = new CD_ConexionSQL();
        public DataTable MET_ListarCategoria()
        {
            DataTable TablaCategoria = new DataTable();
            Comando.Connection = INST_MostrarCatgorias.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_LISTA_CATEGORIAS";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaCategoria.Load(Leer);
            Leer.Close();
            INST_MostrarCatgorias.CerrarConexion();
            return TablaCategoria;
        }
        #endregion

        //MOSTRAR LISTA MARCAS
        #region
        private CD_ConexionSQL MostrarMarcas = new CD_ConexionSQL();
        public DataTable MET_ListarMarca()
        {
            DataTable TablaMarca = new DataTable();
            Comando.Connection = MostrarMarcas.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_LISTA_MARCAS";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaMarca.Load(Leer);
            Leer.Close();
            MostrarMarcas.CerrarConexion();
            return TablaMarca;
        }
        #endregion

        //MOSTRAR LISTA CARGOS
        #region
        private CD_ConexionSQL INST_MostrarCargo = new CD_ConexionSQL();
        public DataTable MET_ListarCargo()
        {
            DataTable TablaCargo = new DataTable();
            Comando.Connection = INST_MostrarCargo.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_LISTA_CARGO";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaCargo.Load(Leer);
            Leer.Close();
            INST_MostrarCargo.CerrarConexion();
            return TablaCargo;
        }
        #endregion

        //MOSTRAR LISTA STATUS
        #region
        private CD_ConexionSQL INST_MostrarStatus = new CD_ConexionSQL();
        public DataTable MET_ListarStatus()
        {
            DataTable TablaStatus = new DataTable();
            Comando.Connection = INST_MostrarStatus.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_LISTA_STATUS";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaStatus.Load(Leer);
            Leer.Close();
            INST_MostrarStatus.CerrarConexion();
            return TablaStatus;
        }
        #endregion

        //MOSTRAR LISTA TIPOS DE VENTAS
        #region
        private CD_ConexionSQL INST_MostrarListaTipoVenta = new CD_ConexionSQL();
        public DataTable MET_ListarTipoVenta()
        {
            DataTable TablaTiposVentas = new DataTable();
            Comando.Connection = INST_MostrarListaTipoVenta.AbrirConexion();
            Comando.CommandText = "EP_MOSTRAR_LISTA_TIPOS_VENTAS";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            TablaTiposVentas.Load(Leer);
            Leer.Close();
            INST_MostrarListaTipoVenta.CerrarConexion();
            return TablaTiposVentas;
        }
        #endregion
    }
}