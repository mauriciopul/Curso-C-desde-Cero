using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1.Ejercicios
{
    class Ejercicio6
    {
        public string convertirGrados()
        {
            Enunciados en = new Enunciados();
            Validadores val = new Validadores();
            string resp = "";
            bool sw = true;
            en.enunciado6();
            do
            {
                try
                {
                    Console.WriteLine("Ingrese cantidad de grados a convertir");
                    var gr = Console.ReadLine();
                    if (val.esNumeroDoble(gr))
                    {
                        var grados = calcular(Convert.ToDouble(gr));
                        sw = false;
                        resp = grados.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Datos incorrectos");
                        sw = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Datos incorrectos");
                    sw = true;
                }
            } while (sw == true);
            return resp;
        }

        public double calcular(double num)
        {
            var n = num;
            var j = 32;
            var k = 1.8;
            var res = (n * k) + j;
            return res;
        }
    }
}
