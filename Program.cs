
namespace Lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> personlist = new List<Person>();
            AddPerson(personlist);
            Age_Below90_Infirst2Cases(personlist);
            Age_between_13to18(personlist);
            AverageAge(personlist);
            Name_listperson_PresentorNot(personlist);
            Age_GreaterThan60(personlist);
            RemoveName_fromList(personlist);
        }
        private static void AddPerson(List<Person> personlist)
        {
            personlist.Add(new Person("1234567890", "Azar", "17th Street", 25));
            personlist.Add(new Person("1234567891", "Afridi", "15th Street", 15));
            personlist.Add(new Person("1234567892", "Ameer", "18th Street", 17));
            personlist.Add(new Person("1234567893", "Arif", "19th Street", 14));
            personlist.Add(new Person("1234567894", "Azmath", "12th Street", 65));
            personlist.Add(new Person("1234567895", "Aman", "11th Street", 90));

            foreach (Person person in personlist)
            {
                Console.WriteLine("Person SSN is " + person.SSN + ", Name is " + person.Name + ", Adress is " + person.Address + ", Age is " + person.Age);
            }
            Console.WriteLine();
        }
        private static void Age_Below90_Infirst2Cases(List<Person> person)
        {
            foreach (Person person1 in person.FindAll(e => (e.Age < 60)).Take(2))
            {
                Console.WriteLine(person1.Name + " " + person1.Age);
            }
            Console.WriteLine();
        }

        private static void Age_between_13to18(List<Person> person)
        {
            foreach (Person person1 in person.FindAll(e => (e.Age < 18 && e.Age > 13)))
            {
                Console.WriteLine(person1.Name + " " + person1.Age);
            }
            Console.WriteLine();
        }
        private static void AverageAge(List<Person> person)
        {
            double avgAge = person.Average(e => e.Age);
            Console.WriteLine("Average Age is " + avgAge);
            Console.WriteLine();
        }

        private static void Name_listperson_PresentorNot(List<Person> person)
        {
            Console.WriteLine("Enter the Name");
            string eName = Console.ReadLine();
            bool exisit = person.Exists(e => e.Name == eName);
            if (true)
            {
                Console.WriteLine("exist");
            }
            else
            {
                Console.WriteLine("not exist");
            }
            Console.WriteLine();

        }
        private static void Age_GreaterThan60(List<Person> person)
        {
            foreach (Person person1 in person.FindAll(e => (e.Age > 60)))
            {
                Console.WriteLine(person1.Name + " " + person1.Age);
            }
            Console.WriteLine();
        }
        private static void RemoveName_fromList(List<Person> person)
        {
            Console.WriteLine("Enter Name to Remove");
            string eName = Console.ReadLine();
            person.RemoveAll(e => e.Name == eName);
            foreach (Person person1 in person)
            {
                Console.WriteLine(person1.Name + " " + person1.Age);
            }
            Console.WriteLine();
        }

    }
}
