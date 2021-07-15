using System;
using System.IO;

namespace Week1Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esempio1();
            //Esempio2();

            //lettura su file
            string path1 = @"C:\Users\angelica.cortez\source\repos\Week1Day4\fileProva-automatica.txt";

            //lettura file
            using (StreamReader sw2 = new StreamReader(path1))
            {
                string contenutoFile = sw2.ReadToEnd();
            }

            //lettura riga
            using (StreamReader sw2 = new StreamReader(path1)) 
            {
                string contenutoRiga = sw2.ReadLine();
            }

            using(StreamReader sw2 = new StreamReader(path1)) 
            {
                string contenutoFile = sw2.ReadToEnd();
                string[] arrayRighe = contenutoFile.Split("\r\n");
            }


        }

        private static void Esempio2()
        {
            //Path default con chiusura manuale
            StreamWriter sw = new StreamWriter(@"fileProva.txt");
            sw.WriteLine("Ciao a tutte - utilizzo con path default");
            sw.Close();

            //Path customized con chiusura manuale
            string path = @"C:\Users\angelica.cortez\source\repos\Week1Day4\fileProva-manuale.txt";
            StreamWriter sw1 = new StreamWriter(path);
            sw1.WriteLine("Buongiorno a tutte - utilizzo con path specifico");
            sw1.Close();

            //Path customized con chiusura automatica
            string path1 = @"C:\Users\angelica.cortez\source\repos\Week1Day4\fileProva-automatica.txt";
            using (StreamWriter sw2 = new StreamWriter(path1))
            {
                sw2.WriteLine("Buongiorno - utilizzo con chiusura automatica");
            }
            //Scrittura su file sovrascrivendo il contenuto precedente
            using (StreamWriter sw2 = new StreamWriter(path1))
            {
                sw2.WriteLine("Come state?");
            }

            //Scrittura su file mantenendo il contenuto precedente
            using (StreamWriter sw2 = new StreamWriter(path1, true))
            {
                sw2.WriteLine("Bene grazie!");
            }
        }

        private static void Esempio1()
        {
            //alternativa if else - ternario
            int a = 1;
            int b = 2;
            string c;
            if (a < b)
            {
                c = " a è più piccolo di b";

            }
            else
            {
                c = "a è più grande di b";
            }
            // if ? (allora) : (else allora);
            c = (a < b) ? "a è più piccolo di b" : "a è più grande di b";
            int pari = 0;
            int dispari = 0;

            int n = 10;
            ((n % 2 == 0) ? ref pari : ref dispari)++;

            //Resize array
            int[] mioArray = new int[10];
            mioArray[0] = 1;
            mioArray[1] = 2;
            mioArray[2] = 3;
            for (int i = 0; i < mioArray.Length; i++)
            {
                Console.Write($"{mioArray[i]} \t");
            }

            Array.Resize(ref mioArray, 3);
            Console.Write("\nStampa del mio array dopo il resize\n");
            for (int i = 0; i < mioArray.Length; i++)
            {
                Console.Write($"{mioArray[i]} \t");
            }
            Console.Write("\nStampa del mio array con foreach dopo il resize\n");
            foreach (var item in mioArray)
            {
                Console.Write(item + "\t");
            }
        }
    }
    
}
