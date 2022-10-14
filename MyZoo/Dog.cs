using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Dog : Djur//Inherited class, from base class to sub class
    {
        public string greets = "noGreets";//New field for this sub class
        public Dog(string name = "Ralph", string breed = "Papillon", string size = "Small", int age = 7, string gender = "Male") : base(name, breed, size, age, gender)//Inherited my constructor to sub class from base class
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
            this.greets = "Tail wag";//One new field for this specific class(DOG)
        }
        public virtual void thisDog()//Methods that is inherited from base class
        {
            Console.WriteLine($"My name is {name} and I am a {breed} which is a {size} model.\nI am {age} years old {gender}. When I see you I greet you with a {greets} Nice meeting you human!");
            this.makeSound();
            Djur.eat();
            Djur.play();
            Djur.sleep();
;        }
        public virtual void makeSound()
        {
            Console.WriteLine("I sound: VoffVoff");
        }
    }
     public class Dog2 : Dog//My second inherited sub class from another sub class
    {
        public string act = "noAct";//New field for this specific class

        public Dog2(string name = "Texas", string breed = "Rhodesian ridgeback", string size = "Huge", int age = 3, string gender = "Male") : base(name, breed, size, age, gender)//Inharited constructor form base class an also first sub class
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
            this.greets = "jumping up and down";
            this.act = "clumsy";
        }
        public override void thisDog()//Methods, both inherited and new for this class
        {
            Console.WriteLine($"My name is {name} and I am a {breed} which is a {size} model.\nI am {age} years old {gender}.\nWhen I meet you I will be {greets} and I can be a bit {act} because it is so nice meeting you human!");
            this.guard();
            this.makeSound();
            Djur.eat();
            Djur.play();
            Djur.sleep();
        }
        public override void makeSound()
        {
            Console.WriteLine("I sound: VOFFVOFF!");
        }
        public void guard()//New method
        {
            Console.WriteLine("I watch over my family, no matter what!");
        }
    }
    public class Dog3 : Dog//Inherited class from sub class and also base class
    {
        public string behavior = "noBehavior";//New field for this specific class

        public Dog3(string name = "Skrållan", string breed = "Bichon havanais", string size = "Small", int age = 2, string gender = "Female") : base(name, breed, size, age, gender)//Inherited constructor from base and sub classes and new field from this class
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
            this.greets = "run away by seeing my chance when new humans are visiting";
            this.behavior = "sneaky";
        }
        public override void thisDog()//Methods, both inherited and new for this specific class
        {
            Console.WriteLine($"My name is {name} and I am a {breed} which is a {size} model.\nI am {age} years old {gender}.\nWhen I meet you I {greets}, I can be a bit {behavior}");
            this.stubborn();
            this.makeSound();
            Djur.eat();
            Djur.play();
            Djur.sleep();
        }
        public override void makeSound()//Method that have been through all classes, inherited from base class with new value for all sub classes
        {
            Console.WriteLine("I sound: VAFFVAFFVAFFVAFF");
        }
        public void stubborn()//New method for this specific class
        {
            Console.WriteLine("I do what ever I can to make my owners life a living hell");
        }
    }
}
