using System;

class Program
{
    static void Main(string[] args)
    {
        DeviceManager deviceManager = new DeviceManager();
        SmartHome smartHome = new SmartHome(deviceManager);
        int quit = 1;
        while (quit != 0)
        {
            Console.WriteLine("Welcome to the smart home manager!");
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("1. Create a new user");
            Console.WriteLine("2. Load a user's data");
            Console.WriteLine("3. Create a new device");
            Console.WriteLine("4. Display status of devices");
            Console.WriteLine("5. Change status of device");
            Console.WriteLine("6. Remove a device");
            Console.WriteLine("7. Create a schedule for a device");
            Console.WriteLine("8. Save current user devices");
            Console.WriteLine("0. Quit");
            quit = int.Parse(Console.ReadLine());
            switch (quit)
            {
                case 1:
                    smartHome.CreateNewUser();
                    break;
                case 2:
                    smartHome.LoadUserData();
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
                case 8:
                    Console.Write("Enter the user's name: ");
                    string userName = Console.ReadLine();
                    smartHome.SaveCurrentUserDevices(userName);
                    break;
                case 0:
                    Console.WriteLine("Thanks for using the Smart Home Manager!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again!");
                    break;
            }
        }
    }
}

