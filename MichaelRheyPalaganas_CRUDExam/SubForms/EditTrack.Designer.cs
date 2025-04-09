namespace MichaelRheyPalaganas_CRUDExam.SubForms
{
    partial class EditTrack
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
            picBoxBrowseTrack = new PictureBox();
            lblImportTrack = new Label();
            txtBoxTrackFilePath = new TextBox();
            lblAddTrackerHeader = new Label();
            btnEditTrack = new Button();
            lblArtist = new Label();
            lblGenre = new Label();
            lblAlbumName = new Label();
            txtBoxArtist = new TextBox();
            txtBoxGenre = new TextBox();
            txtBoxTrackName = new TextBox();
            lblAddAlbum = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxBrowseTrack).BeginInit();
            SuspendLayout();
            // 
            // picBoxBrowseTrack
            // 
            picBoxBrowseTrack.Image = Properties.Resources.browse_icon;
            picBoxBrowseTrack.Location = new Point(677, 98);
            picBoxBrowseTrack.Name = "picBoxBrowseTrack";
            picBoxBrowseTrack.Size = new Size(37, 29);
            picBoxBrowseTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxBrowseTrack.TabIndex = 48;
            picBoxBrowseTrack.TabStop = false;
            picBoxBrowseTrack.Click += picBoxBrowseTrack_Click;
            // 
            // lblImportTrack
            // 
            lblImportTrack.AutoSize = true;
            lblImportTrack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImportTrack.Location = new Point(429, 74);
            lblImportTrack.Name = "lblImportTrack";
            lblImportTrack.Size = new Size(203, 21);
            lblImportTrack.TabIndex = 47;
            lblImportTrack.Text = "Import Track (.mp3, .wav)";
            // 
            // txtBoxTrackFilePath
            // 
            txtBoxTrackFilePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTrackFilePath.Location = new Point(429, 98);
            txtBoxTrackFilePath.Name = "txtBoxTrackFilePath";
            txtBoxTrackFilePath.Size = new Size(242, 29);
            txtBoxTrackFilePath.TabIndex = 46;
            // 
            // lblAddTrackerHeader
            // 
            lblAddTrackerHeader.AutoSize = true;
            lblAddTrackerHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTrackerHeader.Location = new Point(35, 20);
            lblAddTrackerHeader.Name = "lblAddTrackerHeader";
            lblAddTrackerHeader.Size = new Size(125, 32);
            lblAddTrackerHeader.TabIndex = 45;
            lblAddTrackerHeader.Text = "Edit Track";
            // 
            // btnEditTrack
            // 
            btnEditTrack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditTrack.Location = new Point(58, 390);
            btnEditTrack.Name = "btnEditTrack";
            btnEditTrack.Size = new Size(90, 30);
            btnEditTrack.TabIndex = 44;
            btnEditTrack.Text = "Save";
            btnEditTrack.UseVisualStyleBackColor = true;
            btnEditTrack.Click += btnEditTrack_Click;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtist.Location = new Point(59, 171);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(51, 21);
            lblArtist.TabIndex = 43;
            lblArtist.Text = "Artist";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenre.Location = new Point(58, 278);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(55, 21);
            lblGenre.TabIndex = 42;
            lblGenre.Text = "Genre";
            // 
            // lblAlbumName
            // 
            lblAlbumName.AutoSize = true;
            lblAlbumName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbumName.Location = new Point(58, 74);
            lblAlbumName.Name = "lblAlbumName";
            lblAlbumName.Size = new Size(56, 21);
            lblAlbumName.TabIndex = 41;
            lblAlbumName.Text = "Name";
            // 
            // txtBoxArtist
            // 
            txtBoxArtist.Enabled = false;
            txtBoxArtist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxArtist.Location = new Point(58, 195);
            txtBoxArtist.Name = "txtBoxArtist";
            txtBoxArtist.ReadOnly = true;
            txtBoxArtist.Size = new Size(242, 29);
            txtBoxArtist.TabIndex = 40;
            txtBoxArtist.TabStop = false;
            // 
            // txtBoxGenre
            // 
            txtBoxGenre.Enabled = false;
            txtBoxGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxGenre.Location = new Point(58, 302);
            txtBoxGenre.Name = "txtBoxGenre";
            txtBoxGenre.ReadOnly = true;
            txtBoxGenre.Size = new Size(242, 29);
            txtBoxGenre.TabIndex = 39;
            txtBoxGenre.TabStop = false;
            // 
            // txtBoxTrackName
            // 
            txtBoxTrackName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTrackName.Location = new Point(58, 98);
            txtBoxTrackName.Name = "txtBoxTrackName";
            txtBoxTrackName.Size = new Size(242, 29);
            txtBoxTrackName.TabIndex = 38;
            // 
            // lblAddAlbum
            // 
            lblAddAlbum.AutoSize = true;
            lblAddAlbum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddAlbum.Location = new Point(29, 20);
            lblAddAlbum.Name = "lblAddAlbum";
            lblAddAlbum.Size = new Size(0, 32);
            lblAddAlbum.TabIndex = 37;
            // 
            // EditTrack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picBoxBrowseTrack);
            Controls.Add(lblImportTrack);
            Controls.Add(txtBoxTrackFilePath);
            Controls.Add(lblAddTrackerHeader);
            Controls.Add(btnEditTrack);
            Controls.Add(lblArtist);
            Controls.Add(lblGenre);
            Controls.Add(lblAlbumName);
            Controls.Add(txtBoxArtist);
            Controls.Add(txtBoxGenre);
            Controls.Add(txtBoxTrackName);
            Controls.Add(lblAddAlbum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditTrack";
            Text = "EditTrack";
            ((System.ComponentModel.ISupportInitialize)picBoxBrowseTrack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxBrowseTrack;
        private Label lblImportTrack;
        private TextBox txtBoxTrackFilePath;
        private Label lblAddTrackerHeader;
        private Button btnEditTrack;
        private Label lblArtist;
        private Label lblGenre;
        private Label lblAlbumName;
        private TextBox txtBoxArtist;
        private TextBox txtBoxGenre;
        private TextBox txtBoxTrackName;
        private Label lblAddAlbum;
    }
}