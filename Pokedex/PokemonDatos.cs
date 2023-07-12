using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Pokedex
{
    class PokemonDatos
    {
        public List<Pokemon> Listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "Data Source=DESKTOP-6KIGGOG\\MSSQLSERVER01;Initial Catalog=POKEDEX_DB;Integrated Security=True; Encrypt=False";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select numero, nombre, descripcion From POKEMONS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon auxiliar = new Pokemon();
                    auxiliar.Numero = lector.GetInt32(0);
                    auxiliar.Nombre = (string)lector["nombre"];
                    auxiliar.Descripcion = (string)lector[2];

                    lista.Add(auxiliar);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }
    }
}
