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
            lblPlayingArtist = new Label();
            lblPlayingTrackName = new Label();
            picBoxPlayingAlbumPic = new PictureBox();
            picBoxRepeatTrack = new PictureBox();
            picBoxNextTrack = new PictureBox();
            picBoxPreviousTrack = new PictureBox();
            picBoxShuffleTracks = new PictureBox();
            picBoxPlayTrack = new PictureBox();
            picBoxVolume = new PictureBox();
            picBoxNoVolume = new PictureBox();
            picBoxPauseTrack = new PictureBox();
            panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxForwardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBackButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSearch).BeginInit();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxAddAlbum).BeginInit();
            panelBottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayingAlbumPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRepeatTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNextTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPreviousTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxShuffleTracks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNoVolume).BeginInit();
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
            picBoxHome.Location = new Point(136, 12);
            picBoxHome.Name = "picBoxHome";
            picBoxHome.Size = new Size(47, 50);
            picBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxHome.TabIndex = 3;
            picBoxHome.TabStop = false;
            // 
            // picBoxForwardButton
            // 
            picBoxForwardButton.Image = Properties.Resources.right_icon;
            picBoxForwardButton.Location = new Point(70, 12);
            picBoxForwardButton.Name = "picBoxForwardButton";
            picBoxForwardButton.Size = new Size(47, 50);
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
            picBoxBackButton.Location = new Point(10, 12);
            picBoxBackButton.Name = "picBoxBackButton";
            picBoxBackButton.Size = new Size(47, 50);
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
            picBoxSearch.Location = new Point(558, 28);
            picBoxSearch.Name = "picBoxSearch";
            picBoxSearch.Size = new Size(38, 35);
            picBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxSearch.TabIndex = 4;
            picBoxSearch.TabStop = false;
            // 
            // txtBoxSearchBar
            // 
            txtBoxSearchBar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSearchBar.Location = new Point(230, 28);
            txtBoxSearchBar.Name = "txtBoxSearchBar";
            txtBoxSearchBar.PlaceholderText = "  What do you want to play?";
            txtBoxSearchBar.Size = new Size(322, 35);
            txtBoxSearchBar.TabIndex = 0;
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = SystemColors.ScrollBar;
            panelSideBar.Controls.Add(picBoxAddAlbum);
            panelSideBar.Location = new Point(-2, 69);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(71, 472);
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
            panelBottomBar.Controls.Add(lblPlayingArtist);
            panelBottomBar.Controls.Add(lblPlayingTrackName);
            panelBottomBar.Controls.Add(picBoxPlayingAlbumPic);
            panelBottomBar.Controls.Add(picBoxRepeatTrack);
            panelBottomBar.Controls.Add(picBoxNextTrack);
            panelBottomBar.Controls.Add(picBoxPreviousTrack);
            panelBottomBar.Controls.Add(picBoxShuffleTracks);
            panelBottomBar.Controls.Add(picBoxPlayTrack);
            panelBottomBar.Controls.Add(picBoxVolume);
            panelBottomBar.Controls.Add(picBoxNoVolume);
            panelBottomBar.Controls.Add(picBoxPauseTrack);
            panelBottomBar.Location = new Point(-5, 541);
            panelBottomBar.Name = "panelBottomBar";
            panelBottomBar.Size = new Size(902, 113);
            panelBottomBar.TabIndex = 2;
            // 
            // lblPlayingArtist
            // 
            lblPlayingArtist.AutoSize = true;
            lblPlayingArtist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayingArtist.Location = new Point(113, 62);
            lblPlayingArtist.Name = "lblPlayingArtist";
            lblPlayingArtist.Size = new Size(47, 21);
            lblPlayingArtist.TabIndex = 7;
            lblPlayingArtist.Text = "Artist";
            lblPlayingArtist.MouseLeave += lblPlayingArtist_MouseLeave;
            lblPlayingArtist.MouseHover += lblPlayingArtist_MouseHover;
            // 
            // lblPlayingTrackName
            // 
            lblPlayingTrackName.AutoSize = true;
            lblPlayingTrackName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayingTrackName.Location = new Point(113, 23);
            lblPlayingTrackName.Name = "lblPlayingTrackName";
            lblPlayingTrackName.Size = new Size(117, 25);
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
            picBoxPlayingAlbumPic.Size = new Size(80, 86);
            picBoxPlayingAlbumPic.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPlayingAlbumPic.TabIndex = 5;
            picBoxPlayingAlbumPic.TabStop = false;
            // 
            // picBoxRepeatTrack
            // 
            picBoxRepeatTrack.Image = Properties.Resources.repeat_icon;
            picBoxRepeatTrack.Location = new Point(556, 28);
            picBoxRepeatTrack.Name = "picBoxRepeatTrack";
            picBoxRepeatTrack.Size = new Size(38, 38);
            picBoxRepeatTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxRepeatTrack.TabIndex = 3;
            picBoxRepeatTrack.TabStop = false;
            picBoxRepeatTrack.MouseLeave += picBoxRepeatTrack_MouseLeave;
            picBoxRepeatTrack.MouseHover += picBoxRepeatTrack_MouseHover;
            // 
            // picBoxNextTrack
            // 
            picBoxNextTrack.Image = Properties.Resources.next_icon;
            picBoxNextTrack.Location = new Point(504, 28);
            picBoxNextTrack.Name = "picBoxNextTrack";
            picBoxNextTrack.Size = new Size(38, 38);
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
            picBoxPreviousTrack.Location = new Point(375, 28);
            picBoxPreviousTrack.Name = "picBoxPreviousTrack";
            picBoxPreviousTrack.Size = new Size(38, 38);
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
            picBoxShuffleTracks.Location = new Point(322, 28);
            picBoxShuffleTracks.Name = "picBoxShuffleTracks";
            picBoxShuffleTracks.Size = new Size(38, 38);
            picBoxShuffleTracks.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxShuffleTracks.TabIndex = 2;
            picBoxShuffleTracks.TabStop = false;
            picBoxShuffleTracks.MouseLeave += picBoxShuffleTracks_MouseLeave;
            picBoxShuffleTracks.MouseHover += picBoxShuffleTracks_MouseHover;
            // 
            // picBoxPlayTrack
            // 
            picBoxPlayTrack.Image = Properties.Resources.play_icon;
            picBoxPlayTrack.Location = new Point(432, 16);
            picBoxPlayTrack.Name = "picBoxPlayTrack";
            picBoxPlayTrack.Size = new Size(56, 60);
            picBoxPlayTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPlayTrack.TabIndex = 3;
            picBoxPlayTrack.TabStop = false;
            picBoxPlayTrack.MouseLeave += picBoxPlayTrack_MouseLeave;
            picBoxPlayTrack.MouseHover += picBoxPlayTrack_MouseHover;
            // 
            // picBoxVolume
            // 
            picBoxVolume.Image = Properties.Resources.volume_icon;
            picBoxVolume.Location = new Point(670, 28);
            picBoxVolume.Name = "picBoxVolume";
            picBoxVolume.Size = new Size(38, 38);
            picBoxVolume.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxVolume.TabIndex = 8;
            picBoxVolume.TabStop = false;
            picBoxVolume.MouseLeave += picBoxVolume_MouseLeave;
            picBoxVolume.MouseHover += picBoxVolume_MouseHover;
            // 
            // picBoxNoVolume
            // 
            picBoxNoVolume.Image = Properties.Resources.no_volume_icon;
            picBoxNoVolume.Location = new Point(670, 28);
            picBoxNoVolume.Name = "picBoxNoVolume";
            picBoxNoVolume.Size = new Size(38, 38);
            picBoxNoVolume.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxNoVolume.TabIndex = 9;
            picBoxNoVolume.TabStop = false;
            picBoxNoVolume.MouseLeave += picBoxNoVolume_MouseLeave;
            picBoxNoVolume.MouseHover += picBoxNoVolume_MouseHover;
            // 
            // picBoxPauseTrack
            // 
            picBoxPauseTrack.Image = Properties.Resources.pause_icon;
            picBoxPauseTrack.Location = new Point(432, 16);
            picBoxPauseTrack.Name = "picBoxPauseTrack";
            picBoxPauseTrack.Size = new Size(56, 60);
            picBoxPauseTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPauseTrack.TabIndex = 4;
            picBoxPauseTrack.TabStop = false;
            picBoxPauseTrack.MouseLeave += picBoxPauseTrack_MouseLeave;
            picBoxPauseTrack.MouseHover += picBoxPauseTrack_MouseHover;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 655);
            Controls.Add(panelBody);
            Controls.Add(panelBottomBar);
            Controls.Add(panelSideBar);
            Controls.Add(panelTopBar);
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
            ((System.ComponentModel.ISupportInitialize)picBoxPlayingAlbumPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRepeatTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNextTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPreviousTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxShuffleTracks).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNoVolume).EndInit();
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
    }
}
