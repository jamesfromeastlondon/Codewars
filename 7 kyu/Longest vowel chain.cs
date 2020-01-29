// https://www.codewars.com/kata/59c5f4e9d751df43cf000035

using System;
using System.Linq;

public static int Solve(string str)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    char[] consonants = str.Except(vowels).ToArray();
    foreach (var consonant in consonants)
    {
        str = str.Replace(consonant.ToString(), " ");
    }
    string[] arr = str.Split(" ");
    return arr.OrderByDescending(i => i.Count()).ElementAt(0).Count();
}

// Tests
using NUnit.Framework;
using System;

[TestFixture]
public class SolutionTest
{
    [Test, Description("Basic Tests")]
    public void SampleTest()
    {
        Assert.AreEqual(2, Kata.Solve("codewarriors"));
        Assert.AreEqual(3, Kata.Solve("suoidea"));
        Assert.AreEqual(3, Kata.Solve("ultrarevolutionariees"));
        Assert.AreEqual(1, Kata.Solve("strengthlessnesses"));
        Assert.AreEqual(2, Kata.Solve("cuboideonavicuare"));
        Assert.AreEqual(5, Kata.Solve("chrononhotonthuooaos"));
        Assert.AreEqual(8, Kata.Solve("iiihoovaeaaaoougjyaw"));
    }
}
