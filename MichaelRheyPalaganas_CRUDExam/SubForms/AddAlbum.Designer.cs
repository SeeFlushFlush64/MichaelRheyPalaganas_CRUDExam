namespace MichaelRheyPalaganas_CRUDExam.SubForms
{
    partial class AddAlbum
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
            btnAddAlbum = new Button();
            lblArtist = new Label();
            lblGenre = new Label();
            lblAlbumName = new Label();
            txtBoxArtist = new TextBox();
            txtBoxGenre = new TextBox();
            txtBoxAlbumName = new TextBox();
            lblAddAlbum = new Label();
            lblAlbumPicture = new Label();
            txtBoxAlbumPicture = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblAlbumNameError = new Label();
            lblGenreError = new Label();
            lblArtistError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAlbum.Location = new Point(56, 408);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(90, 30);
            btnAddAlbum.TabIndex = 20;
            btnAddAlbum.Text = "Add";
            btnAddAlbum.UseVisualStyleBackColor = true;
            btnAddAlbum.Click += btnAddAlbum_Click;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtist.Location = new Point(56, 180);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(51, 21);
            lblArtist.TabIndex = 19;
            lblArtist.Text = "Artist";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenre.Location = new Point(56, 289);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(55, 21);
            lblGenre.TabIndex = 18;
            lblGenre.Text = "Genre";
            // 
            // lblAlbumName
            // 
            lblAlbumName.AutoSize = true;
            lblAlbumName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbumName.Location = new Point(55, 71);
            lblAlbumName.Name = "lblAlbumName";
            lblAlbumName.Size = new Size(56, 21);
            lblAlbumName.TabIndex = 17;
            lblAlbumName.Text = "Name";
            // 
            // txtBoxArtist
            // 
            txtBoxArtist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxArtist.Location = new Point(55, 204);
            txtBoxArtist.Name = "txtBoxArtist";
            txtBoxArtist.Size = new Size(242, 29);
            txtBoxArtist.TabIndex = 16;
            // 
            // txtBoxGenre
            // 
            txtBoxGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxGenre.Location = new Point(56, 313);
            txtBoxGenre.Name = "txtBoxGenre";
            txtBoxGenre.Size = new Size(242, 29);
            txtBoxGenre.TabIndex = 15;
            // 
            // txtBoxAlbumName
            // 
            txtBoxAlbumName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAlbumName.Location = new Point(55, 95);
            txtBoxAlbumName.Name = "txtBoxAlbumName";
            txtBoxAlbumName.Size = new Size(242, 29);
            txtBoxAlbumName.TabIndex = 14;
            // 
            // lblAddAlbum
            // 
            lblAddAlbum.AutoSize = true;
            lblAddAlbum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddAlbum.Location = new Point(30, 9);
            lblAddAlbum.Name = "lblAddAlbum";
            lblAddAlbum.Size = new Size(144, 32);
            lblAddAlbum.TabIndex = 13;
            lblAddAlbum.Text = "Add Album";
            // 
            // lblAlbumPicture
            // 
            lblAlbumPicture.AutoSize = true;
            lblAlbumPicture.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbumPicture.Location = new Point(431, 71);
            lblAlbumPicture.Name = "lblAlbumPicture";
            lblAlbumPicture.Size = new Size(200, 21);
            lblAlbumPicture.TabIndex = 23;
            lblAlbumPicture.Text = "Album Picture (optional)";
            // 
            // txtBoxAlbumPicture
            // 
            txtBoxAlbumPicture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAlbumPicture.Location = new Point(431, 95);
            txtBoxAlbumPicture.Name = "txtBoxAlbumPicture";
            txtBoxAlbumPicture.Size = new Size(242, 29);
            txtBoxAlbumPicture.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(485, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.album_icon;
            pictureBox2.Location = new Point(523, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(237, 209);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // lblAlbumNameError
            // 
            lblAlbumNameError.AutoSize = true;
            lblAlbumNameError.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAlbumNameError.ForeColor = Color.Red;
            lblAlbumNameError.Location = new Point(56, 129);
            lblAlbumNameError.Name = "lblAlbumNameError";
            lblAlbumNameError.Size = new Size(157, 17);
            lblAlbumNameError.TabIndex = 25;
            lblAlbumNameError.Text = "Album Name is required!";
            // 
            // lblGenreError
            // 
            lblGenreError.AutoSize = true;
            lblGenreError.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGenreError.ForeColor = Color.Red;
            lblGenreError.Location = new Point(56, 345);
            lblGenreError.Name = "lblGenreError";
            lblGenreError.Size = new Size(115, 17);
            lblGenreError.TabIndex = 26;
            lblGenreError.Text = "Genre is required!";
            // 
            // lblArtistError
            // 
            lblArtistError.AutoSize = true;
            lblArtistError.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblArtistError.ForeColor = Color.Red;
            lblArtistError.Location = new Point(56, 236);
            lblArtistError.Name = "lblArtistError";
            lblArtistError.Size = new Size(112, 17);
            lblArtistError.TabIndex = 27;
            lblArtistError.Text = "Artist is required!";
            // 
            // AddAlbum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblArtistError);
            Controls.Add(lblGenreError);
            Controls.Add(lblAlbumNameError);
            Controls.Add(pictureBox2);
            Controls.Add(lblAlbumPicture);
            Controls.Add(txtBoxAlbumPicture);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddAlbum);
            Controls.Add(lblArtist);
            Controls.Add(lblGenre);
            Controls.Add(lblAlbumName);
            Controls.Add(txtBoxArtist);
            Controls.Add(txtBoxGenre);
            Controls.Add(txtBoxAlbumName);
            Controls.Add(lblAddAlbum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAlbum";
            Text = "AddAlbum";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddAlbum;
        private Label lblArtist;
        private Label lblGenre;
        private Label lblAlbumName;
        private TextBox txtBoxArtist;
        private TextBox txtBoxGenre;
        private TextBox txtBoxAlbumName;
        private Label lblAddAlbum;
        private Label lblAlbumPicture;
        private TextBox txtBoxAlbumPicture;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblAlbumNameError;
        private Label lblGenreError;
        private Label lblArtistError;
    }
}