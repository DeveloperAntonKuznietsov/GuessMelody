namespace GuessMelody
{
	partial class fSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.cbAllDirectory = new System.Windows.Forms.CheckBox();
			this.btnSelectFolder = new System.Windows.Forms.Button();
			this.btnClaerList = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbGameDuration = new System.Windows.Forms.ComboBox();
			this.cbMusicDuration = new System.Windows.Forms.ComboBox();
			this.cbRandomStart = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(1, 1);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(414, 264);
			this.listBox1.TabIndex = 0;
			// 
			// cbAllDirectory
			// 
			this.cbAllDirectory.AutoSize = true;
			this.cbAllDirectory.BackColor = System.Drawing.Color.Transparent;
			this.cbAllDirectory.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbAllDirectory.Location = new System.Drawing.Point(276, 277);
			this.cbAllDirectory.Name = "cbAllDirectory";
			this.cbAllDirectory.Size = new System.Drawing.Size(79, 17);
			this.cbAllDirectory.TabIndex = 1;
			this.cbAllDirectory.Text = "AllDirectory";
			this.cbAllDirectory.UseVisualStyleBackColor = false;
			// 
			// btnSelectFolder
			// 
			this.btnSelectFolder.Location = new System.Drawing.Point(23, 271);
			this.btnSelectFolder.Name = "btnSelectFolder";
			this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
			this.btnSelectFolder.TabIndex = 2;
			this.btnSelectFolder.Text = "SelectFolder";
			this.btnSelectFolder.UseVisualStyleBackColor = true;
			this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
			// 
			// btnClaerList
			// 
			this.btnClaerList.Location = new System.Drawing.Point(115, 271);
			this.btnClaerList.Name = "btnClaerList";
			this.btnClaerList.Size = new System.Drawing.Size(75, 23);
			this.btnClaerList.TabIndex = 3;
			this.btnClaerList.Text = "Clear";
			this.btnClaerList.UseVisualStyleBackColor = true;
			this.btnClaerList.Click += new System.EventHandler(this.btnClaerList_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(330, 373);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(330, 335);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox3);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbRandomStart);
			this.groupBox1.Controls.Add(this.cbMusicDuration);
			this.groupBox1.Controls.Add(this.cbGameDuration);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 301);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(311, 100);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Game settings";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Duration of the game";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Time for reply";
			// 
			// cbGameDuration
			// 
			this.cbGameDuration.FormattingEnabled = true;
			this.cbGameDuration.Items.AddRange(new object[] {
            "45",
            "60",
            "75",
            "90",
            "120",
            "180"});
			this.cbGameDuration.Location = new System.Drawing.Point(142, 20);
			this.cbGameDuration.Name = "cbGameDuration";
			this.cbGameDuration.Size = new System.Drawing.Size(35, 21);
			this.cbGameDuration.TabIndex = 2;
			this.cbGameDuration.Text = "60";
			// 
			// cbMusicDuration
			// 
			this.cbMusicDuration.FormattingEnabled = true;
			this.cbMusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
			this.cbMusicDuration.Location = new System.Drawing.Point(142, 51);
			this.cbMusicDuration.Name = "cbMusicDuration";
			this.cbMusicDuration.Size = new System.Drawing.Size(35, 21);
			this.cbMusicDuration.TabIndex = 3;
			this.cbMusicDuration.Text = "20";
			// 
			// cbRandomStart
			// 
			this.cbRandomStart.AutoSize = true;
			this.cbRandomStart.Location = new System.Drawing.Point(13, 77);
			this.cbRandomStart.Name = "cbRandomStart";
			this.cbRandomStart.Size = new System.Drawing.Size(125, 17);
			this.cbRandomStart.TabIndex = 4;
			this.cbRandomStart.Text = "From a random place";
			this.cbRandomStart.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(183, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Player 1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(183, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Player 2";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(234, 19);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(71, 21);
			this.comboBox2.TabIndex = 8;
			this.comboBox2.Text = "A";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(234, 50);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(71, 21);
			this.comboBox3.TabIndex = 9;
			this.comboBox3.Text = "P";
			// 
			// fSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::GuessMelody.Properties.Resources._24752708_beglist11;
			this.ClientSize = new System.Drawing.Size(417, 413);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnClaerList);
			this.Controls.Add(this.btnSelectFolder);
			this.Controls.Add(this.cbAllDirectory);
			this.Controls.Add(this.listBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "fSettings";
			this.Load += new System.EventHandler(this.fSettings_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.CheckBox cbAllDirectory;
		private System.Windows.Forms.Button btnSelectFolder;
		private System.Windows.Forms.Button btnClaerList;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbMusicDuration;
		private System.Windows.Forms.ComboBox cbGameDuration;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbRandomStart;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
	}
}