using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Dailygoals
{
    internal class program
    {
        private static string description;
        private static int quantity;
        private static string name;

        class grocery
        {
            public string Name;
            public string Description;
            public int Quantity;
            

            public grocery(string name, string description, int quantity)
            {
                Name = name;
                Description = description;
                Quantity = quantity;
             
            }
        }
        static void Main(string[] args )
        {
            List<grocery> groceryList = new List<grocery>();

            while(true)
            {
                Console.Clear();
                Console.WriteLine("\n\t      Grocery List Application");
                Console.WriteLine("\n\t 1. Add Grocery items. ");
                Console.WriteLine("\n\t 2. Remove an exisiting Grocery item. ");
                Console.WriteLine("\n\t 3. Mark a Grocery item as purchased.  ");
                Console.WriteLine("\n\t 4. Display all Grocery items.");

                Console.Write("\n\n Choose an Option from 1 to 4 : ");

                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Add a Grocery Item");
                    Console.WriteLine(" Please input the name of the grocery item: ");
                    string name = Console.ReadLine();

                    Console.WriteLine($" How much {name} would you like to buy? ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($" Please write a description of {name}, if not please write NA: ");
                    string description = Console.ReadLine();
                


                    groceryList.Add(new grocery(name, description, quantity));  
                    Console.WriteLine("\n  Press any key to continue... ");
                    Console.ReadKey();
                }
                else if (choose == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Remove an existing Grocery item");
                    int select = 1;
                    string choices = "";
                    int count = 1;
                    foreach (var grocery in groceryList)
                    {
                        Console.WriteLine($"\t{count}) {grocery.Name}");
                        choices += $"{count}, ";
                        count++;
                    }

                    Console.Write($"\nChoice ({choices.Trim().TrimEnd(',')}):");
                    select = Convert.ToInt32(Console.ReadLine());
                    groceryList.RemoveAt(select - 1);


                    groceryList.Add(new grocery(name, description, quantity));
                    Console.WriteLine("\n Press any key to continue... ");
                    Console.ReadKey();
                }
                else if (choose == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Mark a Grocery item as purchased");
                    Console.WriteLine("\n\n Please input the name of the item to be marked as purchased");
                    int count = 1;
                    string choices = "";

                    foreach(var grocery in groceryList)
                    {
                        Console.WriteLine($"\t{count}) {grocery.Name}");
                        choices += $"{count}, ";
                        count++;
                    }

                    Console.Write($"\nChoice ({choices.Trim().TrimEnd(',')}):");
                    int select = Convert.ToInt32(Console.ReadLine());
                      

                    groceryList.Add(new grocery(name, description, quantity));
                    Console.WriteLine("\n Press any key to continue...");
                    Console.ReadKey();
                }
                else if (choose == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Display every Grocery items ***");
                    foreach (var grocery in groceryList)
                    {
                        Console.WriteLine($"Name of the Item:{grocery.Name}\t\tQuantity:{grocery.Quantity}\t\tDescription:{grocery.Description}");
                    }
                    
                    groceryList.Add(new grocery(name, description, quantity));
                    Console.WriteLine("\n Press any key to continue... ");
                    Console.ReadKey();
                }
            }
            
        }
    }

}