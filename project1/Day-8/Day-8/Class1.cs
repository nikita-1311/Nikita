using System;
using System.Collections.Generic;
using System.Text;

namespace Day_8
{
    //custom exceptions
    class MyException:Exception 
    {
        public MyException(string message):base(message)
        {

        }
    }
    class Class1
    {
        public static void Main2()
        {
            try
            {
                Validate(14);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Validate(int age)
        {
            if(age<18)
            {
                throw new MyException("Please enter valid age: ");
            }
            else
            {
                Console.WriteLine("Valid age");
            }
        }
    }
}
