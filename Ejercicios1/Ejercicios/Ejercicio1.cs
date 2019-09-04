using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Ejercicio1
    {
        Enunciados enun = new Enunciados();

        /// <summary>
        /// Metodo que calcula el mayor de 2 numeros dados
        /// </summary>
        /// <returns></returns>
        public string ejercicio()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine(enun.enunciado1());
                    Console.Write("Primer Número: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Segundo Número: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    string resp = "";
                    if (a > b)
                    {
                        return resp = "El mayor es: " + a;
                    }
                    else
                    {
                        return resp = "El mayor es: " + b;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Debe ingresar números");
                }
            }
        }
    }
}
