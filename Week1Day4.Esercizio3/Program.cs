using System;
using System.IO;

namespace Week1Day4.Esercizio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***INDOVINA IL NUMERO***");
            Console.WriteLine("Come ti chiami?");
            string utente = Console.ReadLine();
            Console.WriteLine($"Benvenuto {utente}!");
            Menu();
            int numeroUtente = 1;
            bool vittoria=false;
            bool isvalid = int.TryParse(Console.ReadLine(), out int scelta);
            while (isvalid && scelta == 1 && numeroUtente!=0 && !vittoria)
            {
                
                if (vittoria)
                {
                    break;
                }
                int tentativo = 0;
                int numero = generaNumero();
                scriviNumeroSegreto(numero);
                Console.WriteLine("\nIo ho già pensato ad un numero, prova ad indovinare!");
                Console.WriteLine("Inserisci un numero da 1 a 100. Inserisci 0 per terminare: ");
                
                while (!vittoria && scelta == 1)
                {

                     numeroUtente = sceltaUtente();
                    if(numeroUtente == 0)
                    {
                        break;
                    }else if (numeroUtente == numero)
                    {
                        Console.WriteLine("Bravo! Hai indovinato il numero!");
                        vittoria = true;
                        break;
                    }
                    else
                    {
                        if (numeroUtente > numero)
                        {
                            Console.WriteLine("Prova con un numero più basso");
                            

                        }
                        else
                        {
                            Console.WriteLine("Prova con un numero più alto");
                        }
                        tentativo++;
                        Console.WriteLine($"Finora hai effettuato {tentativo} tentativi.");
                        Console.WriteLine($"Inserisci il tuo {tentativo} tentativo (0 per interrompere la partita):");
                    }
                    
                }
               
            }
            Console.WriteLine("Ciao! Alla prossima!");
        }

        private static void scriviNumeroSegreto(int numero)
        {
            string path = @"C:\Users\angelica.cortez\source\repos\Week1Day4\Week1Day4.Esercizio3\numeroSegreto.txt";

            //lettura file
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine($"Il numero segreto è {numero}");
            }
        }

        private static int sceltaUtente()
        {
            int scelta;
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 100)
            {
                Console.WriteLine("Scelta non consentita. Riprova: ");
            }
            Console.WriteLine("\n");
            return scelta;
        }
        private static int generaNumero()
        {
            Random x = new Random();
            return x.Next(1, 101);
        }

        private static void Menu()
        {
            Console.WriteLine("\nFai la tua scelta tra:");
            Console.WriteLine($"1 - PLAY");
            Console.WriteLine($"0 - EXIT");
            
        }

    }
}