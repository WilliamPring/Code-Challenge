using System;
using NUnit.Framework;
using System;
using System.Linq;

/*
Return the number (count) of vowels in the given string.

We will consider a, e, i, o, and u as vowels for this Kata.

*/




[TestFixture]
public class KataTests
{
    [Test]
    public void TestCase1()
    {
        Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
    }
}




public static class Kata
{
        public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        string name = ""; 
        name = str.ToLower();
        // Your code here
        foreach (char c in name) {
        if ((c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u'))
        {
          vowelCount++;
        }
        }
        return vowelCount;
    }
}
}