using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            var validadores = new Validadores();
            ////var ej1 = new Ejercicio2();
            ////Console.WriteLine(ej1.esPar());
            //var menu = new Menu();
            //var resp = menu.ElegirMenu();
            ////do
            ////{
            ////    menu.ElegirMenu();
            ////} while (resp.ToLower() != "s");
            //    Console.WriteLine(resp);

            ////if (menu.ElegirMenu() == "s")
            ////{
            ////    Console.WriteLine("Presionó la tecla S");
            ////    finPrograma();
            ////}
            ////else
            ////{
            ////    Console.WriteLine(menu.ElegirMenu());
            ////}
            Console.WriteLine(validadores.esS("2"));


            finPrograma();
        }
        public static void finPrograma()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Programa finalizado");
            Console.WriteLine("Presiona ENTER para salir");
            Console.Read();
        }
    }
}
