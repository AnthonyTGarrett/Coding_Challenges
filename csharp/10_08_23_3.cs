// Your task is to make two functions ( max and min, or maximum and minimum, etc., depending on the language ) that receive a list of integers as input, and return the largest and lowest number in that list, respectively.


using System;

public class Kata
{
  public int Min(int[] list)
  {
    Array.Sort(list);
    return list[0];
  }

  public int Max(int[] list)
  {
    Array.Sort(list);
    Array.Reverse(list);
    return list[0];
  }
}