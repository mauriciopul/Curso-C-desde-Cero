using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Ejercicio1
    {
        //Permitir al usuario escribir dos números y mostrar en pantalla cuál de los dos es el más grande. 
        //Si son iguales, mostrar cualquiera.
        public string ejercicio()
        {
            while (true)
            {
                try
                {
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
