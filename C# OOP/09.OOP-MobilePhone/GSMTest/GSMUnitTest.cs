using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class GSMTest
{
    //static in order to keep the values passed in CreateFewGSMInstances()
    static object[] instancesArray = new object[4]; 

    //TestContext is used to display info when debugging a UnitTest
    private TestContext displayInfo;

    public TestContext TestContext
    {
        get
        {
            return displayInfo;
        }
        set
        {
            displayInfo = value;
        }
    }

    [TestMethod]
    public void CreateFewGSMInstances()
    {
        instancesArray[0] = new GSM("3100", "Nokia", 120, "John Doe");
        instancesArray[1] = new GSM("W175", "Motorola", 10);
        instancesArray[2] = new GSM("5", "IPhone", "Johnny Retard");
        instancesArray[3] = new GSM("50", "IPhone");
    }

    [TestMethod]
    //You can see the ouput when you run ALL the tests and when you choose the DisplayInfoAboutGSMsInArray test
    //and click on output
    public void DisplayInfoAboutGSMsInArray()
    {
        for (int i = 0; i < instancesArray.Length; i++)
        {
            TestContext.WriteLine(instancesArray[i].ToString());
        }
    }

    [TestMethod]
    //You can see the ouput when you run the test and you choose the SeeInfoAboutStaticIphone4S test
    //and click on output
    public void SeeInfoAboutStaticIphone4S()
    {
        TestContext.WriteLine(GSM.IPhone4S.ToString());
    }
}