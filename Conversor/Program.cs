using System;
using System.Collections.Generic;

namespace Conversor
{
    public struct Base
    {
        public int baseNumero; 
        public string baseRomano;
    }

    public class Program
    {
        public static List<Base> valoresBase = new List<Base>() {
            new Base { baseNumero = 1000, baseRomano = "M" },
            new Base { baseNumero = 900,  baseRomano = "CM" },
            new Base { baseNumero = 500,  baseRomano = "D" },
            new Base { baseNumero = 400,  baseRomano = "CD" },
            new Base { baseNumero = 100,  baseRomano = "C" },
            new Base { baseNumero = 90,   baseRomano = "XC" },
            new Base { baseNumero = 50,   baseRomano = "L" },
            new Base { baseNumero = 40,   baseRomano = "XL" },
            new Base { baseNumero = 10,   baseRomano = "X" },
            new Base { baseNumero = 9,    baseRomano = "IX" },
            new Base { baseNumero = 5,    baseRomano = "V" },
            new Base { baseNumero = 4,    baseRomano = "IV" },
            new Base { baseNumero = 1,    baseRomano = "I" }
        };

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var teste = Calcular(3);
        }
        public static string Calcular(int intNum)
        {
            foreach (var baseNum in valoresBase)
            {
                if (intNum / baseNum.baseNumero >= 1)
                {
                    int dif = intNum - baseNum.baseNumero;
                    return baseNum.baseRomano + Calcular(dif);
                }
            }
            return "";
        }
    }
}
