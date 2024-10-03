using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplos.Operations;

namespace Ejemplos.Reports
{
    internal class Provider
    {
        public static string GetStatusProvider(int providerID) {
            string status = "";
            if (providerID == 1) {
                status = StatusOperations._success;
            }
            else if (providerID == 2) {
                status = StatusOperations._clientNotFound;
            }
            else if (providerID == 3)
            {
                status = StatusOperations._systemError;
            }

            return status;
        }
    }
}
