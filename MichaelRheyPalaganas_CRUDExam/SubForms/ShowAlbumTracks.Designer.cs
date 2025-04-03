namespace MichaelRheyPalaganas_CRUDExam.SubForms
{
    partial class ShowAlbumTracks
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
            panel1 = new Panel();
            panel2 = new Panel();
            picBoxCurrentAlbumPicture = new PictureBox();
            lblAlbumInformation = new Label();
            lblCurrentAlbumName = new Label();
            lblNoTracks = new Label();
            txtBoxSearchTrack = new TextBox();
            pictureBox1 = new PictureBox();
            picBoxAddTrack = new PictureBox();
            picBoxShuffleTracks = new PictureBox();
            dataGridViewTracks = new DataGridView();
            picBoxPlayTracks = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCurrentAlbumPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAddTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxShuffleTracks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTracks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayTracks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(picBoxCurrentAlbumPicture);
            panel1.Controls.Add(lblAlbumInformation);
            panel1.Controls.Add(lblCurrentAlbumName);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 188);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 411);
            panel2.TabIndex = 1;
            // 
            // picBoxCurrentAlbumPicture
            // 
            picBoxCurrentAlbumPicture.Location = new Point(38, 38);
            picBoxCurrentAlbumPicture.Name = "picBoxCurrentAlbumPicture";
            picBoxCurrentAlbumPicture.Size = new Size(143, 137);
            picBoxCurrentAlbumPicture.TabIndex = 2;
            picBoxCurrentAlbumPicture.TabStop = false;
            // 
            // lblAlbumInformation
            // 
            lblAlbumInformation.AutoSize = true;
            lblAlbumInformation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbumInformation.ForeColor = SystemColors.Control;
            lblAlbumInformation.Location = new Point(212, 131);
            lblAlbumInformation.Name = "lblAlbumInformation";
            lblAlbumInformation.Size = new Size(118, 25);
            lblAlbumInformation.TabIndex = 4;
            lblAlbumInformation.Text = "Artist Name";
            // 
            // lblCurrentAlbumName
            // 
            lblCurrentAlbumName.AutoSize = true;
            lblCurrentAlbumName.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentAlbumName.ForeColor = SystemColors.Control;
            lblCurrentAlbumName.Location = new Point(199, 66);
            lblCurrentAlbumName.Name = "lblCurrentAlbumName";
            lblCurrentAlbumName.Size = new Size(326, 65);
            lblCurrentAlbumName.TabIndex = 3;
            lblCurrentAlbumName.Text = "Album Name";
            // 
            // lblNoTracks
            // 
            lblNoTracks.AutoSize = true;
            lblNoTracks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoTracks.ForeColor = SystemColors.ActiveCaptionText;
            lblNoTracks.Location = new Point(212, 354);
            lblNoTracks.Name = "lblNoTracks";
            lblNoTracks.Size = new Size(350, 60);
            lblNoTracks.TabIndex = 8;
            lblNoTracks.Text = "No tracks available for this album.\r\nClick + to start adding tracks.";
            lblNoTracks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxSearchTrack
            // 
            txtBoxSearchTrack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSearchTrack.Location = new Point(396, 217);
            txtBoxSearchTrack.Name = "txtBoxSearchTrack";
            txtBoxSearchTrack.PlaceholderText = "  Search track";
            txtBoxSearchTrack.Size = new Size(253, 29);
            txtBoxSearchTrack.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search_track;
            pictureBox1.Location = new Point(667, 217);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // picBoxAddTrack
            // 
            picBoxAddTrack.Image = Properties.Resources.add_track;
            picBoxAddTrack.Location = new Point(183, 217);
            picBoxAddTrack.Name = "picBoxAddTrack";
            picBoxAddTrack.Size = new Size(50, 50);
            picBoxAddTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxAddTrack.TabIndex = 10;
            picBoxAddTrack.TabStop = false;
            // 
            // picBoxShuffleTracks
            // 
            picBoxShuffleTracks.Image = Properties.Resources.shuffle_icon_default;
            picBoxShuffleTracks.Location = new Point(118, 217);
            picBoxShuffleTracks.Name = "picBoxShuffleTracks";
            picBoxShuffleTracks.Size = new Size(45, 50);
            picBoxShuffleTracks.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxShuffleTracks.TabIndex = 9;
            picBoxShuffleTracks.TabStop = false;
            // 
            // dataGridViewTracks
            // 
            dataGridViewTracks.AllowUserToAddRows = false;
            dataGridViewTracks.AllowUserToDeleteRows = false;
            dataGridViewTracks.AllowUserToResizeColumns = false;
            dataGridViewTracks.AllowUserToResizeRows = false;
            dataGridViewTracks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTracks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTracks.Location = new Point(12, 306);
            dataGridViewTracks.Name = "dataGridViewTracks";
            dataGridViewTracks.ReadOnly = true;
            dataGridViewTracks.Size = new Size(759, 454);
            dataGridViewTracks.TabIndex = 13;
            // 
            // picBoxPlayTracks
            // 
            picBoxPlayTracks.Image = Properties.Resources.play_tracks;
            picBoxPlayTracks.Location = new Point(29, 205);
            picBoxPlayTracks.Name = "picBoxPlayTracks";
            picBoxPlayTracks.Size = new Size(71, 74);
            picBoxPlayTracks.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPlayTracks.TabIndex = 14;
            picBoxPlayTracks.TabStop = false;
            // 
            // ShowAlbumTracks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(picBoxPlayTracks);
            Controls.Add(txtBoxSearchTrack);
            Controls.Add(pictureBox1);
            Controls.Add(picBoxAddTrack);
            Controls.Add(picBoxShuffleTracks);
            Controls.Add(lblNoTracks);
            Controls.Add(panel1);
            Controls.Add(dataGridViewTracks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowAlbumTracks";
            Text = "ShowAlbumTracks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCurrentAlbumPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAddTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxShuffleTracks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTracks).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayTracks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox picBoxCurrentAlbumPicture;
        private Label lblAlbumInformation;
        private Label lblCurrentAlbumName;
        private Label lblNoTracks;
        private TextBox txtBoxSearchTrack;
        private PictureBox pictureBox1;
        private PictureBox picBoxAddTrack;
        private PictureBox picBoxShuffleTracks;
        private DataGridView dataGridViewTracks;
        private PictureBox picBoxPlayTracks;
    }
}