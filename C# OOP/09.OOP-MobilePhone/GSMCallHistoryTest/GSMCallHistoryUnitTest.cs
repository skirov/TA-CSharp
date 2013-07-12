using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GSMCallHistoryTest
{
    [TestClass]
    public class GSMCallHistoryTest
    {
        //static in order to keep the values passed in AddCalls()
        static GSM phone = new GSM("3100", "Nokia", 120, "John Doe");

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
        public void AddCalls()
        {
            phone.AddCallsInHistory(new DateTime(23, 02, 13, 11, 11, 11), "0888888999", 5);
            phone.AddCallsInHistory(new DateTime(23, 02, 13, 11, 11, 11), "0888888999", 124);
            phone.AddCallsInHistory(new DateTime(23, 02, 13, 11, 11, 11), "0888888999", 355);
        }

        //You can see the ouput when you run ALL the tests and when you choose the DisplayInfoAboutCalls test
        //and click on output
        [TestMethod]
        public void DisplayInfoAboutCalls()
        {
            foreach (var call in phone.CallHistory)
            {
                TestContext.WriteLine(call.DialedNumber.ToString());
                TestContext.WriteLine(call.DateAndTime.ToString());
                TestContext.WriteLine(call.Duration.ToString());
            }
        }

        //You can see the ouput when you run ALL the tests and when you choose the DisplayInfoAboutCalls test
        //and click on output
        [TestMethod]
        public void DisplayPriceForMadeCallsAndAssertResult()
        {
            // (5+124+355) / 60 = 9min
            // 9min * 0.37lv = 3.33lv
            Assert.AreEqual(phone.PriceOfAllCalls(0.37m), 3.33m);
            //print output
            TestContext.WriteLine(phone.PriceOfAllCalls(0.37m).ToString());
        }

        //You can see the ouput when you run ALL the tests and when you choose the DisplayInfoAboutCalls test
        //and click on output
        [TestMethod]
        public void RemoveLongestCallPrintPriceAgainAndAssert()
        {
            //the function is at the bottom of GSM class.
            //It's in the GSM class because I cannot change it in other classes, because I made it
            //IReadOnlyCollection, to prevent changes outside the class GSM
            phone.RemoveLongestCall();
            //this means we remove 355 and the new sum to pay must be 1.11
            // (5+124) / 60 = 3min
            // 3min * 0.37lv = 1.11lv
            Assert.AreEqual(phone.PriceOfAllCalls(0.37m), 1.11m);
            //print output
            TestContext.WriteLine(phone.PriceOfAllCalls(0.37m).ToString());
        }

        [TestMethod]
        public void ClearAllCallHistoryAndShowEmptyCallHistory()
        {
            //clear history
            phone.ClearCallsHistory();

            //assert that the elements in call history are empty(null)
            foreach (var call in phone.CallHistory)
            {
                Assert.IsNull(call.DialedNumber);
                Assert.IsNull(call.DateAndTime);
                Assert.IsNull(call.Duration);
            }
        }
    }
}
