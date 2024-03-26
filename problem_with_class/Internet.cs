using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_with_class
{
    internal class Internet
    {
        private double speed;
        private string name;
        private double cost;
        private string technology;

        public Internet(double speed, string name, double cost, string technology)
        {
            this.speed = speed;
            this.name = name;
            this.cost = cost;
            this.technology = technology;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Internet speed: {speed} Mb/s");
            Console.WriteLine($"Provider's name: {name}");
            Console.WriteLine($"Internet cost: {cost} UAH per month");
            Console.WriteLine($"Internet technology: {technology}");
        }

        public void UpdateSpeed(double speed)
        {
            this.speed = speed;
            Console.WriteLine("\n Speed was noted");
        }

        public bool NeedsService()
        {
            return speed < 100; 
        }

        public void ResetSpeed()
        {
            Console.WriteLine("\n Master do his job...");
            speed = 100;
            Console.WriteLine("Internet is normal now");
        }

    }
}
