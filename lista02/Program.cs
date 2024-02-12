Console.WriteLine("LISTA DE SERIES");
Console.WriteLine();


List<string> serie = new List<string>();

//agregar elementos a la lista
serie.Add("Blacklist");
serie.Add("List");
serie.Add("Insatiable");
serie.Add("The Crods");
serie.Add("Sex Education");
serie.Add("Virgin");
serie.Add("Jane");
serie.Add("Riverdale");

//Recorrido de la lista (es string pero con la palabr var lo identifica)
foreach (string s in serie)
{
    Console.WriteLine("Serie - " + s);
}
Console.WriteLine();

serie.Insert(2, "Helados Sarita");

Console.WriteLine("New list with inserted element in the 2 position");
Console.WriteLine();
foreach (string s in serie)
{
    Console.WriteLine("Serie - " + s);
}
Console.WriteLine();

Console.WriteLine("Determinar si se encuentra un elemento en la lista. ");
Console.WriteLine();

//Primera forma
bool respuesta = serie.Contains("carros");
Console.WriteLine(respuesta);

//Segunda forma
if (respuesta)
{
    Console.WriteLine("Se encuentra el elemento en la lista");
}
else
{
    Console.WriteLine("No se encuentra en la lista");
}

Console.WriteLine("Ordenar la lista en frma ascendente.");
Console.WriteLine();
serie.Sort();
Console.WriteLine();

foreach (string s in serie)
{
    Console.WriteLine("Serie - " + s);
}
Console.WriteLine();

serie.Reverse();

Console.WriteLine("Ordena de forma descendente. ");
Console.WriteLine();

foreach (string s in serie)
{
    Console.WriteLine("Serie - " + s);
}
Console.WriteLine();

//Eliminarsh un elemento especifico de la lista
serie.Remove("List");
serie.Sort();
Console.WriteLine("Nueva lista si el elemento");
Console.WriteLine();
foreach (string s in serie)
{
    Console.WriteLine("Serie - " + s);
}
Console.WriteLine();
//Eliminar un elemento especifico de la lista mendiante indice especificoAt
serie.RemoveAt(1);
Console.WriteLine("Nueva lista sin el elemento elegido mediante indice especifico. ");
Console.WriteLine();
foreach (string s in serie)
{
    Console.WriteLine("Serie - " + s);
}
Console.WriteLine();

Console.WriteLine("Cantidad de elementos de la lista: " + serie.Count);
Console.WriteLine("Determinar la cantida de elementos que puede tener la lista" + " " + serie.Capacity);

//vaciar la lista
serie.Clear();
Console.WriteLine("Cantidad de elementos de la lista: " + serie.Count);
Console.WriteLine("Determinar la cantida de elementos que puede tener la lista" + " " + serie.Capacity);