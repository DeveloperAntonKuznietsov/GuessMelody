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
	public partial class fMain : Form
	{
		fSettings fSettings = new fSettings();
		fGame fGame = new fGame();

		public fMain()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			fSettings.ShowDialog();
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			fGame.ShowDialog();
		}

		private void fMain_Load(object sender, EventArgs e)
		{
			Quiz.ReadParam();
			Quiz.ReadMusic();
		}
	}
}
