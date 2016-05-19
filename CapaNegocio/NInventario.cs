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
    public class NInventario
    {
        //METODO INSERTAR QUE LLAMA AL METODO INSERTAR DE LA CLASE DInventario de la CapaDatos
        public static string Insertar(string parte, string condicion, string precio)
        {
            DInventario obj = new DInventario();
            obj.Parte = parte;
            obj.Condicion = condicion;
            obj.Precio = precio;
            System.Console.WriteLine("Negocio inventario");

            return obj.Insertar(obj);
        }

        public static List<DMarcas> ObtenerMarcas()
        {
            List<DMarcas> _lista = new List<DMarcas>();

            SqlConnection conexion = new SqlConnection("Data Source=LUIS-PC\\SQLEXPRESS; Initial Catalog=BDSistemaCIV; Integrated Security=true");
            conexion.Open();

            SqlCommand _comando = new SqlCommand("select id_marca , marca from Marcas", conexion); 
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                DMarcas Marcas = new DMarcas();
                Marcas.id_marca = _reader.GetInt32(0);
                Marcas.marca = _reader.GetString(1);
                _lista.Add(Marcas);
            }
            conexion.Close();
            return _lista;
        }

        public static List<DModelos> ObtenerModelos(int id_marca)
        {
            List<DModelos> _lista = new List<DModelos>();

            SqlConnection conexion = new SqlConnection("Data Source=CABRERA\\SQLEXPRESS; Initial Catalog=BDSistemaCIV; Integrated Security=true");
            conexion.Open();

            SqlCommand _comando = new SqlCommand("select id_modelo, modelo from Modelos where id_marca ="+id_marca,conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                DModelos Modelos = new DModelos();
                Modelos.id_modelo = _reader.GetInt32(0);
                Modelos.modelo = _reader.GetString(1);
                _lista.Add(Modelos);
            }
            conexion.Close();
            return _lista;
        }

        public static DataTable ConsultaPartesVenta()
        {
            return new DInventario().ConsultaPartesVenta();
        }
    }
}
