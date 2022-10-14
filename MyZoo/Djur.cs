using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Djur//My base class
    {
        public string name; //Fields
        public string breed;
        public string size;
        public int age;
        public string gender;
        public Djur(string name = "noName", string breed = "noBreed", string size = "nosize", int age = 0, string gender = "noGender")//Constructor with default
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
        }
        public static void eat()//Methods
        {
            Console.WriteLine("Chew slaffs slaffs");
        }
        public static void sleep()
        {
            Console.WriteLine("Snore snore dream away");
        }
        public static void play()
        {
            Console.WriteLine("Play with me");
        }
        public virtual void makeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}
