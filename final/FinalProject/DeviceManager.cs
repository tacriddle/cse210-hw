using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class DeviceManager
{
    private List<Device> listOfDevices = new List<Device>();
    private List<string> typeOfDevice = new List<string> { "Thermostat", "Light", "Security Camera" };
    private string _device;
    private string _deviceName;
    private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

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

        Device newDevice = _device switch
        {
            "Thermostat" => new Thermostat(_deviceName),
            "Light" => new Light(_deviceName),
            "Security Camera" => new SecurityCamera(_deviceName),
            _ => null
        };

        if (newDevice != null)
        {
            listOfDevices.Add(newDevice);
            Console.WriteLine($"Device '{_deviceName}' of type '{_device}' has been created.");
        }
        else
        {
            Console.WriteLine("Unknown device type.");
        }
    }

    public void RemoveDevice()
    {
        Console.Write("Enter the name of the device you would like to remove: ");
        string deviceNameToRemove = Console.ReadLine();

        Device deviceToRemove = listOfDevices.Find(device => device.DeviceName == deviceNameToRemove);
        if (deviceToRemove != null)
        {
            listOfDevices.Remove(deviceToRemove);
            Console.WriteLine($"Device '{deviceNameToRemove}' has been removed.");
        }
        else
        {
            Console.WriteLine("Device not found.");
        }
    }

    public void DisplayStatusOfDevice()
    {
        foreach (Device device in listOfDevices)
        {
            device.DisplayStatus();
        }
    }

    public void ChangeStatusOfDevice()
    {
        Console.Write("What is the name of the device you would like to change? ");
        string deviceNameToChange = Console.ReadLine();

        Device deviceToChange = listOfDevices.Find(device => device.DeviceName == deviceNameToChange);
        if (deviceToChange != null)
        {
            deviceToChange.ChangeStatusOfDevice();
            Console.WriteLine($"Status of device '{deviceNameToChange}' has been changed.");
        }
        else
        {
            Console.WriteLine("Device not found.");
        }
    }

    public void CreateScheduleForDevice()
    {
        Console.Write("Enter the name of the device you would like to schedule: ");
        string deviceNameToSchedule = Console.ReadLine();

        Device deviceToSchedule = listOfDevices.Find(device => device.DeviceName == deviceNameToSchedule);
        if (deviceToSchedule != null)
        {
            Console.Write("Enter the start time (in 24-hour format, e.g., 1300 for 1:00 PM): ");
            int startTime = int.Parse(Console.ReadLine());
            Console.Write("Enter the turn off time (in 24-hour format, e.g., 1800 for 6:00 PM): ");
            int turnOffTime = int.Parse(Console.ReadLine());

            Schedule schedule = new Schedule(startTime, turnOffTime);
            deviceToSchedule.DeviceSchedule = schedule;
            Console.WriteLine($"Schedule created for device '{deviceNameToSchedule}'.");
            schedule.DisplaySchedule();
        }
        else
        {
            Console.WriteLine("Device not found.");
        }
    }

    private void StartBackgroundTask()
    {
        Task.Run(() =>
        {
            while (!_cancellationTokenSource.Token.IsCancellationRequested)
            {
                int currentTime = GetCurrentTime();
                foreach (Device device in listOfDevices)
                {
                    device.CheckSchedule(currentTime);
                }
                Thread.Sleep(1000);
            }
        }, _cancellationTokenSource.Token);
    }

    private int GetCurrentTime()
    {
        return int.Parse(DateTime.Now.ToString("HHmm")); // Return time in 24-hour format as an integer
    }

    public void StopBackgroundTask()
    {
        _cancellationTokenSource.Cancel();
    }

    public List<Device> GetDevices()
    {
        return listOfDevices;
    }

    public void LoadDevices(List<Device> devices)
    {
        listOfDevices = devices;
    }
}
