using System;
using System.Collections.Generic;
using System.Text;

namespace MyZoo
{
    public class Horse : Djur//Inherited horse from base class
    {
        public string run = "noRun";//New field for this class
        public Horse(string name = "Casablanca", string breed = "Freanch half-breed", string size = "Large", int age = 5, string gender = "Female") : base(name, breed, size, age, gender)//Inherited constructor and also new fields from this sub class
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
            this.run = "galloping fast";
        }
        public virtual void thisHorse()//Methods, both inherited and new ones for this specific sub class
        {
            Console.WriteLine($"My name is {name} and I am a {breed} which is a {size} model.\nI am {age} years old {gender}. Nice meeting you human!");
            Djur.eat();
            Djur.play();
            Djur.sleep();
            this.competes();
            this.makeSound();
        }
        public virtual void makeSound()//Sound inherited from base class and has a new value
        {
            Console.WriteLine("I sound: IIihhhiiiiiiiiii");
        }
        public void competes()//New method for this specific sub class
        {
            Console.WriteLine("I compete in horse jumping");
        }
    }
}
