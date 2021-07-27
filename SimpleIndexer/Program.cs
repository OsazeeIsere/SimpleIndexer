using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Data;
namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with indexer");
            PersonCollection myPeople = new PersonCollection();
            //Add objects with indexer syntax
            myPeople[0] = new Person("Jason", "Isere", 11);
            myPeople[1] = new Person("Joan", "Isere", 8);
            myPeople[2] = new Person("Amanda", "Udoka", 5);
            //indexing with a string as in dictionary
            myPeople["Harmo"] = new Person("Harmony", "isere", 7);


            //now obtain and display each item using indexer
            for (int i = 0; i <myPeople.count; i++)
            {
                Console.WriteLine("Person number: {0} is {1}",i,myPeople[i].FirstName);
            }
            //print from the dictionary
            Person harmo = myPeople["Harmo"];
            Console.WriteLine("From the dictionary: {0}",harmo.ToString());

            UseGenericListOfPeople();
            MultiIndexerWithDataTable();


            Console.ReadLine();

        }//

        private static void MultiIndexerWithDataTable()
        {
            //make a Simple data tabe with 3 column
            DataTable myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn("First Name"));
            myDataTable.Columns.Add(new DataColumn("Last Name"));
            myDataTable.Columns.Add(new DataColumn("Age"));
            //now add a row to the table
            myDataTable.Rows.Add("Jason", "Isere", 11);

            //use multidimentional indexer to get details of first row
            Console.WriteLine("Fun with Data table");

            Console.WriteLine("First Name: {0}",myDataTable.Rows[0][0]);
            Console.WriteLine("Last Name: {0}", myDataTable.Rows[0][1]);
            Console.WriteLine("Age: {0}", myDataTable.Rows[0][2]);


        }

        public static void UseGenericListOfPeople()
        {
            Console.WriteLine("An indexer of List");
            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person("osas", "Isere", 12));
            myPeople.Add(new Person("Harmony","isere",7));
            //use an indexer to change person info
            myPeople[0] = new Person("Epa", "Isere", 4);

            //now obtain and display each item using indexer

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Name: {0} {1}", myPeople[i].LastName, myPeople[i].FirstName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);

            }
        }
    }
}
