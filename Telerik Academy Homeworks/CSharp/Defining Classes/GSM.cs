using System;
using System.Collections.Generic;
using System.Text;

class GSM
{
    private static Battery batteryiPhone4S = new Battery(Battery.BatteryType.Liion.ToString(), 200, 14); // for the use of IPhone4S
    private static Display displayiPhone4S = new Display(3.5, 16000000); // for the use of IPhone4S
    internal static GSM iPhone4S = new GSM("iPhone 4S", "Apple", null, 500, batteryiPhone4S, displayiPhone4S);
    public string Model { get; private set; }
    public string Manufacturer { get; private set; }
    public string Owner { get; set; }
    public Battery Battery { get; set; }
    public Display Display { get; set; }
    private double price;
    public double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value<0)
	        {
		         throw new ArgumentException("Price can't be negative number!");
	        }
            this.price = value;
        }
    }
    public GSM IPhone4S
    {
        get;
        private set;
    }
    public List<Call> CallHistory = new List<Call>(); // Property for saving the Call History 
    
    public void AddCall(string number, int duration)
    {
        Call call = new Call(number, duration);
        CallHistory.Add(call);
    }
    public void RemoveCall(string number, int duration)
    {
        for (int i = CallHistory.Count - 1; i >= 0; i--)
        {
            if ((number == CallHistory[i].DailedPhone && duration == CallHistory[i].Duration))
                CallHistory.RemoveAt(i);
        }
        
    }
    public void ClearHistory()
    {
        CallHistory.Clear();
    }
    public double CalcTotalPrice(double pricePerMin)
    {
        double minutes=0;
        foreach (var item in CallHistory)
        {
            minutes += item.Duration;
        }
        return pricePerMin * (minutes / 60);
    }
    public GSM(string model, string manufactorer, string owner, double price
        , Battery battery, Display display) //Constructor for all information
    {
        this.Model = model;
        this.Manufacturer = manufactorer;
        this.Owner = owner;
        this.Price = price;
        this.Battery = battery;
        this.Display = display;
    }
    
    //Constructor to define GSM with given model and manufacturer (mandatory)
    public GSM(string model, string manufactorer)
        : this(model, manufactorer, null, 0, null, null)
    {}

    //Constructor to define GSM with given model, manufacturer and owner
    public GSM(string model, string manufacturer, string owner)
        : this(model, manufacturer, owner, 0, null, null)
    {}

    //Constructor to define GSM with given model, manufacturer, owner and price
    public GSM(string model, string manufacturer, string owner, double price)
        : this(model, manufacturer, owner, price, null, null)
    {}

    //Method for printing the GSM's information
    public override string  ToString()
    {

        StringBuilder toString = new StringBuilder();
        toString.AppendLine("----GSM----");
        toString.AppendLine("-> Model: " + this.Model + "\n-> Manufacturer: " + this.Manufacturer);
        toString.AppendLine("-> Owner: " + this.Owner + "\n-> Price: " + this.Price);
        if (this.Battery != null)
        {
            toString.AppendLine("-> Battery\n  >> Battery model: " + this.Battery.Model);
            toString.AppendLine("  >> Battery hours talk: " + this.Battery.HoursTalk);
            toString.AppendLine("  >> Battery hours idle: " + this.Battery.HoursIdle);
        }
        if (this.Display != null)
        {
            toString.AppendLine("-> Display\n  >> Display size: " + this.Display.Size);
            toString.AppendLine("  >> Display color number: " + this.Display.ColorNumber);
        }
        return toString.ToString();
    }
}