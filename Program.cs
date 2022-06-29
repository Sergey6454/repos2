using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            while (true)
            {
                Console.WriteLine("1-Ввести А\n" +
                     "2-Ввести В\n" +
                     "3-Сложить А и В\n" +
                     "4-Вычесть В из А\n" +
                     "5-Умножить А на В\n" +
                     "6-Делить В на А\n");
                int rez = int.Parse(Console.ReadLine());

                if(rez == 1)
                {
                   a = int.Parse(Console.ReadLine());
                }



















                if(rez == 2)
                {
                    b = int.Parse(Console.ReadLine());
                }










                if(rez == 3)
                {
                    Console.WriteLine(a + b);
                }













                if(rez == 4)
                {
                    Console.WriteLine(a - b);
                }











                if(rez == 6)
                {
                    Console.WriteLine(a/b);
                }




















                if(rez == 5)
                {
                    Console.WriteLine(a * b);
                }


























                 




















                  


            }


        }
    }
}
