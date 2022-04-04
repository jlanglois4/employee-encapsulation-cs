using System;

namespace soft_arch_encapsulation.part3.demo.good
{
    public class CarReportService
    {
        private Car _car;

        public CarReportService(Car car)
        {
            this._car = car;
        }

        public void PrintEngineType()
        {
            Console.WriteLine("Engine Type: " + _car.EngineType);
        }

        public void PrintRunningStatus()
        {
            Console.WriteLine("Car running status: " + _car.IsRunning);
        }
    }
}