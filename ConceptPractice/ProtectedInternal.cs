using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
   class ProtectedInternal
    {
       
       protected internal int a;//protected internal variable declaration
        protected internal void print()//protected internal method declaration
        {
            Console.WriteLine("Protected internal");
        }
    }


    //class public1: ProtectedInternal
    class public1

    {
        static void Main()
        {
            ProtectedInternal a1 = new ProtectedInternal();
            // Accessing members of protected internal access specifier that is outside the class
            a1.a = 6;
            a1.print();
          
            //public1 p = new public1();
           // p.a = 10; // Need to inherit protected internal class if u want get feature of Protected.
            Console.ReadLine();
        }
    }


    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }

    class Program1: User
    {
        static void Main(string[] args)
        {
            User u = new User();
            // Complier Error
            // These are inaccessible due to protected specifier
            //u.Name = "This will not accessiable";

            Program1 p = new Program1();
            p.Name = "This will accessiable";
            p.Location = "Hyderabad";
            p.Age = 32;
            p.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();

        }
    }
}


