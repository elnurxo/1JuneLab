using System;

namespace _1JunePractiseP227
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen citizen1 = new Citizen()
            {
                Name = null,
                Surname = "Khalilov1"
            };
            Console.WriteLine($"{citizen1.Name} {citizen1.Surname}");
        }
    }
}
