// https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp

using System;
using System.Linq;

public static string AlphabetPosition(string text)
{
    char[] input = string.Concat(text.Where(char.IsLetter)).ToLower().ToCharArray();
    char[] alphabet = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    string[] output = new string[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        output[i] = Array.IndexOf(alphabet, input[i]).ToString();
    }
    return string.Join(" ", output);
}

// Tests
using NUnit.Framework;
using System;

[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
        Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", Kata.AlphabetPosition("The narwhal bacons at midnight."));
    }
}
