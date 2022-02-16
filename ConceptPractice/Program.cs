using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConceptPractice.BridgeDesignPattern;

namespace ConceptPractice
{
    class Program : A
    {
        static Program()
        {
            Console.WriteLine("Static constructor of Class Program");
        }
        public Program()
        {
            Console.WriteLine("public Constructor of class Program");
        }


        static void Main(string[] args)
        {

            /**************** Reverse Array ***********************/
            int ai,j=0; string reve;
            string[] ArrString = { "a", "b", "c", "d" };

            for (ai = ArrString.Length-1; ai >= 0; ai--)
            {
               Console.WriteLine( ArrString[ai]); 
            }
            /**************** End Reverse Array ***********************/
            //var integers = new ArrayList();
            //integers.Add(1);
            //integers.Add(2);
            //integers.Add("3");
            
            //for (int si = 0; si < integers.Count; ++si)
            //{
            //    int integer = (int)integers[si];
            //    Console.WriteLine(integer);
            //}


            // Function call
            Console.WriteLine(FindMissingPositive());

            //Q: Is the code compliable if yes what is the output
            //Implementer obj = new Implementer();
            //IRejecter obj = new Implementer();
            //obj.Show();
            //obj.Hide();


            StringPelimdrom();
            ToUpperEveryWord();

            BaseClass b = new BaseClass();
            b.Print();
            b = new DerivedClass();
            b.Print();

            DerivedClass d = new DerivedClass();
            d.Print();
            //d = new BaseClass();
            // d.Print();

            SecondLargestElement();

            /**************************Number Of Occurrences Of Character****************************/
            NumberOfOccurrencesOfCharacter();
            RepeatedCharsString();
            RepeatedCharsString_2();

            /************************** Reverse Int ****************************/
            Console.Write("Enter a int : ");
            string inputInt = Console.ReadLine();
            int rev = ReverseInt(Convert.ToInt32(inputInt));
            Console.Write("Number in reverse order: " + rev);

            /************************** Sort Numbers In Ascending Order ****************************/

            SortNumbersInAscendingOrder();

            /******************************************************/

            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string resultString = string.Empty; int xi; int count = 1;
            char charDuplicateString;
            for (xi = 0; xi < inputString.Length; xi++)
            {
                if (!resultString.Contains(inputString[xi]))
                {
                    resultString += inputString[xi];
                    Console.WriteLine(resultString);
                    count = 1;
                }
                else
                {
                    count++;
                    charDuplicateString = inputString[xi];
                    Console.WriteLine(charDuplicateString + " --> caharector is Repeated in string : " + count);

                }
            }
            //Console.WriteLine(resultString);
            Console.ReadKey();

            /******************************************************/

            int[,,] x = new int[3, 2, 3];
            int lnt = x.Length;

            /******************************************************/

            A a = new A();
            a.ID = 1;
            a.Name = "Visal";
            UpdateA(a);
            Console.WriteLine(a.Name);


            /******************************************************/

            //Case 1
            Console.WriteLine("Main");

            //case2
            A aa = new A();

            Console.ReadLine();


            int[] arr = CandiDistribution.GetCandies(10, 3);

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


        public static void UpdateA(A a)
        {
            a.Name = "Ahmad";


            Parents obj1 = new Parents();
            obj1.Show();

            Parents obj2 = new Childs();
            obj2.Show();

            //Childs obj3 = new Parents();
            //obj3.Show();

            Childs obj4 = new Childs();
            obj4.Show();
        }

        /************************* Count Repeated Chars in String.*****************************/
        public static void RepeatedCharsString()
        {
            Console.WriteLine("Enter a string");
            string inputstring = Console.ReadLine();

            Console.WriteLine("Enter to know the reperted char");
            char ch = Convert.ToChar(Console.ReadLine());

            char[] Inputstring = inputstring.ToCharArray();
            char Ch = ch; int result = 0;
            int cntofchar = Inputstring.Length;
            foreach (char chr in Inputstring)
            {
                if (chr == Ch)
                {
                    result++;
                }
            }
            Console.WriteLine(Ch + " caharector is Repeated in string :" + result + " times.");
        }

        //Using Dictionary to Count the Number of Occurrences of character in C#:
        public static void NumberOfOccurrencesOfCharacter()
        {
            Console.Write("Enter the string : ");
            string message = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in message.Replace(" ", string.Empty))
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }
            Console.ReadKey();
        }


        /************************* Count Repeated Chars in String.*****************************/
        public static void RepeatedCharsString_2()
        {
            Console.WriteLine("Enter a string");
            string inputstring = Console.ReadLine();

            for (int i = 0; i < inputstring.Length; i++)
            {
                char[] InputstringChar = inputstring.ToCharArray();
                int result = 0;
                foreach (char chr in InputstringChar)
                {
                    if (chr == inputstring[i])
                    {
                        result++;
                    }
                }
                Console.WriteLine(inputstring[i] + " caharector is Repeated in string :" + result + " times.");
            }
        }

