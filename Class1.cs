using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Loob järjestikuste täisarvude kollektsiooni vahemikus 1 kuni 10
        var numbers = Enumerable.Range(1, 10);

        // Trükib välja kõik elemendid konsoolile
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Trükib välja kõik elemendid konsoolile
        var numbers2 = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

        // Filtritakse ja trükitakse välja kõik elemendid, mis on väiksemad kui 7
        var filteredNumbers = numbers2.TakeWhile(n => n < 7);
        foreach (var number in filteredNumbers)
        {
            Console.WriteLine(number);
        }
    }
}