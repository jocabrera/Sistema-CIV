using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DInventario
    {
        private int _Id_item;
        private string _Parte;
        private string _Condicion;
        private string _Precio;

        public int Id_item
        {
            get { return _Id_item; }
            set { _Id_item = value; }
        }

        public string Parte
        {
            get { return _Parte; }
            set { _Parte = value; }
        }

        public string Condicion
        {
            get { return _Condicion; }
            set { _Condicion = value; }
        }

        public string Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        //CONSTRUCTOR VACIO
        public DInventario()
        {

        }

        //CONSTRUCTOR CON PARAMETROS
        public DInventario (int id_item, string parte, string condicion, string precio)
        {
            this._Id_item = id_item;
            this._Parte = parte;
            this._Condicion = precio;
            this._Precio = precio;
        }

        public string Insertar(DInventario Inventario)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //INICIO DEL CODIGO PARA INSERTAR PARTES
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //AHORA SE ESTABLECE EL COMANDO PARA EL PROCESO ALMACENADO
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "registrar_partes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //ESTABLECEMOS LOS PARAMETROS QUE SE USARAN EN EL PROCESO ALMACENADO registrar_cliente
                SqlParameter ParId_item = new SqlParameter();
                ParId_item.ParameterName = "@id_item";
                ParId_item.SqlDbType = SqlDbType.Int;
                ParId_item.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_item);

                SqlParameter ParParte = new SqlParameter();
                ParParte.ParameterName = "@parte";
                ParParte.SqlDbType = SqlDbType.VarChar;
                ParParte.Size = 20;
                ParParte.Value = Inventario.Parte;
                SqlCmd.Parameters.Add(ParParte);

                SqlParameter ParCondicion = new SqlParameter();
                ParCondicion.ParameterName = "@condicion";
                ParCondicion.SqlDbType = SqlDbType.VarChar;
                ParCondicion.Size = 20;
                ParCondicion.Value = Inventario.Condicion;
                SqlCmd.Parameters.Add(ParCondicion);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.VarChar;
                ParPrecio.Size = 50;
                ParPrecio.Value = Inventario.Precio;
                SqlCmd.Parameters.Add(ParPrecio);

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

        public DataTable ConsultaPartesVenta()
        {
            DataTable DtResultado = new DataTable("Inventario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_partes_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

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
