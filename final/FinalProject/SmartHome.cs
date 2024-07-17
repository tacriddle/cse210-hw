using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class SmartHome
{
    private string _filePath = "userdata.json";
    private DeviceManager _deviceManager;
    private Dictionary<string, List<Device>> _usersData = new Dictionary<string, List<Device>>();

    public SmartHome(DeviceManager deviceManager)
    {
        _deviceManager = deviceManager;
        LoadUsersData();
    }

    public void CreateNewUser()
    {
        Console.Write("Enter the new user's name: ");
        string userName = Console.ReadLine();

        if (_usersData.ContainsKey(userName))
        {
            Console.WriteLine("User already exists. Please choose a different name.");
            return;
        }

        _usersData[userName] = new List<Device>();
        SaveUsersData();
        Console.WriteLine($"User '{userName}' has been created.");
    }

    public void LoadUserData()
    {
        Console.Write("Enter the user's name: ");
        string userName = Console.ReadLine();

        if (!_usersData.ContainsKey(userName))
        {
            Console.WriteLine("User not found.");
            return;
        }

        List<Device> userDevices = _usersData[userName];
        _deviceManager.LoadDevices(userDevices);
        Console.WriteLine($"User '{userName}' data has been loaded.");
    }

    private void SaveUsersData()
    {
        var options = new JsonSerializerOptions { WriteIndented = true, Converters = { new DeviceConverter() } };
        string jsonString = JsonSerializer.Serialize(_usersData, options);
        File.WriteAllText(_filePath, jsonString);
    }

    private void LoadUsersData()
    {
        if (File.Exists(_filePath))
        {
            var options = new JsonSerializerOptions { Converters = { new DeviceConverter() } };
            string jsonString = File.ReadAllText(_filePath);
            _usersData = JsonSerializer.Deserialize<Dictionary<string, List<Device>>>(jsonString, options);
        }
    }

    public void SaveCurrentUserDevices(string userName)
    {
        if (_usersData.ContainsKey(userName))
        {
            _usersData[userName] = _deviceManager.GetDevices();
            SaveUsersData();
            Console.WriteLine($"Devices for user '{userName}' have been saved.");
        }
        else
        {
            Console.WriteLine("User not found. Unable to save devices.");
        }
    }
}
