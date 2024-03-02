using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.OrderByAge
{
    internal class Program
    {
        //OrderByAge - 
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            bool N = true;
            while (N)
            {
                string[] data = Console.ReadLine().Split(' ');
                if (data[0] == "End")
                {
                    N = false;
                    break;
                }
                else
                {
                    string name = data[0];
                    string ID = data[1];
                    int age = int.Parse(data[2]);

                    Person person = new Person(name, ID, age);
                    if (IDCheck(people, ID))
                    {
                        person.Name = name;
                        person.Age = age;
                    }
                    else
                    {
                        person.Age = age;
                        person.Name = name;
                        person.ID = ID;

                        people.Add(person);
                    }
                }
            }
            foreach (Person person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
        static bool IDCheck(List<Person> people, string ID)
        {
            foreach (Person currentPerson in people)
            {
                if (currentPerson.ID == ID)
                {
                    return true;
                }
            }
            return false;
        }
        public class Person
        {
            public Person(string name, string iD, int age)
            {
                Name = name;
                ID = iD;
                Age = age;
            }

            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
        }
    }
}
