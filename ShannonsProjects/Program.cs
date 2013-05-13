using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShannonsProjects
{
    class Programs
    {
        static void Main(string[] args)
        {
            string[] names = { "Mark P", "Shawn L", "Jenna L", "Benji R" };

            Console.WriteLine("Enter a name to search");
          
            string name = Console.ReadLine();          
 

            foreach(string item in names)
            {
                if (item.Contains(name))
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(); 
        }
    }
}
