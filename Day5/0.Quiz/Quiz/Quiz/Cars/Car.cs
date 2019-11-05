using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Cars
{
    public class Car
    {
        public void Run()
        {
            Console.WriteLine("Car Run");
        }

        public virtual void SpeedUp()
        {
            Console.WriteLine("Car Speed up");
        }
    }
}
