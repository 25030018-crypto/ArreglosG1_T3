
using Arreglos.Logica;
using System.Data;

Console.WriteLine("Operaciones de pila");
Console.WriteLine("Arreglo\n");
MiArreglo oMiArreglo = new MiArreglo(5);
try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-2);
    oMiArreglo.Agregar(8);


    Console.WriteLine(oMiArreglo);
    Console.WriteLine("Insertar  500 en posicion 1");
    Console.ReadKey();
    oMiArreglo.Insertar(500, 1);
    Console.WriteLine(oMiArreglo);

    Console.WriteLine("Eliminar  500 en posicion 1");
    Console.ReadKey();
    oMiArreglo.Eliminar( 1);
    Console.WriteLine(oMiArreglo);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
MiArreglo miArreglo = new MiArreglo(50000);
try
{
    Console.WriteLine("\nArreglo\n");
    var tiempo1 = DateTime.Now;
    oMiArreglo.Llenar(1,999999);

    var tiempo2 = DateTime.Now;
    Console.WriteLine(oMiArreglo);
    var restaTiempo = tiempo2 - tiempo1;
    Console.WriteLine(restaTiempo);
    var tiempo3 = DateTime.Now;
    Console.WriteLine(oMiArreglo);
    var restaTiempo1 = tiempo3 - tiempo2;
    var tiempo4 = DateTime.Now;
    Console.WriteLine(oMiArreglo);
    var restaTiempo2 = tiempo4 - tiempo3;
    Console.WriteLine($"\nTiempo transcurrido:{restaTiempo.Minutes}minutos, {restaTiempo.Seconds} segundos, {restaTiempo.Milliseconds}milisegundos,{restaTiempo.Nanoseconds} nanosegundos");
    Console.ReadKey();
   // Console.WriteLine("\npares\n");

    //var verPares = oMiArreglo.ObtenerPares();
    //Console.WriteLine(verPares);
    //Console.ReadKey();
    //Console.WriteLine("\nPares ordenados\n");
    //verPares.Ordenar(true);
    //Console.WriteLine(verPares);
    //Console.ReadKey();

    Console.WriteLine("\nPrimos\n");
    var verPrimos = oMiArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);
    Console.ReadKey();

    Console.WriteLine("\nPrimos\nordenadosn");
    verPrimos.Ordenar();
    Console.WriteLine(verPrimos);
    Console.ReadKey();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

//oMiArreglo.Llenar(1, 20);

//Console.WriteLine("Arreglo desordenado\n");
//Console.WriteLine(oMiArreglo);
//Console.WriteLine("Arreglo ordenado\n");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);
//Console.WriteLine("Arreglo ordenado ascendente\n");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);
//Console.WriteLine("Arreglo ordenado descendente\n");
//oMiArreglo.Ordenar(false);
//Console.WriteLine(oMiArreglo);

Console.ReadKey();
