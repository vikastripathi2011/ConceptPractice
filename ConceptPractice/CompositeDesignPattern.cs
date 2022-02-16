using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    /// <summary>
    /// The Composite Design Pattern always forms a tree structure with the objects, where each root element contains sub nodes called child nodes and 
    /// child nodes contain leaf nodes (last label node). Leaf nodes do not contain any elements. Now, in this object hierarchy we can point any node 
    /// and from this node we can traverse all other nodes.
    /// </summary>Why composite pattern?
    /// The Composite Design Pattern is useful when individual objects as well as a group of those kinds of objects are treated uniformly.
    class CompositeDesignPattern
    {
    }

    #region "Simple Method ==> "
    interface IDraw
    {
        void Draw();
    }
    class Circles : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("I am Circl");
        }
    }
    class Squares : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("I am Square");
        }
    }
    class Oval : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("I am Oval");
        }
    }

    #endregion

    #region "Complex Method ==> "
    interface IEmployee
    {
        void Designation();
    }
    class CEO : IEmployee
    {
        public virtual void Designation()
        {
            Console.WriteLine("I am sourav.CEO of Company");
        }
    }
    class HeadManager_1 : CEO, IEmployee
    {
        public override void Designation()
        {
            Console.WriteLine("I am Rick. My Boss is sourav");
        }
    }
    class HeadManager_2 : CEO, IEmployee
    {
        public override void Designation()
        {
            Console.WriteLine("I am Martin. My Boss is sourav");
        }
    }
    class AreaManager : HeadManager_1, IEmployee
    {
        public new void Designation()
        {
            Console.WriteLine("I am Mack. My Boss is Rick");
        }
    }
    #endregion
}
