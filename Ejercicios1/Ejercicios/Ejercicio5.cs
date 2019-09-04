using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1.Ejercicios
{
    class Ejercicio5
    {
        Enunciados en = new Enunciados();

        public string ejercicio()
        {
            Console.WriteLine(en.enunciado5());
            
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }                
            }
            return "";
        }
    }
}
