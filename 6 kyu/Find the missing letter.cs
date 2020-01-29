// https://www.codewars.com/kata/5839edaa6754d6fec10000a2

using System;

public static class Kata
{
    public static char MissingLetter(char[] arr)
    {
        int counter = 0;
        for (char c = arr[0]; c < arr[arr.Length - 1]; c++)
        {
            if(arr[counter] != c) return c;
            counter++;
        }
        return ' ';
    }
}

// Tests
using NUnit.Framework;
using System;
using System.Linq;

public class KataTests
{
    [Test]
    public void ExampleTests()
    {
        Assert.AreEqual('e', Kata.FindMissingLetter(new [] { 'a','b','c','d','f' }));
        Assert.AreEqual('P', Kata.FindMissingLetter(new [] { 'O','Q','R','S' }));
    }
}
