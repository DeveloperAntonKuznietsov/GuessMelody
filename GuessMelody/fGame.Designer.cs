namespace GuessMelody
{
	partial class fGame
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
			this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
			this.btnNext = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblCounter1 = new System.Windows.Forms.Label();
			this.lblCounter2 = new System.Windows.Forms.Label();
			this.btnPause = new System.Windows.Forms.Button();
			this.btnContinue = new System.Windows.Forms.Button();
			this.lblMelodyCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblMusicDuration = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
			this.SuspendLayout();
			// 
			// WMP
			// 
			resources.ApplyResources(this.WMP, "WMP");
			this.WMP.Name = "WMP";
			this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
			this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
			// 
			// btnNext
			// 
			resources.ApplyResources(this.btnNext, "btnNext");
			this.btnNext.Name = "btnNext";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Name = "label2";
			// 
			// lblCounter1
			// 
			resources.ApplyResources(this.lblCounter1, "lblCounter1");
			this.lblCounter1.BackColor = System.Drawing.Color.Transparent;
			this.lblCounter1.Name = "lblCounter1";
			// 
			// lblCounter2
			// 
			resources.ApplyResources(this.lblCounter2, "lblCounter2");
			this.lblCounter2.BackColor = System.Drawing.Color.Transparent;
			this.lblCounter2.Name = "lblCounter2";
			// 
			// btnPause
			// 
			resources.ApplyResources(this.btnPause, "btnPause");
			this.btnPause.Name = "btnPause";
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// btnContinue
			// 
			resources.ApplyResources(this.btnContinue, "btnContinue");
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.UseVisualStyleBackColor = true;
			this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
			// 
			// lblMelodyCount
			// 
			resources.ApplyResources(this.lblMelodyCount, "lblMelodyCount");
			this.lblMelodyCount.BackColor = System.Drawing.Color.Transparent;
			this.lblMelodyCount.Name = "lblMelodyCount";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Name = "label3";
			// 
			// progressBar1
			// 
			resources.ApplyResources(this.progressBar1, "progressBar1");
			this.progressBar1.Name = "progressBar1";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblMusicDuration
			// 
			resources.ApplyResources(this.lblMusicDuration, "lblMusicDuration");
			this.lblMusicDuration.BackColor = System.Drawing.Color.Transparent;
			this.lblMusicDuration.Name = "lblMusicDuration";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Name = "label4";
			// 
			// fGame
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::GuessMelody.Properties.Resources._64d735876ce855d858a742001e0585ea__holography_doodles;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblMusicDuration);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblMelodyCount);
			this.Controls.Add(this.btnContinue);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.lblCounter2);
			this.Controls.Add(this.lblCounter1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.WMP);
			this.KeyPreview = true;
			this.Name = "fGame";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
			this.Load += new System.EventHandler(this.fGame_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer WMP;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblCounter1;
		private System.Windows.Forms.Label lblCounter2;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Button btnContinue;
		private System.Windows.Forms.Label lblMelodyCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblMusicDuration;
		private System.Windows.Forms.Label label4;
	}
}