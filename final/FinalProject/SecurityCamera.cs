using System.Security.Cryptography;

public class SecurityCamera:Device{
    private int _securityCameraStatus;
    
    public SecurityCamera(string deviceName): base(deviceName){}

    public override void TurnOn()
    {
        _securityCameraStatus=1;
    }
    public override void TurnOff()
    {
        _securityCameraStatus=0;
    }
    public override void DisplayStatus()
    {
        if (_securityCameraStatus==1){
            Console.WriteLine("The security camera is on");
        }
        else if (_securityCameraStatus==0){
            Console.WriteLine("The security camera is off");
        }
    }
    public override void ChangeStatusOfDevice()
    {
        if (_securityCameraStatus==1){
            TurnOff();
        }
        else if (_securityCameraStatus==0){
            TurnOn();
        }
    }
}