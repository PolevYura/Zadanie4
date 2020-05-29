using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList() { 1, 0, 23, "d", 891, "G", "d", 97, "Y", 10, 45, "e", "a", "k", 45 };
            ArrayList up = new ArrayList(100);

            for (int i = 0; i < a.Count; i++)
            {
                Console.Write(a[i] + " | ");
            }
            Console.WriteLine();

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] is string)
                {
                    a.RemoveAt(i);
                    if (a[i] is string) i--;
                }
            }

            for (int i = 0; i < a.Count; i++)
            {
                Console.Write(a[i] + " | ");
            }
        }
    }
}
