﻿using System;
using System.Collections.Generic;

class WordCounter
{
   private static readonly string TEXT ="She uchish li she bachkash li? Be kvo she bachkash " +
                                        "be? Tui vashto uchene li e? Ia po-hubavo opitai da " +
                                        "BACHKASH da se uchish malko! Uchish ne uchish trqbva " +
                                        "da bachkash!";

      static void Main()
      {

            IDictionary<String, int> wordOccurrenceMap =GetWordOccurrenceMap(TEXT);
            PrintWordOccurrenceCount(wordOccurrenceMap);
      }
 
      private static IDictionary<string, int> GetWordOccurrenceMap(string text)
      {
            string[] tokens =text.Split(' ', '.', ',', '-', '?', '!');
            IDictionary<string, int> words =new SortedDictionary<string, int>();

            foreach (string word in tokens)
            {
                  if (string.IsNullOrEmpty(word.Trim()))
                  {
                        continue;
                  }
                  int count;
                  if (!words.TryGetValue(word, out count))
                  {
                        count = 0;
                  }
                  words[word] = count + 1;
            }
            return words;
      }

      private static void PrintWordOccurrenceCount(IDictionary<string, int> wordOccuranceMap)
      {
          foreach (KeyValuePair<string, int> wordEntry in wordOccuranceMap)
          {
              Console.WriteLine("Word ‘{0}’ occurs {1} time(s) in the text",wordEntry.Key, wordEntry.Value);
          }
          Console.ReadKey();
      }
}

