using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    /// <summary> AUthor : VRT, 01/05/2019
    /// An abstract factory pattern acts as a super-factory that creates other factories. An abstract factory interface is responsible for creating a set of related objects or dependent objects without specifying their concrete classes.
    /// </summary>
    class AbstractFactoryPattern
    {
    }

    //Step 1-:    Create an interface for Shapes.
    public interface IFactory
    {
        void Drive(int miles);
    }

    //Step 2-:    Create concrete classes implementing the same interface.
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }

    //Step 3-:  Create an Abstract class to get factories for Vehicle Objects.
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class AbsVehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);

    }

    //Step 4-:    Create Factory classes inherite to AbstractFactory to generate object of concrete class based on given information.
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteVehicleFactory : AbsVehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                case "_Scooter":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }

    }

}
