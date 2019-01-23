using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] sa =new int[] {14,2,56,89,9,47,55,66,44,1};



            for (int i = 0; i < 9; i++)
            {

                if (sa[i]<10) {
                    Console.WriteLine(sa[i]+" Lower than 10" );
                }
                else {
                    Console.WriteLine(sa[i]+" Greater  than 10");
                }

            }
           Console.ReadKey();
        }
    }
}
