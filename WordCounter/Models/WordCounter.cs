using System;
using System.Collections.Generic;
namespace WordCounter.Models
{
  public class counter
  {
    private string _word;
    private string _newWord;
    //private int _total;
    //private int _id;
    private static List<counter> _instances = new List<counter> {};

    public counter(string word, string newWord)
    {
      _word = word;
      _newWord = newWord;
      _instances.Add(this);
      
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetString()
    {
      return _newWord;
    }
    public static List<counter> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public int WordTotal()
    {
      int  _total = 0;
      //string _newString = " ";

      if(_word != " ")
      {
        try
        {
          string[] arr=_newWord.Split( ' ', ',', '.', ':', '\t' );
          for(int x=0; x<arr.Length; x++)
          {
            if(_word.ToLower() == arr[x].ToLower())
            {
              _total++;
            }
          }
        }
        catch ( InvalidCastException )
        {
          Console.WriteLine("That is not good enough");
        }
      }
      return _total;
    }
  }
}
