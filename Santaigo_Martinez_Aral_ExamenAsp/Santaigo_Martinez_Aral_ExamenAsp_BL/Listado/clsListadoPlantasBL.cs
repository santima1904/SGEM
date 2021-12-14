using System;
using System.Collections.Generic;
using System.Text;
using Santaigo_Martinez_Aral_ExamenAsp_Entidades;
using Santaigo_Martinez_Aral_ExamenAsp_DAL.Listado;
using System.Collections.ObjectModel;

namespace Santaigo_Martinez_Aral_ExamenAsp_BL.Listado
{
    public class clsListadoPlantasBL
    {
        /// <summary>
        /// <cadecera>public static ObservableCollection(clsPlanta) obtenerListadoPlantasPorCategoriaBL(int idCategoria)</cadecera>
        /// <descripcion>Método para llamar al método de recoger una lista de plantas en la capa DAL con la categoría dada</descripcion>
        /// <precondiciones>idCategoria positivo o 0</precondiciones>
        /// <postcondiciones>lista devuelta</postcondiciones>
        /// </summary>
        /// <param name="idCategoria">int</param>
        /// <returns>ObservableCollection(clsPersona)</returns>
        public static ObservableCollection<clsPlanta> obtenerListadoPlantasPorCategoriaBL(int idCategoria)
        {
            return clsListadoPlantasDAL.obtenerListadoPlantasPorCategoriaDAL(idCategoria);
        }


        /// <summary>
        /// <cadecera>public static clsPlanta obtenerPlantaBL(int id)</cadecera>
        /// <descripcion>Método para obtener una planta de la BL a partir de un id dado</descripcion>
        /// <precondiciones>id positivo</precondiciones>
        /// <postcondiciones>objeto planta obtenido</postcondiciones>
        /// </summary>
        /// <returns>clsPlanta</returns>
        public static clsPlanta obtenerPlanta(int id)
        {
            return clsListadoPlantasDAL.obtenerPlantaDAL(id);
        }
    }
}
