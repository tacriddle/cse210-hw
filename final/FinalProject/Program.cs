using System;
using System.Diagnostics;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        DeviceManager deviceManager= new();
        int quit=1;
        while(quit!=0){
        Console.WriteLine("Welcome to the smart home manager!");
        Console.WriteLine("Select one of the following options!");
        Console.WriteLine("1. Create a new user");
        Console.WriteLine("2. Load a users data");
        Console.WriteLine("3. Create a new device");
        Console.WriteLine("4. Display Status of devices");
        Console.WriteLine("5. Change Status of device");
        Console.WriteLine("6. Remove a Device");
        Console.WriteLine("7. Create a schedule for a device");
        Console.WriteLine("0. Quit");
        quit=int.Parse(Console.ReadLine());
        switch(quit){
            case 1:
                break;
            case 2:
                break;
            case 3:
            deviceManager.CreateDevice();
                break;
            case 4:
            deviceManager.DisplayStatusOfDevice();
                break;
            case 5:
                deviceManager.ChangeStatusOfDevice();
                break;
            case 6:
            deviceManager.RemoveDevice();
                break;
            case 7:
            deviceManager.CreateScheduleForDevice();
            break;
            case 0:
                Console.WriteLine("Thanks for using the Smart Home Manager!");
                break;
        }
        }
    }
}