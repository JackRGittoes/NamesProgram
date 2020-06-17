using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* I built this program to try and grasp an understanding of creating objects in .NET & C#. 
 The program takes names and then stores them within a list and then outputs them to the user */ 

namespace PersonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            var input = 1;
            for (int i = 0; i < input;)
            {
                var person = new Person();
                Console.WriteLine("Input a name");
                var name = Console.ReadLine();
                person.NewName(name);
                person.Introduce(); 
                names.Add(name);
                

                Console.WriteLine("Would you like to add another name? \n [1] Yes \n [2] No");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 2)
                {
                    input = 0;
                    
                }
            }
            Console.WriteLine("The names you have provided are");
            
            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }
    }
}
