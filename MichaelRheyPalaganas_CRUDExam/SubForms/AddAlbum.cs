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
    public partial class AddAlbum : Form
    {
        private readonly AppDbContext _context;
        private MainForm _parentForm;
        public AddAlbum(MainForm parentForm, AppDbContext context)
        {
            _parentForm = parentForm;
            _context = context;
            InitializeComponent();
        }
        private void ClearAlbumFields()
        {
            txtBoxAlbumName.Text = "";
            txtBoxArtist.Text = "";
            txtBoxGenre.Text = "";
            txtBoxAlbumPicture.Text = "";
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            Album newAlbum = new Album
            {
                AlbumName = txtBoxAlbumName.Text,
                Artist = txtBoxArtist.Text,
                Genre = txtBoxGenre.Text,
                AlbumPicture = txtBoxAlbumPicture.Text
            };
            _context.Albums.Add(newAlbum);
            _context.SaveChanges();

            ClearAlbumFields();
            ShowAddAlbumMessage();
        }

        private void ShowAddAlbumMessage()
        {
            MessageBox.Show("Album Added Successfully", "Add Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
