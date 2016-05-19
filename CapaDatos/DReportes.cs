using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DReportes
    {
        string _FechaInicioCompra;
        string _FechaFinalCompra;
        string _FechaInicioVenta;
        string _FechaFinalVenta;

        public string FechaInicioCompra
        {
            get { return _FechaInicioCompra; }
            set { _FechaInicioCompra = value; }
        }

        public string FechaFinalCompra
        {
            get { return _FechaFinalCompra; }
            set { _FechaFinalCompra = value; }
        }

        public string FechaInicioVenta
        {
            get { return _FechaInicioVenta; }
            set { _FechaInicioVenta = value; }
        }

        public string FechaFinalVenta
        {
            get { return _FechaFinalVenta; }
            set { _FechaFinalVenta = value; }
        }

        public DReportes()
        {

        }

        public DReportes(string fechafinalcompra, string fechainiciocompra, string fechainicioventa, string fechafinalventa)
        {
            this.FechaInicioCompra = fechainiciocompra;
            this.FechaFinalCompra = fechafinalcompra;
            this.FechaInicioVenta = fechainicioventa;
            this.FechaFinalVenta = fechafinalventa;
        }

        //Metodo para mostrar el contenido de las tablas SQL en el form interfaz_Reportes
        public DataTable MostrarCompras()
        {
            DataTable DtResultadoCompras = new DataTable("Automovil");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_compras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultadoCompras);
            }
            catch (Exception ex)
            {
                DtResultadoCompras = null;
            }
            return DtResultadoCompras;
        }

        public DataTable MostrarVentas()
        {
            DataTable DtResultadoVentas = new DataTable("Venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_ventas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultadoVentas);
            }
            catch (Exception ex)
            {
                DtResultadoVentas = null;
            }
            return DtResultadoVentas;
        }

        public DataTable BuscarCompras(DReportes Categoria)
        {
            DataTable DtResultado = new DataTable("Automovil");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_compras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFechaInicio = new SqlParameter();
                ParFechaInicio.ParameterName = "@fechainiciocompra";
                ParFechaInicio.SqlDbType = SqlDbType.VarChar;
                ParFechaInicio.Size = 20;
                ParFechaInicio.Value = Categoria.FechaInicioCompra;
                SqlCmd.Parameters.Add(ParFechaInicio);

                SqlParameter ParFechaFinal = new SqlParameter();
                ParFechaFinal.ParameterName = "@fechafinalcompra";
                ParFechaFinal.SqlDbType = SqlDbType.VarChar;
                ParFechaFinal.Size = 20;
                ParFechaFinal.Value = Categoria.FechaFinalCompra;
                SqlCmd.Parameters.Add(ParFechaFinal);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable BuscarVentas(DReportes Ventas)
        {
            DataTable DtResultado = new DataTable("Venta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_ventas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFechaInicioVenta = new SqlParameter();
                ParFechaInicioVenta.ParameterName = "@fechainicioventa";
                ParFechaInicioVenta.SqlDbType = SqlDbType.VarChar;
                ParFechaInicioVenta.Size = 20;
                ParFechaInicioVenta.Value = Ventas.FechaInicioVenta;
                SqlCmd.Parameters.Add(ParFechaInicioVenta);

                SqlParameter ParFechaFinalVenta = new SqlParameter();
                ParFechaFinalVenta.ParameterName = "@fechafinalventa";
                ParFechaFinalVenta.SqlDbType = SqlDbType.VarChar;
                ParFechaFinalVenta.Size = 20;
                ParFechaFinalVenta.Value = Ventas.FechaFinalVenta;
                SqlCmd.Parameters.Add(ParFechaFinalVenta);

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
