using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lliira.TitanQuest.SaveEditor {
	public class Player {
		public string Name { get; internal set; }
		public int Level { get; internal set; }
		public int Money { get; internal set; }
		public int Attributes { get; internal set; }
		public int Skills { get; internal set; }

		internal int NameOffset { get; set; }
		internal int LevelOffset { get; set; }
		internal int MoneyOffset { get; set; }
		internal int AttributesOffset { get; set; }
		internal int SkillsOffset { get; set; }
	}
}
