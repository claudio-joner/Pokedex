﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Negocio
{
    public class AccecsoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private string cadenaConexion = "Data Source=DESKTOP-6KIGGOG\\MSSQLSERVER01;Initial Catalog=POKEDEX_DB;Integrated Security=True; Encrypt=False";
        //private string cadenaConexion = "Data Source=LAPTOP-E09L8OSG;Initial Catalog=POKEDEX_DB;Integrated Security=True;Encrypt=False"; 



        public SqlDataReader Lector { get => lector; }

        public AccecsoDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();    
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CerrarConexion()
        {
            if(lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre,valor);

        }
    }
}
