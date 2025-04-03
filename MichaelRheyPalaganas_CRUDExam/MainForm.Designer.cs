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
            panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxForwardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBackButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSearch).BeginInit();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxAddAlbum).BeginInit();
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
            panelBottomBar.Location = new Point(-5, 541);
            panelBottomBar.Name = "panelBottomBar";
            panelBottomBar.Size = new Size(902, 113);
            panelBottomBar.TabIndex = 2;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Panel panelSideBar;
        private Panel panelBottomBar;
        private Panel panelBody;
        private TextBox txtBoxSearchBar;
        private PictureBox picBoxHome;
        private PictureBox picBoxSearch;
        private PictureBox picBoxForwardButton;
        private PictureBox picBoxBackButton;
        private PictureBox picBoxAddAlbum;
    }
}
