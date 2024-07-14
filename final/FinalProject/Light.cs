
public class Light:Device{
    private int _lightStatus;
    
    public Light(string deviceName): base(deviceName){}

    public override void TurnOn()
    {
        _lightStatus=1;
    }
    public override void TurnOff()
    {
        _lightStatus=0;
    }
}