using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string line)
    {
        _reference = reference;
        LineToWordsList(line);
    }

    private void LineToWordsList(string line)
    {
        string[] wordsArray = line.Split(' ');
        List<string> wordsList = new List<string>(wordsArray);

        if (wordsList.Count > 0)
        {
            foreach (string word in wordsList)
            {
                 _words.Add(new Word(word));
            }
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        while (numberToHide > 0)
        {    
            Random random = new Random();
            Word word = _words[random.Next(_words.Count)];
            if(word.IsHidden())
            {
                word.Hide();
                numberToHide--;
            }
        }
    }

    public string GetDisplayText()
    {
        string passage = "";
        foreach (Word word in _words)
        {
            passage = passage + word.GetDisplayText() +" ";
        }
        return $"{_reference.GetDisplayText()} {passage}";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}