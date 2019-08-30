using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace basicoConsola
{
    class Nullable
    {
        public static void Main1(string[] ar)
        {
            var persona = new Persona() { nombre = "Mao", edad = 90 };
            persona = null;

            Nullable<int> numero = 45;
            numero = null;

            DateTime? fechaNacimiento = null;//Otra manera de representar un Nullable
            fechaNacimiento = new DateTime(2015, 2, 3);

            // HasValue --> Sirve para validar si un dato tiene valor o es null
            if (numero.HasValue)
            {
                Console.WriteLine("El número tiene valor");
            }

            if (fechaNacimiento.HasValue)
            {
                Console.WriteLine("La fecha tiene valor");

            }

        }
    }
    class Persona
    {
        public string nombre;
        public int edad;
    }

}
