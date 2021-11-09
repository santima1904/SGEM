using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace DAL
{
    public class clsListadoPlantas
    {
        /// <summary>
        /// <h1>Cabecera: </h1>private List(clsPlantas) obtenerListaPlantasCompleto()
        /// <h1>Descripción: </h1>Método para crear una lista de plantas
        /// Este método simula la conexión con la BBDD
        /// </summary>
        /// <returns>List(clsPlantas)</returns>
        private List<clsPlantas> obtenerListaPlantasCompleto()
        {
           List<clsPlantas> listadoPlantas = new List<clsPlantas>();

            listadoPlantas.Add(new clsPlantas("Aloe vera", "De la familia de las Asphodelaceae, pertenece al género Aloe, que cuenta con más de 350 especies vegetales. Esta especie, muy habitual entre las plantas de interior, tiene infinidad de aplicaciones en diversos remedios naturales, especialmente para los de la piel. Entre ellas, la de aliviar las quemaduras, rozaduras e, incluso, psoriasis y picaduras de insectos."));
            listadoPlantas.Add(new clsPlantas("Valeriana", "La valeriana o Valeriana officinalis es una de las plantas medicinales más empleadas en la fitoterapia. Y es normal, ya que tiene infinidad de beneficios pero quizás el más conocido sea el ayudar a relajarnos. La valeriana es una planta que disminuye la ansiedad y ayuda a dormir."));
            listadoPlantas.Add(new clsPlantas("Amapola", "La amapola o Papaver rhoeas L., es una planta curativa de la que se usan las semillas. Con estas semillas se consigue prevenir enfermedades cardiovasculares, anemias o afecciones de la piel."));
            listadoPlantas.Add(new clsPlantas("Eucalipto", "El eucalipto o eucaliptas es una de las plantas que más usamos para decorar la casa. Son plantas muy resistentes y perfectas para añadir a cualquier centro de mesa. Pero además de decorar el interior de nuestra casa, los eucaliptos son plantas medicinales muy beneficiosas para la salud. Entre sus propiedades más conocidas está la de aliviar los síntomas de los resfriados, en concreto afecciones respiratorias (tos, bronquitis, neumonía, asma...)."));
            listadoPlantas.Add(new clsPlantas("Salvia", "La salvia o Salvia officinalis es una de las plantas más conocidas por utilizarse en cosméticos, pero también tiene otras funciones. Entre las más conocidas está su utilización para aliviar los síntomas de la menopausia."));
            listadoPlantas.Add(new clsPlantas("Arándanos", "Los arándanos o también llamado como cranberry (o Vaccinium macrocarpon) junto con las frambuesas son algunos de los ingredientes principales de los boles que más verás en un desayuno saludable. Pues bien, los arándanos, muy populares en la fitoterapia, a pesar de ser muy pequeños, cuentan con muchas propiedades, entre las que destaca su capacidad antibacteriana, ya que ayuda a combatir infecciones."));

            return listadoPlantas;
        }

        /// <summary>
        /// <h1>Cabecera: </h1>public List(String) obtenerListadoNombrePlantas()
        /// <h1>Descripción: </h1>Método para crear una lista de nombres plantas
        /// <h1>Precondiciones: </h1>Ninguna
        /// </summary>
        /// <h1>Postcondiciones:</h1>Listado de nombres de plantas devuelto
        /// <returns>List(clsPlantas)</returns>
        public List<String> obtenerListadoNombrePlantas()
        {
            List<String> listadoNombres = new List<string>();

            List<clsPlantas> listadoPlantas = obtenerListaPlantasCompleto();

            foreach(clsPlantas plantas in listadoPlantas){
                listadoNombres.Add(plantas.Nombre);
            }

            return listadoNombres;
        }

        /// <summary>
        /// <h1>Cabecera: </h1>public clsPlantas obtenerPlantaApartirNombre(String nombre)
        /// <h1>Descripción: </h1>Método para obtener una planta de la lista a partir del nombre
        /// <h1>Precondiciones: </h1>nombre diferente de null
        /// </summary>
        /// <h1>Postcondiciones:</h1> Planta devuelta
        /// <param name="nombre">String</param>
        /// <returns>clsPlantas</returns>
        public clsPlantas obtenerPlantaApartirNombre(String nombre)
        {
            clsPlantas planta = new clsPlantas();
            List<clsPlantas> listado = obtenerListaPlantasCompleto();
            bool encontrado = false;

            for(int i = 0;i<listado.Count&&!encontrado;i++)
            {
                if (nombre == listado[i].Nombre){
                    planta = listado[i];
                }
            }

            return planta;
        }
    }
}
