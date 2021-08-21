using System;

namespace ConceptPractice
{
    /// <summary> AUthor : VRT, 01/05/2019
    /// As the name suggests, it makes a bridge between two components. Here the component may be two classes or any other entity. So the Bridge Design Pattern basically makes a channel between two components. And in this way it helps to create a de-couple architecture. We can communicate with two classes through the bridge component without changing existing class definitions.
    /// </summary>
    class BridgeDesignPattern
    {
        public interface IMessage
        {
            void Send();
        }
        public class CSharp_Mail : IMessage
        {
            public void Send()
            {
                Console.WriteLine("Mail send from C# code");
            }
        }
        public class VB_Mail : IMessage
        {
            public void Send()
            {
                Console.WriteLine("Mail send from VB Code");
            }
        }
        public class Databas_Mail : IMessage
        {
            public void Send()
            {
                Console.WriteLine("Mail send from Database");
            }
        }
        public class MailSendBridge
        {
            public void SendFrom(IMessage obj)
            {
                obj.Send();
            }
        }
    }
}
