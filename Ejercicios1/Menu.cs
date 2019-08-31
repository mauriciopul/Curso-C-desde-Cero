using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicios1
{
    class Menu
    {
        public string ElegirMenu()
        {
            // bool band = false;
            string resp = "";
            Console.WriteLine("Ingresa el ejercicio que deseas realizar entre el 2 y el 18: ");
            string letra = Console.ReadLine();
            if (letra.ToLower()=="s")
            {
                int ej = 0;
            }

            try
            {
                int ej = int.Parse(Console.ReadLine());

                switch (ej)
                {
                    case 1:
                        resp = "Caso 1";
                        break;
                    case 2:
                        resp = "Caso 2";
                        break;
                    case 3:
                        resp = "Caso 3";
                        break;
                    case 4:
                        resp = "Caso 4";
                        break;
                    default:
                        resp = "Debes ingresar un número entre 1 y 18";
                        break;
                }
                return resp;
            }
            catch (Exception)
            {

                return "";
            }
        }

    }
}
