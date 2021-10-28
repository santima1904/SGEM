using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio2.Models;

namespace Ejercicio2.Models
{
    public class Listado
    {
      
        /// <summary>
        /// Método para crear y rellenar una lista con personas
        /// </summary>
        /// <returns>lista</returns>
        public static List<clsPersona> crearListadoPersonas()
        {
            clsPersona opersona1 = new clsPersona("Santi", "Martínez");
            clsPersona opersona2 = new clsPersona("Pedro", "Pastor");
            clsPersona opersona3 = new clsPersona("Jesús", "De los Santos");
            clsPersona opersona4 = new clsPersona("Albert", "Machío");
            clsPersona opersona5 = new clsPersona("Sinkem", "Torres");

            List<clsPersona> lista = new List<clsPersona>();

            lista.Add(opersona1);
            lista.Add(opersona2);
            lista.Add(opersona3);
            lista.Add(opersona4);
            lista.Add(opersona5);

            return lista;
        }
    }
}
