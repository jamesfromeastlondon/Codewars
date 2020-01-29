// https://www.codewars.com/kata/56a5d994ac971f1ac500003e

using System;
using System.Collections.Generic;
using System.Linq;

public static string LongestConsec(string[] strarr, int k)
{
    if (strarr.Length == 0 || strarr.Length < k || k <= 0) return "";
    string longestWord = "";

    for (int i = 0; i < strarr.Length + 1 - k; i++)
    {
        string joinedWord = "";
        int num = i + k;
        for (int j = i; j < num; j++)
        {
            joinedWord += strarr[j];
        }
        if (joinedWord.Length > longestWord.Length)
        {
            longestWord = joinedWord;
        }
    }
    return longestWord;
}

// Tests
using System;
using NUnit.Framework;

[TestFixture]
public static class LongestConsecutivesTests 
{
    private static void testing(string actual, string expected) 
    {
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public static void test1() 
    {        
        Console.WriteLine("Basic Tests");
        testing(LongestConsecutives.LongestConsec(new String[] {"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"}, 2), "abigailtheta");
        testing(LongestConsecutives.LongestConsec(new String[] {"ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"}, 1), "oocccffuucccjjjkkkjyyyeehh");
        testing(LongestConsecutives.LongestConsec(new String[] {}, 3), "");
        testing(LongestConsecutives.LongestConsec(new String[] {"itvayloxrp","wkppqsztdkmvcuwvereiupccauycnjutlv","vweqilsfytihvrzlaodfixoyxvyuyvgpck"}, 2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
        testing(LongestConsecutives.LongestConsec(new String[] {"wlwsasphmxx","owiaxujylentrklctozmymu","wpgozvxxiu"}, 2), "wlwsasphmxxowiaxujylentrklctozmymu");
        testing(LongestConsecutives.LongestConsec(new String[] {"zone", "abigail", "theta", "form", "libe", "zas"}, -2), "");
        testing(LongestConsecutives.LongestConsec(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 3), "ixoyx3452zzzzzzzzzzzz");
        testing(LongestConsecutives.LongestConsec(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 15), "");
        testing(LongestConsecutives.LongestConsec(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 0), "");
    }
}
