// https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1

using System;
using System.Collections.Generic;
using System.Linq;

public static int DuplicateCount(string str)
{
    return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
}

// Tests
[TestFixture]
public class KataTest
{
  [Test]
  public void KataTests()
  {
    Assert.AreEqual(0, Kata.DuplicateCount(""));
    Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
    Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
    Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
    Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
    Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
  }
}
