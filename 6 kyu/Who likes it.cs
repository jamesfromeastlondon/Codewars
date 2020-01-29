// https://www.codewars.com/kata/5266876b8f4bf2da9b000362

using System;
using System.Linq;

public static string Likes(string[] name)
{
    switch (name.Length)
    {
        case 0:
            return "no one likes this";
        case 1:
            return $"{name[0]} like this";
        case 2:
            return $"{name[0]} and {name[1]} likes this";
        case 3:
            return $"{name[0]}, {name[1]} and {name[2]} like this";
        default:
            return $"{name[0]}, {name[1]} and {name.Count() - 2} others like this";
    }
}

// Tests
using NUnit.Framework;
using System;

[TestFixture]
public class SolutionTest
{
    [Test, Description("It should return correct text")]
    public void SampleTest()
    {
        Assert.AreEqual("no one likes this", Kata.Likes(new string[0]));
        Assert.AreEqual("Peter likes this", Kata.Likes(new string[] { "Peter" }));
        Assert.AreEqual("Jacob and Alex like this", Kata.Likes(new string[] { "Jacob", "Alex" }));
        Assert.AreEqual("Max, John and Mark like this", Kata.Likes(new string[] { "Max", "John", "Mark" }));
        Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
    }
}
