using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Validadores
    {
        /// <summary>
        /// Valida que el caracter ingresado es o no un número
        /// </summary>
        /// <param name="num">Caracter a comparar</param>
        /// <returns>Regresa un booleano</returns>
        public bool esNumero(string num)
        {
            try
            {
                Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Valida que el caracter ingresado es o no la letra 's'(se usa para salir de un menú)
        /// </summary>
        /// <param name="letra">Caracter a comparar</param>
        /// <returns>Regresa un booleano</returns>
        public bool esS(string letra)
        {
            try
            {
                return Equals(letra.ToLower(), "s");
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// valida que el número ingresado esté entre 1 y 18
        /// </summary>
        /// <param name="num">Número a comparar</param>
        /// <returns>Retorna un booleano</returns>
        public bool estaEntre1y18(string num)
        {
            bool respuesta = false;
            int n = Convert.ToInt32(num);
            try
            {
                if (n >= 1 && n <= 18) respuesta = true;
                return respuesta;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Valida si un número ingresado es par 
        /// </summary>
        /// <param name="num">Número a comparar</param>
        /// <returns>Retorna un booleano</returns>
        public bool esParBool(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
