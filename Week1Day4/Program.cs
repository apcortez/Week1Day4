using System;

namespace Week1Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //alternativa if else
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

            c = (a < b) ? "a è più piccolo di b" : "a è più grande di b";
            int pari = 0;
            int dispari = 0;

            int n = 10;
            ((n % 2 == 0) ? ref pari : ref dispari)++;

           
        }
    }
}
