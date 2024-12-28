using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class Program
    {
        
        static double ConvertToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static void Main()
        {
            
            Console.Write("Enter Cel Temp: ");
            double celTemp = Convert.ToDouble(Console.ReadLine());

           
            double fahrenheitTemp = ConvertToFahrenheit(celTemp);

            
            Console.WriteLine("Fahrenheit Temperature is : " + fahrenheitTemp);
        }
    }
}
