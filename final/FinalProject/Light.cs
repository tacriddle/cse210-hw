public class Light : Device
{
    public int LightStatus { get; set; }

    public Light() { }

    public Light(string deviceName) : base(deviceName) { }

    public override void TurnOn()
    {
        IsOn = true;
        LightStatus = 1;
    }

    public override void TurnOff()
    {
        IsOn = false;
        LightStatus = 0;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{DeviceName} is currently {(IsOn ? "on" : "off")}");
    }

    public override void ChangeStatusOfDevice()
    {
        if (IsOn)
        {
            TurnOff();
        }
        else
        {
            TurnOn();
        }
    }
}
