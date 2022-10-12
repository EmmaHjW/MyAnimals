using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Djur
    {
        public string name = "noName";
        public string breed = "noBreed";
        public string size = "noSize";
        public int age = 0;
        public string gender = "noGender";
        public Djur(string name, string breed, string size, int age, string gender)
        {
            this.name = name;
            this.breed = breed;
            this.size = size;
            this.age = age;
            this.gender = gender;
        }
        public Djur()
        {
        }
        public static void eat()
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
