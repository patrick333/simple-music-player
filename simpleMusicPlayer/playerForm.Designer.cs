namespace simpleMusicPlayer
{
    partial class playerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.autoPlaycheckBox = new System.Windows.Forms.CheckBox();
            this.repeatCheckBox = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.stopButton = new System.Windows.Forms.Button();
            this.playPausebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.upperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quitToolStripMenuItem});
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mediaToolStripMenuItem.Text = "Media";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lowerPanel
            // 
            this.lowerPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lowerPanel.Controls.Add(this.shuffleButton);
            this.lowerPanel.Controls.Add(this.autoPlaycheckBox);
            this.lowerPanel.Controls.Add(this.repeatCheckBox);
            this.lowerPanel.Controls.Add(this.trackBar1);
            this.lowerPanel.Controls.Add(this.stopButton);
            this.lowerPanel.Controls.Add(this.playPausebutton);
            this.lowerPanel.Location = new System.Drawing.Point(0, 206);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(584, 154);
            this.lowerPanel.TabIndex = 1;
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(282, 84);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(67, 23);
            this.shuffleButton.TabIndex = 3;
            this.shuffleButton.Text = "shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            // 
            // autoPlaycheckBox
            // 
            this.autoPlaycheckBox.AutoSize = true;
            this.autoPlaycheckBox.Location = new System.Drawing.Point(121, 88);
            this.autoPlaycheckBox.Name = "autoPlaycheckBox";
            this.autoPlaycheckBox.Size = new System.Drawing.Size(69, 17);
            this.autoPlaycheckBox.TabIndex = 2;
            this.autoPlaycheckBox.Text = "auto play";
            this.autoPlaycheckBox.UseVisualStyleBackColor = true;
            this.autoPlaycheckBox.CheckedChanged += new System.EventHandler(this.autoPlaycheckBox_CheckedChanged);
            // 
            // repeatCheckBox
            // 
            this.repeatCheckBox.AutoSize = true;
            this.repeatCheckBox.Location = new System.Drawing.Point(196, 88);
            this.repeatCheckBox.Name = "repeatCheckBox";
            this.repeatCheckBox.Size = new System.Drawing.Size(80, 17);
            this.repeatCheckBox.TabIndex = 2;
            this.repeatCheckBox.Text = "auto repeat";
            this.repeatCheckBox.UseVisualStyleBackColor = true;
            this.repeatCheckBox.CheckedChanged += new System.EventHandler(this.repeatCheckBox_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(109, 27);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(381, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopButton.Location = new System.Drawing.Point(512, 32);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(60, 40);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playPausebutton
            // 
            this.playPausebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playPausebutton.Location = new System.Drawing.Point(31, 32);
            this.playPausebutton.Name = "playPausebutton";
            this.playPausebutton.Size = new System.Drawing.Size(60, 40);
            this.playPausebutton.TabIndex = 0;
            this.playPausebutton.Text = "Play";
            this.playPausebutton.UseVisualStyleBackColor = true;
            this.playPausebutton.Click += new System.EventHandler(this.playPausebutton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // playlistBox
            // 
            this.playlistBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.Location = new System.Drawing.Point(0, 0);
            this.playlistBox.MultiColumn = true;
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(266, 176);
            this.playlistBox.TabIndex = 2;
            this.playlistBox.SelectedIndexChanged += new System.EventHandler(this.playlistBox_SelectedIndexChanged);
            this.playlistBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playlistBox_KeyDown);
            this.playlistBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playlistBox_MouseDoubleClick);
            // 
            // upperPanel
            // 
            this.upperPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.upperPanel.Controls.Add(this.playlistBox);
            this.upperPanel.Location = new System.Drawing.Point(0, 24);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(584, 176);
            this.upperPanel.TabIndex = 3;
            // 
            // playerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 360);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "playerForm";
            this.Text = "Music Player";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playerForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.lowerPanel.ResumeLayout(false);
            this.lowerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.upperPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Button playPausebutton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.CheckBox autoPlaycheckBox;
        private System.Windows.Forms.CheckBox repeatCheckBox;
        private System.Windows.Forms.ListBox playlistBox;
        private System.Windows.Forms.Panel upperPanel;
    }
}

