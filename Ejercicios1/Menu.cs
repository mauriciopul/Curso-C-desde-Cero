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
            var ejercicio2 = new Ejercicio2();

            string resp = "";            
            try
            {
                switch (ej)
                {
                    case 1:
                        resp = "Caso: " + ej;
                        break;
                    case 2:
                        resp = "Caso: " + ej;
                        Console.WriteLine(ejercicio2.esPar());
                        break;
                    case 3:
                        resp = "Caso: " + ej;
                        break;
                    case 4:
                        resp = "Caso: " + ej;
                        break;
                    default:
                        resp = info;
                        break;
                }
                Console.WriteLine(resp);
            }
            catch (Exception)
            {
                Console.WriteLine(infoError);
            }
        }
    }
}
