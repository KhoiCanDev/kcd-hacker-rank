

string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int m = Convert.ToInt32(firstMultipleInput[1]);

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

int total = Result.getTotalX(arr, brr);

Console.WriteLine(total);

class Result
{

  /*
   * Complete the 'getTotalX' function below.
   *
   * The function is expected to return an INTEGER.
   * The function accepts following parameters:
   *  1. INTEGER_ARRAY a
   *  2. INTEGER_ARRAY b
   */

  public static int getTotalX(List<int> a, List<int> b)
  {
    var result = new List<int>();
    // x%a == 0, b%x == 0
    // find the max in a and b
    // then find between maxA -> maxB
    var maxA = a.Max();
    var maxB = b.Max();

    for (int i = maxA; i <= maxB; i++)
    {
      var thisIsIt = true;
      foreach (var num in a)
      {
        if (i % num > 0)
        {
          thisIsIt = false;
          break;
        }
      }
      foreach (var num in b)
      {
        if (num % i > 0)
        {
          thisIsIt = false;
          break;
        }
      }
      if (thisIsIt)
      {
        result.Add(i);
      }
    }

    return result.Count();
  }
}