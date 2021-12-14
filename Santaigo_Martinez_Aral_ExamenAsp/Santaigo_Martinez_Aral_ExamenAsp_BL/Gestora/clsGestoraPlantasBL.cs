using Santaigo_Martinez_Aral_ExamenAsp_Entidades;
using Santaigo_Martinez_Aral_ExamenAsp_DAL.Gestora;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santaigo_Martinez_Aral_ExamenAsp_BL.Gestora
{
    public class clsGestoraPlantasBL
    {
        /// <summary>
        /// <cadecera>public int actualizarPrecioPlantaBL(clsPlanta planta)</cadecera>
        /// <descripcion>Método para llamar al método de actualizar el precio de una planta en la DAL</descripcion>
        /// <precondiciones>planta distinta de null</precondiciones>
        /// <postcondiciones>devuelve un entero con el número de filas afectadas , el precio queda actualizado</postcondiciones>
        /// </summary>
        /// <returns>int</returns>
        public static int actualizarPrecioPlantaBL(clsPlanta planta)
        {
            return clsGestoraPlantasDAL.actualizarPrecioPlantaDAL(planta);
        }
    }
}
