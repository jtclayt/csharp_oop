using System;

namespace Phone
{
    public abstract class Phone
{
    public string VersionNumber { get; }
    public int BatteryPercentage { get; }
    public string Carrier { get; }
    public string RingTone { get; set; }


    public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
    {
        VersionNumber = versionNumber;
        BatteryPercentage = batteryPercentage;
        Carrier = carrier;
        RingTone = ringTone;
    }

    public abstract void DisplayInfo();
}
}
