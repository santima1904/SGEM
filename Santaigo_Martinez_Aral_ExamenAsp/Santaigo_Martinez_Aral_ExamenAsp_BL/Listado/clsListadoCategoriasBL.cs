using System;
using System.Collections.Generic;
using System.Text;
using Santaigo_Martinez_Aral_ExamenAsp_Entidades;
using Santaigo_Martinez_Aral_ExamenAsp_DAL.Listado;
using System.Collections.ObjectModel;

namespace Santaigo_Martinez_Aral_ExamenAsp_BL.Listado
{
    public class clsListadoCategoriasBL
    {
        /// <summary>
        /// <cadecera>public static ObservableCollection(clsCategoria) obtenerListadoCategoriasCompletoBL()</cadecera>
        /// <descripcion>Método para llamar a un método de la capa DAL para  recoger una lista completa de categorías</descripcion>
        /// <precondiciones>Ninguna</precondiciones>
        /// <postcondiciones>lista devuelta</postcondiciones>
        /// </summary>
        /// <returns>ObservableCollection(clsCategoria)</returns>
        public static ObservableCollection<clsCategoria> obtenerListadoCategoriasCompletoBL()
        {
            return clsListadoCategoriasDAL.obtenerListadoCategoriasCompletoDAL();   
        }
    }
}
