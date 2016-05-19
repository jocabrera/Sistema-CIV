using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DVentaAutos
    {
        private int _CUA;
        private string _Marca;
        private string _Modelo;
        private int _Anio;
        private string _NumeroDeSerie;
        private string _CantidadCilindros;
        private string _Color;
        private string _TipoAuto;
        private string _FechaCompra;

        public int CUA
        {
            get { return _CUA; }
            set { _CUA = value; }
        }

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

        public string NumeroDeSerie
        {
            get { return _NumeroDeSerie; }
            set { _NumeroDeSerie = value; }
        }

        public string CantidadCilindros
        {
            get { return _CantidadCilindros; }
            set { _CantidadCilindros = value; }
        }

        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public string TipoAuto
        {
            get { return _TipoAuto; }
            set { _TipoAuto = value; }
        }

        public string FechaCompra
        {
            get { return _FechaCompra; }
            set { _FechaCompra = value; }
        }

        //CONSTRUCTOR VACIO
        public DVentaAutos()
        {

        }
        //CONSTRUCTOR CON PARAMETROS
        public DVentaAutos(int claveUnicaAuto, string marca, string modelo, int anio, string numeroSerie, string cantidadCilindros, string color, string tipoAuto, string fechaCompra)
        {
            this.CUA = claveUnicaAuto;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
            this.NumeroDeSerie = numeroSerie;
            this.CantidadCilindros = cantidadCilindros;
            this.Color = color;
            this.TipoAuto = tipoAuto;
            this.FechaCompra = fechaCompra;
        }

        //METODO ELIMINAR LOS AUTOS DE VENTA CHATARRA
        public string eliminarAutos(DVentaAutos Automovil)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
               
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminar_auto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCua = new SqlParameter();
                ParCua.ParameterName = "@cua";
                ParCua.SqlDbType = SqlDbType.Int;
                ParCua.Value = Automovil.CUA;
                SqlCmd.Parameters.Add(ParCua);

                //EJECUTAMOS EL COMANDO 
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el registro.";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //METODO PARA MOSTRAR LOS AUTOS CHATARRA PARA VENTA
        public DataTable mostrarAutos()
        {
            DataTable DtResultado = new DataTable("Automovil");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_autos";
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

