using System;

namespace Unidad9.Entidades
{
    public class clsPersona
    {
        #region atributos privados
        private int idPersona;
        private string nombre;
        private string apellidos;
        private DateTime fechaNacimiento;
        private string direccion;
        private string telefono;

        #endregion

        #region propiedades publicas
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }



        #endregion

        // Forma de autoimplementacion (para más adelante)
        // public String Nombre { get; set; }

        #region constructores
        //Constructor por defecto
        public clsPersona()
        {
            this.nombre = "Santi";
            this.apellidos = "Martinez";
            this.fechaNacimiento = DateTime.Now;
            this.direccion = "mi casa";
            this.telefono = "987654321";
            this.idPersona = 0;
        }

        //Constructor por parametros
        public clsPersona(string nombre, string apellidos, DateTime fechaNacimiento, string direccion, string telefono, int idPersona)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.direccion = direccion;
            this.telefono = telefono;
            this.idPersona = idPersona;
        }

        #endregion

        #region toString
        public String toString()
        {
            return nombre;
        }
        #endregion

    }

} 