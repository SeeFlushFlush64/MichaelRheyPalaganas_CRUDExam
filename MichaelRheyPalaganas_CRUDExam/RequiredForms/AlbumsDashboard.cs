using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using MichaelRheyPalaganas_CRUDExam.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichaelRheyPalaganas_CRUDExam.RequiredForms
{
    public partial class AlbumsDashboard : Form
    {
        private readonly AppDbContext _context;
        private int _albumWidth = 180; // Album box width + margin
        private int _visibleAlbums = 4; // Only 4 visible at a time
        private int _currentIndex = 0; // Current scroll index
        private List<Panel> _albumPanels = new List<Panel>(); // Store panels
        private MainForm _parentForm;
        public AlbumsDashboard(MainForm parentForm, AppDbContext context)
        {
            _parentForm = parentForm;
            _context = context;
            InitializeComponent();
            LoadAlbums();
        }

        public void LoadAlbums()
        {
            panelRecentlyAdded.Controls.Clear();
            _albumPanels.Clear(); // Clear previous panels

            var albums = _context.Albums.ToList();

            for (int i = 0; i < albums.Count; i++)
            {
                Album album = albums[i];
                Panel albumPanel = new Panel
                {
                    Size = new Size(170, 220),
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(5),
                    Left = (i % _visibleAlbums) * _albumWidth,
                    Top = 0,
                    BackColor = Color.LightGray, // For visibility
                    Visible = (i < _visibleAlbums), // Only first 3 are visible initially
                    Tag = album
                };

                PictureBox picAlbum = new PictureBox
                {
                    Size = new Size(160, 160),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = albums[i].AlbumPicture,
                    Top = 5,
                    Left = 5,
                    Tag = album
                };

                Label lblAlbumName = new Label
                {
                    Text = albums[i].AlbumName,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(albumPanel.Width - 10, 20),
                    Top = picAlbum.Bottom + 5,
                    Left = 5,
                    Cursor = Cursors.Hand,
                    Tag = album
                };

                Label lblArtist = new Label
                {
                    Text = "By: " + albums[i].Artist,
                    Font = new Font("Arial", 8),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(albumPanel.Width - 10, 15),
                    Top = lblAlbumName.Bottom + 2,
                    Left = 5,
                    Cursor = Cursors.Hand,
                    Tag = album
                };

                // Attach events
                picAlbum.MouseEnter += Album_MouseEnter;
                picAlbum.MouseLeave += Album_MouseLeave;
                picAlbum.Click += Album_Click;
                lblAlbumName.MouseEnter += Album_MouseEnter;
                lblAlbumName.MouseLeave += Album_MouseLeave;
                lblAlbumName.Click += Album_Click;
                lblArtist.MouseEnter += Album_MouseEnter;
                lblArtist.MouseLeave += Album_MouseLeave;
                lblArtist.Click += Album_Click;

                albumPanel.Controls.Add(picAlbum);
                albumPanel.Controls.Add(lblAlbumName);
                albumPanel.Controls.Add(lblArtist);

                _albumPanels.Add(albumPanel);
                panelRecentlyAdded.Controls.Add(albumPanel);
            }

            UpdateButtons();
        }

        public void ShowAddAlbums(object Form)
        {
            if (_parentForm.panelBody.Controls.Count > 0)
            {
                _parentForm.panelBody.Controls.RemoveAt(0);
            }
            AddAlbum addAlbumForm = new AddAlbum(_parentForm, _context); // Pass this dashboard
            addAlbumForm.TopLevel = false;
            addAlbumForm.Dock = DockStyle.Fill;
            _parentForm.panelBody.Controls.Add(addAlbumForm);
            _parentForm.panelBody.Tag = addAlbumForm;

            addAlbumForm.Show();
        }

        private void UpdateButtons()
        {
            picBoxRALeft.Visible = (_currentIndex > 0);
            picBoxRARight.Visible = (_currentIndex + _visibleAlbums < _albumPanels.Count);
        }

        private void Album_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Album_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }


        private void Album_Click(object sender, EventArgs e)
        {
            // Get the clicked control
            Control clickedControl = (Control)sender;

            // Retrieve the Album object from the Tag property
            if (clickedControl.Tag is Album selectedAlbum)
            {
                _parentForm.ShowAddAlbums(new ShowAlbumTracks(_context, selectedAlbum, _parentForm));
            }
        }
    }
}
