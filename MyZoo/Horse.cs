using System;
using System.Collections.Generic;
using System.Text;

namespace MyZoo
{
    public class Horse : Djur
    {
        public string run = "noRun";
        public Horse(string name, string breed, string size, int age, string gender) : base(name, breed, size, age, gender)
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
            this.run = "noRun";
        }
        public Horse()
        {
            this.name = "Casablanca";
            this.breed = "Freanch half-breed";
            this.size = "Large";
            this.age = 5;
            this.gender = "Female";
            this.run = "galloping fast";
        }
        public virtual void thisHorse()
        {
            Console.WriteLine($"My name is {name} and I am a {breed} which is a {size} model.\nI am {age} years old {gender}. Nice meeting you human!");
            Djur.eat();
            Djur.play();
            Djur.sleep();
            this.makeSound();
        }
        public virtual void makeSound()
        {
            Console.WriteLine("I sound: IIihhhiiiiiiiiii");
        }
        public void competes()
        {
            Console.WriteLine("I compete in horse jumping");
        }
    }
}
