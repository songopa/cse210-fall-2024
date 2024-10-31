public class SwimmingActivity: Activity
{
    private float _laps;

    public SwimmingActivity(string date, int minutes, float laps): base("Swimming", date, minutes)
    {
        _laps = laps;
    }

    public override float Distance()
    {
        return _laps * 50 / 1000;
    }
}