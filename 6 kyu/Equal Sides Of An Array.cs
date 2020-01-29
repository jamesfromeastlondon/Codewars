// https://www.codewars.com/kata/5679aa472b8f57fb8c000047

using System;

public static int FindEvenIndex(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int sumLeft = 0;
        int sumRight = 0;
        if (i != 0)
        {
            for (int iLeft = i - 1; iLeft > -1; iLeft--)
            {
                sumLeft += arr[iLeft];
            }
        }
        if (i != arr.Length)
        {
            for (int iRight = i + 1; iRight < arr.Length; iRight++)
            {
                sumRight += arr[iRight];
            }
        }
        if (sumLeft == sumRight)
        {
            return i;
        }
    }
    return -1;
}

// Tests
using NUnit.Framework; 
using System;

[TestFixture]
public class ValidateWordTest
{
  [Test]
  public void GenericTests()
  {
    Assert.AreEqual(3,Kata.FindEvenIndex(new int[] {1,2,3,4,3,2,1}));
    Assert.AreEqual(1,Kata.FindEvenIndex(new int[] {1,100,50,-51,1,1}));
    Assert.AreEqual(-1,Kata.FindEvenIndex(new int[] {1,2,3,4,5,6}));
    Assert.AreEqual(3,Kata.FindEvenIndex(new int[] {20,10,30,10,10,15,35}));
  }
}
