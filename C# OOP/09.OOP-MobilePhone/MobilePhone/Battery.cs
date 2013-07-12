using System;

public class Battery
{
    public enum BatteryTypes
    {
        LiIon,
        NiMH,
        NiCd,
        LiPo
    }

    private string model;
    private double? hoursIdle;
    private double? hoursTalk;
    private BatteryTypes batteryType;
                
    public Battery(string model = null, double? hoursIdle = null, double? hoursTalk = null) 
    {
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }

    public BatteryTypes BatteryType
    {
        get
        {
            return this.batteryType;
        }
        set
        {
            this.batteryType = value;
        }
    }

    public double? HoursTalk
    {
        get
        {
            return hoursTalk;
        }
        set
        { 
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Talking hours must be bigger than 0.");
            }
            else
            {
                this.hoursTalk = value;
            }
        }
    }

    public double? HoursIdle
    {
        get
        {
            return hoursIdle;
        }
        set 
        { 
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Idle hours must be bigger than 0.");
            }
            else
            {
                this.hoursIdle = value;
            }
        }
    }

    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            this.model = value;
        }
    }
}