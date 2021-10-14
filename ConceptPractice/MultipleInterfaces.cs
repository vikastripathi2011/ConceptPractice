using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    /// <summary>Creating Interface with the Same Method Name 
    ///   Now we create interfaces named A and B.The A and B interfaces contain functions with the same name, Hello().
    /// </summary>
    interface IA
    {
        void Hello();
    }
    interface IB
    {
        void Hello();
    }
    class Test : IA, IB
    {
        void IA.Hello()
        {
            Console.WriteLine("Hello to all-A");
        }
        void IB.Hello()
        {
            Console.WriteLine("Hello to all-B");
        }
    }

    class MultipleInterfaces
    {
        public static void Main()
        {
            IA Obj1 = new Test();
            Obj1.Hello();
            IB Obj2 = new Test();
            Obj2.Hello();
        }
    }

}
