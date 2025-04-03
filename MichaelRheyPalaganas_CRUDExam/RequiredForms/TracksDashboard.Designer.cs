namespace MichaelRheyPalaganas_CRUDExam.RequiredForms
{
    partial class TracksDashboard
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
            dataGridViewAllTracks = new DataGridView();
            btnShowAllTracks = new Button();
            btnShowAllAlbums = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllTracks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAllTracks
            // 
            dataGridViewAllTracks.AllowUserToAddRows = false;
            dataGridViewAllTracks.AllowUserToDeleteRows = false;
            dataGridViewAllTracks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAllTracks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllTracks.Location = new Point(26, 192);
            dataGridViewAllTracks.Name = "dataGridViewAllTracks";
            dataGridViewAllTracks.ReadOnly = true;
            dataGridViewAllTracks.Size = new Size(795, 338);
            dataGridViewAllTracks.TabIndex = 0;
            // 
            // btnShowAllTracks
            // 
            btnShowAllTracks.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllTracks.Location = new Point(105, 21);
            btnShowAllTracks.Name = "btnShowAllTracks";
            btnShowAllTracks.Size = new Size(88, 35);
            btnShowAllTracks.TabIndex = 3;
            btnShowAllTracks.Text = "Tracks";
            btnShowAllTracks.UseVisualStyleBackColor = true;
            // 
            // btnShowAllAlbums
            // 
            btnShowAllAlbums.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllAlbums.Location = new Point(21, 21);
            btnShowAllAlbums.Name = "btnShowAllAlbums";
            btnShowAllAlbums.Size = new Size(78, 35);
            btnShowAllAlbums.TabIndex = 2;
            btnShowAllAlbums.Text = "Albums";
            btnShowAllAlbums.UseVisualStyleBackColor = true;
            // 
            // TracksDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 400);
            Controls.Add(btnShowAllTracks);
            Controls.Add(btnShowAllAlbums);
            Controls.Add(dataGridViewAllTracks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TracksDashboard";
            Text = "TracksDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllTracks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAllTracks;
        private Button btnShowAllTracks;
        private Button btnShowAllAlbums;
    }
}