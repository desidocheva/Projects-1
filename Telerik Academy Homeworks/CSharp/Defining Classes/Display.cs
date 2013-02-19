using System;
class Display
{
    private double size;
    private long colorNumber;
    public double Size 
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value<0)
	        {
		         throw new ArgumentException("Size of display can't be negative");
	        }
            this.size = value;
        }
    }
    public long ColorNumber 
    {
        get
        {
            return this.colorNumber;
        }
        set
        {
            if (value<0)
	        {
		         throw new ArgumentException("Number of colors can't be negative");
	        }
            this.colorNumber = value;
        }
    }
    public Display(double size, long colorNumber)//Constructor to define display with size and color number
    {
        this.Size = size;
        this.ColorNumber = colorNumber;
    }
    //Constructor to define display with size
    public Display(double size)
        : this(size, 0)
    { }
}