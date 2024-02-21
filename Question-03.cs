using System;
namespace TemperatureTrackerApp
{
    class TemperatureTracker
    {
        private double[] dailyTemperatures;
        public TemperatureTracker()
        {
            dailyTemperatures = new double[7]; 
        }
        public void InputTemperatures()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter temperature for day {i + 1}: ");
                dailyTemperatures[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void DisplayTemperatureReport()
        {
            Console.WriteLine("Weekly Temperature Report:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {dailyTemperatures[i]}C");
            }
        }
    }
   class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();
            tracker.InputTemperatures();
            tracker.DisplayTemperatureReport();
           
            Console.ReadLine(); 
        }
    }
}
