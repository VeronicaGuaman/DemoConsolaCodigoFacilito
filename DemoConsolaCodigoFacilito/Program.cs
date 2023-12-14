// See https://aka.ms/new-console-template for more information
using DemoConsolaCodigoFacilito;

Console.WriteLine("Hello, World!");


//Nueva funcionalidad C# 12, lambda params
var sum = (params int[] values) =>
{
    int sum = 0;
    foreach (var item in values)
        sum += item;

    return sum;
};

var empty = sum();
Console.WriteLine(empty); // 0

var sequence = new[] { 1, 2, 3, 4, 5 };
var total = sum(sequence);

Console.WriteLine($"result: {total}");

//Nueva funcionalidad C# 12, Parametros por defecto en lambda
var sumLambda = (int a, int b = 5) => a + b;

//Aqui podemos llamar a la función sin el parametro b o con el parametro b para probar
//Debemos comentar la linea 23 para probar esta funcionalidad y descomentar la línea 31

//Console.WriteLine(sumLambda(5)); // 10