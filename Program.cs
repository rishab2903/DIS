using System;

namespace Practices
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many years experience do you have in professional programming?");
            string input = Console.ReadLine();
            if (int.Parse(input) != 0)
            {
                for (int i = 0; i < (int.Parse(input)); i++)
                {
                    Console.WriteLine("You have" + input + "years of experience");
                }
            }
            else
            {
                Console.WriteLine("You have zero years of experience");
            }



        }
        
    }
}
