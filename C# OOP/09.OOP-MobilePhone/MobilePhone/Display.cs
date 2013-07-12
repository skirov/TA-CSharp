using System;

public class Display
{
    private double? size;
    private int? numberOfColors;

    public Display(double? size = null, int? numberOfColors = null) 
    {
        this.Size = size;
        this.NumberOfColors = numberOfColors;
    }

    public int? NumberOfColors
    {
        get
        {
            return numberOfColors;
        }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Number of colors must be bigger than 0.");
            }
            else
            {
                this.numberOfColors = value;
            }
        }
    }

    public double? Size
    {
        get
        {
            return this.size;
        }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Display size must be bigger than 0.");
            }
            else
            {
                this.size = value;
            }
        }
    }
}