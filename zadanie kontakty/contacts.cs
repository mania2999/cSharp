using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts
{
     class contact
    {   
        //variables
        private int number;
        private static bool testnumber;
        public int Number
        {
            get { return number; }
            set { 
                    if (value.ToString().Length == 9 )
                    {
                    number = value;
                    testnumber = true;
                }
                    else
                    {
                    Console.WriteLine(" your number must have 9 numbers");
                    testnumber = false;
                    }
                }
        }
        public static bool TestNumber { get { return testnumber; } }
        public string Name { get; set; }
        //properties
        public contact(int number,string  name)
        { 
            this.Name= name;
            this.number = number;
        }
        public contact() { }
        // method

        static public void DisplayMenu()
        {
            Console.WriteLine("Welcome to ContactApp ");
            Console.WriteLine("press 1 to view your contacts");
            Console.WriteLine("press 2 to search contact by name ");
            Console.WriteLine("press 3 to add contact ");
            Console.WriteLine("press 4 to change someone number");
            Console.WriteLine("to exit press x");
        }


    }
}