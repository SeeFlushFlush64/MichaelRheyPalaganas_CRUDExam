using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichaelRheyPalaganas_CRUDExam.SubForms
{
    public partial class ShowAlbumTracks : Form
    {
        private AppDbContext _context;
        private Album _album;
        private bool _isShuffleActive = false;
        private MainForm _parentForm;
        public ShowAlbumTracks(AppDbContext context, Album album, MainForm parentForm)
        {
            _context = context;
            _album = _context.Albums.Include(a => a.Tracks).FirstOrDefault(a => a.AlbumId == album.AlbumId);
            _parentForm = parentForm;
            InitializeComponent();
            LoadAlbumTracks();
        }
        private void LoadAlbumTracks()
        {
            picBoxCurrentAlbumPicture.ImageLocation = _album.AlbumPicture;
            picBoxCurrentAlbumPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCurrentAlbumName.Text = _album.AlbumName;
            lblAlbumInformation.Text = $"{_album.Artist} • {_album.Genre} • {_album.Tracks.Count} Tracks";
            // Load tracks into DataGridView
            var tracks = _context.Tracks
                .Where(t => t.AlbumId == _album.AlbumId)
                .Select(t => new { t.TrackId, t.TrackName, t.Duration })
                .ToList();
            if (tracks.Count.Equals(0))
            {
                dataGridViewTracks.Visible = false;
                return;
            }
            lblNoTracks.Visible = false;
            dataGridViewTracks.DataSource = tracks;
        }

        private void picBoxPlayTracks_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxPlayTracks_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxShuffleTracks_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxShuffleTracks_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxShuffleTracks_MouseClick(object sender, MouseEventArgs e)
        {

            if (_isShuffleActive)
            {
                _isShuffleActive = false;
                picBoxShuffleTracks.Image = Properties.Resources.shuffle_icon_default;
                return;
            }
            picBoxShuffleTracks.Image = Properties.Resources.shuffle_icon_active;
            _isShuffleActive = true;
        }

        private void picBoxAddTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxAddTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxAddTrack_MouseClick(object sender, MouseEventArgs e)
        {

            _parentForm.ShowAddAlbums(new AddTrack(_album, _context));

        }
    }
}
