public class Thermostat:Device{
    private int _temp;
    private int ac;
    private int heat;
    private int _desiredTemp;
    
    public Thermostat(string deviceName): base(deviceName){

    }

    public override void TurnOn()
    {
        while (true){
            if (_desiredTemp<_temp){
                ac=1;
                heat=0;
                break;
            }
            else if (_desiredTemp>_temp){
                ac=0;
                heat=1;
                break;
            }
            else{
                ac=0;
                heat=0;
                break;
            }
        }
    }
    public override void TurnOff()
    {
        ac=0;
        heat=0;
    }
    public void ChangeTemp(){
    }
    
}