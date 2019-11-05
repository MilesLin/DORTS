using System;

namespace Quiz.Cars
{
    public class Benz : Car
    {
        public new void Run()
        {
            Console.WriteLine("Benz Run");
        }

        public override void SpeedUp()
        {
            Console.WriteLine("Benz Speed Up");
        }
    }
}