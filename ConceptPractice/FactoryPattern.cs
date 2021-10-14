using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    class FactoryPattern
    {
    }

    //Step 1-:    Create an interface.
    public interface IShape
    {
        void Draw();
    }
   
    //Step 2-:    Create concrete classes implementing the same interface.
    public class Reacatangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }


    //Step 3-:    Create a Factory to generate object of concrete class based on given information.
    public class ShapeFactory
    {
        ////use getShape method to get object of type shape 
        public IShape GetShape(string shapeType)
        {
            switch (shapeType)
            {
                case "Reactangle":
                    return new Reacatangle();
                case "Circle":
                    return new Circle();
                case "Square":
                    return new Square();
                default:
                    throw new ApplicationException(string.Format("shapeType '{0}' cannot be created", shapeType));

            }
        }
    }
}
