using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Dog : Djur
    {
        public string greets = "noGreets";
        public Dog(string name, string breed, string size, int age, string gender) : base(name, breed, size, age, gender)
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
            this.greets = "Tail wag";
        }
        public Dog()
        {
            this.name = "Ralph";
            this.breed = "Papillon";
            this.size = "Small";
            this.age = 7;
            this.gender = "Male";
            this.greets = "Tail wag";
        }
        public virtual void thisDog()
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
     public class Dog2 : Dog
    {
        public string act = "noAct";

        public Dog2(string name, string breed, string size, int age, string gender) : base(name, breed, size, age, gender)
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
            this.greets = greets;
            this.act = "clumsy";
        }
        public Dog2()
        {
            this.name = "Texas";
            this.breed = "Rhodesian ridgeback";
            this.size = "Huge";
            this.age = 3;
            this.gender = "Male";
            this.greets = "jumping up and down";
            this.act = "clumsy";
        }
        public override void thisDog()
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
        public void guard()
        {
            Console.WriteLine("I watch over my family, no matter what!");
        }
    }

    public class Dog3 : Dog
    {
        public string behavior = "noBehavior";

        public Dog3(string name, string breed, string size, int age, string gender) : base(name, breed, size, age, gender)
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
            this.greets = greets;
            this.behavior = behavior;
        }
        public Dog3()
        {
            this.name = "Skrållan";
            this.breed = "Bichon havanais";
            this.size = "Small";
            this.age = 2;
            this.gender = "Female";
            this.greets = "run away by seeing my chance when new humans are visiting";
            this.behavior = "sneaky";
        }
        public override void thisDog()
        {
            Console.WriteLine($"My name is {name} and I am a {breed} which is a {size} model.\nI am {age} years old {gender}.\nWhen I meet you I {greets}, I can be a bit {behavior}");
            this.stubborn();
            this.makeSound();
            Djur.eat();
            Djur.play();
            Djur.sleep();
        }
        public override void makeSound()
        {
            Console.WriteLine("I sound: VAFFVAFFVAFFVAFF");
        }
        public void stubborn()
        {
            Console.WriteLine("I do what ever I can to make my owners life a living hell");
        }
    }
}
