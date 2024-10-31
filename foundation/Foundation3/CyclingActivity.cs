public class CyclingActivity: Activity
{
    private float _speed;

    public CyclingActivity(string date, int minutes, float speed): base("Cycling", date, minutes)
    {
        _speed = speed;
    }

    public override float Distance()
    {
        return _minutes * _speed / 60;
    }

}