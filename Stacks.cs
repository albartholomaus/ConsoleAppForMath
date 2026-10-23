namespace ConsoleAppForMath;

class Stacks
{
    //["1","2","+","C","5","D"]
    //["5","D","+","C"]
    public int CalPoints(string[] operations)
    {
        Stack<int> scores = new();

        for (int i = 0; i < operations.Length; i++)
        {

            switch (operations[i])
            {
                case "+":
                    int top = scores.Pop();
                    int total = top + scores.Peek();
                    scores.Push(top);
                    scores.Push(total);
                    break;
                case "D":
                    int doubleScore = scores.Peek() * 2;
                    scores.Push(doubleScore);
                    break;
                case "C":
                    scores.Pop();
                    break;
                default:
                    scores.Push(int.Parse(operations[i]));
                    break;
            }
        }
        int totalScore = 0;
        foreach (var score in scores)
        {
            totalScore += score;
        }
        return totalScore;
    }

    public bool IsValid(string s)
    {
        Stack<char> brackets = new(s.Length);

        for (int i = 0; i < s.Length; i++)
        {
            char test = s[i];
        }

        return false;
    }
}