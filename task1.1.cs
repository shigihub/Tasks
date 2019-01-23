using System;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i<21; i++) {

                Console.WriteLine(i);
                if (i == 13) {

                    Console.WriteLine("This is my lucky number");
                }

            }
            Console.ReadKey();
        }
    }
}
