// https://www.hackerrank.com/challenges/the-birthday-bar/problem?isFullScreen=true

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int d = Convert.ToInt32(firstMultipleInput[0]);

int m = Convert.ToInt32(firstMultipleInput[1]);

int result = Result.birthday(s, d, m);

Console.WriteLine(result);

class Result
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int sumBar = d;
        int sumSquare = m;
        
        int barTracking = 0;
        int squareTracking = 0;
        int ways = 0;
        
        bool continueToRun = true;
        int executingIndex = 0;
        int checkingIndex = 0;
        int maxIndex = s.Count() - 1;
        
        while (continueToRun) {
            barTracking += s.ElementAt(executingIndex);
            squareTracking += 1;
            
            if (squareTracking == sumSquare) {
                if (barTracking == sumBar) {
                    ways += 1;
                }
                barTracking = 0;
                squareTracking = 0;
                checkingIndex += 1;
                executingIndex = checkingIndex;
            } else {
                executingIndex += 1;
            }
            
            if (executingIndex > maxIndex) {
                continueToRun = false;
            }
        }
    
        return ways;
    }

}