using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    /// <summary>The Proxy design pattern provides a surrogate or placeholder for another object to control access to it.
    /// Again, a Proxy Design Pattern acts as main point of contact for the resources that should not be available directly to the client code.
    /// </summary>
    /* * *  *  * 
     * Benefits:

    One of the advantages of Proxy pattern is security.
    This pattern avoids duplication of objects which might be huge size and memory intensive. This in turn increases the performance of the application.
    The remote proxy also ensures about security by installing the local code proxy (stub) in the client machine and then accessing the server with help of the remote code.
    Drawbacks/Consequences:

    This pattern introduces another layer of abstraction which sometimes may be an issue if the RealSubject code is accessed by some of the clients directly and some of them might access the Proxy classes. This might cause disparate behaviour.

    Interesting points:

    There are few differences between the related patterns:

    Like Adapter pattern gives a different interface to its subject, 
    while Proxy patterns provides the same interface from the original object but 
    the decorator provides an enhanced interface.Decorator pattern adds additional behaviour at runtime.
    Proxy used in Java API: java.rmi.*;

    */
    class ProxyDesigPattern
    {
    }
    public class Employee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Employee(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }

    //Subject (ISharedFolder): 
    public interface ISharedFolder
    {
        void PerformRWOperations();
    }

    //RealSubject (SharedFolder):
    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }

    //Proxy (SharedFolderProxy):
    class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee employee;
        public SharedFolderProxy(Employee emp)
        {
            employee = emp;
        }
        public void PerformRWOperations()
        {
            if (employee.Role.ToUpper() == "CEO" || employee.Role.ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                folder.PerformRWOperations();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }

    class Program_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            Employee emp1 = new Employee("Anurag", "Anurag123", "Developer");
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerformRWOperations();
            Console.WriteLine();
            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee emp2 = new Employee("Pranaya", "Pranaya123", "Manager");
            SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
            folderProxy2.PerformRWOperations();
            Console.Read();
        }
    }

    /***************************** 2nd Way *******************************
     * https://dotnettutorials.net/lesson/proxy-design-pattern/
     * https://www.c-sharpcorner.com/UploadFile/b1df45/proxy-design-pattern-using-C-Sharp/
     * https://www.geeksforgeeks.org/proxy-design-pattern/
     * let say we have two users X and Y and they want to access a particular resource through the proxy server. First, user X request a particular resource (let say a list of employees) and cache that resource for a certain amount of time. Later, user Y also requests the same resource, then the Proxy server instead of forwarding that request to the actual server (which is a time-consuming operation), can simply return the data from the cache. Since the client and the proxy server are in the same network, so it is going to be a much faster operation.
     * 
     * 
     * ********************************************************************/

    public interface IPrice
    {
        Int32 Getprice();
    }
    public class GoldPrice : IPrice
    {
        public Int32 Getprice()
        {
            Random rnd = new Random();
            return rnd.Next(999, 99999);
        }
    }

    public class ProxyAPI
    {
        IPrice _Price;
        public Int32 GetCurrentPrice(bool getPrice)
        {
            if (getPrice)
            {
                _Price = new GoldPrice();
                return _Price.Getprice();
            }
            else
                return 0;
        }

    }
}
