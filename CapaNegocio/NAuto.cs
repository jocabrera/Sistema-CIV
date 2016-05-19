using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class NAuto
    {

        //METODO PARA INSERTAR LAS PARTES DEL AUTO
        public static string insertarPartes(string parte, string condicion, string precio, int cuaAuto)
        {
            DAuto obj = new DAuto();
            obj.Parte = parte;
            obj.Condicion = condicion;
            obj.Precio = precio;
            obj.CucAuto = cuaAuto;
            return obj.insertarPartes(obj);
        }
        //METODO INSERTAR QUE LLAMA AL METODO INSERTAR DE LA CLASE DatAuto de la CapaDatos
        public static string Insertar(string marca, string modelo, int anio, string color, string tipoAuto, string numeroSerie,
                       string cantidadCilindros, string fechaCompra, string vendedor, string telefonoVendedor, string direccionVendedor, string costoAuto)
        {
            DAuto obj = new DAuto();
            obj.Marca = marca;
            obj.Modelo = modelo;
            obj.Anio = anio;
            obj.Color = color;
            obj.TipoAuto = tipoAuto;
            obj.NumeroDeSerie = numeroSerie;
            obj.CantidadCilindros = cantidadCilindros;
            obj.FechaCompra = fechaCompra;
            obj.Vendedor = vendedor;
            obj.TelVendedor = telefonoVendedor;
            obj.DirVendedor = direccionVendedor;
            obj.CostoAuto = costoAuto;
            System.Console.WriteLine("Negocio auto");

            return obj.Insertar(obj);
        }

        //CONSULTA POR MARCA,MODELO Y AÑO DE AUTOS
        public static DataTable ConsultaAutoGral(string marca, string modelo, int anioInicial, int anioFinal)
        {
            DAuto Obj = new DAuto();
            Obj.Marca=marca;
            Obj.Modelo = modelo;
            Obj.AnioInicial = anioInicial;
            Obj.AnioFinal = anioFinal;
            return Obj.ConsultaAutoGral(Obj);
        }

        //METODO ConsultarAutoCUA QUE LLAMA AL METODO ConsultarAutoCUA DE LA CLASE DatAuto de la CapaDatos
        public static DataTable ConsultarAutoCUA(string cuabuscar)
        {
            DAuto Obj = new DAuto();
            Obj.CUABuscar = cuabuscar;
            return Obj.ConsultarAutoCUA(Obj);
        }

        //METODO PARA CONSULTAR LOS DATOS QUE SE PUEDEN MODIFICAR EN MANTENIMIENTO AUTOS
        public static DataTable ConsultarAutoCUAModificar(string cuabuscar)
        {
            DAuto Obj = new DAuto();
            Obj.CUABuscar = cuabuscar;
            return Obj.ConsultarAutoCUAModificar(Obj);
        }

        //METODO PARA MODIFICAR DATOS DEL AUTO
        public static string Modificar(int cua, string marca, string modelo, string anio, string color, string tipoAuto, string numeroSerie)
        {
            int año = int.Parse(anio);
            DAuto Obj = new DAuto();
            Obj.CUA = cua;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Anio = año;
            Obj.Color = color;
            Obj.TipoAuto = tipoAuto;
            Obj.NumeroDeSerie = numeroSerie;
            return Obj.Modificar(Obj);
        }

        //EXTRAER EL ID DEL ULTIMO REGISTRO
        public static int cuaAuto()
        {
              int Cua;
              SqlConnection conexion = new SqlConnection("Data Source=CABRERA\\SQLEXPRESS; Initial Catalog=BDSistemaCIV; Integrated Security=true");
              conexion.Open();
              SqlCommand _comando = new SqlCommand("select MAX(claveUnicaAuto) from Automovil", conexion);
              Cua = (int)_comando.ExecuteScalar();
              conexion.Close();
              return Cua;          
        }

        //CONSULTAR PARTES DEL AUTO 
        public static DataTable ConsultarPartes(string cuabuscar)
        {
            DAuto Obj = new DAuto();
            Obj.CUABuscar = cuabuscar;
            return Obj.ConsultarPartes(Obj);
        }        
    }
}
