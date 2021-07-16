using System;

namespace Week1Day4.Esercizio4_optional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esercizio 1: Trovare quante volte un certo carattere è contenuto in una stringa
            //Esercizio1();


            //Esercizio 2: Data una stringa, scrivere un programma che trova il primo carattere non ripetuto.
            //es. mozzarella -> output m
            //es. sottilissimo -> output l
            
            //Esercizio2(); -- NON FINITA --
        }

        private static void Esercizio2()
        {
            Console.WriteLine("***Trova il carattere non ripetuto***");
            Console.WriteLine("Inserisci la stringa che vuoi controllare:");
            string stringa = Console.ReadLine();
            char[] stringaMat =new char[stringa.Length];
            stringaMat = RiempiMatrice(stringa, stringaMat);

            

        }

        private static char[] RiempiMatrice(string stringa, char[] stringMat)
        {
           for(int x =0; x<stringa.Length; x++)
            {
                stringMat[x] = stringa[x];
            }

            return stringMat;
        }

        private static void Esercizio1()
        {
            Console.WriteLine("***Trova il carattere***");
            Console.WriteLine("Inserisci la stringa che vuoi controllare:");
            string stringa = Console.ReadLine().ToLower();
            Console.WriteLine("Inserisci il carattere da cercare: ");
            char carattere = Char.ToLower(Console.ReadKey().KeyChar); ;
            int max=0;
            for(int x =0; x<stringa.Length; x++)
            {
                if(carattere == stringa[x])
                {
                    max++;
                }
            }

            Console.WriteLine($"\n Il carattere {carattere} è stato trovato {max} volte");
            
        }
    }
}
