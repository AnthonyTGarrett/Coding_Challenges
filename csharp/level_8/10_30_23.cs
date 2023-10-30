// Complete the function that takes a non-negative integer n as input, and returns a list of all the powers of 2 with the exponent ranging from 0 to n ( inclusive ).

using System;
using System.Numerics;

public class Kata
{
  public static BigInteger[] PowersOfTwo(int n)
  {
    var result = new BigInteger[n + 1];

    for (int i = 0; i <= n; i++)
    {
      result[i] = (BigInteger)Math.Pow((double)2, (double)i);
    }

    return result;
  }
}