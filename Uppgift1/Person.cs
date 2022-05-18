namespace Uppgift1 
{ 
        public class Person
        {

            public string Name { get; private set; }
            public int Age { get; private set; }
            public string ReturnPersonDetails => Name + " - " + Age;


            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            

            //public void SetName(string name)
            //{
            //    this.Name = name;
            //}

            //public void SetAge(int age)
            //{
            //    this.Age = age;
            //}

        }
    
}
