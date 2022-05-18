using System;

namespace Uppgift1
{
    class Program
    {
        

        class Person
        {

            public string name { get; protected set; }
            public int age { get; protected set; }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string returnDetails()
            {
                return name + " - " + age;
            }

            public void setName(string name)
            {
                this.name = name;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

        }


        class Manager
        {
            public List<Person> people;
            public Manager()
            {
                people = new List<Person>();                
                {
                    new Person("Aba", 23);
                    new Person("test", 10);

                };
                printMenu();

            }
            
            public void printMenu()
            {
                Console.WriteLine("Welcome Management system!" + Environment.NewLine);
                Console.WriteLine("1. - print all user");
                Console.WriteLine("2. - Add user ");
                Console.WriteLine("3. - Edit user ");
                Console.WriteLine("4. - Search user ");
                Console.WriteLine("5. - Remove user ");
                Console.WriteLine("6. - Exit ");

                Console.Write("Enter  your Menu option: ");

                bool tryParse = int.TryParse(Console.ReadLine(), out int menuOption);

                if (tryParse)
                {
                    Console.WriteLine(menuOption);

                    if (menuOption == 1)
                    {
                        PrintAll();
                    }
                    else if (menuOption == 2)
                    {
                        AddPerson();
                    }
                    else if (menuOption == 3)
                    {
                        EditPerson();
                    }
                    else if (menuOption == 4)
                    {
                        SearchPerson();
                    }
                    else if (menuOption == 5)
                    {
                        RemovePerson();
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect menu option.");
                    Console.WriteLine("press <enter> try again");
                    Console.ReadLine();
                    Console.Clear();
                    printMenu();
                }
            }
        }

        public static void PrintAll()
        {
            int i = 0;
            people.ForEach(delegate (Person person)
            {
                i++;
                Console.WriteLine(i + ". " + person.returnDetails());
            });
        }
                 
        public static void AddPerson() => Console.WriteLine("Add");

        public static void EditPerson() => Console.WriteLine("Edit");
       
        public static void SearchPerson() => Console.WriteLine("Search");
       
        public  static void RemovePerson() => Console.WriteLine("Remove");
       

        static void Main(string[] args)
        {

            Manager manager = new Manager();

            Console.ReadLine();
                                                     
        }
    }
}
