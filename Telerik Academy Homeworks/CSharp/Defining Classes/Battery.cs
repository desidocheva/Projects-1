using System;
class Battery
{
    public enum BatteryType{Liion, NiMH, NiCd, LiPoly }
    public string Model { get; private set; }
    private int hoursIdle;
    private int hoursTalk;
    
    public int HoursIdle 
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            if (value<0)
	        {
		         throw new ArgumentException("Hours can't be negative");
	        }
            this.hoursIdle = value;
        }
    }
    public int HoursTalk 
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            if (value<0)
	        {
		         throw new ArgumentException("Hours can't be negative");
	        }
            this.hoursTalk = value;
        }
    }

    public Battery(string model, int hoursIdle, int hoursTalk) //Constructor to define battery with model, hours idle and hours talk
    {
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }

    //Constructor to define battery with model
    public Battery(string model)
        : this(model, 0, 0)
    {}
}