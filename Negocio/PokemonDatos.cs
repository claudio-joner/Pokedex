using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dominio;
using System.Collections;


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
                //conexion.ConnectionString = "Data Source=LAPTOP-E09L8OSG;Initial Catalog=POKEDEX_DB;Integrated Security=True; Encrypt=False";
                
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select p.Numero,p.Nombre,p.Descripcion,p.UrlImagen, e.Descripcion Tipo,D.Descripcion Debilidad, p.IdTipo, p.IdDebilidad, p.Id " +
                                      "From POKEMONS p,ELEMENTOS e, ELEMENTOS d WHERE e.Id = p.IdTipo AND d.Id = p.IdDebilidad AND p.Activo=1";
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

        public void elimnarLogico(int id)
        {
            try
            {
                AccecsoDatos datos = new AccecsoDatos();
                datos.setearConsulta("UPDATE POKEMONS SET ACTIVO = 0  WHERE id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Pokemon> filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> list = new List<Pokemon>();
            AccecsoDatos datos = new AccecsoDatos();
            try
            {
                string consulta = "Select p.Numero,p.Nombre,p.Descripcion,p.UrlImagen, e.Descripcion Tipo,D.Descripcion Debilidad, " +
                                  "p.IdTipo, p.IdDebilidad, p.Id FROM POKEMONS p,ELEMENTOS e, ELEMENTOS d WHERE e.Id = p.IdTipo AND " +
                                  "d.Id = p.IdDebilidad AND p.Activo=1 AND";
                switch (campo)
                {
                    case "Número":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += " p.Numero > " + filtro;
                                break;
                            case "Menor a":
                                consulta += " p.Numero < " + filtro;
                                break;
                            default:
                                consulta += " p.Numero == " + filtro;
                                break;
                        }
                        break;
                    case "Descripción":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += " p.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " p.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += " p.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    //case "Nombre":
                        
                    default:
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += " p.Nombre like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " p.Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += " p.Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;  
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon auxiliar = new Pokemon();
                    auxiliar.Numero = datos.Lector.GetInt32(0);
                    auxiliar.Id = (int)datos.Lector["Id"];
                    auxiliar.Nombre = (string)datos.Lector["nombre"];
                    auxiliar.Descripcion = (string)datos.Lector[2];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                    {
                        auxiliar.UrlImagen = (string)datos.Lector[3];
                    }
                    auxiliar.Tipo = new Elemento();
                    auxiliar.Tipo.Id = (int)datos.Lector[6];
                    auxiliar.Tipo.Descripcion = (string)datos.Lector[4];
                    auxiliar.Debilidad = new Elemento();
                    auxiliar.Debilidad.Id = (int)datos.Lector[7];
                    auxiliar.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    list.Add(auxiliar);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
