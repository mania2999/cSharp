using contacts;
using System;
using System.ComponentModel.DataAnnotations;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<contact>()
            {
                new contact(211303678,"mia") ,
                new contact(212090678,"john") ,    
                new contact(212090678,"bob")
            };

            contact.DisplayMenu();

            var UserInput = Console.ReadLine();

            while(UserInput != "x")
            {
                switch (UserInput)
                {
                    case "1":
                        foreach(contact element  in contacts)
                        {
                            Console.WriteLine($" number : {element.Number}  Name : {element.Name}");
                        }
                        break;
                    case "2":
                        Console.WriteLine("inpute name");
                        var UserName = Console.ReadLine();
                        var SelectedName = contacts.FirstOrDefault(c => UserName == c.Name );
                        if(SelectedName != null)
                        {
                            Console.WriteLine($" name: {SelectedName.Name}   number: {SelectedName.Number}");
                        }
                        else
                        {
                            Console.WriteLine("invalid name");
                        }
                        break;
                    case "3":

                        var AddFile = new contact();

                        //set Name
                        Console.WriteLine("input name");
                        var AddName = Console.ReadLine();
                        var TestName = contacts.FirstOrDefault(c => c.Name == AddName);
                        if(TestName != null)
                        {
                            Console.WriteLine("this name have already number");
                            break;
                        }
                        else
                        {
                            AddFile.Name = AddName;
                        }

                        //Set Number
                        Console.WriteLine("input number");
                        var AddNumber = Console.ReadLine();
                        AddFile.Number = int.Parse(AddNumber);
                        
                        //add number
                        if ( contact.TestNumber ) 
                        {
                            contacts.Add(AddFile);
                            Console.WriteLine("you add new number");
                        }

                        break;
                    case "4":
                        Console.WriteLine("select name");
                        UserName = Console.ReadLine();
                        SelectedName = contacts.FirstOrDefault(c => c.Name == UserName);
                        if(SelectedName != null)
                        {
                            Console.WriteLine(" input number (if you input wrong number of digits number will not change!)");
                            var NewNumber = Console.ReadLine();
                            SelectedName.Number = int.Parse(NewNumber);

                        }
                        else
                        {
                            Console.WriteLine("this name not found");
                        }
                        break;
                    default:
                        Console.WriteLine("invalid value ");
                        break;
                }
                contact.DisplayMenu();
                UserInput = Console.ReadLine();

            }
        }
    }
}