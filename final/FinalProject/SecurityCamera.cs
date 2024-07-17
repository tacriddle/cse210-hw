public class SecurityCamera : Device
{
    public int SecurityCameraStatus { get; set; }

    public SecurityCamera() { }

    public SecurityCamera(string deviceName) : base(deviceName) { }

    public override void TurnOn()
    {
        IsOn = true;
        SecurityCameraStatus = 1;
    }

    public override void TurnOff()
    {
        IsOn = false;
        SecurityCameraStatus = 0;
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
