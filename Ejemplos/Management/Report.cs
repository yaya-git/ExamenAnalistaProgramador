using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.Management
{
    public class Report
    {
        public string getAll() {
            string reprot = "";

            reprot += "REPORTE ADMINISTRATIVO \n";
            reprot += "El siguiente documento revisa las actividades de las divisiones financiera y contable de la region. \n";

            return reprot;
        }
    }
}
