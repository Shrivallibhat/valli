using System;
public class ConvertCelciusToKelvinAndFahrenheit
{
    public static void Main(string[] args)
    {
        int celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("kelvin= {0}", celsius + 273);
        Console.WriteLine("fahrenheit= {0}", celsius * 18 / 10 + 32);
    }
}

