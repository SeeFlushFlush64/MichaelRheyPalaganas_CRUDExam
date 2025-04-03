namespace MichaelRheyPalaganas_CRUDExam.RequiredForms
{
    partial class AlbumsDashboard
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
            picBoxRARight = new PictureBox();
            picBoxRALeft = new PictureBox();
            lblRecentlyAdded = new Label();
            btnShowAllTracks = new Button();
            btnShowAllAlbums = new Button();
            panelRecentlyAdded = new Panel();
            ((System.ComponentModel.ISupportInitialize)picBoxRARight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRALeft).BeginInit();
            SuspendLayout();
            // 
            // picBoxRARight
            // 
            picBoxRARight.Image = Properties.Resources.right_icon;
            picBoxRARight.Location = new Point(800, 208);
            picBoxRARight.Name = "picBoxRARight";
            picBoxRARight.Size = new Size(35, 50);
            picBoxRARight.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxRARight.TabIndex = 22;
            picBoxRARight.TabStop = false;
            // 
            // picBoxRALeft
            // 
            picBoxRALeft.Image = Properties.Resources.left_icon;
            picBoxRALeft.Location = new Point(21, 208);
            picBoxRALeft.Name = "picBoxRALeft";
            picBoxRALeft.Size = new Size(35, 50);
            picBoxRALeft.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxRALeft.TabIndex = 21;
            picBoxRALeft.TabStop = false;
            // 
            // lblRecentlyAdded
            // 
            lblRecentlyAdded.AutoSize = true;
            lblRecentlyAdded.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentlyAdded.Location = new Point(21, 85);
            lblRecentlyAdded.Name = "lblRecentlyAdded";
            lblRecentlyAdded.Size = new Size(151, 25);
            lblRecentlyAdded.TabIndex = 19;
            lblRecentlyAdded.Text = "Recently Added";
            // 
            // btnShowAllTracks
            // 
            btnShowAllTracks.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllTracks.Location = new Point(105, 21);
            btnShowAllTracks.Name = "btnShowAllTracks";
            btnShowAllTracks.Size = new Size(88, 35);
            btnShowAllTracks.TabIndex = 18;
            btnShowAllTracks.Text = "Tracks";
            btnShowAllTracks.UseVisualStyleBackColor = true;
            // 
            // btnShowAllAlbums
            // 
            btnShowAllAlbums.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllAlbums.Location = new Point(21, 21);
            btnShowAllAlbums.Name = "btnShowAllAlbums";
            btnShowAllAlbums.Size = new Size(78, 35);
            btnShowAllAlbums.TabIndex = 17;
            btnShowAllAlbums.Text = "Albums";
            btnShowAllAlbums.UseVisualStyleBackColor = true;
            // 
            // panelRecentlyAdded
            // 
            panelRecentlyAdded.Location = new Point(62, 125);
            panelRecentlyAdded.Name = "panelRecentlyAdded";
            panelRecentlyAdded.Size = new Size(732, 228);
            panelRecentlyAdded.TabIndex = 20;
            // 
            // AlbumsDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(855, 400);
            Controls.Add(picBoxRARight);
            Controls.Add(picBoxRALeft);
            Controls.Add(lblRecentlyAdded);
            Controls.Add(btnShowAllTracks);
            Controls.Add(btnShowAllAlbums);
            Controls.Add(panelRecentlyAdded);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlbumsDashboard";
            Text = "AlbumsDashboard";
            ((System.ComponentModel.ISupportInitialize)picBoxRARight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRALeft).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxRARight;
        private PictureBox picBoxRALeft;
        private Label lblRecentlyAdded;
        private Button btnShowAllTracks;
        private Button btnShowAllAlbums;
        private Panel panelRecentlyAdded;
    }
}