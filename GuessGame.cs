public class GuessGame
{
    private readonly int _picked;

    public GuessGame(int picked)
    {
        _picked = picked;
    }

    // -1: num is higher than picked, 1: num is lower than picked, 0: correct
    protected int guess(int num)
    {
        if (num > _picked) return -1;
        if (num < _picked) return 1;
        return 0;
    }

    public int GuessNumber(int higherBound)
    {
        if (higherBound == 1) return higherBound;
        int lowerBound = 1;
        int mid;

        while (lowerBound <= higherBound)
        {
            mid = lowerBound + (higherBound - lowerBound) / 2;
            int returnedAnswer = guess(mid);

            if (returnedAnswer == 0) return mid;
            else if (returnedAnswer == 1) lowerBound = mid + 1;
            else higherBound = mid - 1;
        }
        return -1;
    }

}
