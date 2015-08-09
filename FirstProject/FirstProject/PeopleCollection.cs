using FirstProject.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class PeopleCollection : IEnumerable<Person>
    {
        private List<Person> _peopleCollection = new List<Person>();

        public void AddPerson(Person person)
        {
            if (person.Age <= 0)
                throw new InvalidAgeException("Not allowed age");

            _peopleCollection.Add(person);
        }

        /// <summary>
        /// Custom enumerator implementation - gets under age people
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Person> GetUnderAgePeople()
        {
            foreach(Person person in _peopleCollection)
            {
                if (person.Age < 21)
                    yield return person; 
            }
        }

        public IEnumerable<Person> GetPeopleUntilUnderAged()
        {
            foreach (Person person in _peopleCollection)
            {
                if (person.Age < 21)
                {
                    yield break; 
                }

                yield return person;
            }
        }

        #region IEnumerable

        public IEnumerator<Person> GetEnumerator()
        {
            return _peopleCollection.GetEnumerator(); 
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
