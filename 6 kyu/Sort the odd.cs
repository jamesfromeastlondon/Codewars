// https://www.codewars.com/kata/578aa45ee9fd15ff4600090d

using System;
using System.Linq;

public static int[] SortArray(int[] array)
{
    if (array.Length == 0) return new int[0];

    int[] oddArray = array.Where(n => n % 2 != 0).OrderBy(n => n).ToArray();
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            array[i] = oddArray[counter];
            counter++;
        }
    }
    return array;
}

// Tests
using NUnit.Framework;
using System;

[TestFixture]
public class Tests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
        Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
        Assert.AreEqual(new int[] { }, Kata.SortArray(new int[] { }));
    }
}
