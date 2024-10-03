using Ejemplos.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.Reports
{
    internal class Numbers
    {
        public static string getTypeOfNumbers(int type) {
            string numbers = "";

            switch (type)
            {
                case 1:
                    foreach (int i in TypeNumbers.Naturals())
                    {
                        numbers += Convert.ToString(i) + ", ";
                    }
                    break;

                case 2:
                    foreach (string e in TypeNumbers.Integers())
                    {
                        numbers += e + ", ";
                    }
                    break;
               default: 
                    numbers = "No encontrado";
                    break;
            }

            return numbers;
        }
    }
}
