using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConceptPractice.BridgeDesignPattern;

namespace ConceptPractice
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            int[,,] x = new int[3, 2, 3];
            int lnt = x.Length;
            int [] arr= CandiDistribution.GetCandies(10, 3);

            var val = EncryptionAndDecryption.DecodeForUrlBase64("AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAA+GktGuR4p0arlf40oTnNhwQAAAACAAAAAAADZgAAwAAAABAAAACpeQYnT315WQUWCw6PXFegAAAAAASAAACgAAAAEAAAANXds2Uri6Y+KwmvAnvfPQOoAQAAPXUm2qUP0k5Nm0sdyzBOE++oybdfRV6DcFtixkRf7ITmjrk/UBkKeBamBmkgav0B3rPZm66hEXaNKiAiYB4zNwBm5xG2+YPwdMMASzcPAJZzKs+01W4CQnfAMq7NZE9m1KKx9QHQHAdwAptydyHR3QWdVAdgvuf3XaMpeAd1DSlJVdlbm44OYTyuPcpOcaSBDe4GFYMhk2uwNGtKbgf2XfvLRurekXupo9XRCJOm3rk/8481WsX0wfI3DLKiLKJcxIS8rKGmpUzHWRqStjazuDtI5hLtMFKYDxhU+v/UtrGshCqyhgIRxXWfrrKNAM8AinaO+oWw2ys8OS+5hmEsO3Pe2w2+6cH2p5Rd7lo6CPhw93Th/omasnGnmqRrUAYhvpXIVZMDTor0VF2NdeMDVquM5KmYeGDRwrmGW+x8H4Udd2T/uJ9J4DvgsIWHfQcJJXDELoSE7W7iOeeDRGdb00qBLVWpYRbYjNjhPwCwsGlH+b8b5gTX4xpCY3cxBzhu+Q74/UnNWbGz4/PR7mUkl4RbVOpChQq9EW70z+tpKirn7f62/kyaORQAAABFdtrUTfovVywJsVEBlcaqOq0kUw==");

            #region  "Exploring The Singulton Design Pattern ==>"
            Console.WriteLine("********** Exploring The Singulton Pattern *******************************");
            //If we now call Singleton class from the client class as:
            SingultonPattern.Instace.PrintSingleton();
            SingultonPattern.Instace.PrintSingleton();
            SingultonPattern.GetSingletonInstance().PrintSingleton();
            SingultonPattern.GetSingletonInstance().PrintSingleton();
            SingultonPattern.GetSingletonInstance().PrintSingleton();
            // Console.ReadLine();
            #endregion

            #region  "Exploring The Factory Design Pattern ==>"
            Console.WriteLine("********************** Exploring The Factory Pattern ***********************");
            //Step 4-: Use the Factory to get object of concrete class by passing an information such as type.
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape reactangle = shapeFactory.GetShape("Reactangle");
            reactangle.Draw();

            IShape circle = shapeFactory.GetShape("Circle");
            circle.Draw();

            IShape square = shapeFactory.GetShape("Square");
            square.Draw();
            #endregion

            #region  "Exploring The Abstract Factory Design Pattern ==>"
            Console.WriteLine("************************ Exploring The Abstract Factory Pattern **************");

            //Step 5-: Use the Abstract Factory to get object of concrete class by passing an information such as type.
            AbsVehicleFactory factory = new ConcreteVehicleFactory();
            ConcreteVehicleFactory _factory = new ConcreteVehicleFactory();

            IFactory _scooter = _factory.GetVehicle("_Scooter");
            _scooter.Drive(10);

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);
            #endregion

            #region  "Exploring The Bridge Design Pattern ==>"
            Console.WriteLine("************************ Exploring The Bridge Design Pattern **************");

            MailSendBridge mb = new MailSendBridge();
            CSharp_Mail objCS = new CSharp_Mail();
            VB_Mail objVB = new VB_Mail();
            mb.SendFrom(objCS);    //Mail send from C# cod  
            mb.SendFrom(objVB);  //Mail Send from VB Code 
            #endregion

            #region  "Exploring The Prototype Design Pattern ==>"
            Console.WriteLine("************************ Exploring The Prototype Design Pattern **************");
            InvitationCard obj1 = new InvitationCard();
            obj1.p_To = "Ram";
            obj1.p_Title = "My birthday invitation";
            obj1.p_content = "Hey guys !! I am throwing a cheers party in my home";
            obj1.SendBy = "Sourav";
            obj1.p_Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //Here our first object has created  
            InvitationCard[] objList = new InvitationCard[5];
            String[] nameList = { "Ram", "Shyam", "Hari", "Tapan", "Sukant" };
            int i = 0;
            foreach (String name in nameList)
            {
                //objList[i] = new InvitationCard();  
                objList[i] = obj1.CloneMe(obj1);
                objList[i].p_To = nameList[i];
                i++;
            }
            // Print all Invitation Card here  
            foreach (InvitationCard obj in objList)
            {
                Console.WriteLine("To :- " + obj.p_To);
                Console.WriteLine("Title :- " + obj.p_Title);
                Console.WriteLine("Content :- " + obj.p_content);
                Console.WriteLine("Send By :- " + obj.p_SendBy);
                Console.WriteLine("Date :- " + obj.Date);
                Console.WriteLine("\n");
            }

            #endregion

            #region  "Exploring The Decorator Design Pattern ==>"
            Console.WriteLine("************************ Exploring The Decorator Factory Pattern **************");
            Car objCarAC = new WithAC();
            objCarAC.CarType();
            Console.WriteLine("\n");
            Car objCarAll = new WithSoundSystemAndAC();
            objCarAll.CarType();
            #endregion

            #region  "Exploring The Composite Design Pattern ==>"    
            Console.WriteLine("************************ Exploring The Composite Factory Pattern **************");

            //Simple Method
            ArrayList objLists = new ArrayList();
            IDraw objcircl = new Circles();
            IDraw objSquare = new Squares();
            IDraw objOval = new Oval();
            objLists.Add(objcircl);
            objLists.Add(objSquare);
            objLists.Add(objOval);
            foreach (IDraw obj in objLists)
            {
                obj.Draw();
            }

            //Complex Method
            IEmployee AreaManager = new AreaManager();
            IEmployee Hm_1 = new HeadManager_1();
            IEmployee CEO = new CEO();
            List<IEmployee> objEmployee = new List<IEmployee>();
            objEmployee.Add(AreaManager);
            objEmployee.Add(Hm_1);
            objEmployee.Add(CEO);
            foreach (IEmployee O in objEmployee)
            {
                O.Designation();
            }
            Console.ReadLine();


            #endregion

            #region  "Exploring The Adpator Design Pattern ==>"    
            Console.WriteLine("************************ Exploring The Adpator Design  Pattern **************");
            Person p = new Person();
            p.SwitchOn(new HP_Laptop()); //On HP Laptop  
            p.SwitchOn(new Compaq_Laptop()); //On Compaq laptop  

            #endregion

            #region  "Exploring The Memento Design Pattern ==>"    
            Console.WriteLine("************************ Exploring The Memento Design Factory Pattern **************");

            Persons objP = new Persons();
            Console.WriteLine("Name : " + objP.Name);
            Console.WriteLine("Surname : " + objP.Surname);

            Console.WriteLine("Enter choice: Update/Revert");
            var foo = Console.ReadLine();
            
            if (foo.ToLower() == "update")
            {
               
                Console.WriteLine("Plz Enter a Name");
                var Name = Console.ReadLine();
                Console.WriteLine("Plz Enter a Surname");
                var Surname = Console.ReadLine();
                objP.Update(Name, Surname);
            }
            else if (foo.ToLower() == "revert")
            {
                objP.Revert();
               
            }
            else
                Console.WriteLine("Sorry! You have not made any choice.");

            Console.WriteLine("/t New Name : " + objP.Name);
            Console.WriteLine("/t New Surname : " + objP.Surname);
            Console.WriteLine("************************ Now I want to Revert **************");
            
            objP.Revert();
            Console.WriteLine("/t Old Name : " + objP.Name);
            Console.WriteLine("/t Old Surname : " + objP.Surname);

            #endregion

            #region  "Exploring The Observer Design Pattern ==>"    
            Console.WriteLine("************************ Exploring The Observer Design Pattern **************");
            //Generate exception to notify all client  
            try
            {
                throw new ApplicationException("This is Exception");
            }
            catch (Exception ex)
            {
                INotifyObserver obj_1 = new MailNotify();
                INotifyObserver obj_2 = new SMSNotify();
                clsNotifier O = new clsNotifier();
                O.AddService(obj_1);
                O.AddService(obj_2);
                O.ExecuteNotifier();
            }

            #endregion

            #region  "Exploring The Decoupling  ==>"    
            Console.WriteLine("************************ Exploring The Decoupling  **************");

            Consumer C = new Consumer(new Server());
            C.Execute();

            //Now the question is, how will it help us? What is the facility for that? Let's change the class name from Server to Server123.

            Consumer Cc = new Consumer(new Server123());
            Cc.Execute();

            //Let's change the class name from Consumer to Consumer123.

            Consumer123 Ccc = new Consumer123(new Server());
            Ccc.Execute();

            #endregion


            Console.ReadKey();
        }
    }
}
