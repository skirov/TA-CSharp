using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.IO;

[TestClass]
public class ConsoleOutput
{
    [TestMethod]
    public void TestConsoleOutput()
    {
        StringBuilder expectedOutput = new StringBuilder();

        expectedOutput.AppendLine("Expected console output");

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            Console.WriteLine("Expected console output"); //on this line you print your console output
                                                          //It compares it with the stringbuilder string
        }
        Assert.AreEqual<string>(expectedOutput.ToString(), sw.ToString());
    }
}