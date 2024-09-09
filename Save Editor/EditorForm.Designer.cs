namespace Lliira.TitanQuest.SaveEditor {
	partial class EditorForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.txtSaveFile = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.dlgOpenSave = new System.Windows.Forms.OpenFileDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPlayerName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nudAttributes = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.nudSkills = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.nudMoney = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUndo = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtLevel = new System.Windows.Forms.TextBox();
			this.cbBackup = new System.Windows.Forms.CheckBox();
			this.lblStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudAttributes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSkills)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMoney)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Save File:";
			// 
			// txtSaveFile
			// 
			this.txtSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSaveFile.Location = new System.Drawing.Point(120, 16);
			this.txtSaveFile.Name = "txtSaveFile";
			this.txtSaveFile.ReadOnly = true;
			this.txtSaveFile.Size = new System.Drawing.Size(370, 26);
			this.txtSaveFile.TabIndex = 1;
			this.txtSaveFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(496, 12);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 34);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// dlgOpenSave
			// 
			this.dlgOpenSave.FileName = "openFileDialog1";
			this.dlgOpenSave.Filter = "Save file|Player.chr|All files|*.*";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Player Name:";
			// 
			// txtPlayerName
			// 
			this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlayerName.ForeColor = System.Drawing.Color.Green;
			this.txtPlayerName.Location = new System.Drawing.Point(120, 48);
			this.txtPlayerName.Name = "txtPlayerName";
			this.txtPlayerName.ReadOnly = true;
			this.txtPlayerName.Size = new System.Drawing.Size(120, 26);
			this.txtPlayerName.TabIndex = 4;
			this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Attributes:";
			// 
			// nudAttributes
			// 
			this.nudAttributes.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudAttributes.Location = new System.Drawing.Point(120, 80);
			this.nudAttributes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudAttributes.Name = "nudAttributes";
			this.nudAttributes.Size = new System.Drawing.Size(120, 26);
			this.nudAttributes.TabIndex = 6;
			this.nudAttributes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudAttributes.ValueChanged += new System.EventHandler(this.nudAttributes_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(317, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Skills:";
			// 
			// nudSkills
			// 
			this.nudSkills.Location = new System.Drawing.Point(372, 82);
			this.nudSkills.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudSkills.Name = "nudSkills";
			this.nudSkills.Size = new System.Drawing.Size(120, 26);
			this.nudSkills.TabIndex = 8;
			this.nudSkills.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudSkills.ValueChanged += new System.EventHandler(this.nudSkills_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(54, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Money:";
			// 
			// nudMoney
			// 
			this.nudMoney.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudMoney.Location = new System.Drawing.Point(120, 112);
			this.nudMoney.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.nudMoney.Name = "nudMoney";
			this.nudMoney.Size = new System.Drawing.Size(120, 26);
			this.nudMoney.TabIndex = 10;
			this.nudMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudMoney.ValueChanged += new System.EventHandler(this.nudMoney_ValueChanged);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(496, 194);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 34);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUndo
			// 
			this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUndo.Enabled = false;
			this.btnUndo.Location = new System.Drawing.Point(415, 194);
			this.btnUndo.Name = "btnUndo";
			this.btnUndo.Size = new System.Drawing.Size(75, 34);
			this.btnUndo.TabIndex = 12;
			this.btnUndo.Text = "Undo";
			this.btnUndo.UseVisualStyleBackColor = true;
			this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(269, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 20);
			this.label6.TabIndex = 13;
			this.label6.Text = "Player Level:";
			// 
			// txtLevel
			// 
			this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLevel.ForeColor = System.Drawing.Color.Green;
			this.txtLevel.Location = new System.Drawing.Point(372, 48);
			this.txtLevel.Name = "txtLevel";
			this.txtLevel.ReadOnly = true;
			this.txtLevel.Size = new System.Drawing.Size(120, 26);
			this.txtLevel.TabIndex = 14;
			this.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbBackup
			// 
			this.cbBackup.AutoSize = true;
			this.cbBackup.Checked = true;
			this.cbBackup.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbBackup.Location = new System.Drawing.Point(16, 155);
			this.cbBackup.Name = "cbBackup";
			this.cbBackup.Size = new System.Drawing.Size(158, 24);
			this.cbBackup.TabIndex = 15;
			this.cbBackup.Text = "Backup Save File";
			this.cbBackup.UseVisualStyleBackColor = true;
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblStatus.AutoSize = true;
			this.lblStatus.ForeColor = System.Drawing.Color.Blue;
			this.lblStatus.Location = new System.Drawing.Point(12, 201);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 20);
			this.lblStatus.TabIndex = 16;
			// 
			// EditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 240);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.cbBackup);
			this.Controls.Add(this.txtLevel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnUndo);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.nudMoney);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nudSkills);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nudAttributes);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPlayerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtSaveFile);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(605, 296);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(605, 296);
			this.Name = "EditorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Titan Quest Save Editor";
			((System.ComponentModel.ISupportInitialize)(this.nudAttributes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSkills)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMoney)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSaveFile;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.OpenFileDialog dlgOpenSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPlayerName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudAttributes;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudSkills;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nudMoney;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUndo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtLevel;
		private System.Windows.Forms.CheckBox cbBackup;
		private System.Windows.Forms.Label lblStatus;
	}
}

