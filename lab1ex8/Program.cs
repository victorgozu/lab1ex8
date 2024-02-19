/*
 * Ex8
Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele
trei valori in ordine descrescatoare.
• Exemplu: citim 3 9 0 Afisam : 9 3 0
*/


Console.WriteLine("Introduceti numarul intreg x");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti numarul intreg y");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti numarul intreg z");
int z = int.Parse(Console.ReadLine());

if ((x > y) && (x > z))
    if (y > z)
    {
        Console.WriteLine("Ordinea descrescatoare a numerelor este: " + x + ";" + y + ";" + z);
    }
    else
    {
        Console.WriteLine("Ordinea descrescatoare a numerelor este: " + x + ";" + z + ";" + y);
    }
else if ((y > x) && (y > z))
{
    if (x > z)
    {
        Console.WriteLine("Ordinea descrescatoare a numerelor este: " + y + ";" + x + ";" + z);
    }
    else
    {
        Console.WriteLine("Ordinea descrescatoare a numerelor este: " + y + ";" + z + ";" + x);
    }
}
else if ((z > x) && (z > y))
    if (x > y)
    {
        Console.WriteLine("Ordinea descrescatoare a numerelor este: " + z + ";" + x + ";" + y);
    }
    else
    {
        Console.WriteLine("Ordinea descrescatoare a numerelor este: " + z + ";" + y + ";" + x);
    }