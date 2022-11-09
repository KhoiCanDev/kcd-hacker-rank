// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

List<int> result = Result.breakingRecords(scores);

Console.WriteLine(String.Join(" ", result));

class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int maxScore = 0;
        int minScore = 0;
        int breakHigh = 0;
        int breakLow = 0;
        
        for (int i = 0; i < scores.Count(); i++)
        {
            int score = scores.ElementAt(i);
            if (i == 0) {
                maxScore = score;
                minScore = score;
            } else {
                if (maxScore < score) {
                    maxScore = score;
                    breakHigh += 1;
                }
                if (score < minScore) {
                    minScore = score;
                    breakLow += 1;
                }
            }
        }
        
        return new List<int>() { breakHigh, breakLow };
    }

}