using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.Operations
{
    public static class TypeNumbers
    {
        public static List<int> Naturals() {
            List<int> numbers = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            return numbers;
        }
        public static List<string> Integers()
        {
            List<string> numbers = new List<string> { "−5", "−4", "−3", "−2", "−1", "0", "1", "2", "3", "4", "5" };

            return numbers;
        }

    }
}
