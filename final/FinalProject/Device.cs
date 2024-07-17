
public abstract class Device{
    protected string _deviceName;

    public Device(string deviceName){
        _deviceName=deviceName;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void DisplayStatus();
      public string GetDeviceName()
    {
        return _deviceName;
    }
    public abstract void ChangeStatusOfDevice();
}