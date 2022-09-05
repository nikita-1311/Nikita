using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    //types of inheritence
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking");
        }
    }
    class BabyDog : Dog
    {
        public void weep()
        {
            Console.WriteLine("Weeping......");
        }

    }
    class Class9
    {
        public static void Main()
        {
            BabyDog d1 = new BabyDog();
            d1.eat();
            d1.bark();
            d1.weep();
        }
    }
}
