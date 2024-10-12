using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    

    public Scripture()
    {
        string[] verseArray = Loader();
        _reference = new Reference(verseArray[0], int.Parse(verseArray[1]), int.Parse(verseArray[2]));

        string line = String.Join(",", verseArray[3..verseArray.Length]);
        LineToWordsList(line);
    }

    private string[] Loader()
    {
        string verse;
        
        try
        {
            string[] verses = File.ReadAllLines("mathew.csv");
            Random rand = new Random();
            verse  = verses[rand.Next(verses.Length)];
        }
        catch (FileNotFoundException ex)
        {
            verse = "mathew,4,4,\"But he answered and said, It is written, Man shall not live by bread alone, but by every word that proceedeth out of the mouth of God.\"";
        }
        
        return verse.Split(',');
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