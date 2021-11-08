using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class clsPlantas
    {
        #region atributos
        private string nombre;
        private string descripcion;
        #endregion

        #region constructor
        public clsPlantas(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public clsPlantas()
        {
            this.nombre = " ";
            this.descripcion = " ";
        }
        #endregion

        #region propiedades publicas
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        #endregion

    }
}
