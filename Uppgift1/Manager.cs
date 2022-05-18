namespace Uppgift1
{

    public class Manager
    {
        private List<Person> people;
        public Manager()
        {
            //Instansiera ett nytt objekt av Employestrorage
            //Add some people

            people = new List<Person>()
            {
                new Person("Aba", 23),
                new Person("test", 10)

            };

        }

        public void Run()
        {
            PrintMenu();
            UserInput();
        }

        private void UserInput()
        {
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
                    //Use instanse of storage
                    //AddPerson();
                }
                else if (menuOption == 3)
                {
                   // EditPerson();
                }
                else if (menuOption == 4)
                {
                   // SearchPerson();
                }
                else if (menuOption == 5)
                {
                   // RemovePerson();
                }
            }
            else
            {
                IncorrectMeny();
            }
        }

        private void IncorrectMeny()
        {
            Console.WriteLine("Incorrect menu option.");
            Console.WriteLine("press <enter> try again");
            Console.ReadLine();
            Console.Clear();
            PrintMenu();
        }

        public void PrintMenu()
        {
            Console.WriteLine("Welcome Management system!" + Environment.NewLine);
            Console.WriteLine("1. - print all user");
            Console.WriteLine("2. - Add user ");
            Console.WriteLine("3. - Edit user ");
            Console.WriteLine("4. - Search user ");
            Console.WriteLine("5. - Remove user ");
            Console.WriteLine("6. - Exit ");
        }


        public void PrintAll()
        {           
            int i = 1;
            people.ForEach(p => Console.WriteLine($"{i++} {p.ReturnPersonDetails}"));                               
        }

        public void Print(Person p)
        {

           Console.WriteLine(p.ReturnPersonDetails);
           
        }
    }
}




