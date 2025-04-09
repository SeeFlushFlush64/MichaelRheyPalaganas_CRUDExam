namespace MichaelRheyPalaganas_CRUDExam
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTopBar = new Panel();
            picBoxHome = new PictureBox();
            picBoxForwardButton = new PictureBox();
            picBoxBackButton = new PictureBox();
            picBoxSearch = new PictureBox();
            txtBoxSearchBar = new TextBox();
            panelSideBar = new Panel();
            picBoxAddAlbum = new PictureBox();
            panelBody = new Panel();
            panelBottomBar = new Panel();
            lblTrackDuration = new Label();
            lblTrackTimer = new Label();
            picBoxSeekBar = new PictureBox();
            lblPlayingArtist = new Label();
            lblPlayingTrackName = new Label();
            picBoxPlayingAlbumPic = new PictureBox();
            picBoxRepeatTrack = new PictureBox();
            picBoxNextTrack = new PictureBox();
            picBoxPreviousTrack = new PictureBox();
            picBoxShuffleTracks = new PictureBox();
            picBoxVolume = new PictureBox();
            picBoxNoVolume = new PictureBox();
            picBoxPlayTrack = new PictureBox();
            picBoxPauseTrack = new PictureBox();
            panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxForwardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBackButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSearch).BeginInit();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxAddAlbum).BeginInit();
            panelBottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxSeekBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayingAlbumPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRepeatTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNextTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPreviousTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxShuffleTracks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNoVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPauseTrack).BeginInit();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = SystemColors.WindowFrame;
            panelTopBar.Controls.Add(picBoxHome);
            panelTopBar.Controls.Add(picBoxForwardButton);
            panelTopBar.Controls.Add(picBoxBackButton);
            panelTopBar.Controls.Add(picBoxSearch);
            panelTopBar.Controls.Add(txtBoxSearchBar);
            panelTopBar.Location = new Point(-5, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(902, 70);
            panelTopBar.TabIndex = 0;
            // 
            // picBoxHome
            // 
            picBoxHome.Image = Properties.Resources.home_icon;
            picBoxHome.Location = new Point(124, 12);
            picBoxHome.Name = "picBoxHome";
            picBoxHome.Size = new Size(36, 41);
            picBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxHome.TabIndex = 3;
            picBoxHome.TabStop = false;
            picBoxHome.MouseLeave += picBoxHome_MouseLeave;
            picBoxHome.MouseHover += picBoxHome_MouseHover;
            // 
            // picBoxForwardButton
            // 
            picBoxForwardButton.Image = Properties.Resources.right_icon;
            picBoxForwardButton.Location = new Point(70, 12);
            picBoxForwardButton.Name = "picBoxForwardButton";
            picBoxForwardButton.Size = new Size(36, 41);
            picBoxForwardButton.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxForwardButton.TabIndex = 3;
            picBoxForwardButton.TabStop = false;
            picBoxForwardButton.Click += picBoxForwardButton_Click;
            picBoxForwardButton.MouseLeave += picBoxForwardButton_MouseLeave;
            picBoxForwardButton.MouseHover += picBoxForwardButton_MouseHover;
            // 
            // picBoxBackButton
            // 
            picBoxBackButton.Image = Properties.Resources.left_icon;
            picBoxBackButton.Location = new Point(17, 12);
            picBoxBackButton.Name = "picBoxBackButton";
            picBoxBackButton.Size = new Size(36, 41);
            picBoxBackButton.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxBackButton.TabIndex = 1;
            picBoxBackButton.TabStop = false;
            picBoxBackButton.Click += picBoxBackButton_Click;
            picBoxBackButton.MouseLeave += picBoxBackButton_MouseLeave;
            picBoxBackButton.MouseHover += picBoxBackButton_MouseHover;
            // 
            // picBoxSearch
            // 
            picBoxSearch.Image = Properties.Resources.search_icon;
            picBoxSearch.Location = new Point(560, 18);
            picBoxSearch.Name = "picBoxSearch";
            picBoxSearch.Size = new Size(38, 35);
            picBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxSearch.TabIndex = 4;
            picBoxSearch.TabStop = false;
            picBoxSearch.MouseLeave += picBoxSearch_MouseLeave;
            picBoxSearch.MouseHover += picBoxSearch_MouseHover;
            // 
            // txtBoxSearchBar
            // 
            txtBoxSearchBar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSearchBar.Location = new Point(232, 18);
            txtBoxSearchBar.Name = "txtBoxSearchBar";
            txtBoxSearchBar.PlaceholderText = "  What do you want to play?";
            txtBoxSearchBar.Size = new Size(322, 35);
            txtBoxSearchBar.TabIndex = 0;
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = SystemColors.ScrollBar;
            panelSideBar.Controls.Add(picBoxAddAlbum);
            panelSideBar.Location = new Point(-2, 59);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(71, 482);
            panelSideBar.TabIndex = 1;
            // 
            // picBoxAddAlbum
            // 
            picBoxAddAlbum.Image = Properties.Resources.add_icon;
            picBoxAddAlbum.Location = new Point(3, 16);
            picBoxAddAlbum.Name = "picBoxAddAlbum";
            picBoxAddAlbum.Size = new Size(61, 59);
            picBoxAddAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxAddAlbum.TabIndex = 4;
            picBoxAddAlbum.TabStop = false;
            picBoxAddAlbum.Click += picBoxAddAlbum_Click;
            picBoxAddAlbum.MouseLeave += picBoxAddAlbum_MouseLeave;
            picBoxAddAlbum.MouseHover += picBoxAddAlbum_MouseHover;
            // 
            // panelBody
            // 
            panelBody.Location = new Point(85, 85);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(799, 439);
            panelBody.TabIndex = 3;
            // 
            // panelBottomBar
            // 
            panelBottomBar.BackColor = SystemColors.WindowFrame;
            panelBottomBar.Controls.Add(lblTrackDuration);
            panelBottomBar.Controls.Add(lblTrackTimer);
            panelBottomBar.Controls.Add(picBoxSeekBar);
            panelBottomBar.Controls.Add(lblPlayingArtist);
            panelBottomBar.Controls.Add(lblPlayingTrackName);
            panelBottomBar.Controls.Add(picBoxPlayingAlbumPic);
            panelBottomBar.Controls.Add(picBoxRepeatTrack);
            panelBottomBar.Controls.Add(picBoxNextTrack);
            panelBottomBar.Controls.Add(picBoxPreviousTrack);
            panelBottomBar.Controls.Add(picBoxShuffleTracks);
            panelBottomBar.Controls.Add(picBoxVolume);
            panelBottomBar.Controls.Add(picBoxNoVolume);
            panelBottomBar.Controls.Add(picBoxPlayTrack);
            panelBottomBar.Controls.Add(picBoxPauseTrack);
            panelBottomBar.Location = new Point(-5, 541);
            panelBottomBar.Name = "panelBottomBar";
            panelBottomBar.Size = new Size(902, 125);
            panelBottomBar.TabIndex = 2;
            // 
            // lblTrackDuration
            // 
            lblTrackDuration.AutoSize = true;
            lblTrackDuration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrackDuration.Location = new Point(645, 77);
            lblTrackDuration.Name = "lblTrackDuration";
            lblTrackDuration.Size = new Size(40, 21);
            lblTrackDuration.TabIndex = 12;
            lblTrackDuration.Text = "0:00";
            // 
            // lblTrackTimer
            // 
            lblTrackTimer.AutoSize = true;
            lblTrackTimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrackTimer.Location = new Point(252, 77);
            lblTrackTimer.Name = "lblTrackTimer";
            lblTrackTimer.Size = new Size(40, 21);
            lblTrackTimer.TabIndex = 11;
            lblTrackTimer.Text = "0:00";
            // 
            // picBoxSeekBar
            // 
            picBoxSeekBar.Location = new Point(298, 70);
            picBoxSeekBar.Name = "picBoxSeekBar";
            picBoxSeekBar.Size = new Size(331, 33);
            picBoxSeekBar.TabIndex = 10;
            picBoxSeekBar.TabStop = false;
            picBoxSeekBar.Paint += picBoxSeekBar_Paint;
            picBoxSeekBar.MouseDown += picBoxSeekBar_MouseDown;
            picBoxSeekBar.MouseLeave += picBoxSeekBar_MouseLeave;
            picBoxSeekBar.MouseHover += picBoxSeekBar_MouseHover;
            picBoxSeekBar.MouseMove += picBoxSeekBar_MouseMove;
            picBoxSeekBar.MouseUp += picBoxSeekBar_MouseUp;
            // 
            // lblPlayingArtist
            // 
            lblPlayingArtist.AutoSize = true;
            lblPlayingArtist.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayingArtist.Location = new Point(113, 62);
            lblPlayingArtist.Name = "lblPlayingArtist";
            lblPlayingArtist.Size = new Size(38, 17);
            lblPlayingArtist.TabIndex = 7;
            lblPlayingArtist.Text = "Artist";
            lblPlayingArtist.MouseLeave += lblPlayingArtist_MouseLeave;
            lblPlayingArtist.MouseHover += lblPlayingArtist_MouseHover;
            // 
            // lblPlayingTrackName
            // 
            lblPlayingTrackName.AutoSize = true;
            lblPlayingTrackName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayingTrackName.Location = new Point(113, 23);
            lblPlayingTrackName.Name = "lblPlayingTrackName";
            lblPlayingTrackName.Size = new Size(100, 21);
            lblPlayingTrackName.TabIndex = 6;
            lblPlayingTrackName.Text = "Track Name";
            lblPlayingTrackName.MouseLeave += lblPlayingTrackName_MouseLeave;
            lblPlayingTrackName.MouseHover += lblPlayingTrackName_MouseHover;
            // 
            // picBoxPlayingAlbumPic
            // 
            picBoxPlayingAlbumPic.Image = Properties.Resources.play_icon;
            picBoxPlayingAlbumPic.Location = new Point(17, 16);
            picBoxPlayingAlbumPic.Name = "picBoxPlayingAlbumPic";
            picBoxPlayingAlbumPic.Size = new Size(80, 84);
            picBoxPlayingAlbumPic.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPlayingAlbumPic.TabIndex = 5;
            picBoxPlayingAlbumPic.TabStop = false;
            // 
            // picBoxRepeatTrack
            // 
            picBoxRepeatTrack.Image = Properties.Resources.repeat_icon;
            picBoxRepeatTrack.Location = new Point(551, 23);
            picBoxRepeatTrack.Name = "picBoxRepeatTrack";
            picBoxRepeatTrack.Size = new Size(30, 30);
            picBoxRepeatTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxRepeatTrack.TabIndex = 3;
            picBoxRepeatTrack.TabStop = false;
            picBoxRepeatTrack.MouseLeave += picBoxRepeatTrack_MouseLeave;
            picBoxRepeatTrack.MouseHover += picBoxRepeatTrack_MouseHover;
            // 
            // picBoxNextTrack
            // 
            picBoxNextTrack.Image = Properties.Resources.next_icon;
            picBoxNextTrack.Location = new Point(504, 23);
            picBoxNextTrack.Name = "picBoxNextTrack";
            picBoxNextTrack.Size = new Size(30, 30);
            picBoxNextTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxNextTrack.TabIndex = 3;
            picBoxNextTrack.TabStop = false;
            picBoxNextTrack.Click += picBoxNextTrack_Click;
            picBoxNextTrack.MouseLeave += picBoxNextTrack_MouseLeave;
            picBoxNextTrack.MouseHover += picBoxNextTrack_MouseHover;
            // 
            // picBoxPreviousTrack
            // 
            picBoxPreviousTrack.Image = Properties.Resources.previous_icon;
            picBoxPreviousTrack.Location = new Point(397, 23);
            picBoxPreviousTrack.Name = "picBoxPreviousTrack";
            picBoxPreviousTrack.Size = new Size(30, 30);
            picBoxPreviousTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPreviousTrack.TabIndex = 3;
            picBoxPreviousTrack.TabStop = false;
            picBoxPreviousTrack.Click += picBoxPreviousTrack_Click;
            picBoxPreviousTrack.MouseLeave += picBoxPreviousTrack_MouseLeave;
            picBoxPreviousTrack.MouseHover += picBoxPreviousTrack_MouseHover;
            // 
            // picBoxShuffleTracks
            // 
            picBoxShuffleTracks.Image = Properties.Resources.shuffle_icon;
            picBoxShuffleTracks.Location = new Point(350, 23);
            picBoxShuffleTracks.Name = "picBoxShuffleTracks";
            picBoxShuffleTracks.Size = new Size(30, 30);
            picBoxShuffleTracks.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxShuffleTracks.TabIndex = 2;
            picBoxShuffleTracks.TabStop = false;
            picBoxShuffleTracks.MouseLeave += picBoxShuffleTracks_MouseLeave;
            picBoxShuffleTracks.MouseHover += picBoxShuffleTracks_MouseHover;
            // 
            // picBoxVolume
            // 
            picBoxVolume.Image = Properties.Resources.volume_icon;
            picBoxVolume.Location = new Point(711, 23);
            picBoxVolume.Name = "picBoxVolume";
            picBoxVolume.Size = new Size(30, 30);
            picBoxVolume.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxVolume.TabIndex = 8;
            picBoxVolume.TabStop = false;
            picBoxVolume.MouseLeave += picBoxVolume_MouseLeave;
            picBoxVolume.MouseHover += picBoxVolume_MouseHover;
            // 
            // picBoxNoVolume
            // 
            picBoxNoVolume.Image = Properties.Resources.no_volume_icon;
            picBoxNoVolume.Location = new Point(711, 23);
            picBoxNoVolume.Name = "picBoxNoVolume";
            picBoxNoVolume.Size = new Size(30, 30);
            picBoxNoVolume.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxNoVolume.TabIndex = 9;
            picBoxNoVolume.TabStop = false;
            picBoxNoVolume.MouseLeave += picBoxNoVolume_MouseLeave;
            picBoxNoVolume.MouseHover += picBoxNoVolume_MouseHover;
            // 
            // picBoxPlayTrack
            // 
            picBoxPlayTrack.Image = Properties.Resources.play_icon;
            picBoxPlayTrack.Location = new Point(442, 16);
            picBoxPlayTrack.Name = "picBoxPlayTrack";
            picBoxPlayTrack.Size = new Size(46, 48);
            picBoxPlayTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPlayTrack.TabIndex = 3;
            picBoxPlayTrack.TabStop = false;
            picBoxPlayTrack.Click += picBoxPlayTrack_Click;
            picBoxPlayTrack.MouseLeave += picBoxPlayTrack_MouseLeave;
            picBoxPlayTrack.MouseHover += picBoxPlayTrack_MouseHover;
            // 
            // picBoxPauseTrack
            // 
            picBoxPauseTrack.Image = Properties.Resources.pause_icon;
            picBoxPauseTrack.Location = new Point(442, 16);
            picBoxPauseTrack.Name = "picBoxPauseTrack";
            picBoxPauseTrack.Size = new Size(46, 48);
            picBoxPauseTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPauseTrack.TabIndex = 4;
            picBoxPauseTrack.TabStop = false;
            picBoxPauseTrack.Click += picBoxPauseTrack_Click;
            picBoxPauseTrack.MouseLeave += picBoxPauseTrack_MouseLeave;
            picBoxPauseTrack.MouseHover += picBoxPauseTrack_MouseHover;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 664);
            Controls.Add(panelBody);
            Controls.Add(panelBottomBar);
            Controls.Add(panelTopBar);
            Controls.Add(panelSideBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Music Player";
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxForwardButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBackButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSearch).EndInit();
            panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxAddAlbum).EndInit();
            panelBottomBar.ResumeLayout(false);
            panelBottomBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxSeekBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayingAlbumPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRepeatTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNextTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPreviousTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxShuffleTracks).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNoVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPauseTrack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Panel panelSideBar;
        private Panel panelBottomBar;
        public Panel panelBody;
        private TextBox txtBoxSearchBar;
        private PictureBox picBoxHome;
        private PictureBox picBoxSearch;
        private PictureBox picBoxForwardButton;
        private PictureBox picBoxBackButton;
        private PictureBox picBoxAddAlbum;
        private PictureBox picBoxShuffleTracks;
        private PictureBox picBoxRepeatTrack;
        private PictureBox picBoxNextTrack;
        public PictureBox picBoxPlayTrack;
        private PictureBox picBoxPreviousTrack;
        public PictureBox picBoxPauseTrack;
        public PictureBox picBoxPlayingAlbumPic;
        public Label lblPlayingArtist;
        public Label lblPlayingTrackName;
        private PictureBox picBoxVolume;
        private PictureBox picBoxNoVolume;
        private PictureBox picBoxSeekBar;
        private Label lblTrackDuration;
        private Label lblTrackTimer;
    }
}
