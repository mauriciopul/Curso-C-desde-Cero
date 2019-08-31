using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Validadores
    {
        public bool esNumero(string num)
        {
            try
            {
                Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool esS(string letra)
        {
            try
            {                
                return Equals(letra.ToLower(), "s");
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
