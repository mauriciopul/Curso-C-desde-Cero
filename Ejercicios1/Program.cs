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


            
            bool sw = true;

            do
            {
                encabezadoPrograma();

                string numEjer = Console.ReadLine();

                if (validadores.esNumeroEntero(numEjer) && validadores.estaEntre1y18(numEjer))
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

        /// <summary>
        /// Saltos de linea y titulos para el mensaje al iniciar el programa
        /// </summary>
        public static void encabezadoPrograma()
        {
            const string infoInicial = "Este programa tiene 18 ejercicios y debes elegir el ejercicio que deseas mostrar";
            const string infoInicialSalir = "Recuerda que tambien puedes presionar la tecla 's' o 'S' para salir";
            string car = "----";
            string espacio = "";
            for (int i = 0; i < infoInicial.Length; i++)
            {
                car = car + "-";
            }
            for (int i = 0; i < ((infoInicial.Length - infoInicialSalir.Length)/2); i++)
            {
                espacio = espacio + " ";
            }
            Console.WriteLine(car);
            Console.WriteLine("| "+infoInicial+" |");
            Console.WriteLine("| "+espacio+infoInicialSalir+espacio+" |");
            Console.WriteLine(car);
            Console.Write("...  ");
        }
    }
}
