using Day_10;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_10
{
    public class idException : Exception
    {
        //Overriding the Message property
        public override string Message
        {
            get
            {
                return "book id should be of 5 digits. re-enter";
            }
        }
    }
    //Book Class
    class Book
    {
        public int BookId;
        public string BookName;
        public string Publisher;
        public int Price;
        public int NoPages;
        public string Language;
        public string LoT;
        public string Summary;
        public int ISBN;
    }
    class library:Book//Library Class
    {
        //Get Details From The User
            public void GetData()
            {
            Console.WriteLine("Please enter your BookID");
                BookId = Convert.ToInt32(Console.ReadLine());
            //Check Validations of Id
                if (!(BookId>0 && BookId<5))
                {
                Console.WriteLine("Please Enter 5 Digit Number: ");
                BookId = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Please enter your BookName");
                BookName = Console.ReadLine();
            //Validations of name
            while (string.IsNullOrEmpty(BookName))
            {
                Console.WriteLine("Book Name is a mandatory Field,It can't be empty. Please enter Book Name: ");
                BookName = Console.ReadLine();
            }
            Console.WriteLine("Please enter Publisher");
                Publisher = Console.ReadLine();
                Console.WriteLine("Please enter Price");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Pages");
                NoPages = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Language");
                Language  = Console.ReadLine();
                Console.WriteLine("Please enter lot");
                LoT = Console.ReadLine();
            //Validations for LoT
                if(LoT!=".NET" && LoT!="Java" && LoT != "IMS" && LoT != "V&V" && LoT != "BI" && LoT != "RDBMS")
            {
                Console.WriteLine("Please Enter correct Value!");
                LoT = Console.ReadLine();
            }
                Console.WriteLine("Please enter summary");
                Summary = Console.ReadLine();
            Console.WriteLine("Enter ISBN Number: ");
            ISBN = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    class Class2
    {
    public static Book FindObject(List<Book> b, int ID)
    {
        foreach (var item in b)
        {
            if (item.BookId == ID)
            {
                return item;
            }
        }
        return new Book();
    }
        public static void Main3()
        {
        bool flag = true;
        //Create List Of Books
        List<Book> b = new List<Book>();
        library l = new library();
        while (flag)
        {
            Console.WriteLine("Please enter the choice you want to do \n1.Add Details \n2.Display Details \n3.Delete Record");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1://Enter Details
                    Console.WriteLine("Enter Details:");
                    l.GetData();
                    b.Add(l);
                    break;
                case 2://Display Details
                    Console.WriteLine("Details Are:");
                    Console.WriteLine("Book Id: " + l.BookId);
                    Console.WriteLine("Book Name: " + l.BookName);
                    Console.WriteLine("Publisher Name: " + l.Publisher);
                    Console.WriteLine("Price: " + l.Price);
                    Console.WriteLine("No. of Pages: " + l.NoPages);
                    Console.WriteLine("Language: " + l.Language);
                    Console.WriteLine("LoT: " + l.LoT);
                    Console.WriteLine("Summary: " + l.Summary);
                    Console.WriteLine("ISBN Number: " + l.ISBN);
                    break;
                case 3://Delete Details
                    Console.WriteLine("Enter Book Id You Want to delete: ");
                    int bid = Convert.ToInt32(Console.ReadLine());
                    var id = FindObject(b, bid);
                    b.Remove(id);
                    Console.WriteLine("Your record is successully Deleted.");
                    break;
                default:
                    Console.WriteLine("Enter Valid Choice!");
                    break;
            }
            if (!flag)
            {
                break;
            }
        }
        }
    }

