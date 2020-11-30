public class Wiskunde
{

    public static int GeefPercentile(int score)
    {
        return _percentiles[score];
    }

    int[] _percentiles = 
    {
        0, 2, 10, 20, 30, 40, 60, 60, 80, 98, 99
    };

}