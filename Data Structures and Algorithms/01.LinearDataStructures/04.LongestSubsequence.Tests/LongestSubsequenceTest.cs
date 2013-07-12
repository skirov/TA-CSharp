using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class LongestSubsequenceTest
{
    [TestMethod]
    public void GetLongestSubsequenceTest_WithFollowingNumbers()
    {
        List<int> integers = new List<int>() { 1, 1, 1, 2, 2, 2, 2, 3, 3, 3 };

        List<int> expected = new List<int>() { 2, 2, 2, 2 };

        List<int> actual = integers.GetLongestSubsequence();

        for (int i = 0; i < actual.Count; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }

    [TestMethod]
    public void GetLongestSubsequenceTest_WithMixedNumbers()
    {
        List<int> integers = new List<int>() { 1, 2, 15, 15, 15, 25, 18, 18, 18, 18 };

        List<int> expected = new List<int>() { 18, 18, 18, 18 };

        List<int> actual = integers.GetLongestSubsequence();

        for (int i = 0; i < actual.Count; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }

    [TestMethod]
    public void GetLongestSubsequenceTest_WithOneNumberSubsequence()
    {
        List<int> integers = new List<int>() { 1, 2, 15, 18, 16, 6, 10, 2, 15 };

        List<int> expected = new List<int>() { 15 };

        List<int> actual = integers.GetLongestSubsequence();

        for (int i = 0; i < actual.Count; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }

    [TestMethod]
    public void GetLongestSubsequenceTest_WithAllNumbersSubsequence()
    {
        List<int> integers = new List<int>() { 5, 5, 5, 5, 5 };

        List<int> expected = new List<int>() { 5, 5, 5, 5, 5 };

        List<int> actual = integers.GetLongestSubsequence();

        for (int i = 0; i < actual.Count; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }
}
