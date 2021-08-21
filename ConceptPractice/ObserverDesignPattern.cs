using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{

    /// <summary>
    /// The concept is, one or more systems will be the observer simultaneously and if necessary they can start their action. It's like a bodyguard. Right? Let's talk about a notification system where the user can send notifications in various ways. They may use SMS notification or Mail Notification or Event Log.
    /// </summary>
    class ObserverDesignPattern
    {
    }

    interface INotifyObserver
    {
        void Notify();
    }
    class MailNotify : INotifyObserver
    {
        public void Notify()
        {
            Console.WriteLine("Notify through Mail");
        }
    }
    class EventNotify : INotifyObserver
    {
        public void Notify()
        {
            Console.WriteLine("Notify through Event");
        }
    }
    class SMSNotify : INotifyObserver
    {
        public void Notify()
        {
            Console.WriteLine("Notify through SMS");
        }
    }

    class clsNotifier
    {
        public ArrayList ALNotify = new ArrayList();
        /// <summary>  
        /// Add object of notification System  
        /// </summary>  
        /// <param name="obj">Object is notification class</param>  
        public void AddService(INotifyObserver obj)
        {
            ALNotify.Add(obj);
        }
        /// <summary>  
        /// Remove object of notification System  
        /// </summary>  
        /// <param name="obj">Object of notification Calss</param>  
        public void RemoveService(INotifyObserver obj)
        {
            ALNotify.Remove(obj);
        }
        public void ExecuteNotifier()
        {
            foreach (INotifyObserver O in ALNotify)
            {
                //Call all notification System  
                O.Notify();
            }
        }
    }
}
