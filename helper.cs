public class Wiskunde
{

    public static int GeefPercentile(int score)
    {
        return _percentiles[score];
    }

    int[] _percentiles = 
    {
        0, 10, 10, 20, 30, 40, 60, 60, 80, 90, 99
    };

}