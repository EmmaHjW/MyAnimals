using System;
using System.Collections.Generic;
using System.Text;

namespace MyZoo
{
    public class Cat : Djur
    {
        public string hunter = "noHunter";
        public Cat(string name, string breed, string size, int age, string gender) : base(name, breed, size, age, gender)
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
            this.hunter = hunter;
        }
        public Cat()
        {
            this.name = "Clarabella";
            this.breed = "Farm cat";
            this.size = "Small";
            this.age = 10;
            this.gender = "Female";
            this.hunter = "Loves to be out hunting";
        }
        public virtual void thisCat()
        {
            Console.WriteLine($"My name is {name} and I am a {breed} which is a {size} model.\nI am {age} years old {gender}. Nice meeting you human!");
            Djur.eat();
            Djur.play();
            Djur.sleep();
            this.makeSound();
        }
        public virtual void makeSound()
        {
            Console.WriteLine("I sound: Mjaaaaaaaaoowwwwww");
        }
        public void catchesMice()
        {
            Console.WriteLine("When I hunt, it is most mice and birds. Good sizes for me and my humans hates it *mohahahahaha*");
        }

    }
}
