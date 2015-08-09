using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            PeopleCollectionEnumerationExample();

            Console.ReadLine(); 
        }

        public static void PeopleCollectionEnumerationExample()
        {
            PeopleCollection people = new PeopleCollection();
            people.AddPerson(new Person()
            {
                Name = "Mike", 
                Age = 22
            });

            people.AddPerson(new Person()
            {
                Name = "Kate",
                Age = 17
            });

            people.AddPerson(new Person()
            {
                Name = "John",
                Age = 20
            });

            Console.WriteLine("All people");
            foreach (Person person in people)
                Console.WriteLine(person);

            Console.WriteLine("\r\nUnder age people");
            foreach (Person person in people.GetUnderAgePeople())
                Console.WriteLine(person);

            Console.WriteLine("\r\nTake people until under aged");
            foreach(Person person in people.GetPeopleUntilUnderAged())
                Console.WriteLine(person);
        }
    }
}
