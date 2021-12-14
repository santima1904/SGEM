using Santaigo_Martinez_Aral_ExamenAsp_Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CRUD_Personas_DAL.Conexion;

namespace Santaigo_Martinez_Aral_ExamenAsp_DAL.Gestora
{
    public class clsGestoraPlantasDAL
    {
        /// <summary>
        /// <cadecera>public int actualizarPrecioPlantaDAL(clsPlanta planta)</cadecera>
        /// <descripcion>Método para actualizar el precio de una planta de la base de datos</descripcion>
        /// <precondiciones>planta distinta de null</precondiciones>
        /// <postcondiciones>devuelve un entero con el número de filas afectadas , el precio queda actualizado</postcondiciones>
        /// </summary>
        /// <returns>int</returns>
        public static int actualizarPrecioPlantaDAL(clsPlanta planta)
        {
            int resultado = 0;
            clsMyConnection miConexion = new clsMyConnection();
            try
            {
                SqlConnection connection = miConexion.getConnection();
                SqlCommand miComando = new SqlCommand();
                miComando.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = planta.Precio;
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = planta.IdPlanta;
                miComando.CommandText = "Update plantas " +
                    "SET precio = @precio " +
                    "WHERE idPlanta = @id";
                miComando.Connection = connection;
                resultado = miComando.ExecuteNonQuery();
                miConexion.closeConnection(ref connection);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
