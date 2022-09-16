using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO
{
    public class Omnibus : transportePublico
    {
        public Omnibus() { }
        public override string Avanzar()
        {
            return $"El omnibus está avanzando.";
        }

        public override string Detenerse()
        {
            return $"El omnibus se esta deteniendo.";
        }
    }
}
