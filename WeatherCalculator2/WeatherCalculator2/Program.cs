using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            int RelHumid;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);

            if (temperature > 50)
            {
                Console.WriteLine("Enter the Relative Humidity");
                input = Console.ReadLine();
                RelHumid = int.Parse(input);

                double Math1 = RelHumid * 0.094;
                double Math2 = temperature + 61.0;
                double Math3 = (temperature - 68.0) * 1.2;
                double HeatIndex = (Math1 + Math2 + Math3) * 0.5;

                Console.WriteLine("It feels like " + HeatIndex);
            }
            else
            {
                // Get the windspeed from the user
                Console.WriteLine("Enter the wind speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);


                // Calculate the wind chill

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("It feels like " + windChill);
            }
        }
    }
}
