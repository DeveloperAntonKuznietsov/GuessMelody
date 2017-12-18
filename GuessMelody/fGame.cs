using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
	public partial class fGame : Form
	{
		Random random = new Random();
		int musicDuration = Quiz.musicDuration;
		public fGame()
		{
			InitializeComponent();
		}
		void MakeMusic()
		{
			if (Quiz.list.Count == 0) EndGame();
			else
			{
				musicDuration = Quiz.musicDuration;
				int n = random.Next(0, Quiz.list.Count);
				WMP.URL = Quiz.list[n];
				Quiz.list.RemoveAt(n);
				lblMelodyCount.Text = Quiz.list.Count.ToString();
			}
		

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			MakeMusic();
			timer1.Start();
		}

		private void fGame_FormClosed(object sender, FormClosedEventArgs e)
		{
			timer1.Stop();
			WMP.Ctlcontrols.stop();
		}

		private void fGame_Load(object sender, EventArgs e)
		{
			lblMelodyCount.Text = Quiz.list.Count.ToString();
			progressBar1.Value = 0;
			progressBar1.Minimum = 0;
			progressBar1.Maximum = Quiz.gameDuration;
			lblMusicDuration.Text = musicDuration.ToString();
		}
		void EndGame()
		{
			MessageBox.Show("Game over", "Game over");
			timer1.Stop();
			WMP.Ctlcontrols.stop();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			progressBar1.Value++;
			musicDuration--;
			lblMusicDuration.Text = musicDuration.ToString();
			if (progressBar1.Value == progressBar1.Maximum)
			{
				EndGame();
				return;
			}
			if (musicDuration == 0) MakeMusic();
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			GamePause();
		}

		private void btnContinue_Click(object sender, EventArgs e)
		{
			GamePlay();
		}

		void GamePause()
		{
			timer1.Stop();
			WMP.Ctlcontrols.pause();
		}

		void GamePlay()
		{
			timer1.Start();
			WMP.Ctlcontrols.play();
		}
		private void fGame_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.A)
			{
				GamePause();
				fMessage fm = new fMessage();
				fm.label1.Text = "Player 1";
				if (fm.ShowDialog()== DialogResult.Yes)
				{
					lblCounter1.Text = Convert.ToString(Convert.ToInt32(lblCounter1.Text) + 1);
					MakeMusic();
				}
				GamePlay();
			}
			if (e.KeyData == Keys.P)
			{
				fMessage fm = new fMessage();
				fm.label1.Text = "Player 2";
				if (fm.ShowDialog() == DialogResult.Yes)
				{
					lblCounter2.Text = Convert.ToString(Convert.ToInt32(lblCounter2.Text) + 1);
					MakeMusic();
				}
				GamePlay();
			}
		}

		private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
		{
			if (Quiz.randomStart)
				if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
					WMP.Ctlcontrols.currentPosition = random.Next(0, (int)WMP.currentMedia.duration/2);
		}
	}
}
