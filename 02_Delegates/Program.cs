using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates
{
    // 1) Declares delegate type
    delegate void StringProcessor(string input);

    class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }

        public void Say(string message) // 2) comptabile instance methods
        {
            Console.WriteLine("{0} says {1}", name, message);
        }
    }

    class Background
    {
        public static void Note(string note) // 3) compatible static methods
        {
            Console.WriteLine("({0})", note);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person ismael = new Person("Ismael");
            Person allen = new Person("Allen");
            
            StringProcessor ismaelVoice, allenVoice, background; // 4) create delegate instances
            ismaelVoice = new StringProcessor(ismael.Say); // 5) invoke delegate instances
            allenVoice = new StringProcessor(allen.Say);
            background = new StringProcessor(Background.Note);

            ismaelVoice("Hello, son...");
            allenVoice.Invoke("Hello, Daddy!");
            background("An airplance flies past.");

            //anonymous types
            var jon = new { Name = "Jon", Age = 12 };
            var tom = new { Name = "Tom", Age = 12 };

            jon = tom;
            Console.WriteLine(" Name: {0} , Age: {1}", jon.Name, jon.Age);

            Console.ReadLine();
        }
    } 
}
