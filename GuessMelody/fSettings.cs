using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelody
{
	public partial class fSettings : Form
	{
		public fSettings()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Quiz.allDirectory = cbAllDirectory.Checked;
			Quiz.gameDuration = Convert.ToInt32(cbGameDuration.Text);
			Quiz.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
			Quiz.randomStart = cbRandomStart.Checked;
			Quiz.WriteParam();
			this.Hide();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			defaultSetup();
			this.Hide();
		}

		private void defaultSetup()
		{
			cbAllDirectory.Checked = Quiz.allDirectory;
			cbGameDuration.Text = Quiz.gameDuration.ToString();
			cbMusicDuration.Text = Quiz.musicDuration.ToString();
			cbRandomStart.Checked = Quiz.randomStart;

		}

		private void btnSelectFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3",cbAllDirectory.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
				Quiz.lastFolder = fbd.SelectedPath;
				
				Quiz.list.Clear();
				Quiz.list.AddRange(music_list);
			}
		}

		private void btnClaerList_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}

		private void fSettings_Load(object sender, EventArgs e)
		{
			defaultSetup();
			listBox1.Items.Clear();
			listBox1.Items.AddRange(Quiz.list.ToArray());
		}
	}
}
