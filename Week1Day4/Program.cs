using System;

namespace Week1Day4
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
