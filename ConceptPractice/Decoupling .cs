using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    /// <summary>
    /// Decoupling is very important in application development. It helps up to attach and detach components of any class without affecting another class.
    //The main goal of decoupling is to reduce dependency.Let's use an example to understand the concept. Think about a Desktop computer. If the monitor does not work then we just unplug it and replace it with a new one, even a different brand would work.
    //If the hard disk does not work then we just unplug it(hope you know how to unplug it! Ha..Ha) and install a new one.Now, think of how to decouple each and every component? When we are changing one, it does not at all affect other components and the computer is running happily.
    /// </summary>
    class Decoupling
    {
    }
    public interface IService
    {
        void Serve();
    }
    public class Server123 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Server executes");
        }
    }
    public class Server : IService
    {
        public void Serve()
        {
            Console.WriteLine("Server executes");
        }
    }
    public class Consumer
    {
        IService obj;
        public Consumer(IService temp)
        {
            this.obj = temp;
        }
        public void Execute()
        {
            obj.Serve();
        }
    }

    public class Consumer123
    {
        IService obj;
        public Consumer123(IService temp)
        {
            this.obj = temp;
        }
        public void Execute()
        {
            obj.Serve();
        }
    }
}
