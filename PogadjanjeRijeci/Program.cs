using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogadjanjeRijeci
{
    class Program
    {
        static void Main(string[] args)
        {   

            

            char unos;

            string zavrsnaRec;
            char[] rec = "test".ToCharArray();
            string test = Console.ReadLine();
            char[] arr;
            arr = test.ToCharArray();
            string pogodak = rec;
            for (int i = 0; i < rec.Length; i++)
            {   
                Console.Write("_ ");
            }
            do
            {
                Console.WriteLine();
                unos = Console.ReadKey().KeyChar;
                Console.WriteLine();
                bool tacno = false;
                for (int i = 0; i < rec.Length; i++)
                {
                    if(pogodak[i] == unos)
                    {
                        test[i] = unos;
                        pogodak += unos;
                        
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine();

            } while (unos != '4');
        }
    }
}
