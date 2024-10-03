using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.Finance
{
    public class Report
    {
        public string WorkingCapita() {
            string wc = "";

            wc += "Nombre: Capital Operativo \n";
            wc += "Salario Previo: $ 5,000.00 \n";
            wc += "Prima de Seguro: 1,000.00 \n";
            wc += "Inventario: $ 2,000.00 \n";

            return wc;
        }
    }
}
