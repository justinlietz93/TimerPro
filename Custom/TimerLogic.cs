namespace TimerPro.Custom;

public class TimerLogic
{
    private int _intSec;
    private int _intMin;
    private int _intHour;

    public TimerLogic()
    {
        Reset();
    }

    public void Reset()
    {
        _intSec = 0;
        _intMin = 0;
        _intHour = 0;
    }

    public void SetTickCount()
    {
        _intSec++;
        if (_intSec == 60)
        {
            _intMin++;
            _intSec = 0;
            if (_intMin == 60)
            {
                _intHour++;
                _intMin = 0;
            }
        }
    }

    public string GetFormattedString()
    {
        return _intHour.ToString().PadLeft(2,'0')
               + ":" + _intMin.ToString().PadLeft(2,'0')
               + ":" + _intSec.ToString().PadLeft(2,'0');
    }
}