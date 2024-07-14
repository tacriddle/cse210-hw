using System;
using System.Diagnostics;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        int quit;
        Console.WriteLine("Welcome to the smart home manager!");
        Console.WriteLine("Select one of the following options!");
        Console.WriteLine("1. Create a new user");
        Console.WriteLine("2. Load a users data");
        Console.WriteLine("3. Create a new device");
        Console.WriteLine("4. Display Status of devices");
        Console.WriteLine("5. Mange Devices");
        Console.WriteLine("6. Remove a Device");
        Console.WriteLine("0. Quit");
        quit=int.Parse(Console.ReadLine());
        switch(quit){
            case 1:
                DeviceManager deviceManager= new();
                deviceManager.CreateDevice();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 0:
                Console.WriteLine("Thanks for using the Smart Home Manager!");
                break;
        }

    }
}