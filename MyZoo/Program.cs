using System;

namespace MyZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true; // Doing a do-while loop for my menu

            do
            {
                Console.Clear();
                Console.WriteLine("♥ Här kommer en presentation av djur ♥\n");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("* Tryck 1 och 'enter' för hundar.\n* Tryck 2 och 'enter' för häst.\n* Tryck 3 och 'enter' för katt.\n* Tryck 'enter' för att komma tillbaka till menyn.\n* Tryck 4 och 'enter' för att avsluta programmet");
             
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Dog dog1 = new Dog();
                        dog1.thisDog();
                        Dog2 dog2 = new Dog2();
                        dog2.thisDog();
                        Dog3 dog3 = new Dog3();
                        dog3.thisDog();
                        break;
                    case 2:
                        Horse horse = new Horse();
                        horse.thisHorse();
                        break;
                    case 3:
                        Cat cat = new Cat();
                        cat.thisCat();
                        break;
                    default:
                        continueProgram = false;
                        Console.Write("\n");
                        Console.WriteLine("Tack för att du besökte mitt program ♥");
                        break;
                }
                Console.ReadKey();
            } while (continueProgram);
        }
    }
}
