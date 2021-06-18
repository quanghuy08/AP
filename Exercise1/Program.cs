using System;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 40;
            person.Name = "Amar";
            Console.WriteLine("Person deatails - Name = "+person.Name+", Age = "+person.Age);
            Console.WriteLine("Person deatails (After incrementing age) - Name = "+person.Name+", Age = "+(person.Age+1));
        }
    }
}