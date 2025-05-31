using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        string[] texts = text.Split(' ');
        foreach (string singleText in texts)
        {
            Word word = new Word(singleText);
            this._words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {

        Word word = this._words[numberToHide];
        word.Hide();
    }

    public string GetDisplayText()
    {
        string sentence = this._reference.GetDisplayText() + " ";
        foreach (Word word in this._words)
        {
            sentence += word.GetDisplay() + ' ';
        }
        return sentence.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in this._words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    public int GetWordsLength()
    {
        return this._words.Count;
    }
}