using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO
{
    public abstract class transportePublico
    {
        protected transportePublico()
        {
            this.pasajeros = pasajeros;
        }

        public int pasajeros { get; set; }

        public abstract string Avanzar();
        public abstract string Detenerse();


    }
}
