// Write a function that returns a string in which firstname is swapped with last name.

using System;

public class Kata
{
  public static string NameShuffler(string str)
  {
    var splitName = str.Split();
    Array.Reverse(splitName);

    return String.Join(" ", splitName);
  }
}