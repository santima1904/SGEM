using Santaigo_Martinez_Aral_ExamenAsp_Entidades;
using System.Collections.ObjectModel;
using Santaigo_Martinez_Aral_ExamenAsp_BL.Listado;

namespace Santaigo_Martinez_Aral_ExamenAsp_UI.Models
{
    public class ListadoCategoriasVM
    {
        ObservableCollection<clsCategoria> listadoCategoriasCompleto;

        public ListadoCategoriasVM()
        {
            this.listadoCategoriasCompleto = rellenarListadoCategoriasCompleto();
        }

        public ObservableCollection<clsCategoria> ListadoCategoriasCompleto { get => listadoCategoriasCompleto; set => listadoCategoriasCompleto = value; }

        /// <summary>
        /// <cadecera>private ObservableCollection<clsCategoria> rellenarListadoCategoriasCompleto()</cadecera>
        /// <descripcion>Método para devolver  una lista completa de categorías</descripcion>
        /// <precondiciones>Ninguna</precondiciones>
        /// <postcondiciones>lista devuelta</postcondiciones>
        /// </summary>
        /// <returns>ObservableCollection(clsCategoria)</returns>
        private ObservableCollection<clsCategoria> rellenarListadoCategoriasCompleto()
        {
            ObservableCollection<clsCategoria> listadoCategorias = new ObservableCollection<clsCategoria>();
            listadoCategorias = clsListadoCategoriasBL.obtenerListadoCategoriasCompletoBL();
            return listadoCategorias;
        }
    }
}
