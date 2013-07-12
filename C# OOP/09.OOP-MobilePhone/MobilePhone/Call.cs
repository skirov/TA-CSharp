using System;

public class Call
{
    private DateTime dateAndTime;
    private string dialedNumber;
    private int duration;

    public Call()
    {
    }

    public Call(DateTime dateAndTime, string dialedNumber, int duration) 
    {
        this.DateAndTime = dateAndTime;
        this.DialedNumber = dialedNumber;
        this.Duration = duration;
    }

    public DateTime DateAndTime
    {
        get { return this.dateAndTime; }
        set { dateAndTime = DateTime.Parse(value.ToString()); }
    }

    public string DialedNumber 
    {
        get { return this.dialedNumber; }
        set { dialedNumber = value; }
    }

    public int Duration 
    {
        get { return this.duration; }
        set { duration = value; }
    }

}

