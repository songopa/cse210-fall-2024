public class RunningActivity: Activity
{
    private float _distance;

    public RunningActivity(string date, int minutes, float distance): base("Running", date, minutes)
    {
        _distance = distance;
    }

    public override float Distance()
    {
        return _distance;
    }


}