using Quiz.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Benz();
            car.Run();
            car.SpeedUp();

            Benz car2 = new Benz();
            car2.Run();
            car2.SpeedUp();
        }
    }
}
