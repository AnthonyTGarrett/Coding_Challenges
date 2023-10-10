// Given an array of integers, return a new array with each value doubled.
using System.Linq;

public class Kata
{
  public static int[] Maps(int[] x)
  {
    return x.Select(num => num * 2).ToArray();
  }
}