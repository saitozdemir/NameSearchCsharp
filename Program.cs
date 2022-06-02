using System;
using System.Collections.Generic;
using System.Linq; // Linq library was used for this project

namespace NameSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); // create a new List object
            list.Add("mark"); // add new names in homework
            list.Add("markus");
            list.Add("marcel");
            list.Add("marcello");
            list.Add("david");
            list.Add("davian");

            while (true)
            {
                Console.WriteLine("Please enter a valid number!\n1- Enter 1 to add a name\n2- Enter 2 to return home\n0- Exit");
                int id = Int32.Parse(Console.ReadLine()); //take a integer value to use switch-case loop from the user
                switch (id)
                {
                    case 0: 
                        Console.WriteLine("Exit");
                        break;
                    case 1:
                        Console.WriteLine("Enter a name!");
                        string value = Console.ReadLine(); //take a new name (string value) to add in the list
                        list.Add(value); //add the name that take from the user
                        break;
                    case 2:
                        Console.WriteLine("Please enter a letter or word to search!");
                        string search = Console.ReadLine();
                        var newlist = list.Where(x => x.ToLower().StartsWith(search)).ToList(); //this is constraint and search query of Linq
                        foreach (string s in newlist) //for each elements in new list
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number!");                        
                        break;
                }
                if (id == 0) //exit the loop
                {
                    break;
                }
            }
        }
    }
}
