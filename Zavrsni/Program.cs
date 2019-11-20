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
            //kako da proverim je li rec ili 

            string[] reci = File.ReadAllLines("reci.txt");
                
            Random nasumicnaRec = new Random();
            var randomLinijaBroj = nasumicnaRec.Next(0, reci.Length - 1);
            var linija = reci[randomLinijaBroj];
            
            char[] nizRec;
            nizRec = linija.ToCharArray(); //linija je random rec iz fajla
            char[] copy = nizRec;//kopija reci za proveru

            char[] nizTest = new char[nizRec.Length]; //rec za ispis

            string unos;
            string unos2;

            bool tacno = false;
            char biranje;
            do
            {
                Meni();
                biranje = Console.ReadKey().KeyChar;
                Console.WriteLine();
                bool izlazC1 = false;
                switch (biranje)
                {
                    case '1':
                        {
                            for (int i = 0; i < copy.Length; i++)
                            {
                                Console.Write("_ "); //linija za broj slova
                            }
                            do
                            {   
                                Console.WriteLine();
                                Console.Write("Unesite slovo: ");

                                unos = Console.ReadLine();
                                Console.WriteLine();
                                for (int indeks = 0; indeks < copy.Length; indeks++)
                                {
                                    if (copy[indeks] == unos)
                                    {
                                        Console.WriteLine("Pogodak! "); //provera unosa
                                        nizTest[indeks] = unos;

                                    }
                                }
                                foreach (char c in nizTest)
                                {
                                    if (c != '\0')
                                    {
                                        Console.Write(c);
                                    }
                                    else
                                    {
                                        Console.Write("_ ");
                                    }
                                }
                                if (copy == nizTest)
                                {
                                    izlazC1 = true;
                                }
                            } while (!izlazC1);   
                            break;
                        }

                    case '2':

                        break;
                }
                
                
            } while (biranje != '3');


            Console.ReadKey();
        }
        static void Meni()
        {
            Console.WriteLine("1 -- Igraj! \n" +
                              "2 -- Top Lista: \n" +
                              "3 -- Izlaz! \n" +
                              "==================\n" +
                              "Izaberite opciju: \n");
        }
    }
}
