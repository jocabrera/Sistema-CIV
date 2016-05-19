using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DAuto
    {
        private int _CUA;
        private string _Marca;
        private string _Modelo;
        private int _Anio;
        private string _Color;
        private string _TipoAuto;
        private string _NumeroDeSerie;
        private string _CantidadCilindros;
        private string _FechaCompra;
        private string _Vendedor;
        private string _TelVendedor;
        private string _DirVendedor;
        private string _CUABuscar;
        private string _Parte;
        private string _Condicion;
        private string _Precio;
        private string _CostoAuto;
        private int _CucAuto;
        private int _AnioInicial;
        private int _AnioFinal;

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

        public string FechaCompra
        {
            get { return _FechaCompra; }
            set { _FechaCompra = value; }
        }

        public string CostoAuto
        {
            get { return _CostoAuto; }
            set { _CostoAuto = value; }
        }

        public string Vendedor
        {
            get { return _Vendedor; }
            set { _Vendedor = value; }
        }

        public string TelVendedor
        {
            get { return _TelVendedor; }
            set { _TelVendedor = value; }
        }

        public string DirVendedor
        {
            get { return _DirVendedor; }
            set { _DirVendedor = value; }
        }

        public string CUABuscar
        {
            get { return _CUABuscar; }
            set { _CUABuscar = value; }
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

        public int CucAuto
        {
            get { return _CucAuto; }
            set { _CucAuto = value; }
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

        //CONSTRUCTOR VACIO
        public DAuto()
        {

        }

        //CONSTRUCTOR CON PARAMETROS
        public DAuto(int claveUnicaAuto, string marca, string modelo, int anio, string color, string tipoAuto, string numeroSerie, 
                       string cantidadCilindros, string fechaCompra, string vendedor, string telefonoVendedor, string direccionVendedor, string cuabuscar, string costoAuto)
        {
            this.CUA = claveUnicaAuto;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
            this.Color = color;
            this.TipoAuto = tipoAuto;
            this.NumeroDeSerie = numeroSerie;
            this.CantidadCilindros = cantidadCilindros;
            this.FechaCompra = fechaCompra;
            this.CostoAuto = costoAuto;
            this.Vendedor = vendedor;
            this.TelVendedor = telefonoVendedor;
            this.DirVendedor = direccionVendedor;
            this.CUABuscar = cuabuscar;
        }

        //INICIO DEL METODO INSERTAR DATOS DEL AUTO
        public string Insertar (DAuto Automovil)
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
                SqlCmd.CommandText = "registrar_auto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //establecer los parametros que manejaremos en el proceso almacenado
                SqlParameter ParCUA = new SqlParameter();
                ParCUA.ParameterName = "@cua";
                ParCUA.SqlDbType = SqlDbType.Int;
                ParCUA.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCUA);

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
                ParAnio.ParameterName = "@anio";
                ParAnio.SqlDbType = SqlDbType.Int;
                ParAnio.Value = Automovil.Anio;
                SqlCmd.Parameters.Add(ParAnio);

                SqlParameter ParColor = new SqlParameter();
                ParColor.ParameterName = "@color";
                ParColor.SqlDbType = SqlDbType.VarChar;
                ParColor.Size = 20;
                ParColor.Value = Automovil.Color;
                SqlCmd.Parameters.Add(ParColor);

                SqlParameter ParTipoAuto = new SqlParameter();
                ParTipoAuto.ParameterName = "@tipoauto";
                ParTipoAuto.SqlDbType = SqlDbType.VarChar;
                ParTipoAuto.Size = 20;
                ParTipoAuto.Value = Automovil.TipoAuto;
                SqlCmd.Parameters.Add(ParTipoAuto);

                SqlParameter ParNumeroDeSerie = new SqlParameter();
                ParNumeroDeSerie.ParameterName = "@numeroserie";
                ParNumeroDeSerie.SqlDbType = SqlDbType.VarChar;
                ParNumeroDeSerie.Size = 20;
                ParNumeroDeSerie.Value = Automovil.NumeroDeSerie;
                SqlCmd.Parameters.Add(ParNumeroDeSerie);

                SqlParameter ParCantidadCilindros = new SqlParameter();
                ParCantidadCilindros.ParameterName = "@cantcilindros";
                ParCantidadCilindros.SqlDbType = SqlDbType.VarChar;
                ParCantidadCilindros.Size = 20;
                ParCantidadCilindros.Value = Automovil.CantidadCilindros;
                SqlCmd.Parameters.Add(ParCantidadCilindros);

                SqlParameter ParFechaCompra = new SqlParameter();
                ParFechaCompra.ParameterName = "@fechacompra";
                ParFechaCompra.SqlDbType = SqlDbType.Date;
                ParFechaCompra.Value = Automovil.FechaCompra;
                SqlCmd.Parameters.Add(ParFechaCompra);

                SqlParameter ParCostoAuto = new SqlParameter();
                ParCostoAuto.ParameterName = "@costoauto";
                ParCostoAuto.SqlDbType = SqlDbType.VarChar;
                ParCostoAuto.Size = 20;
                ParCostoAuto.Value = Automovil.CostoAuto;
                SqlCmd.Parameters.Add(ParCostoAuto);

                SqlParameter ParVendedor = new SqlParameter();
                ParVendedor.ParameterName = "@vendedor";
                ParVendedor.SqlDbType = SqlDbType.VarChar;
                ParVendedor.Size = 20;
                ParVendedor.Value = Automovil.Vendedor;
                SqlCmd.Parameters.Add(ParVendedor);

                SqlParameter ParTelVendedor = new SqlParameter();
                ParTelVendedor.ParameterName = "@telvendedor";
                ParTelVendedor.SqlDbType = SqlDbType.VarChar;
                ParTelVendedor.Size = 20;
                ParTelVendedor.Value = Automovil.TelVendedor;
                SqlCmd.Parameters.Add(ParTelVendedor);

                SqlParameter ParDirVendedor = new SqlParameter();
                ParDirVendedor.ParameterName = "@dirvendedor";
                ParDirVendedor.SqlDbType = SqlDbType.VarChar;
                ParDirVendedor.Size = 100;
                ParDirVendedor.Value = Automovil.DirVendedor;
                SqlCmd.Parameters.Add(ParDirVendedor);

                //EJECUTAR COMANDO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
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

        

        //METODO CONSULTA AUTOMOVIL POR MARCA, MODELO Y AÑOS
        public DataTable ConsultaAutoGral(DAuto Automovil)
        {
            DataTable DtResultado = new DataTable("Automovil");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_auto_gral";
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

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        //METODO CONSULTAR AUTOMOVIL POR SU CUA
        public DataTable ConsultarAutoCUA(DAuto Automovil)
        {
            DataTable DtResultado = new DataTable("Automovil");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_auto_cua";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCuaBuscar = new SqlParameter();
                ParCuaBuscar.ParameterName = "@cuabuscar";
                ParCuaBuscar.SqlDbType = SqlDbType.Int;
                ParCuaBuscar.Value = Automovil.CUABuscar;
                SqlCmd.Parameters.Add(ParCuaBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //METODO CONSULTAR AUTOMOVIL POR SU CUA EN LAS MODIFICACIONES
        public DataTable ConsultarAutoCUAModificar(DAuto Automovil)
        {
            DataTable DtResultado = new DataTable("Automovil");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_auto_modificar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCuaBuscar = new SqlParameter();
                ParCuaBuscar.ParameterName = "@cua";
                ParCuaBuscar.SqlDbType = SqlDbType.Int;
                ParCuaBuscar.Value = Automovil.CUABuscar;
                SqlCmd.Parameters.Add(ParCuaBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //INICIO DEL METODO INSERTAR LAS PARTES 
        public string insertarPartes(DAuto Partes)
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
                SqlCmd.CommandText = "registrar_partes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //establecer los parametros que manejaremos en el proceso almacenado
                SqlParameter ParId_Item = new SqlParameter();
                ParId_Item.ParameterName = "@id_item";
                ParId_Item.SqlDbType = SqlDbType.Int;
                ParId_Item.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Item);

                SqlParameter ParCUA = new SqlParameter();
                ParCUA.ParameterName = "@claveUnicaAuto";
                ParCUA.SqlDbType = SqlDbType.Int;
                ParCUA.Value = Partes.CucAuto;                
                SqlCmd.Parameters.Add(ParCUA);

                SqlParameter ParParte = new SqlParameter();
                ParParte.ParameterName = "@parte";
                ParParte.SqlDbType = SqlDbType.VarChar;
                ParParte.Size = 20;
                ParParte.Value = Partes.Parte;
                SqlCmd.Parameters.Add(ParParte);

                SqlParameter ParCondicion = new SqlParameter();
                ParCondicion.ParameterName = "@condicion";
                ParCondicion.SqlDbType = SqlDbType.VarChar;
                ParCondicion.Size = 20;
                ParCondicion.Value = Partes.Condicion;
                SqlCmd.Parameters.Add(ParCondicion);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.VarChar;
                ParPrecio.Size = 50;
                ParPrecio.Value = Partes.Precio;
                SqlCmd.Parameters.Add(ParPrecio);
                

                //EJECUTAR COMANDO
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
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

        //METODO PARA MODIFICAR DATOS DEL AUTO
        public string Modificar(DAuto Automovil)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //INICIO DEL CODIGO PARA INSERTAR
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //AHORA SE ESTABLECE EL COMANDO PARA EL PROCESO ALMACENADO modificar_auto
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "modificar_auto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //ESTABLECEMOS LOS PARAMETROS QUE SE USARAN EN EL PROCESO ALMACENADO modificar_auto
                SqlParameter ParCUA = new SqlParameter();
                ParCUA.ParameterName = "@cua";
                ParCUA.SqlDbType = SqlDbType.Int;
                ParCUA.Value = Automovil.CUA;
                SqlCmd.Parameters.Add(ParCUA);

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
                ParAnio.ParameterName = "@anio";
                ParAnio.SqlDbType = SqlDbType.Int;
                ParAnio.Value = Automovil.Anio;
                SqlCmd.Parameters.Add(ParAnio);

                SqlParameter ParColor = new SqlParameter();
                ParColor.ParameterName = "@color";
                ParColor.SqlDbType = SqlDbType.VarChar;
                ParColor.Size = 20;
                ParColor.Value = Automovil.Color;
                SqlCmd.Parameters.Add(ParColor);

                SqlParameter ParTipoAuto = new SqlParameter();
                ParTipoAuto.ParameterName = "@tipoauto";
                ParTipoAuto.SqlDbType = SqlDbType.VarChar;
                ParTipoAuto.Size = 20;
                ParTipoAuto.Value = Automovil.TipoAuto;
                SqlCmd.Parameters.Add(ParTipoAuto);

                SqlParameter ParNumeroDeSerie = new SqlParameter();
                ParNumeroDeSerie.ParameterName = "@numeroserie";
                ParNumeroDeSerie.SqlDbType = SqlDbType.VarChar;
                ParNumeroDeSerie.Size = 20;
                ParNumeroDeSerie.Value = Automovil.NumeroDeSerie;
                SqlCmd.Parameters.Add(ParNumeroDeSerie);
                

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

        //METODO PARA MOSTRAR LAS PARTES EN LA CONSULTA DEL AUTO
        public DataTable ConsultarPartes(DAuto Automovil)
        {
            DataTable DtResultado = new DataTable("Inventario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_partes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCuaBuscar = new SqlParameter();
                ParCuaBuscar.ParameterName = "@cua";
                ParCuaBuscar.SqlDbType = SqlDbType.Int;
                ParCuaBuscar.Value = Automovil.CUABuscar;
                SqlCmd.Parameters.Add(ParCuaBuscar);

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
