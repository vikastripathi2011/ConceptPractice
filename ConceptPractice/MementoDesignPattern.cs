using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{

    /// <summary>
    /// The Memento Design Pattern is useful when we want to save data in a temporary location and depending on the user's needs we can retrieve the old data.
    /// </summary>
    class MementoDesignPattern
    {
        public String Name { get; set; }
        public string Surname { get; set; }
        public MementoDesignPattern(String Name, String Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
    }

    public class Persons
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        MementoDesignPattern objMPerson = null;
        public Persons()
        {
            Name = "Sourav";
            Surname = "Kayal";
            objMPerson = new MementoDesignPattern(Name, Surname);
        }
        public void Update(String name, string Surname)
        {
            this.Name = name;
            this.Surname = Surname;
        }
        public void Revert()
        {
            Name = objMPerson.Name;
            Surname = objMPerson.Surname;
        }
    }
    public class MomentoPersons
    {
        //no tin use
    }
}
