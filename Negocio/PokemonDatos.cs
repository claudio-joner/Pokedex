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
                comando.CommandText = "Select p.Numero,p.Nombre,p.Descripcion,p.UrlImagen, e.Descripcion Tipo,D.Descripcion Debilidad, p.IdTipo, p.IdDebilidad, p.Id " +
                                      "From POKEMONS p,ELEMENTOS e, ELEMENTOS d WHERE e.Id = p.IdTipo AND d.Id = p.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon auxiliar = new Pokemon();
                    auxiliar.Numero = lector.GetInt32(0);
                    auxiliar.Id = (int)lector["Id"];
                    auxiliar.Nombre = (string)lector["nombre"];
                    auxiliar.Descripcion = (string)lector[2];
                    //if(!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))
                    //    auxiliar.UrlImagen = (string)lector[3];
                    if (!(lector["UrlImagen"] is DBNull))
                    {
                        auxiliar.UrlImagen = (string)lector[3];
                    }
                    auxiliar.Tipo = new Elemento();
                    auxiliar.Tipo.Id = (int)lector[6];
                    auxiliar.Tipo.Descripcion = (string)lector[4];
                    auxiliar.Debilidad = new Elemento();
                    auxiliar.Debilidad.Id = (int)lector[7];
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
                datos.setearConsulta("Insert into Pokemons (Numero,Nombre,Descripcion,Activo,UrlImagen,IdTipo,IdDebilidad)values ("
                                    + nuevo.Numero +",'"+ nuevo.Nombre +"','"+ nuevo.Descripcion +"',1,'"+ nuevo.UrlImagen +"',@idTipo,@idDebilidad)");
                datos.setearParametro("@idTipo", nuevo.Tipo.Id);
                datos.setearParametro("@idDebilidad", nuevo.Debilidad.Id);
                
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

        public void modificarPokemon(Pokemon pokeModificar)
        {
            AccecsoDatos datos = new AccecsoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set " +
                                     "Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @imagen, IdTipo = @tipo, IdDebilidad = @deb " +
                                     "WHERE Id = @id");
                datos.setearParametro("@numero",pokeModificar.Numero);
                datos.setearParametro("@nombre", pokeModificar.Nombre);
                datos.setearParametro("@desc",pokeModificar.Descripcion);
                datos.setearParametro("@imagen",pokeModificar.UrlImagen);
                datos.setearParametro("@tipo",pokeModificar.Tipo.Id );
                datos.setearParametro("@deb",pokeModificar.Debilidad.Id);
                datos.setearParametro("@id",pokeModificar.Id);


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

        public void eliminar(int id)
        {
            try
            {
                AccecsoDatos datos = new AccecsoDatos();
                datos.setearConsulta("DELETE POKEMONS WHERE id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
