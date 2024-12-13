using System;

public abstract class Activity
{
    private DateTime _date;
    private float _duration; 


    public Activity(DateTime date, float duration)
    {
        _date = date;
        _duration = duration;
    }


    public Activity(float duration)
    {
        _date = DateTime.Today;
        _duration = duration;
    }

    public DateTime Date => _date;


    public float Duration => _duration;


    public abstract string GetSummary();
}
