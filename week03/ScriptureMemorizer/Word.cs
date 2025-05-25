using System;
using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text)
    {
        this._text = text;
        this._isHidden = false;
    }

    public void Hide()
    {
        this._isHidden = true;
    }

    public void Show()
    {
        this._isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplay()
    {
        if (this._isHidden == true)
        {
            return new string('_', this._text.Length);
        }
        else
        {
            return this._text;
        }
    }
}