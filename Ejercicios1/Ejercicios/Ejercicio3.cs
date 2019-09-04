using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1.Ejercicios
{
    class Ejercicio3
    {
        Enunciados enun = new Enunciados();

        /// <summary>
        /// Metodo que pide los datos para procesar
        /// </summary>
        /// <returns></returns>
        public string datos()
        {
            Console.WriteLine(enun.enunciado3());
            Console.WriteLine("Ingrese la primer cadena: ");
            string cad1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda cadena: ");
            string cad2 = Console.ReadLine();
            return ejercicio(cad1, cad2);
        }

        /// <summary>
        /// Metodo que valida cual cadena es mas larga
        /// </summary>
        /// <param name="a">Cadena 1</param>
        /// <param name="b">Cadena 2</param>
        /// <returns>Retorna respuesta con la cadena más larga</returns>
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
                return "La cadena mas larga es... " + resp;
            }
            catch (Exception ex)
            {
                return "ERROR!!!... " + ex.ToString();
            }
        }
    }
}
