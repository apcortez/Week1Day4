using System;
using System.IO;

namespace Week1Day4.Esercizio4
{
    class Program
    {   //Scrivere un programma che permetta all'utente di creare la sua lista della spesa.

        //Si chiede all'utente quanti prodotti vuole inserire nell'elenco. (numero intero valido e positivo).
        //Quindi si chiede all'utete di inserire i prodotti (esempio "uova", "pasta"..).
        //Non si possono inserire 2 prodotti uguali.
        //(Opzionale: "uova", "UOVA", "Uova" sono da intendersi uguali, quindi no-case-sensitive)

        //Se l'utente inserisce un prodotto già presente, gli si mostra un messaggio del tipo "prodotto già inserito".
        //Completato l'elenco della spesa, stampare un riepilogo con tutti i prodotti che ha inserito l'utente.

        //Requisiti: utilizzare un array (non una lista). Utilizzare le routine (es. ScriviListaSpesa e StampaListaSpesa)

        //Opzionale. Stampare la lista della spesa su un file "listaSpesa.txt" invece che a video.

        static void Main(string[] args)
        {
            
            Console.WriteLine("***GESTIONE LISTA SPESA***");
            Console.WriteLine("Quanti prodotti vuoi inserire nella lista?");
            int numero_prodotti;
            while (!int.TryParse(Console.ReadLine(), out numero_prodotti) && numero_prodotti<0)
            {
                Console.WriteLine("Numero di prodotti non validi. Riprova: ");
            }


        string[] listaSpesa = ScriviListaDellaSpesa(numero_prodotti);
            scriviLista(listaSpesa);
        StampaListaSpesa(listaSpesa);
         
    }

        private static void scriviLista(string[] listaSpesa)
        {
            string path = @"C:\Users\angelica.cortez\source\repos\Week1Day4\Week1Day4.Esercizio4\ListaSpesa.txt";

            //lettura file
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("**Lista della Spesa**");
                for(int x=0; x<listaSpesa.Length; x++)
                {
                    sw.WriteLine($"{x + 1}. {listaSpesa[x]}");
                }
                
            }
        }

        private static void StampaListaSpesa(string[] listaSpesa)
    {
        Console.WriteLine("Ecco il riepilogo della tua lista della spesa");
        for (int i = 0; i < listaSpesa.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {listaSpesa[i]}");
        }
    }

    private static string[] ScriviListaDellaSpesa(int n)
    {
        string[] products = new string[n];


        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"Inserisci il {i + 1}° prodotto");
            string product = Console.ReadLine().ToUpper();

            int found = Array.IndexOf(products, product);

            if (found > -1) 
            {
                Console.WriteLine($"Hai già inserito {product}!");
                i--; //torno indietro e scrivo un altro prodotto
            }
            else
            {
                products[i] = product; 
            }
        }
        return products;
    }
}
}
