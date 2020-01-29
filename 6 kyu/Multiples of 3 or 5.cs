// https://www.codewars.com/kata/514b92a657cdc65150000006

using System;
using System.Linq;

public static int Solution(int n)
{
  return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
}

// Tests
using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  public void Test()
  {
    Assert.AreEqual(23, Kata.Solution(10));
  }
}
