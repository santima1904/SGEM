using CRUD_Personas_DAL.Conexion;
using Santaigo_Martinez_Aral_ExamenAsp_Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;

namespace Santaigo_Martinez_Aral_ExamenAsp_DAL.Listado
{
    public class clsListadoCategoriasDAL
    {
        /// <summary>
        /// <cadecera>public static ObservableCollection(clsCategoria) obtenerListadoCategoriasCompletoDAL()</cadecera>
        /// <descripcion>Método para recoger una lista completa de categorías de la base de datos</descripcion>
        /// <precondiciones>Ninguna</precondiciones>
        /// <postcondiciones>lista devuelta</postcondiciones>
        /// </summary>
        /// <returns>ObservableCollection(clsCategoria)</returns>
        public static ObservableCollection<clsCategoria> obtenerListadoCategoriasCompletoDAL()
        {
            ObservableCollection<clsCategoria> listadoCategorias = new ObservableCollection<clsCategoria>();
            clsMyConnection miConexion = new clsMyConnection();
            SqlConnection connection = miConexion.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            miComando.CommandText = "SELECT * FROM categorias";
            miComando.Connection = connection;
            miLector = miComando.ExecuteReader();

            if (miLector.HasRows)
            {
                while (miLector.Read())
                {
                    clsCategoria oCategoria = new clsCategoria();
                    oCategoria.IdCategoria = (int)miLector["idCategoria"];
                    oCategoria.NombreCategoria = (string)miLector["nombreCategoria"];
                    listadoCategorias.Add(oCategoria);

                }
            }
            miLector.Close();
            miConexion.closeConnection(ref connection);

            return listadoCategorias;
        }
    }
}
