// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



IEnumerable<int> test = [1, 22, 3, 4, 5, 6, 7];


var dump = test.Select((x,i) => $"Index: {i} || Value: {x}");


foreach (string item in dump)
{

    Console.WriteLine(item);

}