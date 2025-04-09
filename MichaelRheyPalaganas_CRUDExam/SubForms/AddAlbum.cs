using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.Models.Entities;

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
            // Navigate back to AlbumsDashboard after adding the album
            _parentForm.LoadAlbumsDashboard();
        }

    }
}
