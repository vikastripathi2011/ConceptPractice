using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    /// <summary>Calling constructor from another constructor is known as constructor chaining . Constructor Chaining can be done by the keyword this and base.
    /// Note:-Static constructor cannot be chained. And a public constructor can access a private constructor with the help of constructor chaining.
    /// </summary>
    class ConstructorChaining
    {
    }

    // This Keyword
    public class MyClass
    {
        public string companyName;
        public MyClass() : this("XYZ Company")
        {

        }

        public MyClass(string compname)
        {
            companyName = compname;

        }

    }
    class Program_1
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine(mc.companyName);
            Console.Read();
        }
    }

    //BASE keyword
    public class Abc
    {
        public int p, q;
        public Abc(int p1, int p2)
        {
            p = p1;
            q = p2;
        }
        public int sum(int x, int y)
        {
            return (x + y);
        }

    }

    //derived class/ child class
    public class Pqr : Abc
    {
        public int a;
        public Pqr(int a1, int p1, int p2) : base(p1, p2)
        {
            a = a1;
        }
        public int sub(int x, int y)
        {
            return (x - y);
        }
    }
}
