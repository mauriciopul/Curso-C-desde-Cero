using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operaciones;

namespace Enums_y_numeros_Magicos
{
    enum EstatusOperacion
    {
        Exitoso = 1,
        ClienteNoEncontrado = 2,
        ErrorDeSistema = 5
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int estatusOperacion = 5;
            //if (estatusOperacion == (int)EstatusOperacion.Exitoso)
            //{
            //}
            //else if (estatusOperacion==(int)EstatusOperacion.ClienteNoEncontrado)
            //{
            //}else if (estatusOperacion==(int)EstatusOperacion.ErrorDeSistema)
            //{
            //}

            string estatusOperacion = "K15";
            if (estatusOperacion == EstatusOperaciones._exitoso)
            {
            }
            else if (estatusOperacion == EstatusOperaciones._clienteNoEncontrado)
            {
            }
            else if (estatusOperacion == EstatusOperaciones._errorDelSistema)
            {
            }

            Console.WriteLine(Suma(2, 3));


            Console.ReadLine();

        }

        /// <summary>
        /// Metodo que sirve para sumar
        /// </summary>
        /// <param name="a">Sumando 1</param>
        /// <param name="b">Sumando 2</param>
        /// <returns>Retorna la suma de a y b</returns>
        private static int Suma(int a, int b)
        {
            return a + b;
        }
    }
    
}

