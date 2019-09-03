using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Enunciados
    {
        /// <summary>
        /// Enunciado del ejercicio 1
        /// </summary>
        /// <returns></returns>
        public string enunciado1()
        {
            string tit = "Ejercicio 1";
            string l1 = "Permitir al usuario escribir dos números y mostrar en pantalla cuál de los dos es el más grande";
            string l2 = "Si son iguales, mostrar cualquiera";
            string l3 = tit + Environment.NewLine + l1 + Environment.NewLine + l2 + Environment.NewLine;
            return l3;
        }

        /// <summary>
        /// Enunciado del ejercicio 2
        /// </summary>
        /// <returns></returns>
        public string enunciado2()
        {
            string tit = "Ejercicio 2";
            string l1 = "Escribir un método que acepte un número y devuelva True si el número es par, o false si es impar.";
            return tit + Environment.NewLine + l1 + Environment.NewLine;
        }

        /// <summary>
        /// Enunciado del ejercicio 3
        /// </summary>
        /// <returns></returns>
        public string enunciado3()
        {
            string tit = "Ejercicio 3" + Environment.NewLine;
            string l1 = "Escribir un método que acepte dos strings y devuelva el string con más caracteres." + Environment.NewLine;
            string l2 = "Si ambos tienen la misma cantidad de caracteres, devolver cualquiera de los dos." + Environment.NewLine;
            string l3 = tit + l1 + l2;
            return l3;
        }

        /// <summary>
        /// Enunciado del ejercicio 4
        /// </summary>
        /// <returns></returns>
        public string enunciado4()
        {
            string tit = "Ejercicio 4" + Environment.NewLine;
            string l1 = "Escribir un método que acepte dos catetos y devuelve la hipotenusa" + Environment.NewLine;
            string l2 = "(usar la clase Math para calcular la raíz cuadrada)" + Environment.NewLine;
            string l3 = tit + l1 + l2;
            return l3;
        }
        
        /// <summary>
        /// Enunciado del ejercicio 5
        /// </summary>
        /// <returns></returns>
        public string enunciado5()
        {
            string tit = "Ejercici 5" + Environment.NewLine;
            string l1 = "Utilizando un iterador escribir en pantalla los números del 1 al 100 de dos en dos." + Environment.NewLine;
            string l = l1;
            return l;
        }

        //public string enunciado()
        //{
        //    string tit = "" + Environment.NewLine;
        //    string l1 = "" + Environment.NewLine;

        //    string l = l1;
        //    return l;
        //}
    }
}
