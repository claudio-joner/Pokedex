using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {
			List<Elemento> lista = new List<Elemento>();
			AccecsoDatos datos = new AccecsoDatos();
			string consulta = "Select * from Elementos";
			try
			{
				datos.setearConsulta(consulta);
				datos.ejecutarLectura();

				while(datos.Lector.Read())
				{
					Elemento aux = new Elemento();
					aux.Id = (int)datos.Lector[0];
					aux.Descripcion = (string)datos.Lector[1];
					lista.Add(aux);
				}

				return lista;
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
