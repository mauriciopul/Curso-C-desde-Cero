using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicios1
{
    class Menu
    {
        const string info = "Debe ingresar un número entre 1 y 18 o la letra 's' para salir";
        const string infoError = "ERROR!!! Recuerda ingresar un número entre 1 y 18 o la letra 's' para salir";
        

        public void ElegirMenu(int ej)
        {
            var ejercicio1 = new Ejercicio1();
            var ejercicio2 = new Ejercicio2();
            var ejercicio3 = new Ejercicio3();
            var ejercicio4 = new Ejercicio4();
            var ejercicio5 = new Ejercicio5();

            //string resp = "";            
            try
            {
                switch (ej)
                {
                    case 1:
                        Console.WriteLine(ejercicio1.ejercicio());
                        break;
                    case 2:
                        Console.WriteLine(ejercicio2.esPar());
                        break;
                    case 3:
                        Console.WriteLine(ejercicio3.datos());
                        break;
                    case 4:
                        Console.WriteLine(ejercicio4.datos());
                        break;
                    case 5:
                        Console.WriteLine(ejercicio5.ejercicio());
                        break;
                    case 6:
                        Console.WriteLine("Caso 6");
                        break;
                    case 7:
                        Console.WriteLine("Caso 7");
                        break;
                    case 8:
                        Console.WriteLine("Caso 8");
                        break;
                    case 9:
                        Console.WriteLine("Caso 9");
                        break;
                    case 10:
                        Console.WriteLine("Caso 10");
                        break;
                    case 11:
                        Console.WriteLine("Caso 11");
                        break;
                    case 12:
                        Console.WriteLine("Caso 12");
                        break;
                    case 13:
                        Console.WriteLine("Caso 13");
                        break;
                    case 14:
                        Console.WriteLine("Caso 14");
                        break;
                    case 15:
                        Console.WriteLine("Caso 15");
                        break;
                    case 16:
                        Console.WriteLine("Caso 16");
                        break;
                    case 17:
                        Console.WriteLine("Caso 17");
                        break;
                    case 18:
                        Console.WriteLine("Caso 18");
                        break;

                    default:
                        Console.WriteLine(info);
                        break;
                }
                //Console.WriteLine(resp);
            }
            catch (Exception)
            {
                Console.WriteLine(infoError);
            }
        }
    }
}
