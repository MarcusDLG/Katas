using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static bool One(int[] arr, Func<int, bool> fun)
  {
    return arr.Count(fun) == 1;
  }
}