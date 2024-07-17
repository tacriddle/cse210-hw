
public abstract class Device{
    protected string _deviceName;
    protected bool _isOn;
    public Schedule DeviceSchedule { get; set; }
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