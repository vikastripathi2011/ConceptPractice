using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
    class LfetOuterJoinLINQ
    {
        /// <summary>Perform left outer joins in linq C# // Perform left outer joins
        /// In order to implement the Linq Left Join in C#, it’s mandatory to use the “INTO” keyword along with the “DefaultIfEmpty()” method.
        /// </summary>
        public static void LeftOuterJoinExample()
        {
            PersonJ magnus = new PersonJ { FirstName = "Magnus", LastName = "Hedlund" };
            PersonJ terry = new PersonJ { FirstName = "Terry", LastName = "Adams" };
            PersonJ charlotte = new PersonJ { FirstName = "Charlotte", LastName = "Weiss" };
            PersonJ arlene = new PersonJ { FirstName = "Arlene", LastName = "Huff" };

            Child barley = new Child { Name = "Barley", Owner = terry };
            Child boots = new Child { Name = "Boots", Owner = terry };
            Child whiskers = new Child { Name = "Whiskers", Owner = charlotte };
            Child bluemoon = new Child { Name = "Blue Moon", Owner = terry };
            Child daisy = new Child { Name = "Daisy", Owner = magnus };

            // Create two lists.
            List<PersonJ> people = new List<PersonJ> { magnus, terry, charlotte, arlene };
            List<Child> childs = new List<Child> { barley, boots, whiskers, bluemoon, daisy };

            var query = from Person in people
                        join child in childs
                        on Person equals child.Owner into gj
                        from subpet in gj.DefaultIfEmpty()
                        select new
                        {
                            Person.FirstName,
                            ChildName = subpet != null ? subpet.Name : "No Child"
                        };
            // PetName = subpet?.Name ?? String.Empty };

            foreach (var v in query)
            {
                Console.WriteLine($"{v.FirstName + ":",-25}{v.ChildName}");
            }
        }

        // This code produces the following output:
        //
        // Magnus:        Daisy
        // Terry:         Barley
        // Terry:         Boots
        // Terry:         Blue Moon
        // Charlotte:     Whiskers
        // Arlene:        No Child
    }

    public class PersonJ
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Child
    {
        public string Name { get; set; }
        public PersonJ Owner { get; set; }
    }
}
    