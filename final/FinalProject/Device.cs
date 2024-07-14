
public abstract class Device{
    protected string _deviceName;

    public Device(string deviceName){
        _deviceName=deviceName;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
}