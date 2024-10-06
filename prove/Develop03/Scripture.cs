using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    

    public Scripture()
    {
        string[] verses = File.ReadAllLines("mathew.csv");
        Random rand = new Random();
        string verse  = verses[rand.Next(verses.Length)];
        string[] verseArray = verse.Split(',');
        string line = String.Join(",", verseArray[3..verseArray.Length]);

        _reference = new Reference(verseArray[0], int.Parse(verseArray[1]), int.Parse(verseArray[2]));
        LineToWordsList(line);
    }

    private string Loader()
    {
        return "";
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
        while (numberToHide > 0 )
        {    
            Random random = new Random();
            Word word = _words[random.Next(_words.Count)];
            if(!word.IsHidden())
            {
                word.Hide();
                numberToHide--;
            }
            if (IsCompletelyHidden())
            {
                numberToHide = 0;
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
        int hiddenCount = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden()) 
            {
                hiddenCount++;
            }
        }
        if (hiddenCount == _words.Count())
        {
            return true;
        } else
        {
            return false;
        }
    }
}