using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lliira.TitanQuest.SaveEditor {
	public partial class EditorForm : Form {

		private Player player = null;

		public EditorForm() {
			InitializeComponent();
		}

		private void btnBrowse_Click(object sender, EventArgs e) {
			if (dlgOpenSave.ShowDialog(this) == DialogResult.OK) {
				OpenSave(dlgOpenSave.FileName);
			}
		}

		private void OpenSave(string saveFile) {
			txtSaveFile.Text = saveFile;
			SaveFileReader reader = new SaveFileReader();
			player = reader.Read(saveFile);
			ShowPlayer();
			lblStatus.Text = "Save file opened.";
		}

		private void btnSave_Click(object sender, EventArgs e) {
			player.Money = (int)nudMoney.Value;
			player.Attributes = (int)nudAttributes.Value;
			player.Skills = (int)nudSkills.Value;
			SaveFileWriter writer = new SaveFileWriter();
			if (writer.Write(player, txtSaveFile.Text, cbBackup.Checked)) {
				btnSave.Enabled = false;
				btnUndo.Enabled = false;
				lblStatus.Text = "Changes saved.";
			} else {
				lblStatus.Text = "Saving failed, please re-open the save file.";
			}
		}

		private void btnUndo_Click(object sender, EventArgs e) {
			ShowPlayer();
			lblStatus.Text = "Changes reverted.";
		}

		private void ShowPlayer() {
			txtPlayerName.Text = player.Name;
			txtLevel.Text = player.Level.ToString();
			nudMoney.Value = player.Money;
			nudAttributes.Value = player.Attributes;
			nudSkills.Value = player.Skills;
			btnSave.Enabled = false;
			btnUndo.Enabled = false;
		}

		private void nudAttributes_ValueChanged(object sender, EventArgs e) {
			ValueChanged();
		}

		private void nudMoney_ValueChanged(object sender, EventArgs e) {
			ValueChanged();
		}

		private void nudSkills_ValueChanged(object sender, EventArgs e) {
			ValueChanged();
		}

		private void ValueChanged() {
			btnSave.Enabled = true;
			btnUndo.Enabled = true;
			lblStatus.Text = "There are unsaved changes.";
		}
	}
}
