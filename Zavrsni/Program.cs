using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsni
{
    class Program
    {
        static void Main(string[] args)
        {

            


            Console.WriteLine("Unesite rec: "); //unosenje reci
            string rec = Console.ReadLine();
            char[] nizRec;
            nizRec = rec.ToCharArray();
            char[] copy = nizRec;//kopija reci za proveru

            char[] nizTest = new char[nizRec.Length]; //rec za ispis

            char unos;

            for (int i = 0; i < copy.Length; i++)
            {
                Console.Write("_ "); //linija za broj slova
            }
            bool tacno = false;
            do
            {
                Console.Write("Unesite slovo: ");
                unos = Console.ReadKey().KeyChar;
                Console.WriteLine();
                for (int indeks = 0;  indeks < copy.Length;  indeks++)
                {
                    if (copy[indeks] == unos)
                    {
                        Console.WriteLine("Pogodak! "); //provera unosa
                        nizTest[indeks] = unos;                        
                        tacno = true;
                    }
                }
                Console.WriteLine(nizTest);
            } while (unos != '4');


            Console.ReadKey();
        }
    }
}
