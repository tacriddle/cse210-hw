
public class Light:Device{
    private int _lightStatus;
    private string _lightStatusDesc;
    
    public Light(string deviceName): base(deviceName){}

    public override void TurnOn()
    {
        _lightStatus=1;
    }
    public override void TurnOff()
    {
        _lightStatus=0;
    }

    public override void DisplayStatus()
    {
        if (_lightStatus==1){
            _lightStatusDesc="on";
        }
        else if (_lightStatus==0){
            _lightStatusDesc="off";
        }
        Console.WriteLine($"{_deviceName} is currently {_lightStatusDesc}");
    }
    public override void ChangeStatusOfDevice()
    {
        if (_lightStatus==1){
            TurnOff();
        }
        else if(_lightStatus==0){
            TurnOn();
        }
    }

}