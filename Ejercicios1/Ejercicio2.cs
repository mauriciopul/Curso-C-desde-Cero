using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Ejercicio2
    {
        //Escribir un método que acepte un número y devuelva True si el número es par, o false si es impar.

        public string esPar()
        {
            var validador = new Validadores();
            Console.WriteLine("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());
            string respuesta = validador.esParBool(n).ToString();
            string re= "El numero " + n + " es par?: " + respuesta;
            return re;
        }

    }
}
