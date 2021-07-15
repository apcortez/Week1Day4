using System;

namespace Week1Day4.Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gioco del lancio dei Dadi

            //Si chiede all'utente quanti dadi vuole lanciare.
            //L'utente inserisce un numero per provare ad indovinare
            //la somma dei valori usciti dal lancio dei dadi.


            //Il computer lancia i dadi, quindi sorteggia i numeri(random tra 1 e 6).


            //Se la somma dei  numeri random è uguale al numero scelto dall'utente, l'utente vince
            //Se l'utente vince, stampare 'hai vinto', altrimenti 'hai perso'.

            //Finita la partita, l'utente deve poter rigiocare.

            //Requisiti:
            //            Verificare che l'utente inserisca un intero e che sia compreso tra i valori possibili/accettabili.
            //Se la verifica non va a buon fine, l'utente deve potere inserire nuovamente qualcosa.

            //Opzionale->Creare un metodo per l'inserimento dei numeri e la verifica,
            //uno per il controllo della vittoria(da chiamare nel main).

            Console.WriteLine("***Gioco dei Dadi***");
            do
            {
                Console.WriteLine("Quanti dadi vuoi lanciare?");
                bool isValid = int.TryParse(Console.ReadLine(), out int dadi);
                if (isValid && dadi > 0)
                {
                    int[] arrayDadi = new int[dadi];
                    arrayDadi = GeneraDadi(arrayDadi);
                    stampaDadi(arrayDadi);
                    Console.WriteLine($"Indovina quanto è la somma dei {dadi} dadi: ");
                    bool isSomma = int.TryParse(Console.ReadLine(), out int somma_utente);
                    if (isSomma)
                    {
                        
                        int somma = SommaDadi(arrayDadi);
                        ConfrontoVittoria(somma, somma_utente);
                    }
                    else
                    {
                        Console.WriteLine("Input non valido. Riprova");
                    }


                }
                else
                {
                    Console.WriteLine("Numeri di dadi inseriti non valido. Riprova.");
                }
                Console.WriteLine("Vuoi continuare a giocare? Scrivi 'si' per proseguire\n");
            } while (Console.ReadLine() == "si");

        }

        private static void stampaDadi(int[] arrayDadi)
        {
            foreach (var dado in arrayDadi) {
                Console.Write(dado + "\t");
            }
            Console.WriteLine("\n");
        }

        private static void ConfrontoVittoria(int somma, int somma_utente)
        {
            if (somma == somma_utente)
            {
                Console.WriteLine("Bravo! HAI VINTO!");
            }
            else
            {   
                Console.WriteLine("Peccato! HAI PERSO! =(");
                Console.WriteLine($"La somma dei dadi è {somma}");
            }
        }

        private static int SommaDadi(int[] arrayDadi)
        {
            int somma =0;
            foreach(var dado in arrayDadi)
            {
                somma = somma + dado;
            }

            return somma;
        }

        private static int[] GeneraDadi(int[] dadi)
        {
           
            Random random = new Random();

            for (int x = 0; x < dadi.Length; x++)
            {
                dadi[x] = random.Next(1, 7);
            }

            return dadi;
        }
    }
}
