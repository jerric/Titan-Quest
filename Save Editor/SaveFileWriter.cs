using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lliira.TitanQuest.SaveEditor {
	public class SaveFileWriter {

		private const string BACKUP_EXT = ".backup";

		public void Write(Player player, string fileName, bool backup) {
			if (backup) Backup(fileName);
			using (Stream stream = File.Open(fileName, FileMode.Open)) {
				WriteInt(stream, player.MoneyOffset, player.Money);
				WriteInt(stream, player.AttributesOffset, player.Attributes);
				WriteInt(stream, player.SkillsOffset, player.Skills);
			}
		}

		private void Backup(string fileName) {
			string backupFile = fileName + BACKUP_EXT;
			File.Copy(fileName, backupFile, true);
		}

		private void WriteInt(Stream stream, int offset, int value) {
			stream.Position = offset;
			byte[] data = BitConverter.GetBytes(value);
			stream.Write(data, 0, data.Length);
		}
	}
}
