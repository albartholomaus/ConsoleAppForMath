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

    public bool IsValid(string str)
    {
        str = "[]";
        Dictionary<char, char> brackets = new()
        {
            {'(',')'}, {'[',']'}, {'{','}'}
        };
        Stack<char> stack = new();
        for (int i = 0; i < str.Length; i++)
        {
            if (brackets.ContainsKey(str[i])) stack.Push(str[i]);
            else if (stack.Count > 0 && brackets[stack.Peek()] == str[i]) stack.Pop();
            else return false;
        }
        return stack.Count == 0;
    }

}

public class MinStack
{
    private Stack<int> theStack;
    int min;
    public MinStack()
    {
        theStack = new();
        min = int.MinValue;
    }

    public void Push(int val)
    {
        theStack.Push(val);
    }

    public void Pop()
    {
        theStack.Pop();
    }

    public int Top()
    {
        return theStack.Peek();
    }

    public int GetMin()
    {
       return min;
    }
}
