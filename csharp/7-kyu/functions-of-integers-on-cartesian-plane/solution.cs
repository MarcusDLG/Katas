public class Funcij
{

  public static ulong sumin(ulong n)
  {
    return n * (n + 1) * (2 * n + 1) / 6;
  }
  public static ulong sumax(ulong n)
  {
    return n * n * (n + 1) - n * (n + 1) * (2 * n + 1) / 6;
  }
  public static ulong sumsum(ulong n)
  {
    var m = n * (n + 1) / 2;
    return n * m + n * m;
  }
}