using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCliente
    {
        private int _CUC;
        private string _Nombre;
        private string _Direccion;
        private string _Telefono;
        private string _Descuento;
        private int _CUCbuscar;
        private string _Fecha_Ultima_Compra;

        public int CUC
        {
            get { return _CUC; }
            set { _CUC = value; }
        }

        public int CUCbuscar
        {
            get { return _CUCbuscar; }
            set { _CUCbuscar = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

        public string Fecha_Ultima_Compra
        {
            get { return _Fecha_Ultima_Compra; }
            set { _Fecha_Ultima_Compra = value; }
        }

        //CONSTRUCTOR VACIO
        public DCliente()
        {

        }

        //CONSTRUCTOR CON SUS PARAMETROS
        public DCliente(int cuc, string nombre, string direccion, string telefono, string descuento, string fecha_ultima_compra)
        {
            this._CUC = CUC;
            this._Nombre = nombre;
            this._Direccion = direccion;
            this._Telefono = telefono;
            this._Descuento = descuento;
            this._Fecha_Ultima_Compra = fecha_ultima_compra;
        }

        //METODO PARA INSERTAR LOS DATOS DEL CLIENTE DESDE EL FORMULARIO
        public string Insertar(DCliente Cliente)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //INICIO DEL CODIGO PARA INSERTAR
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //AHORA SE ESTABLECE EL COMANDO PARA EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "registrar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //ESTABLECEMOS LOS PARAMETROS QUE SE USARAN EN EL PROCESO ALMACENADO registrar_cliente
                SqlParameter ParCUC = new SqlParameter();
                ParCUC.ParameterName = "@cuc";
                ParCUC.SqlDbType = SqlDbType.Int;
                ParCUC.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCUC);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@descuento";
                ParDescuento.SqlDbType = SqlDbType.VarChar;
                ParDescuento.Size = 20;
                ParDescuento.Value = Cliente.Descuento;
                SqlCmd.Parameters.Add(ParDescuento);

                SqlParameter ParFUC = new SqlParameter();
                ParFUC.ParameterName = "@fecha_ultima_compra";
                ParFUC.SqlDbType = SqlDbType.VarChar;
                ParFUC.Size = 20;
                ParFUC.Value = Cliente.Fecha_Ultima_Compra;
                SqlCmd.Parameters.Add(ParFUC);

                //AHORA EJECUTAMOS EL COMANDO PARA INGRESAR EL REGISTRO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally //AQUI LIMPIAREMOS LOS RECURSOS DESPUES DE HABER REALIZADO LA CONEXION
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

        //METODO PARA MODIFICAR DATOS DEL CLIENTE
        public string Modificar (DCliente Cliente)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //INICIO DEL CODIGO PARA INSERTAR
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //AHORA SE ESTABLECE EL COMANDO PARA EL PROCESO ALMACENADO modificar_cliente
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "modificar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //ESTABLECEMOS LOS PARAMETROS QUE SE USARAN EN EL PROCESO ALMACENADO modificar_cliente
                SqlParameter ParCUC = new SqlParameter();
                ParCUC.ParameterName = "@cuc";
                ParCUC.SqlDbType = SqlDbType.Int;
                ParCUC.Value = Cliente.CUC;
                SqlCmd.Parameters.Add(ParCUC);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@descuento";
                ParDescuento.SqlDbType = SqlDbType.VarChar;
                ParDescuento.Size = 20;
                ParDescuento.Value = Cliente.Descuento;
                SqlCmd.Parameters.Add(ParDescuento);

                SqlParameter ParFUC = new SqlParameter();
                ParFUC.ParameterName = "@fecha_ultima_compra";
                ParFUC.SqlDbType = SqlDbType.VarChar;
                ParFUC.Size = 20;
                ParFUC.Value = Cliente.Fecha_Ultima_Compra;
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

        //METODO ELIMINAR REGISTRO DE CLIENTE
        public string Eliminar (DCliente Cliente)
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
                SqlCmd.CommandText = "eliminar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //ESTABLECER EL PARAMETRO POR ELIMINACION DE CLIENTE
                SqlParameter ParCUC = new SqlParameter();
                ParCUC.ParameterName = "@cuc";
                ParCUC.SqlDbType = SqlDbType.Int;
                ParCUC.Value = Cliente.CUCbuscar;
                SqlCmd.Parameters.Add(ParCUC);

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

        //METODO CONSULTAR CLIENTES
        public DataTable ConsultaGral()
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //ESTABLECEMOS LA CONEXION PRIMERAMENTE
                SqlCon.ConnectionString = Conexion.Cn;

                //AHORA ESTABLECEMOS EL COMANDO PARA EL PROCESO ALMACENADO consulta_gral_cliente
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "consulta_gral_cliente";
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

        //METODO PARA REALIZAR LA BUSQUEDA POR CLAVE UNICA DE CLIENTE (CUC)
        public DataTable ConsultaEsp(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //VAMOS A ESTABLECER LA CONEXION PRIMERAMENTE
                SqlCon.ConnectionString = Conexion.Cn;

                //AHORA ESTABLECEMOS EL COMANDO A EJECUTAR PARA EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "consulta_esp_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure; 

                //ESTABLECER EL PARAMETRO DE BUSQUEDA EN EL PROCESO ALMACENADO
                SqlParameter ParCUC = new SqlParameter();
                ParCUC.ParameterName = "@cuc";
                ParCUC.SqlDbType = SqlDbType.Int;
                ParCUC.Value = Cliente.CUCbuscar;
                SqlCmd.Parameters.Add(ParCUC);

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
    }
}
