using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Ejercicio3
    {
        //Escribir un método que acepte dos strings y devuelva el string con más caracteres. 
        //Si ambos tienen la misma cantidad de caracteres, devolver cualquiera de los dos.

        public string  datos()
        {
            Console.WriteLine("Ingrese la primer cadena: ");
            string cad1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda cadena: ");
            string cad2 = Console.ReadLine();
           return  ejercicio(cad1, cad2);
        }

        public string ejercicio(string a, string b)
        {
            try
            {
                string resp = "";
                if (a.Trim().Length == b.Trim().Length)
                {
                    resp = "Ambas cadenas son iguales";
                }
                else
                {
                    if (a.Length > b.Length)
                    {
                        resp = a;
                    }
                    else
                    {
                        resp = b;
                    }
                }
                return "La cadena mas larga es... "+resp;
            }
            catch (Exception ex)
            {
                return "ERROR!!!... " + ex.ToString();
            }
        }

    }
}
