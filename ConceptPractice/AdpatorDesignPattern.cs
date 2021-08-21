using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    /// <summary>
    /// Basically the Adaptor Design Pattern is relevant when two different classes talk with each other. Sometimes a situation may occur like that, you cannot change anything in an existing class and at the same time another class wants to talk with the existing class. In that situation we can implement a middle-level class called an adaptor class and by using the adaptor class both classes are able to talk with each other.
    /// </summary>
    class AdpatorDesignPattern
    {
    }

    interface ILaptop
    {
        void ShowModel();
    }
    class HP_Laptop : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("I am HP Laptiop");
        }
    }
    class Sony_Laptop : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("I am Sony Laptop");
        }
    }
    class Compaq_Laptop : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("I am Compaq Laptop");
        }
    }
    class LaptopAdaptor : ILaptop
    {
        public void ShowModel() { }
        public static void ShowModel(ILaptop obj)
        {
            obj.ShowModel();
        }
    }
    class Person
    {
        public void SwitchOn(ILaptop obj)
        {
            LaptopAdaptor.ShowModel(obj);
        }
    }
}
