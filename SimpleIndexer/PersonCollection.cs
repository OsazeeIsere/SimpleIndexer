using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    // Indexer allows you to access items in an arraylike fashion
    public class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        private Dictionary<string, Person> listOfPeople = new Dictionary<string, Person>();

        //Cast for caller
        public Person GetPerson(int pos) => (Person)arPeople[pos];

        // insert only persons
        public void AddPerson(Person p)
        {
            arPeople.Add(p);

        }
        public void ClearPerson(Person p)
        {
            arPeople.Clear();

        }

        //Custom indexer for this class
        public Person this[int index]
        {
            get => (Person)arPeople[index];
            set => arPeople.Insert(index, value);
            
            //count = arPeople.Count;
            
        }
        //Custom indexer for the dictionary class
        public Person this[string name]
        {
            get => (Person)listOfPeople[name];
            set => listOfPeople[name]= value;

        }
        public void ClearPeople()
        {
            listOfPeople.Clear();

        }
        public int count => arPeople.Count;
        public int Count => listOfPeople.Count;
        IEnumerator IEnumerable.GetEnumerator() => listOfPeople.GetEnumerator();
        //public IEnumerator GetEnumerator()
        //{
        //    return arPeople.GetEnumerator();
        //}
        //above code can be written as such
     //   IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }
}
