using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKatas._5Kyu
{
    class WhereMyAnagramsAt
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            var result = new List<string>();
            var wordDictionary = WordToDictionary(word);
            var wordsDictionaryList = words.Select(WordToDictionary).ToList();
            for (var index = 0; index < wordsDictionaryList.Count; index++)
            {
                var potentialAnagramDictionary = wordsDictionaryList[index];
                var isAnagram = true;
                if (potentialAnagramDictionary.Sum(pa => pa.Value) != word.Length)
                {
                    continue;
                }
                foreach (var (key, value) in potentialAnagramDictionary)
                {
                    if (!wordDictionary.ContainsKey(key))
                    {
                        isAnagram = false;
                    }
                    else if(wordDictionary[key] != value)
                    {
                        isAnagram = false;
                    }
                }

                if (isAnagram)
                {
                    result.Add(words[index]);
                }
            }

            return result;
        }

        private static Dictionary<char, int> WordToDictionary(string word)
        {
            var dictionary = new Dictionary<char, int>();
            foreach (var letter in word)
            {
                var success = dictionary.TryAdd(letter, 1);
                if (!success)
                {
                    dictionary[letter]++;
                }
            }

            return dictionary;
        }
    }
}
