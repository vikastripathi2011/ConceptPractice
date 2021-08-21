using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    public sealed class SingultonPattern
    {
        private static SingultonPattern obj = null;
        public static readonly Object Padlock = new object();
        private SingultonPattern()
        {
        }
        public static SingultonPattern Instace
        {
            get
            {
                lock (Padlock)
                {
                    if (obj == null)
                    {
                        obj = new SingultonPattern();
                        Console.WriteLine("Creating new instance");
                    }
                  
                }
                return obj;
            }
        }

        //Implementation Example: Lazy initialization
        public static SingultonPattern getSingletonInstance()
        {
            if (null == obj)
            {
                obj = new SingultonPattern();
                Console.WriteLine("Creating new instance SingultonPattern");
                
            }
            return obj;
        }

        public void printSingleton()
        {
            Console.WriteLine("Inside print Singleton");
            Console.ReadLine();
        }
    }
}
