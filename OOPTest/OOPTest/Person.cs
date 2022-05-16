using System;

namespace OOPTest
{
    internal class Person
    {
        private string name;
        private int age;
        private string Phone_number;

        public Person(string name, int age, string phone_number)
        {
            Name = name;
            Age = age;
            Phone_number = phone_number;
           
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Phone_number1 { get => Phone_number; set => Phone_number = value; }

      

        public  string getdisplay()
        {
            string AllDate = "ur name is : " + Name1 + " \n ";
            AllDate += "ur Age : " + age + "\n" ;
              AllDate +=  "ur phone number is : " + Phone_number ;
            return AllDate;
        }

        public  void display()
        {
            Console.WriteLine(getdisplay());
        }




    }
}
