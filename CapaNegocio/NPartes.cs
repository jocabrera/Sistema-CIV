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
    public class NPartes
    {
        public static List<DPartes> CargarProductos(int id_parte)
        {
            List<DPartes> ListaProductos = new List<DPartes>();
            using (SqlConnection cnn = new SqlConnection("Data Source=CABRERA\\SQLEXPRESS; Initial Catalog=BDSistemaCIV; Integrated Security=true"))
            {
                cnn.Open();
                string ConsultaProductos = "SELECT * FROM Partes";
                SqlCommand cmd = new SqlCommand(ConsultaProductos, cnn);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    DPartes Partes = new DPartes();
                    Partes.id_parte = lector.GetInt32(0);
                    Partes.parte = lector.GetString(1);
                    ListaProductos.Add(Partes);
                }
            }
            return ListaProductos;
        }
    }
}
