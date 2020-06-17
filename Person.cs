using System;

namespace PersonProgram
{
    public class Person
    {
        string Name;


        public void Introduce()
        {

            Console.WriteLine("The name you provided is {0}", Name);
            Console.ReadLine();
        }
        public string NewName(string name)
        {
            this.Name = name;
            return name;
        }
            

            

    }
}
