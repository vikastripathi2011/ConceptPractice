using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    /// <summary> Author : VRT, 01/05/2019
    /// As the name suggests, prototype means making a copy of something that exists. when we need to create the same object again and again 
    /// then we will implement a Prototype Design Pattern
    /// </summary>
    class PrototypeDesignPattern
    {
    }

    class InvitationCard
    {
        public String To;
        public String Title;
        public String Content;
        public String SendBy;
        public DateTime Date;
        public String p_To
        {
            get { return To; }
            set { To = value; }
        }
        public String p_Title
        {
            get { return Title; }
            set { Title = value; }
        }
        public String p_content
        {
            get { return Content; }
            set { Content = value; }
        }
        public String p_SendBy
        {
            get { return SendBy; }
            set { SendBy = value; }
        }
        public DateTime p_Date
        {
            get { return Date; }
            set { Date = value; }
        }
        public InvitationCard CloneMe(InvitationCard obj)
        {
            return (InvitationCard)this.MemberwiseClone();
        }
    }
}
    //static void Main(string[] args)
    //{
    //    InvitationCard obj1 = new InvitationCard();
    //    obj1.p_To = "Ram";
    //    obj1.p_Title = "My birthday invitation";
    //    obj1.p_content = "Hey guys !! I am throwing a cheers party in my home";
    //    obj1.SendBy = "Sourav";
    //    obj1.p_Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
    //    //Here our first object has created  
    //    InvitationCard[] objList = new InvitationCard[5];
    //    String[] nameList = { "Ram", "Shyam", "Hari", "Tapan", "Sukant" };
    //    int i = 0;
    //    foreach (String name in nameList)
    //    {
    //        //objList[i] = new InvitationCard();  
    //        objList[i] = obj1.CloneMe(obj1);
    //        objList[i].p_To = nameList[i];
    //        i++;
    //    }
    //    // Print all Invitation Card here  
    //    foreach (InvitationCard obj in objList)
    //    {
    //        Console.WriteLine("To :- " + obj.p_To);
    //        Console.WriteLine("Title :- " + obj.p_Title);
    //        Console.WriteLine("Content :- " + obj.p_content);
    //        Console.WriteLine("Send By :- " + obj.p_SendBy);
    //        Console.WriteLine("Date :- " + obj.Date);
    //        Console.WriteLine("\n");
    //    }
    //    Console.ReadLine();
    //}


