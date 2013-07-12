using System;
using System.Threading;

public delegate void TimerDelegate(string messageToDisplay);

class Timer
{
    private int seconds;
    public TimerDelegate displayMessage;
    public int Seconds
    {
        get { return this.seconds; }
        set { this.seconds = value * 1000; } //Multiply the value with 1000 because Thread.Sleep() works with milliseconds
    }

    public Timer(int secondsToFreeze)
    {
        Seconds = secondsToFreeze;
    }

    //the method which shows the message
    public void Message(string message)
    {
        Console.WriteLine(message);
    }

    private void DislayMessage(string message, int timesToDisplayMessage)
    {
        displayMessage = Message; //set the message to the delegate
        while (timesToDisplayMessage > 0) //display the message n times with t second intervals
        {
            displayMessage(message);
            Thread.Sleep(Seconds);
            timesToDisplayMessage--;
        }
    }

    static void Main()
    {
        Timer timer = new Timer(1); //1sec
        timer.DislayMessage("Hello", 10); //Displays ""Hello" ten times
    }
}
