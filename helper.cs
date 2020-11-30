public class Wiskunde
{

    public static int GeefPercentile(int score)
    {
        return _percentiles[score];
    }

    int[] _percentiles = 
    {
        0, 5, 10, 15, 25, 35, 55, 60, 75, 85, 99
    };

}