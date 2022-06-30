using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userWork, userSignOfTheZodiac;
            int userAge;
            
            Console.WriteLine("Как вас зовут?");
            userName = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у вас знак зодиака?");
            userSignOfTheZodiac = Console.ReadLine();
            Console.WriteLine("Где вы работаете?");
            userWork = Console.ReadLine();

            Console.WriteLine($"Вас зовут {userName}, вам {userAge} год, вы {userSignOfTheZodiac} и работаете на {userWork}.");
        }
    }
}
