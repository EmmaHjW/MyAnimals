using System;
using System.Collections.Generic;
using System.Text;

namespace MyZoo
{
    public class Cat : Djur//Cat inherited from base class
    {
        public string hunter = "noHunter";//New field for this sub class
        public Cat(string name = "Clarabella", string breed = "Farm cat", string size = "Small", int age = 10, string gender = "Female") : base(name, breed, size, age, gender)//Inherited constructor from base class and new fields for this specific class
        
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
            this.hunter = "Loves to be out hunting";
        }
        public virtual void thisCat()//Methods, both inherited and new one for this specific sub class
        {
            Console.WriteLine($"My name is {name} and I am a {breed} which is a {size} model.\nI am {age} years old {gender}. Nice meeting you human!");
            Djur.eat();
            Djur.play();
            Djur.sleep();
            this.catchesMice();
            this.makeSound();
        }
        public virtual void makeSound()//INherited method from base class but giving a new value
        {
            Console.WriteLine("I sound: Mjaaaaaaaaoowwwwww");
        }
        public void catchesMice()//New method for this specific sub class
        {
            Console.WriteLine("When I hunt, it is most mice and birds. Good sizes for me and my humans hates it *mohahahahaha*");
        }

    }
}
