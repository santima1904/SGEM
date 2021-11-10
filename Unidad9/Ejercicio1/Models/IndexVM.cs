using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unidad9.Entidades;


namespace Ejercicio1.Models
{
    public class IndexVM
    {
        private clsPersona opersona;
        public clsPersona Opersona { get => opersona; set => opersona = value; }

        public IndexVM(clsPersona opersona)
        {
            this.opersona = opersona;
        }

        public IndexVM()
        {
            this.opersona = new clsPersona();
        }
    }
}
