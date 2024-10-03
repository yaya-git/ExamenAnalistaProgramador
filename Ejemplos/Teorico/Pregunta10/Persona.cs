using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos.Teorico.Pregunta10
{
    public class Persona
    {
        // Atributos privados
        private string nombre;
        private int edad;
        private double peso;

        // Métodos Get y Set para nombre
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        // Métodos Get y Set para edad
        public int GetEdad()
        {
            return edad;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        // Métodos Get y Set para peso
        public double GetPeso()
        {
            return peso;
        }

        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        public void CambiaNombre()
        {
            nombre = "Hola_" + nombre;
        }

        public double Calcula()
        {
            return edad * peso;
        }
    }
}
