using System;
using System.Reflection;
using log4net;
using log4net.Config;

class Program
{
    private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    static void Main()
    {
        XmlConfigurator.Configure();

        Log.Debug("Debug message");
        Log.Info("Info message");
        Log.Warn("Warning message");
        Log.Error("Error message");
        Log.Fatal("Fatal message");

        try
        {
            throw new InvalidOperationException("An exception occurred.");
        }
        catch (InvalidOperationException ex)
        {
            Log.Error("Error.", ex);
        }
    }
}