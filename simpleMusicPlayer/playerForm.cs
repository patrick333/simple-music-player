using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WMPLib;
using System.Diagnostics;
namespace simpleMusicPlayer
{
    public partial class playerForm : Form
    {
        string fileName=null;
        WindowsMediaPlayer player;

        public playerForm()
        {
            InitializeComponent();            

            player = new WindowsMediaPlayer();
            player.PlayStateChange +=
                new _WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            player.MediaError +=
                new _WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            player.settings.autoStart = false;

            openFileDialog.Filter = "Audio files|*.mp3;*.wma;*.aac|All files|*.*";
            openFileDialog.InitialDirectory = @"d:\music";
            openFileDialog.Multiselect = true;

            timer1.Tick += new EventHandler(timer1_Tick);
            //autoPlaycheckBox.Checked = true;
            //repeatCheckBox.Checked = true;

            playPausebutton.Enabled = false;
            stopButton.Enabled = false;
        }

        #region menu items handling
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.Assert(stopButton.Enabled == false, 
                "openToolStripMenuItem_Click():stopButton should be disabled.");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] names=openFileDialog.FileNames;
                foreach(string name in names){
                    playlistBox.Items.Add(name);
                }
                

                
                playPausebutton.Enabled = true;
                stopButton.Enabled = true;
                trackBar1.Enabled = true;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(player.playState==WMPPlayState.wmppsPlaying)
            goInitialStatuses();
        }

        #endregion

        #region buttons, trackBar1, checkboxes, 
        private void playPausebutton_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                if (stopButton.Enabled==false)
                {
                    stopButton.Enabled = true;
                }

                if (playPausebutton.Text == "Play")
                {
                    player.controls.play();
                    timer1.Enabled = true;

                    playPausebutton.Text = "Pause";
                }
                else
                {
                    player.controls.pause();
                    timer1.Enabled = false;

                    playPausebutton.Text = "Play";
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                player.controls.stop();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int trackBarValue = trackBar1.Value;
            //TimeSpan ts = new TimeSpan(0, 0, 0, 0, trackBarValue);
            double duration = player.controls.currentItem.duration;
            player.controls.currentPosition = duration * trackBarValue / trackBar1.Maximum;
        }

        private void autoPlaycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoPlaycheckBox.Checked)
            {
                player.settings.autoStart = true;
            }
            else
            {
                player.settings.autoStart = false;
            }
        }

        private void repeatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (repeatCheckBox.Checked)
            {
                player.settings.setMode("loop", true);
            }
            else
            {
                player.settings.setMode("loop", false);
            }
        }
        #endregion

        private void goStop()
        {
            timer1.Enabled = false;

            trackBar1.Enabled = false;
            stopButton.Enabled = false;
            playPausebutton.Text = "Play";
            trackBar1.Value = trackBar1.Minimum;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            double duration = player.controls.currentItem.duration;
            //currentPosition: "the current position in the media item in seconds from the beginning."
            int trackBarValue = Convert.ToInt32(player.controls.currentPosition * trackBar1.Maximum / duration);
            if (trackBarValue > trackBar1.Maximum) trackBarValue -= trackBar1.Maximum;
            trackBar1.Value = trackBarValue;
            //this.trackBar1.ValueChanged += new EventHandler(this.trackBar1_ValueChanged); 
            //注意 是怎么写的, trackBar1_ValueChanged needs to be defined as a function that do the job!

            //Console.WriteLine("timer1_Tick(): trackBar1.Value={0}", trackBar1.Value);
        }



        private void goInitialStatuses()
        {
            playPausebutton.Enabled = false;
            stopButton.Enabled = false;
            timer1.Enabled = false;
            trackBar1.Value = trackBar1.Minimum;
        }



        private void Player_PlayStateChange(int NewState)
        {
            switch (player.playState)
            {
                case WMPPlayState.wmppsStopped:
                    Console.WriteLine("Player_PlayStateChange(): stopped");
                    goStop();
                    break;
                case WMPPlayState.wmppsPaused:
                    Console.WriteLine("Player_PlayStateChange(): paused");
                    break;
                case WMPPlayState.wmppsReady://when it's triggered? URL is set, but autoplay is false.
                    Console.WriteLine("Player_PlayStateChange(): is ready");
                    break;
                case WMPPlayState.wmppsPlaying://when play starts.
                    Console.WriteLine("Player_PlayStateChange(): is playing");
                    if (!trackBar1.Enabled) trackBar1.Enabled = true;
                    if (!timer1.Enabled) timer1.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show(this,"Cannot play media file.","Error");
            this.Close();
        }



        #region playListBox
        private void playlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("playlistBox_SelectedIndexChanged(): selected index changed");
            if (playlistBox.SelectedItem != null)
            {
                fileName = Convert.ToString(playlistBox.SelectedItem);
                player.URL = fileName;

                playPausebutton.Text = "Play";
                stopButton.Enabled = false;
            }
        }

        private void playlistBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)//竟写成swich, wasted several minutes.
            {
                case Keys.OemMinus:
                case Keys.Delete:
                    if (playlistBox.SelectedItem != null)
                        playlistBox.Items.Remove(playlistBox.SelectedItem);
                break;
                default:
                break;
            }
        }

        private void playlistBox_MouseDoubleClick(object sender, MouseEventArgs e)//play the selected music
        {
            int index = this.playlistBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                player.URL = Convert.ToString(playlistBox.Items[index]);


            }
        }
        #endregion

        private void playerForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space://play/pause shuffle
                    if (player.playState == WMPPlayState.wmppsPlaying)
                    {
                        Console.WriteLine("playerForm_KeyDown(): playing->pause");
                        player.controls.pause();
                    }
                    else if (player.playState == WMPPlayState.wmppsPaused)
                    {
                        Console.WriteLine("playerForm_KeyDown(): paused->play");
                        player.controls.play();
                    }
                    else
                    {
                        Console.WriteLine("playerForm_KeyDown(): other keys down.");
                    }
                    break;
                default:
                    break;
            }
        }


        




    }
}
