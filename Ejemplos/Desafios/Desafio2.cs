using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.Desafios
{
    public class Desafio2
    {
        public static Dictionary<char, int> ContarCaracteres(string input)
        {
            // Creamos un diccionario para almacenar el recuento de cada carácter
            Dictionary<char, int> contador = new Dictionary<char, int>();

            // Recorremos cada carácter en la cadena
            foreach (char c in input)
            {
                // Si el carácter ya está en el diccionario, incrementamos su valor
                if (contador.ContainsKey(c))
                {
                    contador[c]++;
                }
                // Si no está, lo añadimos con un valor de 1
                else
                {
                    contador[c] = 1;
                }
            }

            return contador;
        }
    }
}
