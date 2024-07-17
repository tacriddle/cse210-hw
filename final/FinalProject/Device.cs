using System;
using System.Text.Json.Serialization;

[JsonConverter(typeof(DeviceConverter))]
public abstract class Device
{
    public string DeviceName { get; set; }
    public bool IsOn { get; set; }
    public Schedule DeviceSchedule { get; set; }

    protected Device() { }

    protected Device(string deviceName)
    {
        DeviceName = deviceName;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void DisplayStatus();
    public abstract void ChangeStatusOfDevice();

    public void CheckSchedule(int currentTime)
    {
        if (DeviceSchedule != null)
        {
            if (DeviceSchedule.IsActive(currentTime))
            {
                TurnOn();
            }
            else
            {
                TurnOff();
            }
        }
    }
}
