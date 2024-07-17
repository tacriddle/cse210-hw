public class Thermostat : Device
{
    public int Temp { get; set; }
    public int AC { get; set; }
    public int Heat { get; set; }
    public int DesiredTemp { get; set; }

    public Thermostat() { }

    public Thermostat(string deviceName) : base(deviceName) { }

    public override void TurnOn()
    {
        if (DesiredTemp < Temp)
        {
            IsOn = true;
            AC = 1;
            Heat = 0;
        }
        else if (DesiredTemp > Temp)
        {
            IsOn = true;
            AC = 0;
            Heat = 1;
        }
        else
        {
            IsOn = false;
            AC = 0;
            Heat = 0;
        }
    }

    public override void TurnOff()
    {
        IsOn = false;
        AC = 0;
        Heat = 0;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{DeviceName} - Temperature: {Temp}, AC: {(AC == 1 ? "on" : "off")}, Heat: {(Heat == 1 ? "on" : "off")}");
    }

    public void ChangeDesiredTemp(int temp)
    {
        DesiredTemp = temp;
    }

    public override void ChangeStatusOfDevice()
    {
        Console.Write("Would you like to change the desired temperature? ");
        string change = Console.ReadLine();
        if (change == "yes")
        {
            Console.Write("What would you like the temperature to be? ");
            int temp = int.Parse(Console.ReadLine());
            ChangeDesiredTemp(temp);
        }

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
