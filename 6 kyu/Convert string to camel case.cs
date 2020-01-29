// https://www.codewars.com/kata/517abf86da9663f1d2000003

using System;

public static string ToCamelCase(string str)
{
    string[] split = str.Split('_', '-');
    for (int i = 1; i < split.Length; i++)
    {
        split[i] = split[i].Substring(0, 1).ToUpper() + split[i].Substring(1);
    }
    return string.Join("", split);
}

// Tests
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void KataTests()
    {
        Assert.AreEqual("theStealthWarrior", Kata.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        Assert.AreEqual("TheStealthWarrior", Kata.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        Assert.AreEqual("ickupcjdibDmjpfhwiymIybuikcxks", Kata.ToCamelCase("ickupcjdib_dmjpfhwiymIybuikcxks"), "Kata.ToCamelCase('ickupcjdib_dmjpfhwiymIybuikcxks') did not return correct value");
    }
}
