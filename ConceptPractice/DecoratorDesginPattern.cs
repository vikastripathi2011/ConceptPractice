using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    /// <summary>
    /// If there is a need to produce one object with many features but not all the features are needed all the time then the Decorator Design Pattern is useful.
    /// </summary>
    class DecoratorDesginPattern
    {
    }

    public class Car
    {
        public virtual void CarType()
        {
            Console.WriteLine("Simple Car");
        }
    }
    public class WithAC : Car
    {
        public override void CarType()
        {
            //base.CarType();  
            Console.Write("AC Car");
        }
    }
    public class WithSoundSystemAndAC : WithAC
    {
        public override void CarType()
        {
            base.CarType();
            Console.WriteLine("with Sound system");
        }
    }
}
