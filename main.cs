// Created by: Venika Sem
// Created on: Apr 2022
//
// This program converts the temperature from fahrenheit to celsius.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function converts the temperature from fahrenheit to celsius.
        double fahrenheitTemperature;
        double temperature;

        // input
        Console.WriteLine("This program converts the temperature from Fahrenheit to Celsius.");
        Console.WriteLine("");
        Console.WriteLine("The formula is: (°F − 32) × 5 / 9");
        Console.WriteLine("");
        Console.WriteLine("Please enter the degree in Fahrenheit (°F).");

        Console.WriteLine("");
        Console.Write("Input temperature in Fahrenheit: ");
        fahrenheitTemperature = Convert.ToDouble(Console.ReadLine());

        // process
        Console.WriteLine("");
        temperature = (fahrenheitTemperature - 32) * 5 / 9;

        // output
        Console.WriteLine("The temperature in Celcius is: " + temperature.ToString("0.00") + " " + "°C.");

        Console.WriteLine("\nDone.");
    }
}