using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace TextGobbler
{
	public static class Gobbler
	{
		public class GobbleOptions
		{
			public bool ExclusiveParagraphs { get; set; } = true;
			public bool PrioritizeLongWords { get; set; } = false;
			public bool AddJunk { get; set; } = false;
			public string Seed { get; set; } = "silly";
			public bool Watermark { get; set; } = true;
		}

		private static readonly string[] _junk =
		{
			"but um",
			"so like",
			"yea ok",
			"uh right",
		};

		private static readonly string[] _junkEnding =
		{
			"yea",
			"ok",
			"fair enough",
		};

		private static string GetSomeJunk(Random random)
		{
			return _junk[random.Next(0, _junk.Length)];
		}

		private static string GetSomeEndingJunk(Random random)
		{
			return _junkEnding[random.Next(0, _junkEnding.Length)];
		}

		private static string StripNonAlphaNumericCharacters(string text)
		{
			return Regex.Replace(text, @"([^A-Za-z0-9\-\s])", "");
		}

		private static List<string> GetUniqueWords(List<string> words)
		{
			List<string> result = new List<string>();

			foreach (string word in words)
			{
				if (result.Contains(word))
					continue;
				result.Add(word);
			}

			return result;
		}

		private static int GetNumShortWords(List<string> words, int shortLength)
		{
			int result = 0;

			foreach (string word in words)
			{
				if (word.Length <= shortLength)
					result++;
			}

			return result;
		}

		private static int GetNumLongWords(List<string> words, int shortLength)
		{
			int result = 0;

			foreach (string word in words)
			{
				if (word.Length > shortLength)
					result++;
			}

			return result;
		}

		public static string Gobble(string text, GobbleOptions options, bool sub = false, int index = -1)
		{
			StringBuilder sb = new StringBuilder();

			Random random = !string.IsNullOrWhiteSpace(options.Seed)
				? new Random(options.Seed.GetHashCode())
				: new Random();

			text = text.Replace("\r\n", "\n");

			if (options.ExclusiveParagraphs && text.Contains("\n"))
			{
				List<string> lines = text.Split('\n').ToList();
				for (int i = 0; i < lines.Count; i++)
				{
					sb.Append(Gobble(lines[i], options, true, i));

					if (i < lines.Count - 1)
						sb.Append("\n");
				}

				if (options.Watermark && !sub)
				{
					sb.Append("\n\n~ Generated with Microsoft Phrase Gobbler 2018 Professional");
				}

				return sb.ToString();
			}

			List<string> words = StripNonAlphaNumericCharacters(text).Split(' ').ToList();
			
			int tinyLength = 3;

			string lastWord = "";
			bool lastJunk = false;

			int wordIndex = 0;
			while (words.Count > 0)
			{
				if (options.AddJunk && random.Next(0, 10) == 0)
				{
					sb.Append(GetSomeJunk(random) + ' ');
					lastJunk = true;
				}

				int rand = random.Next(0, words.Count);
				string word = words[rand];
				/*bool found = false;
				foreach (string w in words)
				{
					if (w.Length > tinyLength)
					{
						found = true;
						break;
					}
				}

				if (!found)
					break;*/
				if (options.PrioritizeLongWords && lastWord.Length > tinyLength && random.Next(0, 10) == 0)
				{
					List<string> unique = GetUniqueWords(words);
					if (GetNumLongWords(unique, tinyLength) > 10)
					{
						while (lastWord == word || word.Length <= tinyLength)
						{
							word = unique[random.Next(0, unique.Count)];
							rand = words.IndexOf(word);
						}
					}
				}

				List<string> uniqueWords = GetUniqueWords(words);
				if (uniqueWords.Count > 1)
				{
					while (word == lastWord)
					{
						word = uniqueWords[random.Next(0, uniqueWords.Count)];
						rand = words.IndexOf(word);
					}
				}
				lastWord = word;

				if (uniqueWords.Count <= 4)
				{
					/*foreach (string uniqueWord in uniqueWords)
					{
						while (words.Contains(uniqueWord))
						{
							words.RemoveAt(words.IndexOf(uniqueWord));
						}

						words.Add(uniqueWord);
					}*/

					words = uniqueWords;
				}

				if (!options.PrioritizeLongWords || words.Count <= 4 || uniqueWords.Count <= 1 || word.Length <= tinyLength ||
				    random.Next(0, 2) == 0)
				{
					if (rand > words.Count)
						rand = words.IndexOf(word);
					if (rand >= 0 && rand < words.Count)
						words.RemoveAt(rand);
				}

				if (words.Count == 0 && word.Length <= tinyLength)
				{
					if (options.AddJunk && lastJunk)
						sb.Append(GetSomeEndingJunk(random) + ' ');

					break;
				}

				sb.Append(word);

				if (words.Count > 0)
					sb.Append(' ');
			}


			if (options.Watermark && !sub)
			{
				sb.Append("\n\n~ Generated with Microsoft Phrase Gobbler 2018 Professional");
			}

			return sb.ToString();
		}
	}
}
