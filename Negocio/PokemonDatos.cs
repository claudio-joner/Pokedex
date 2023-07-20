using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dominio;


namespace Negocio
{
    public class PokemonDatos
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
                comando.CommandText = "Select p.Numero,p.Nombre,p.Descripcion,p.UrlImagen, e.Descripcion Tipo,D.Descripcion Debilidad " +
                                      "From POKEMONS p,ELEMENTOS e, ELEMENTOS d WHERE e.Id = p.IdTipo AND d.Id = p.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon auxiliar = new Pokemon();
                    auxiliar.Numero = lector.GetInt32(0);
                    auxiliar.Nombre = (string)lector["nombre"];
                    auxiliar.Descripcion = (string)lector[2];
                    auxiliar.UrlImagen = (string)lector[3];
                    auxiliar.Tipo = new Elemento();
                    auxiliar.Tipo.Descripcion = (string)lector[4];
                    auxiliar.Debilidad = new Elemento();
                    auxiliar.Debilidad.Descripcion = (string)lector["Debilidad"];
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

        public void agregarPokemon(Pokemon nuevo)
        {
            AccecsoDatos datos = new AccecsoDatos();
            try
            {
                datos.setearConsulta("Insert into Pokemons (Numero,Nombre,Descripcion,Activo)values ("+ nuevo.Numero+",'"+nuevo.Nombre +"',"+nuevo.Descripcion+",1)");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
