﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escribir un método que acepte dos catetos y devuelve la hipotenusa (usar la clase Math para calcular la raíz cuadrada) 

namespace Ejercicios1
{
    class Ejercicio4
    {        
        /// <summary>
        /// Enunciado del ejercicio
        /// </summary>
        /// <returns></returns>
        public string enunciado()
        {
            string l1 = "Escribir un método que acepte dos catetos y devuelve la hipotenusa";
            string l2 = "(usar la clase Math para calcular la raíz cuadrada)";
            string l3 =  l1 + Environment.NewLine + l2 + Environment.NewLine;
            return l3;
        }

        /// <summary>
        /// metodo para solicitar los datos y procesarlos
        /// </summary>
        /// <returns></returns>
        public string datos()
        {
            Console.WriteLine(enunciado());
            Console.WriteLine("Ingrese el Cateto 1");
            int cateto1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Cateto 2");
            int cateto2 = Convert.ToInt32(Console.ReadLine());
            return calcular(cateto1, cateto2);
        }

        /// <summary>
        /// Metodo para calcular la Hipotenusa
        /// </summary>
        /// <param name="catOp">Valor del cateto 1</param>
        /// <param name="catAd">Valor del cateto 2</param>
        /// <returns>Retorna el valor de la hipotenusa como string</returns>
        public string calcular(int catOp, int catAd)
        {
            string resp;
            double hip;
            int catOpCuad = catOp * catOp;
            int catAdCuad = catAd * catAd;
            try
            {
                hip = Math.Sqrt(catAdCuad + catOpCuad);
                resp = "El valor de la Hipotenusa es '"+hip.ToString()+"'" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                resp = "Error: " + ex.ToString();
            }
            return resp;
        }


    }
}
