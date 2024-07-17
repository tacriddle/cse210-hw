using System.Runtime.CompilerServices;

public class Thermostat:Device{
    private int _temp;
    private int _ac;
    private int _heat;
    private int _desiredTemp;

    private int _status=0;
    
    public Thermostat(string deviceName): base(deviceName){

    }
    public void InitlizeValues(){
        _ac=0;
        _heat=0;
        _temp=65;
    }

    public override void TurnOn()
    {
        if (_desiredTemp<_temp){
            _isOn=true;
            _ac=1;
            _heat=0;
            _status=1;
        }
        else if (_desiredTemp>_temp){
            _isOn=true;
            _ac=0;
            _heat=1;
            _status=1;
        }
        else{
            _isOn=false;
            _ac=0;
            _heat=0;
            _status=0;
        }
    }
    public override void TurnOff()
    {
        _isOn=false;
        _ac=0;
        _heat=0;
        _status=0;
    }
    
    public override void DisplayStatus()
    {
        string acStatus;
        string heatStatus;
        if (_ac==1){
            acStatus="on";
        }
        else{
            acStatus="off";
        }
        if(_heat==1){
            heatStatus="on";
        }
        else{
            heatStatus="off";
        }

        Console.WriteLine($"The current temperture is {_temp}");
        Console.WriteLine($"The ac is currently {acStatus}");
        Console.WriteLine($"The heat is currently {heatStatus}");
    }
    public void ChangeDesiredTemp(int temp){
        _desiredTemp=temp;
    }
    public override void ChangeStatusOfDevice()
    {
        Console.Write("Would you like to change the desired temperature?");
        string change=Console.ReadLine();
        if (change=="yes"){
            Console.Write("What would you like the temperture to be?");
            int temp=int.Parse(Console.ReadLine());
            ChangeDesiredTemp(temp);
        }
        if (_status==1){
            TurnOff();
        }
        else if (_status==0){
            TurnOn();
        }
    }
}