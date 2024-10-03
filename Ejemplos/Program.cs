using Ejemplos.Reports;
using Ejemplos.Desafios;


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


