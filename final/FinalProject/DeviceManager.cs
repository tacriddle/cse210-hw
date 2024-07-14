using System;
using System.Collections.Generic;

public class DeviceManager
{
    private List<string> listOfDeviceNames = new List<string>();
    private List<string> typeOfDevice = new List<string> { "Thermostat", "Light", "Security Camera" };
    private string _device;
    private string _deviceName;

    public void CreateDevice()
    {
        Console.WriteLine("Here is a list of the type of devices available:");
        foreach (string device in typeOfDevice)
        {
            Console.WriteLine(device);
        }

        Console.Write("Enter which device you would like to create: ");
        _device = Console.ReadLine();
        Console.Write("What would you like the name of your device to be: ");
        _deviceName = Console.ReadLine();
        listOfDeviceNames.Add(_deviceName);

        if (_device == "Thermostat")
        {
            Thermostat thermostat = new Thermostat(_deviceName);
        }
        else if (_device == "Light")
        {
            Light device = new Light(_deviceName);
        }
        else if (_device == "Security Camera")
        {
            SecurityCamera securityCamera = new SecurityCamera(_deviceName);
        }
        else
        {
            Console.WriteLine("Unknown device type.");
        }
    }
}