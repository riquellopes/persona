using System;

namespace persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m = new Man{
                Name = "Henrique",
                LastName = "Lopes",
                Age = 36,
                Mustach = false,
            };

            Console.WriteLine($"Hi my name {m.GetFullName()} and {m.GetHasMoustach()}");

        }
    }
}
