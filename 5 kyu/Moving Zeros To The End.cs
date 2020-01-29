// https://www.codewars.com/kata/52597aa56021e91c93000cb0

using System;

public static int[] MoveZeroes(int[] arr)
{
    int counter = 0;
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0)
        {
            counter++;
        }
        else
        {
            newArr[i - counter] = arr[i];
        }
    }
    return newArr;
}

// Tests
using NUnit.Framework;
using System;
using System.Linq;

[TestFixture]
public class Sample_Test
{
  [Test]
  public void Test()
  {
    Assert.AreEqual(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}, Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
  }
}

[TestFixture]
public class Random_Test
{
  private static Random rnd = new Random();
  
  private static int[] solution(int[] arr) => arr.Where(v => v != 0).Concat(arr.Where(v => v == 0)).ToArray();
  
  [Test, Description("Random Tests")]
  public void Test()
  {
    const int Tests = 100;
    
    for (int i = 0; i < Tests; ++i)
    {
      int[] test = new int[rnd.Next(4, 100)].Select(_ => rnd.Next(0, 6)).ToArray();
      
      int[] expected = solution(test);
      int[] actual = Kata.MoveZeroes(test);
      
      Assert.AreEqual(expected, actual);
    }
  }
}
