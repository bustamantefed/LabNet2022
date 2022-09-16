using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO
{
    public class taxi : transportePublico
    {

        public taxi() { }

        public override string Avanzar()
        {
            return $"El taxi está avanzando.";
        }

        public override string Detenerse()
        {
            return $"El taxi se esta deteniendo.";
        }
    }
}
