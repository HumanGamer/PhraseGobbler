using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGobbler;

namespace PhraseGobbler
{
	public static class Options
	{
		private const string Magic = "PGOF";
		private const int OptionsVersion = 2;

		public static void LoadOptions(this Gobbler.GobbleOptions options)
		{
			string path = GetOptionsPath();

			if (!File.Exists(path))
			{
				SaveOptions(options);
				return;
			}

			using (Stream s = File.OpenRead(path))
			using (BinaryReader br = new BinaryReader(s))
			{
				if (Encoding.ASCII.GetString(br.ReadBytes(Magic.Length)) != Magic)
				{
					Debug.Write("Invalid options file");
					return;
				}

				int version = br.ReadInt32();
				if (version > OptionsVersion)
				{
					Debug.Write("Options file is for a newer version of the program");
					return;
				}

				options.ExclusiveParagraphs = br.ReadBoolean();
				options.PrioritizeLongWords = br.ReadBoolean();
				options.AddJunk = br.ReadBoolean();
				options.Seed = br.ReadString();

				if (version >= 2)
					options.Watermark = br.ReadBoolean();
			}
		}

		public static void SaveOptions(this Gobbler.GobbleOptions options)
		{
			string path = GetOptionsPath();
			string dirPath = Path.GetDirectoryName(path);

			if (dirPath != null && !File.Exists(dirPath))
				Directory.CreateDirectory(dirPath);

			using (Stream s = File.Open(path, FileMode.Create))
			using (BinaryWriter bw = new BinaryWriter(s))
			{
				bw.Write(Encoding.ASCII.GetBytes(Magic));
				bw.Write(OptionsVersion);

				bw.Write(options.ExclusiveParagraphs);
				bw.Write(options.PrioritizeLongWords);
				bw.Write(options.AddJunk);
				bw.Write(options.Seed);

				if (OptionsVersion >= 2)
					bw.Write(options.Watermark);
			}
		}

		public static string GetOptionsPath()
		{
			string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			return Path.Combine(appdata, "PhraseGobbler", "options.cfg");
		}
	}
}
