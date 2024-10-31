public abstract class Activity
{
    private string _name;
    private string _date;
    protected int _minutes;

    public Activity(string name, string date, int minutes)
    {
        _name = name;
        _date = date;
        _minutes = minutes;
    }

    public abstract float Distance();
    public float Speed()
    {
        return Distance() / _minutes * 60;
    }
    public float Pace()
    {
        return _minutes / Distance();
    }
    public string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} min): Distance {Distance()} km, Speed {Speed()} kph, Pace {Pace()} min per km";
    }
}