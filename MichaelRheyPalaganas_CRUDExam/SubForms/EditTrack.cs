using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using NAudio.Wave;
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
    public partial class EditTrack : Form
    {
        private readonly AppDbContext _context;
        private Track _track;
        private MainForm _parentForm;
        private WaveOutEvent _outputDevice;
        private AudioFileReader _audioFile;
        public EditTrack(MainForm parentForm, Track track, AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            _track = _context.Tracks.FirstOrDefault(t => t.TrackId == track.TrackId);
            _parentForm = parentForm;
            LoadTrackDetails();
        }
        private void LoadTrackDetails()
        {
            txtBoxTrackName.Text = _track.TrackName;
            txtBoxArtist.Text = _track.Duration.ToString();
            txtBoxGenre.Text = _track.Album.Genre;
            txtBoxTrackFilePath.Text = _track.FilePath;
        }

        private void btnEditTrack_Click(object sender, EventArgs e)
        {
            Track trackToUpdate = _context.Tracks.FirstOrDefault(t => t.TrackId == _track.TrackId);
            trackToUpdate.TrackName = txtBoxTrackName.Text;
            trackToUpdate.FilePath = txtBoxTrackFilePath.Text;
            _context.Tracks.Update(trackToUpdate);
            _context.SaveChanges();
            _parentForm.NavigateToForm(new ShowAlbumTracks(_context, trackToUpdate.Album, _parentForm));
        }

        private void picBoxBrowseTrack_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; // optional
                openFileDialog.Filter = "Music Files (*.mp3;*.wav)|*.mp3;*.wav|All files (*.*)|*.*";
                openFileDialog.Multiselect = false; // change to true if you want to allow multiple files

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    txtBoxTrackFilePath.Text = selectedFile; // Example: Display in a TextBox

                    _outputDevice = new WaveOutEvent();
                    _audioFile = new AudioFileReader(openFileDialog.FileName);
                    _outputDevice.Init(_audioFile);
                }
            }
        }
    }
}
