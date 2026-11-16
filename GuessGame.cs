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
}
