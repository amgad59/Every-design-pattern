using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.Protection_Pattern
{
    public class CarProxy : ICar
    {
        Car car = new Car();
        Driver driver;
        public CarProxy(Driver driver)
        {
            this.driver = driver;
        }
        public void Drive()
        {
            if(driver.Age >= 16)
            {
                car.Drive();
            }
            else
            {
                Console.WriteLine("Driver too young");
            }
        }
    }
}
