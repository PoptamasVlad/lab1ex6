using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
            descrescatoare.
                • Exemplu: citim 3,9,0 Afisam : 9 3 0*/

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            if(x >= y && y >= z)
            {
                Console.WriteLine(x + " " + y + " " + z);
            }
            else if (x >= z && z >= y)
            {
                Console.WriteLine(x + " " + z + " " + y);
            }
            else if (y >= x && x >= z)
            {
                Console.WriteLine(y + " " + x + " " + z);
            }
            else if (y >= z && z >= x)
            {
                Console.WriteLine(y + " " + z + " " + x);
            }
            else if (z >= y && y >= x)
            {
                Console.WriteLine(z + " " + y + " " + x);
            }
            else
            {
                Console.WriteLine(z + " " + x + " " + y);
            }
        }
    }
}
