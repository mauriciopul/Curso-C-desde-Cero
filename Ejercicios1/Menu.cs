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