        /************************* Reverse Integer No.*****************************/
        public static void SortNumbersInAscendingOrder()
        {
            int i;
            int[] a = new int[30]; // Array Declaration in C#  
            Console.Write("Enter the Number of values to be Sort : ");
            // read the string value (by default) and convert it in to integer  
            int n = Convert.ToInt16(Console.ReadLine());
            //Reading the values one by one  
            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the No " + i + ":");
                // read the string value (by default) and convert it in to integer  
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            //Sorting the values  
            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            //Display the Ascending values one by one  
            Console.Write("Ascending Sort : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            //Waiting for output
            Console.ReadKey();
        }

        /************************* Reverse Integer No.*****************************/
        public static int ReverseInt(int num)
        {
            int result = 0;
            int n = 12345;
            int left = n;
            int rev = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
                /*******************************/
                int r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10);
            }
            return result;
        }

        /************************* Find Second largest element in an array.*****************************/
        public static int SecondLargestElement()
        {
            int[] myArray = new int[] { 0, 4, 2, 3, 13, -8, 5 };
            int secondHighest = (from number in myArray
                                 orderby number descending
                                 select number).Distinct().Skip(1).First();


            int Result = SecondLargestElement2(myArray);
            return secondHighest;

        }
        public static int SecondLargestElement2(int[] array)
        {
            array = array.OrderByDescending(c => c).Distinct().ToArray();
            switch (array.Count())
            {
                case 0:
                    return -1;
                case 1:
                    return array[0];
            }

            SecondLargestElement3();
            return array[1];
        }

        public static void SecondLargestElement3()
        {
            int[] myArray = new int[] { 0, 11, 2, 15, 16, 8, 16, 8, 15 };
            int Smallest = myArray.Min();
            int Largest = myArray.Max();
            foreach (int i in myArray)
            {
                Console.WriteLine("Array element is :" + i);
                if (i > Smallest && i < Largest)
                {
                    Smallest = i;
                }
            }
            Console.WriteLine("Second largest element is : " + Smallest);
            Console.ReadLine();
        }

        // Function to find the smallest
        // positive missing number
        public static int FindMissingPositive()
        {
            int[] arr = { 2, 3, -7, 6, 8, 1, -10, 15 };
            int n = arr.Length;

            int m = 1; // Default smallest Positive Integer
           
            // Store values in set which are
            // greater than variable m
            HashSet<int> x = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                // Store value when m is less than
                // current index of given array
                if (m < arr[i])
                {
                    x.Add(arr[i]);
                }
                else if (m == arr[i])
                {
                    // Increment m when it is equal
                    // to current element
                    m = m + 1;

                    while (x.Contains(m))
                    {
                        x.Remove(m);

                        // Increment m when it is one of the
                        // element of the set
                        m = m + 1;
                    }
                }
            }
          var smallestPositiveInt = FindMissingPositive2(arr);
            // Return the required answer
            return m;
        }

        public static int FindMissingPositive2(int[] arr)
        {
            int smallestInt = 1;

            if (arr.Length == 0) return smallestInt;

            Array.Sort(arr);

            if (arr[0] > 1) return smallestInt;
            if (arr[arr.Length - 1] <= 0) return smallestInt;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == smallestInt)
                {
                    smallestInt++;
                }
            }

            return smallestInt;
        }

        public static string ToUpperEveryWord()
        {
            string strInput = "convert each word of this string to capital";
            // Check for empty string.  
            if (string.IsNullOrEmpty(strInput))
            {
                return string.Empty;
            }

            var words = strInput.Split(' ');

            var t = "";
            foreach (var word in words)
            {
                t += char.ToUpper(word[0]) + word.Substring(1) + ' ';
            }
            return t.Trim();
        }

        public static void StringPelimdrom()
        {
            string inputString, revs = "";
            Console.WriteLine(" Enter string");
            inputString = Console.ReadLine();
            for (int i = inputString.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += inputString[i].ToString();
            }
            if (revs == inputString) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", inputString, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", inputString, revs);
            }

            //2nd Method

            char[] rev = inputString.ToCharArray();
            Array.Reverse(rev);
            string revr = new string(rev);
            if (inputString.Equals(revr))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");


            Console.ReadKey();
        }


    }


    public class Parents
    {
        int i = 0;
        public virtual void Show()
        {
            Console.WriteLine("virtual - " + i); i++;
        }
    }

    public class Childs : Parents
    {
        int i = 0;
        public override void Show()
        {
            Console.WriteLine("Override - " + i); i++;
        }
    }

    class A
    {
        public int ID { get; set; }
        public string Name { get; set; }

        static A()
        {
            Console.WriteLine("Static constructor of class A");
        }

        public A()
        {
            Console.WriteLine("public Constructor of class A");
        }
    }

    class BaseClass
    {
        public virtual void Print()
        {
            System.Console.WriteLine("BaseClass");
        }
    }
    class DerivedClass : BaseClass
    {
        public new void Print()
        {
            System.Console.WriteLine("DerivedClass");
        }
    }
}


public interface IProjecter
{
    void Show();
}
public interface IRejecter
{
    void Hide();
}
public class Implementer : IProjecter, IRejecter
{
    void IRejecter.Hide()
    {
        Console.WriteLine("I am rejecting");
    }

    void IProjecter.Show()
    {
        Console.WriteLine("I am projecting");
    }
}
//public class Program
//{
//    public static void Main(string[] args)
//    {
//    Q: Is the code compliable if yes what is the output
//        Implementer obj = new Implementer();
//        obj.Show();
//        obj.Hide();
//    }
//}





