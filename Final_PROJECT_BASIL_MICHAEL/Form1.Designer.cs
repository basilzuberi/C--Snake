namespace Final_PROJECT_BASIL_MICHAEL
{
    partial class Form1
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
			this.pbBoard = new System.Windows.Forms.PictureBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbFast = new System.Windows.Forms.RadioButton();
			this.rbSlow = new System.Windows.Forms.RadioButton();
			this.rbMedium = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbCurrentScore = new System.Windows.Forms.Label();
			this.lbHighScore = new System.Windows.Forms.Label();
			this.GameTimer = new System.Windows.Forms.Timer(this.components);
			this.btnRestart = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HighscoreTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbBoard)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbBoard
			// 
			this.pbBoard.BackColor = System.Drawing.Color.Aqua;
			this.pbBoard.Location = new System.Drawing.Point(-1, 26);
			this.pbBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pbBoard.Name = "pbBoard";
			this.pbBoard.Size = new System.Drawing.Size(1707, 615);
			this.pbBoard.TabIndex = 0;
			this.pbBoard.TabStop = false;
			this.pbBoard.Click += new System.EventHandler(this.pbBoard_Click);
			this.pbBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pbBoard_Paint);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(16, 649);
			this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(100, 28);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnPause
			// 
			this.btnPause.Enabled = false;
			this.btnPause.Location = new System.Drawing.Point(124, 649);
			this.btnPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(100, 28);
			this.btnPause.TabIndex = 2;
			this.btnPause.Text = "Pause";
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.Location = new System.Drawing.Point(232, 649);
			this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(100, 28);
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(1219, 654);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(487, 123);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Miscellaneous Options";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbFast);
			this.groupBox2.Controls.Add(this.rbSlow);
			this.groupBox2.Controls.Add(this.rbMedium);
			this.groupBox2.Location = new System.Drawing.Point(8, 27);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(113, 91);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Speed";
			// 
			// rbFast
			// 
			this.rbFast.AutoSize = true;
			this.rbFast.Location = new System.Drawing.Point(12, 70);
			this.rbFast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rbFast.Name = "rbFast";
			this.rbFast.Size = new System.Drawing.Size(56, 21);
			this.rbFast.TabIndex = 7;
			this.rbFast.TabStop = true;
			this.rbFast.Text = "Fast";
			this.rbFast.UseVisualStyleBackColor = true;
			this.rbFast.CheckedChanged += new System.EventHandler(this.rbFast_CheckedChanged_1);
			// 
			// rbSlow
			// 
			this.rbSlow.AutoSize = true;
			this.rbSlow.Location = new System.Drawing.Point(8, 16);
			this.rbSlow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rbSlow.Name = "rbSlow";
			this.rbSlow.Size = new System.Drawing.Size(58, 21);
			this.rbSlow.TabIndex = 5;
			this.rbSlow.Text = "Slow";
			this.rbSlow.UseVisualStyleBackColor = true;
			this.rbSlow.CheckedChanged += new System.EventHandler(this.rbSlow_CheckedChanged);
			// 
			// rbMedium
			// 
			this.rbMedium.AutoSize = true;
			this.rbMedium.Checked = true;
			this.rbMedium.Location = new System.Drawing.Point(8, 43);
			this.rbMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rbMedium.Name = "rbMedium";
			this.rbMedium.Size = new System.Drawing.Size(78, 21);
			this.rbMedium.TabIndex = 6;
			this.rbMedium.TabStop = true;
			this.rbMedium.Text = "Medium";
			this.rbMedium.UseVisualStyleBackColor = true;
			this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(423, 658);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(449, 69);
			this.label1.TabIndex = 5;
			this.label1.Text = "Current Score :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(509, 718);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(369, 69);
			this.label2.TabIndex = 6;
			this.label2.Text = "High Score :";
			// 
			// lbCurrentScore
			// 
			this.lbCurrentScore.AutoSize = true;
			this.lbCurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCurrentScore.Location = new System.Drawing.Point(917, 656);
			this.lbCurrentScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbCurrentScore.Name = "lbCurrentScore";
			this.lbCurrentScore.Size = new System.Drawing.Size(64, 69);
			this.lbCurrentScore.TabIndex = 7;
			this.lbCurrentScore.Text = "0";
			// 
			// lbHighScore
			// 
			this.lbHighScore.AutoSize = true;
			this.lbHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHighScore.Location = new System.Drawing.Point(917, 724);
			this.lbHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbHighScore.Name = "lbHighScore";
			this.lbHighScore.Size = new System.Drawing.Size(64, 69);
			this.lbHighScore.TabIndex = 8;
			this.lbHighScore.Text = "0";
			// 
			// GameTimer
			// 
			this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
			// 
			// btnRestart
			// 
			this.btnRestart.Enabled = false;
			this.btnRestart.Location = new System.Drawing.Point(16, 684);
			this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRestart.Name = "btnRestart";
			this.btnRestart.Size = new System.Drawing.Size(316, 55);
			this.btnRestart.TabIndex = 4;
			this.btnRestart.Text = "Restart Game";
			this.btnRestart.UseVisualStyleBackColor = true;
			this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1708, 28);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1708, 801);
			this.Controls.Add(this.btnRestart);
			this.Controls.Add(this.lbHighScore);
			this.Controls.Add(this.lbCurrentScore);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.pbBoard);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "snake";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbBoard)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBoard;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCurrentScore;
        private System.Windows.Forms.Label lbHighScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSlow;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbFast;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Timer HighscoreTimer;
    }
}

