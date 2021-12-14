using System;
using System.Collections.Generic;
using System.Text;

namespace Santaigo_Martinez_Aral_ExamenAsp_Entidades
{
    public class clsCategoria
    {
        #region atributos
        int idCategoria;
        string nombreCategoria;
        #endregion

        #region constructor
        public clsCategoria(int idCategoria, string nombreCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
        }

        public clsCategoria()
        {
            this.idCategoria = 0;
            this.nombreCategoria = " ";
        }
        #endregion

        #region propiedades publicas
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        #endregion
    }
}
