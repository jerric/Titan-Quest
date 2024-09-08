using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lliira.TitanQuest.SaveEditor {
	public class SaveFileReader {
		private const string PLAYER_NAME_TAG = "myPlayerName";
		private const string PLAYER_LEVEL_TAG = "playerLevel";
		private const string MONEY_TAG = "money";
		private const string ATTRIBUTES_TAG = "modifierPoints";
		private const string SKILLS_TAG = "skillPoints";

		public Player Read(String filename) {
			if (!File.Exists(filename))
				throw new FileNotFoundException(filename + " doesn't exist!");
			byte[] bytes = File.ReadAllBytes(filename);

			Player player = new Player();
			player.NameOffset = FindOffset(bytes, PLAYER_NAME_TAG);
			player.Name = ReadString(bytes, player.NameOffset);
			player.LevelOffset = FindOffset(bytes, PLAYER_LEVEL_TAG);
			player.Level = ReadInt(bytes, player.LevelOffset);
			player.MoneyOffset = FindOffset(bytes, MONEY_TAG);
			player.Money = ReadInt(bytes, player.MoneyOffset);
			player.AttributesOffset = FindOffset(bytes, ATTRIBUTES_TAG);
			player.Attributes = ReadInt(bytes, player.AttributesOffset);
			player.SkillsOffset = FindOffset(bytes, SKILLS_TAG);
			player.Skills = ReadInt(bytes, player.SkillsOffset);

			return player;
		}

		private int ReadInt(byte[] bytes, int offset) {
			return BitConverter.ToInt32(bytes, offset);
		}

		private string ReadString(byte[] bytes, int offset) {
			// The string is UTF-16 encoded, and first 4 bytes are used to
			// record string length (# of chars).
			int length = BitConverter.ToInt32(bytes, offset);

			UnicodeEncoding unicode = new UnicodeEncoding();
			return unicode.GetString(bytes, offset + 4, length * 2);
		}

		private int FindOffset(byte[] bytes, String tag) {
			for (int dataIdx = 0, tagIdx = 0; dataIdx < bytes.Length; dataIdx++) {
				if (bytes[dataIdx] == tag[tagIdx]) {
					if (tagIdx == tag.Length - 1) return dataIdx + 1;
					tagIdx++;
				}
				else {
					tagIdx = 0;
				}
			}
			return -1;
		}
	}
}
