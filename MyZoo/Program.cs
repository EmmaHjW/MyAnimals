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
                Console.Clear();//A presentation and a menu of my animals
                Console.WriteLine("♥ Here is a presentation of animals ♥\n");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("* Press 1 and 'enter' for dogs.\n* Press 2 and 'enter' for horse.\n* Press 3 and 'enter' for cat.\n* Press 'enter' to go back to menu.\n* Press 4 and 'enter' to end program");
                int number = 0;//Here I wanted to catch if user input is wrong. 
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You can only use integer ☺");//First out, if there were a letter instead of number
                }
                Console.Clear();//A presentation and a menu of my animals
                switch (number)//A switch-case to make a good looking and functioning menu
                    {
                        case 1:
                            Dog dog1 = new Dog();
                            dog1.printDog();
                            Dog2 dog2 = new Dog2();
                            dog2.printDog();
                            Dog3 dog3 = new Dog3();
                            dog3.printDog();
                            break;
                        case 2:
                            Horse horse = new Horse();
                            horse.printHorse();
                            break;
                        case 3:
                        Cat cat = new Cat();
                            cat.printCat();
                            break;
                         case 4:
                        continueProgram = false;//And if user want to quit program they get this massage
                            Console.Write("\n");
                            Console.WriteLine("Thank you for visiting my program ♥");
                        break;
                }
                if (number > 4 || number < 1)//Here i catch if user did't type in a number between 1-4. And give them a chance to go back and try again.
                {
                    Console.WriteLine("You need to type a number between 1-4 like it is indicated in the menu , try again please ☺");
                }
               
              Console.ReadKey();
            } while (continueProgram);//Ending program
        }
    }
}
