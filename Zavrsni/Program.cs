using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zavrsni
{
    class Program
    {
        static void Main(string[] args)
        {
            

                string[] reci = File.ReadAllLines("reci.txt");
                
            Random nasumicnaRec = new Random();
            var randomLinijaBroj = nasumicnaRec.Next(0, reci.Length - 1);
            var linija = reci[randomLinijaBroj];
            
            char[] nizRec;
            nizRec = linija.ToCharArray();
            char[] copy = nizRec;//kopija reci za proveru

            char[] nizTest = new char[nizRec.Length]; //rec za ispis
            //string unosRec;
            char unos;

            for (int i = 0; i < copy.Length; i++)
            {
                Console.Write("_ "); //linija za broj slova
            }
            bool tacno = false;
            do
            {
                Console.WriteLine();
                Console.Write("Unesite slovo: ");
                unos = Console.ReadKey().KeyChar;
                Console.WriteLine();
                for (int indeks = 0; indeks < copy.Length; indeks++)
                {
                    if (copy[indeks] == unos)
                    {
                        Console.WriteLine("Pogodak! "); //provera unosa
                        nizTest[indeks] = unos;
                        tacno = true;
                    }
                    
                }
                foreach (char c in nizTest)
                {
                    if(c != '\0')
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
            } while (unos != '4');


            Console.ReadKey();
        }
    }
}
