using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool correct = true;
            do
            {
                try
                {
                    Console.WriteLine("Saisie un âge ");
                    a = Convert.ToInt32(Console.ReadLine());
                    while (a > 110||a<0)
                    {
                        Console.WriteLine("Erreur ");
                        a = Convert.ToInt32(Console.ReadLine());
                    } 
                }
                catch (FormatException)
                { 
                    Console.WriteLine("Erreur de Format");
                }
                finally
                {
                    Console.ReadKey();
                }
            }
            while (correct == true);
        }
    }
}
