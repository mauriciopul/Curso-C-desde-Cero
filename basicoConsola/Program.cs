using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicoConsola
{
    class Program
    {
        static void Main(string[] args)
        {




            //fechas();
            string nombre = "Felipe";
            string frase = "Juan y Jose son amigos";
            int edad = 50;

            //// substring --> obtiene un frgmento de la cadena indicando donde empiez
            //nombre.Substring(3);//resultado = ipe
            //frase.Substring(7, 4);//resultado = Jose

            //// startswith --> Valida si la frase comienza por un caracter o caracteres que le indicamos
            //frase.StartsWith("Juan"); //true
            //frase.StartsWith("Jose"); //False

            //// EndsWith --> Valida si la frase termina por un caracter o caracteres que le indicamos
            //Console.WriteLine( frase.EndsWith("amigos"));
            //Console.WriteLine( frase.EndsWith("enemigos"));

            //// Contains --> Valida si la frase contiene un caracter o caracteres que le indicamos
            //Console.WriteLine(frase.Contains("Jose"));

            ////trim() --> Elimina los espacios al inicio y al final de una cadena
            //string ejemploTrim = " Mauricio ";
            //Console.WriteLine(ejemploTrim.Trim());

            //// Format --> da un formato o plantilla incluyendo los valores en una cadena similar a javascript con ${}
            //string ejemploFormat = "Felicidades {0} en tu cumpleaños número {1}!!! ya estas viejo {0}";
            //var resultadoFormat = string.Format(ejemploFormat, nombre, 55);
            //Console.WriteLine(resultadoFormat);

            // Replace, similar al format pero en replace se puede indicar el nombre de la variable en la cadena anteponiendo @
            //string ejemploReplace = "Felicidades @nombre en tu cumpleaños número @edad";
            //var resultadoReplace = ejemploReplace.Replace("@nombre", nombre);
            //resultadoReplace = resultadoReplace.Replace("@edad", edad.ToString());
            //Console.WriteLine(resultadoReplace);

            //// IsNullOrWhiteSpace --> Validar si un string consiste solo en espacios en blanco o si es nulo
            //string stringEnBlanco = "   ";
            //string stringNulo = null;
            //Console.WriteLine(string.IsNullOrWhiteSpace(stringEnBlanco)); // True
            //Console.WriteLine(string.IsNullOrWhiteSpace(stringNulo)); // True
            //Console.WriteLine(string.IsNullOrWhiteSpace(nombre)); //False

            List<string> nombres = new List<string>() { "Felipe", "Claudia" };

            //var n1 = nombre.Length;//Cuenta los caracteres de una cadena
            //var n2 = nombres.Count;//Cuenta los elementos de una lista
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);

            foreach (var item in nombres)
            {
                Console.WriteLine(item.ToUpper());
            }


            var persona = new Persona() { nombre = "Mao", edad = 90 };
            persona = null;

            Nullable<int> numero = 45;
            //numero = null;

            DateTime? fechaNacimiento = null;//Otra manera de representar un Nullable
            //fechaNacimiento = new DateTime(2015, 2, 3);

            // HasValue --> Sirve para validar si un dato tiene valor o es null
            if (numero.HasValue)
            {
                Console.WriteLine("El número tiene valor");
            }

            if (fechaNacimiento.HasValue)
            {
                Console.WriteLine("La fecha tiene valor");

            }

            Console.Read();
        }
        
        class Persona
        {
            public string nombre;
            public int edad;
        }

        public static void fechas()
        {
            DateTime fecha = new DateTime(2014, 10, 23);
            DateTime fechaConHora = new DateTime(2005, 04, 23, 9, 30, 45);

            Console.WriteLine(fecha.ToString());
            Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
            Console.WriteLine(fecha.ToString("dd-MM-yy"));
            Console.WriteLine(fechaConHora.ToString("dd*MM*yy hh:mm:ss"));

            Console.WriteLine(fecha.AddDays(45).ToString("dd-MM-yy"));

            Console.WriteLine(fechaConHora.DayOfWeek);

            Console.WriteLine(fechaConHora.Date);

            Console.WriteLine(fecha.Subtract(fechaConHora).Days);//Restar fechas

            Console.Read();
        }
    }
}
