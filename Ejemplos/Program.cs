using Ejemplos.Reports;
using Ejemplos.Desafios;
using Ejemplos.Teorico.Pregunta10;


// ¿Qué es una namespace y da 3 ejemplos de namespaces en .NET?

// Ejemplo 1
Console.WriteLine("Status Numero. Opciones: (1,2,3): ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Status: "  + Provider.GetStatusProvider(n1));

// Ejemplo 2
Console.WriteLine("Tipos de Numeros, Naturales(1) Enteros(2): ");
int typoNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Numeros: " + Numbers.getTypeOfNumbers(typoNumero));

// Ejemplo 3
Console.WriteLine("Selecciona el Tipo de Reporte, Finanzas(1) Gestion(2): ");
int typoReporte = Convert.ToInt32(Console.ReadLine());
var reporteFinanzas = new Ejemplos.Finance.Report();
var reporteGestion = new Ejemplos.Management.Report();
if (typoReporte == 1)
{
    Console.WriteLine(reporteFinanzas.WorkingCapita());
}
else if (typoReporte == 2) {
    Console.WriteLine(reporteGestion.getAll());
}

Console.WriteLine("\n\n");

// 7. Escribe el código para desplegar la cadena de caracteres “abcdefg” al revés:
string original = "abcdefg";
char[] charArray = original.ToCharArray();
Array.Reverse(charArray);
string reversed = new string(charArray);
Console.WriteLine("cadena de caracteres “abcdefg” al revés: " + reversed);

Console.WriteLine("\n\n");

// 11. Escribe el código para declarar una instancia de la clase anterior, ...
Persona persona = new Persona();
persona.SetNombre("Juan");
persona.SetEdad(25);
persona.SetPeso(70.5);
// Llamar al método CambiaNombre
persona.CambiaNombre();
// Mostrar el nombre cambiado
Console.WriteLine("Nombre después de cambiar: " + persona.GetNombre());
// Llamar al método Calcula y mostrar el resultado
double resultadoCalculo = persona.Calcula();
Console.WriteLine("El resultado de edad * peso es: " + resultadoCalculo);

Console.WriteLine("\n\n");

// 12. Escribe una función en javascript de nombre “Despliega”


Console.WriteLine("\n\n");
//Desafios
// 1
string cadena = "hola";
string reverso = Desafio1.ReversaCadena(cadena);
Console.WriteLine("Cadena original: " + cadena); 
Console.WriteLine("Cadena invertida: " + reverso);

// 2
string cadena2 = "Yadira";
Dictionary<char, int> resultado = Desafio2.ContarCaracteres(cadena2);

Console.WriteLine("Recuento de cada carácter de la cadena: \n");
foreach (var item in resultado)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}


