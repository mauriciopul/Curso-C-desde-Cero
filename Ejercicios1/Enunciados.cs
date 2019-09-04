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

        /// <summary>
        /// Enunciado del ejercicio 6
        /// </summary>
        /// <returns></returns>
        public string enunciado6()
        {
            string tit = "Ejercicio 6" + Environment.NewLine;
            string l1 = "Escribir un método que acepte un double que represente un " + Environment.NewLine;
            string l2 = "número en grados Celcius y lo transforme a grados Fahrenheit." + Environment.NewLine;
            string l = tit + l1 + l2;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 7
        /// </summary>
        /// <returns></returns>
        public string enunciado7()
        {
            string tit = "Ejercicio 7" + Environment.NewLine;
            string l1 = "Escribir un método que acepte una lista de números y devuelva el producto de dichos números." + Environment.NewLine;

            string l = tit + l1;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 8
        /// </summary>
        /// <returns></returns>
        public string enunciado8()
        {
            string tit = "Ejercicio 8" + Environment.NewLine;
            string l1 = "Escribir un método que acepte un int y te devuelva el factorial de dicho número." + Environment.NewLine;
            string l2 = "Nota: El factorial de 3 es 3 * 2 * 1, el factorial de 5 es 5 * 4 * 3 * 2 * 1, etc." + Environment.NewLine;

            string l = tit + l1 + l2;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 9
        /// </summary>
        /// <returns></returns>
        public string enunciado9()
        {
            string tit = "Ejercicio 9" + Environment.NewLine;
            string l1 = "Escribir un método que acepte una lista de números y devuelva su promedio." + Environment.NewLine;
            string l = tit + l1;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 10
        /// </summary>
        /// <returns></returns>
        public string enunciado10()
        {
            string tit = "Ejercicio 10" + Environment.NewLine;
            string l1 = "Escribir un método que acepte una lista de números y devuelva el número más grande." + Environment.NewLine;
            string l = tit + l1;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 11
        /// </summary>
        /// <returns></returns>
        public string enunciado11()
        {
            string tit = "Ejercicio 11" + Environment.NewLine;
            string l1 = "Escribir un método que acepte un datetime que represente la fecha de nacimiento de una persona" + Environment.NewLine;
            string l2 = "y retornar su edad al día de hoy." + Environment.NewLine;
            string l3 = "Nota: DateTime.Today te da la fecha de hoy." + Environment.NewLine;
            string l = tit + l1 + l2 + l3;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 12
        /// </summary>
        /// <returns></returns>
        public string enunciado12()
        {
            string tit = "Ejercicio 12" + Environment.NewLine;
            string l1 = "Escribir un fizzbuzz: Iterar los números del uno al cien, y cuando llegues a un número que sea múltiplo de 3(el 6 por ejemplo)," + Environment.NewLine;
            string l2 = "escribir en la consola 'Fizz', cuando llegues a un número que sea múltiplo de 5(el 20 por ejemplo)" + Environment.NewLine;
            string l3 = "escribir en la consola 'Buzz', cuando llegues a un número que sea" + Environment.NewLine;
            string l4 = "múltiplo de 3 y 5(el 30 por ejemplo) escribir FizzBuzz en la consola." + Environment.NewLine;
            string l = tit + l1 + l2 + l3 + l4;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 13
        /// </summary>
        /// <returns></returns>
        public string enunciado13()
        {
            string tit = "Ejercicio 13" + Environment.NewLine;
            string l1 = "Escribir un método que acepte una lista con números y devuelva dicha lista en orden invertido" + Environment.NewLine;
            string l2 = "Ejemplo: Si ingresamos la lista { 4,6,49}, entonces el método debe devolver la lista { 49,6,4}" + Environment.NewLine;
            string l = tit + l1 + l2;
            return l;
        }

        /// <summary>
        /// Enuniado del ejercicio 14
        /// </summary>
        /// <returns></returns>
        public string enunciado14()
        {
            string tit = "Ejercicio 14" + Environment.NewLine;
            string l1 = "Escribir un método que acepte una lista de números y devuelva una lista con los mismos números ordenados de menor a mayor" + Environment.NewLine;
            string l2 = "Ejemplo: Si ingresamos la lista { 5,2,9,4}, entonces el método debe devolver la lista { 2,4,5,9}" + Environment.NewLine;
            string l = tit + l1 + l2;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 15
        /// </summary>
        /// <returns></returns>
        public string enunciado15()
        {
            string tit = "Ejercicio 15" + Environment.NewLine;
            string l1 = "Escribir un método que acepte una lista de números y devuelva una lista con los mismos números ordenados de mayor a menor" + Environment.NewLine;
            string l2 = "Ejemplo: Si ingresamos la lista { 5,2,9,4}, entonces el método debe devolver la lista { 9,5,4,2}" + Environment.NewLine;
            string l = tit + l1 + l2;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 16
        /// </summary>
        /// <returns></returns>
        public string enunciado16()
        {
            string tit = "Ejercicio 16" + Environment.NewLine;
            string l1 = "Escribir un método que acepte una lista de strings y escriba en la consola el primer caracter de cada uno de los strings" + Environment.NewLine;
            string l = tit + l1;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 17
        /// </summary>
        /// <returns></returns>
        public string enunciado17()
        {
            string tit = "Ejercicio 17" + Environment.NewLine;
            string l1 = "Escribir un método que acepte una lista de strings y escriba en la consola el último caracter de cada uno de los strings" + Environment.NewLine;
            string l = tit + l1;
            return l;
        }

        /// <summary>
        /// Enunciado del ejercicio 18
        /// </summary>
        /// <returns></returns>
        public string enunciado18()
        {
            string tit = "Ejercicio 18" + Environment.NewLine;
            string l1 = "Escribir un método que acepte un string y devuelva true si dicho string es un palíndromo, si no lo es devuelve false." + Environment.NewLine;
            string l2 = "Un palíndromo es un texto que es igual al derecho y al revés." + Environment.NewLine;
            string l3 = "Ejemplos: 'ana' es un palíndromo, pero 'Pirata' no es palíndromo. Para iterar un string caracter por caracter, utilizamos el indexador[]." + Environment.NewLine;
            string l4 = "Ejemplo: string nombre = 'Felipe';for (int i = 0; i < nombre.Length; i++) {Console.WriteLine(nombre[i]);" + Environment.NewLine;

            string l = tit + l1 + l2 + l3 + l4;
            return l;
        }
    }
}
