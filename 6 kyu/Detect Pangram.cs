// https://www.codewars.com/kata/545cedaa9943f7fe7b000048

using System;

public static bool IsPangram(string str)
{
    str = str.ToLower();
    for (char letter = 'a'; letter <= 'z'; letter++)
    {
        if (!str.Contains(letter)) return false;
    }
    return true;
}

// Tests
using NUnit.Framework;
using System;

[TestFixture]
public class Tests 
{
    [Test]
    public void SampleTests() 
    {
        Assert.AreEqual(true, Kata.IsPangram("The quick brown fox jumps over the lazy dog."));
        Assert.AreEqual(false, Kata.IsPangram("Hello World."));
    }
}
