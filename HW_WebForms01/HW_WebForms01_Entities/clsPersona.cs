using System;

namespace HW_WebForms01_Entities
{
    public class clsPersona
    {
        #region atributos privados
        private String nombre;      //Para generar las propiedades automaticamente en C#, escribir "prop" y 2 tabulaciones. Son propiedades autoimplementadas
        #endregion

        #region propiedades publicas
        public String Nombre { 
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

        #region contructores
        //Constructor por defecto sin parametros
        public clsPersona() { }

        //Constructor por parametros
        public clsPersona(String nombre) {
            Nombre = nombre;
        }
        #endregion
    }
}
