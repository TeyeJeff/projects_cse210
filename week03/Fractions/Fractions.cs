using System;
using System.Security.Cryptography.X509Certificates;

public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int wholeNumber)
    {
        this._top = wholeNumber;
        this._bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        this._top = top;
        this._bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string results = $"{_top}/{_bottom}";
        return results;
    }

    public double GetDecimalValue()
    {
        double decimalResults = (double)_top / (double)_bottom;
        return decimalResults;
    }
    
}