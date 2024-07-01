using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private readonly string _reference;
    private readonly List<Word> _words;
    private bool _allWordsHidden;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = ParseWords(text);
        _allWordsHidden = false;
    }

    private List<Word> ParseWords(string text)
    {
        var words = new List<Word>();
        var wordArray = text.Split(' ');
        foreach (var word in wordArray)
        {
            words.Add(new Word(word));
        }
        return words;
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Scripture Reference: {_reference}");
        foreach (var word in _words)
        {
            Console.Write(word.IsHidden ? "____ " : $"{word.Text} ");
        }
        Console.WriteLine("\n\nPress Enter to continue or type 'quit' to exit.");
    }


    public void HideRandomWords()
    {
        var random = new Random();
    
        int wordsToHide = random.Next(1, 4); 
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
        
        _allWordsHidden = _words.All(word => word.IsHidden);
    }

    
    public bool AllWordsHidden()
    {
        return _allWordsHidden;
    }
}


public class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    
    public void Hide()
    {
        IsHidden = true;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        var scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

       
        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            string input = Console.ReadLine()?.ToLower();
            if (input == "quit")
            {
                break;
            }
            else if (input == "")
            {
                scripture.HideRandomWords();
            }
        }

        
        Console.WriteLine("All words are hidden. Program ended.");
    }
}
