using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DVenta
    {
        private string _Marca;
        private string _Modelo;
        private int _Anio;
        private int _AnioInicial;
        private int _AnioFinal;
        private string _TipoAuto;
        private string _CantidadCilindros;
        private int _Id_Buscar;
        private int _Id_Cotizacion;
        private int _CUC;
        private string _Nombre;
        private string _Fecha;
        private string _Parte;
        private string _Precio;
        private float _CantidadRecibida;
        private float _Cambio;
        private float _Descuento;
        private float _Ahorro;
        private float _MontoTotal;
        private float _PagoTotal;
        private int _Id_Presupuesto;
        private int _Folio;
        private int _Id_Item;

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        public int Anio
        {
            get { return _Anio; }
            set { _Anio = value; }
        }

        public int AnioInicial
        {
            get { return _AnioInicial; }
            set { _AnioInicial = value; }
        }

        public int AnioFinal
        {
            get { return _AnioFinal; }
            set { _AnioFinal = value; }
        }

        public string TipoAuto
        {
            get { return _TipoAuto; }
            set { _TipoAuto = value; }
        }

        public string CantidadCilindros
        {
            get { return _CantidadCilindros; }
            set { _CantidadCilindros = value; }
        }

        public int Id_Buscar
        {
            get { return _Id_Buscar; }
            set { _Id_Buscar = value; }
        }

        public int Id_Cotizacion
        {
            get { return _Id_Cotizacion; }
            set { _Id_Cotizacion = value; }
        }
        public int CUC
        {
            get { return _CUC; }
            set { _CUC = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public string Parte
        {
            get { return _Parte; }
            set { _Parte = value; }
        }

        public string Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        public float CantidadRecibida
        {
            get { return _CantidadRecibida; }
            set { _CantidadRecibida = value; }
        }

        public float Cambio
        {
            get { return _Cambio; }
            set { _Cambio = value; }
        }

        public float Ahorro
        {
            get { return _Ahorro; }
            set { _Ahorro = value; }
        }

        public float MontoTotal
        {
            get { return _MontoTotal; }
            set { _MontoTotal = value; }
        }

        public float PagoTotal
        {
            get { return _PagoTotal; }
            set { _PagoTotal = value; }
        }

        public float Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

        public int Id_Presupuesto
        {
            get { return _Id_Presupuesto; }
            set { _Id_Presupuesto = value; }
        }

        public int Folio
        {
            get { return _Folio; }
            set { _Folio = value; }
        }

        public int Id_Item
        {
            get { return _Id_Item; }
            set { _Id_Item = value; }
        }

        //CONSTRUCTOR VACIO
        public DVenta()
        {

        }

        //CONSTRUCTOR CON PARAMETROS
        public DVenta(string marca, string modelo, int anio, string tipoAuto, string cantidadCilindros)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
            this.TipoAuto = tipoAuto;
            this.CantidadCilindros = cantidadCilindros;
        }

        //INICIO DEL METODO PARA CONSULTAR UN AUTO ESPECIFICO PARA VENTA DE PARTES
        public DataTable ConsultaAutoVenta(DVenta Automovil)
        {
            DataTable DtResultado = new DataTable("Automovil");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_auto_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 20;
                ParMarca.Value = Automovil.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 20;
                ParModelo.Value = Automovil.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParAnio = new SqlParameter();
                ParAnio.ParameterName = "@anioInicial";
                ParAnio.SqlDbType = SqlDbType.Int;
                ParAnio.Value = Automovil.AnioInicial;
                SqlCmd.Parameters.Add(ParAnio);

                SqlParameter ParAnioFinal = new SqlParameter();
                ParAnioFinal.ParameterName = "@anioFinal";
                ParAnioFinal.SqlDbType = SqlDbType.Int;
                ParAnioFinal.Value = Automovil.AnioFinal;
                SqlCmd.Parameters.Add(ParAnioFinal);

                SqlParameter ParTipoAuto = new SqlParameter();
                ParTipoAuto.ParameterName = "@tipoAuto";
                ParTipoAuto.SqlDbType = SqlDbType.VarChar;
                ParTipoAuto.Size = 20;
                ParTipoAuto.Value = Automovil.TipoAuto;
                SqlCmd.Parameters.Add(ParTipoAuto);

                SqlParameter ParCantidadCilindros = new SqlParameter();
                ParCantidadCilindros.ParameterName = "@cantidadCilindros";
                ParCantidadCilindros.SqlDbType = SqlDbType.VarChar;
                ParCantidadCilindros.Size = 20;
                ParCantidadCilindros.Value = Automovil.CantidadCilindros;
                SqlCmd.Parameters.Add(ParCantidadCilindros);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //INICIO DEL METODO INSERTAR LA COTIZACION
        public string insertarCotizacion(DVenta Venta)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                //CODIGO
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //AHORA ESTABLECEMOS EL COMANDO PARA EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "registrar_cotizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //establecer los parametros que manejaremos en el proceso almacenado
                SqlParameter ParId_Item = new SqlParameter();
                ParId_Item.ParameterName = "@id_item";
                ParId_Item.SqlDbType = SqlDbType.Int;
                ParId_Item.Value = Venta._Id_Buscar;
                SqlCmd.Parameters.Add(ParId_Item);

               

                //EJECUTAR COMANDO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar la corización";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally //limpiar los recursos despues de realizar la conexion
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

        //METODO CONSULTAR  COTIZACION
        public DataTable ConsultaCotizacion()
        {
            DataTable DtResultado = new DataTable("Cotizacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //ESTABLECEMOS LA CONEXION PRIMERAMENTE
                SqlCon.ConnectionString = Conexion.Cn;

                //AHORA ESTABLECEMOS EL COMANDO PARA EL PROCESO ALMACENADO consulta_cotizacion
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "consulta_cotizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //AHORA OBTENEMOS LOS DATOS A MOSTRAR DESPUES DE EJECUTAR EL COMANDO 
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //METODO ELIMINAR COTIZACION
        public string EliminarCotizacion(DVenta Venta)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //CODIGO PARA ESTABLECER UNA CONEXION CON LA BASE DE DATOS
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //ESTABLECER EL COMANDO PARA EJECUTAR EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminar_cotizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                //AHORA VAMOS A EJECUTAR EL COMANDO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar cotización";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally //LIMPIAR RECURSOS CERRAR LA CONEXION
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

        //INICIO DEL METODO INSERTAR LA COTIZACION
        public string insertarVenta(DVenta Venta)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                //CODIGO
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //AHORA ESTABLECEMOS EL COMANDO PARA EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "registrar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //establecer los parametros que manejaremos en el proceso almacenado
                SqlParameter ParId_Venta = new SqlParameter();
                ParId_Venta.ParameterName = "@id_venta";
                ParId_Venta.SqlDbType = SqlDbType.Int;
                ParId_Venta.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Venta);

                SqlParameter ParId_Cotizacion = new SqlParameter();
                ParId_Cotizacion.ParameterName = "@id_cotizacion";
                ParId_Cotizacion.SqlDbType = SqlDbType.Int;
                ParId_Cotizacion.Value = Venta.Id_Cotizacion;
                SqlCmd.Parameters.Add(ParId_Cotizacion);

                SqlParameter ParCUC = new SqlParameter();
                ParCUC.ParameterName = "@cuc";
                ParCUC.SqlDbType = SqlDbType.Int;
                ParCUC.Value = Venta.CUC;
                SqlCmd.Parameters.Add(ParCUC);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_cliente";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Venta.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.VarChar;
                ParFecha.Size = 30;
                ParFecha.Value = Venta.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParParte = new SqlParameter();
                ParParte.ParameterName = "@parte";
                ParParte.SqlDbType = SqlDbType.VarChar;
                ParParte.Size = 20;
                ParParte.Value = Venta.Parte;
                SqlCmd.Parameters.Add(ParParte);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 20;
                ParMarca.Value = Venta.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 20;
                ParModelo.Value = Venta.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParAnio = new SqlParameter();
                ParAnio.ParameterName = "@anio";
                ParAnio.SqlDbType = SqlDbType.Int;
                ParAnio.Value = Venta.Anio;
                SqlCmd.Parameters.Add(ParAnio);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.VarChar;
                ParPrecio.Size = 20;
                ParPrecio.Value = Venta.Precio;
                SqlCmd.Parameters.Add(ParPrecio);

                SqlParameter ParCantidadRecibida = new SqlParameter();
                ParCantidadRecibida.ParameterName = "@cantidad_recibida";
                ParCantidadRecibida.SqlDbType = SqlDbType.Float;
                ParCantidadRecibida.Value = Venta.CantidadRecibida;
                SqlCmd.Parameters.Add(ParCantidadRecibida);

                SqlParameter ParCambio = new SqlParameter();
                ParCambio.ParameterName = "@cambio";
                ParCambio.SqlDbType = SqlDbType.Float;    
                ParCambio.Value = Venta.Cambio;
                SqlCmd.Parameters.Add(ParCambio);

                SqlParameter ParMontoTotal = new SqlParameter();
                ParMontoTotal.ParameterName = "@monto_total";
                ParMontoTotal.SqlDbType = SqlDbType.Float;
                ParMontoTotal.Value = Venta.MontoTotal;
                SqlCmd.Parameters.Add(ParMontoTotal);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@descuento";
                ParDescuento.SqlDbType = SqlDbType.Float;
                ParDescuento.Value = Venta.Descuento;
                SqlCmd.Parameters.Add(ParDescuento);

                SqlParameter ParPagoTotal = new SqlParameter();
                ParPagoTotal.ParameterName = "@pago_total";
                ParPagoTotal.SqlDbType = SqlDbType.Float;
                ParPagoTotal.Value = Venta.PagoTotal;
                SqlCmd.Parameters.Add(ParPagoTotal);

                SqlParameter ParAhorro = new SqlParameter();
                ParAhorro.ParameterName = "@ahorro";
                ParAhorro.SqlDbType = SqlDbType.Float;
                ParAhorro.Value = Venta.Ahorro;
                SqlCmd.Parameters.Add(ParAhorro);


                //EJECUTAR COMANDO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar la corización";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally //limpiar los recursos despues de realizar la conexion
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }
        //METODO ELIMINAR PARTES DESPUES DE LA VENTA
        public string EliminarPartes(DVenta Venta)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //CODIGO PARA ESTABLECER UNA CONEXION CON LA BASE DE DATOS
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //ESTABLECER EL COMANDO PARA EJECUTAR EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminar_parte";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                
                SqlParameter ParId_item = new SqlParameter();
                ParId_item.ParameterName = "@id_item";
                ParId_item.SqlDbType = SqlDbType.Int;
                ParId_item.Value = Venta.Id_Buscar;
                SqlCmd.Parameters.Add(ParId_item);

                //AHORA VAMOS A EJECUTAR EL COMANDO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro del cliente";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally //LIMPIAR RECURSOS CERRAR LA CONEXION
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

        //METODO PARA MODIFICAR FECHA DE ÚLTIMA COMPRA DEL CLIENTE
        public string ModificarFechaUltimaCompra(DVenta Venta)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //INICIO DEL CODIGO PARA INSERTAR
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //AHORA SE ESTABLECE EL COMANDO PARA EL PROCESO ALMACENADO modificar_fechaUltimaCompra
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "modificar_fechaUltimaCompra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //ESTABLECEMOS LOS PARAMETROS QUE SE USARAN EN EL PROCESO ALMACENADO DE LA MODIFICACIÓN QUE SE REALIZARA
                SqlParameter ParCUC = new SqlParameter();
                ParCUC.ParameterName = "@cuc";
                ParCUC.SqlDbType = SqlDbType.Int;
                ParCUC.Value = Venta.CUC;
                SqlCmd.Parameters.Add(ParCUC);

                

                SqlParameter ParFUC = new SqlParameter();
                ParFUC.ParameterName = "@fecha_ultima_compra";
                ParFUC.SqlDbType = SqlDbType.VarChar;
                ParFUC.Size = 20;
                ParFUC.Value = Venta.Fecha;
                SqlCmd.Parameters.Add(ParFUC);

                //AHORA EJECUTAMOS EL COMANDO PARA INGRESAR EL REGISTRO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudieron actualizar los datos del cliente";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally //limpiar los recursos
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

        //METODO ELIMINAR PARTES DESPUES DE LA VENTA
        public string EliminarPartesFull(DVenta Venta)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //CODIGO PARA ESTABLECER UNA CONEXION CON LA BASE DE DATOS
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //ESTABLECER EL COMANDO PARA EJECUTAR EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminar_partes_full";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParCua = new SqlParameter();
                ParCua.ParameterName = "@cua";
                ParCua.SqlDbType = SqlDbType.Int;
                ParCua.Value = Venta.Id_Buscar;
                SqlCmd.Parameters.Add(ParCua);

                //AHORA VAMOS A EJECUTAR EL COMANDO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro del cliente";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally //LIMPIAR RECURSOS CERRAR LA CONEXION
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

        //INICIO DEL METODO INSERTAR EL PRESUPUESTO
        public string insertarPresupuesto(DVenta Venta)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                //CODIGO
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //AHORA ESTABLECEMOS EL COMANDO PARA EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "registrar_presupuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //establecer los parametros que manejaremos en el proceso almacenado
                SqlParameter ParId_Presupuesto = new SqlParameter();
                ParId_Presupuesto.ParameterName = "@id_presupuesto";
                ParId_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Presupuesto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Presupuesto);

                SqlParameter ParFolio = new SqlParameter();
                ParFolio.ParameterName = "@folio";
                ParFolio.SqlDbType = SqlDbType.Int;
                ParFolio.Value = Venta.Folio;
                SqlCmd.Parameters.Add(ParFolio);

                SqlParameter ParId_Item = new SqlParameter();
                ParId_Item.ParameterName = "@id_item";
                ParId_Item.SqlDbType = SqlDbType.Int;
                ParId_Item.Value = Venta.Id_Item;
                SqlCmd.Parameters.Add(ParId_Item);

                SqlParameter ParParte = new SqlParameter();
                ParParte.ParameterName = "@parte";
                ParParte.SqlDbType = SqlDbType.VarChar;
                ParParte.Size = 20;
                ParParte.Value = Venta.Parte;
                SqlCmd.Parameters.Add(ParParte);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 20;
                ParMarca.Value = Venta.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 20;
                ParModelo.Value = Venta.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParAnio = new SqlParameter();
                ParAnio.ParameterName = "@anio";
                ParAnio.SqlDbType = SqlDbType.Int;
                ParAnio.Value = Venta.Anio;
                SqlCmd.Parameters.Add(ParAnio);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.VarChar;
                ParPrecio.Size = 20;
                ParPrecio.Value = Venta.Precio;
                SqlCmd.Parameters.Add(ParPrecio);



                //EJECUTAR COMANDO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar la corización";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally //limpiar los recursos despues de realizar la conexion
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

        //METODO PARA REALIZAR LA BUSQUEDA POR FOLIO DEL PRESUPUESTO
        public DataTable ConsultaEspPresupuesto(DVenta Venta)
        {
            DataTable DtResultado = new DataTable("Presupuesto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //VAMOS A ESTABLECER LA CONEXION PRIMERAMENTE
                SqlCon.ConnectionString = Conexion.Cn;

                //AHORA ESTABLECEMOS EL COMANDO A EJECUTAR PARA EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "consulta_esp_presupuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //ESTABLECER EL PARAMETRO DE BUSQUEDA EN EL PROCESO ALMACENADO
                SqlParameter ParFolio = new SqlParameter();
                ParFolio.ParameterName = "@folio";
                ParFolio.SqlDbType = SqlDbType.Int;
                ParFolio.Value = Venta._Folio;
                SqlCmd.Parameters.Add(ParFolio);

                //EJECUTAMOS EL COMANDO Y LLENAMOS EL DATATABLE
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //METODO ELIMINAR PRESUPUESTO
        public string EliminarPresupuesto(DVenta Venta)
        {

            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //CODIGO PARA ESTABLECER UNA CONEXION CON LA BASE DE DATOS
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //ESTABLECER EL COMANDO PARA EJECUTAR EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminar_presupuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                //ESTABLECER EL PARAMETRO DE BUSQUEDA EN EL PROCESO ALMACENADO
                SqlParameter ParFolio = new SqlParameter();
                ParFolio.ParameterName = "@folio";
                ParFolio.SqlDbType = SqlDbType.Int;
                ParFolio.Value = Venta._Folio;
                SqlCmd.Parameters.Add(ParFolio);

                //AHORA VAMOS A EJECUTAR EL COMANDO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro del cliente";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally //LIMPIAR RECURSOS CERRAR LA CONEXION
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

        //METODO ELIMINAR PARTES DEL PRESUPUESTO GUARDADO
        public string EliminarPartesPresupuesto(DVenta Venta)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //CODIGO PARA ESTABLECER UNA CONEXION CON LA BASE DE DATOS
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //ESTABLECER EL COMANDO PARA EJECUTAR EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminar_esp_presupuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParId_item = new SqlParameter();
                ParId_item.ParameterName = "@id_item";
                ParId_item.SqlDbType = SqlDbType.Int;
                ParId_item.Value = Venta.Id_Buscar;
                SqlCmd.Parameters.Add(ParId_item);

                //AHORA VAMOS A EJECUTAR EL COMANDO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro del cliente";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally //LIMPIAR RECURSOS CERRAR LA CONEXION
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }
    }
}
