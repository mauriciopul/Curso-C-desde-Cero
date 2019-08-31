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
            var menu = new Menu();
            //var ej1 = new Ejercicio2();
            const string infoInicial = "Este programa tiene 18 ejercicios y debes elegir el ejercicio que deseas mostrar";
            bool sw = true;

            do
            {
                Console.WriteLine(infoInicial);
                Console.WriteLine();
                string numEjer = Console.ReadLine();

                if (validadores.esNumero(numEjer) && validadores.estaEntre1y18(numEjer))
                {
                    menu.ElegirMenu(Convert.ToInt32(numEjer));
                }
                else if (validadores.esS(numEjer))
                {
                    finPrograma();
                    sw = false;
                }
            } while (sw==true);
        }


        /// <summary>
        /// Saltos de linea y mensajes para finalizar un programa
        /// </summary>
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
