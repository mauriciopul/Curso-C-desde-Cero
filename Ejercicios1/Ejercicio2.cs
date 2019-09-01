using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Ejercicio2
    {
        Enunciados enun = new Enunciados();

        /// <summary>
        /// Metodo que calcula si un número es par
        /// </summary>
        /// <returns></returns>
        public string esPar()
        {
            Console.WriteLine(enun.enunciado2());
            var validador = new Validadores();
            Console.WriteLine("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());
            string respuesta = validador.esParBool(n).ToString();
            string re = "El numero " + n + " es par?: " + respuesta;
            return re;
        }
    }
}
