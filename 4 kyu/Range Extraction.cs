// https://www.codewars.com/kata/51ba717bb08c1cd60f00002f/train/csharp

using System;
using System.Collections.Generic;

public static string Extract(int[] arr)
{
    List<string> strings = new List<string>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 2)
        {
            if (arr[i] + 1 == arr[i + 1] && 
                arr[i] + 2 == arr[i + 2])
            {
                int rangeStart = arr[i];
                int rangeEnd = GetRangeEnd(i, arr);
                strings.Add($"{rangeStart}-{rangeEnd}");
                i = Array.IndexOf(arr, rangeEnd);
                continue;
            }
        }
        strings.Add(arr[i].ToString());
    }
    return string.Join(",",strings.ToArray());
}

public static int GetRangeEnd(int index, int[] arr)
{
    for (int i = index; i < arr.Length - 1; i++)
    {
        if (i == arr.Length - 1) break;
        if (arr[i] + 1 != arr[i + 1]) return arr[i];
    }
    return arr[arr.Length - 1];
}

// Tests
using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class RangeExtractorTest
{
    [Test(Description = "Simple tests")]
    public void SimpleTests()
    {
        Assert.AreEqual("1,2", RangeExtraction.Extract(new[] { 1, 2 }));
        Assert.AreEqual("1-3", RangeExtraction.Extract(new[] { 1, 2, 3 }));

        Assert.AreEqual(
            "-6,-3-1,3-5,7-11,14,15,17-20",
            RangeExtraction.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })
        );

        Assert.AreEqual(
            "-3--1,2,10,15,16,18-20",
            RangeExtraction.Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 })
        );
    }
}