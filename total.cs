using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sonuc = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for(int i = a; i <= b; i++)
            {
                sonuc += i;
            }
            Console.WriteLine(sonuc);
        }
    }
}
