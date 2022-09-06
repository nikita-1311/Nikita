using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    abstract class Animal 
    {
        private string Name;
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
    class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine(" is Eating");
        }
    }
    class Class2
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            Console.WriteLine("Enter a dog name");
            dog.SetName(Console.ReadLine());
            Console.Write(dog.GetName());
            dog.Eat();
        }
    }
}
