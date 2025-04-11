using FluentValidation.Results;
using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using MichaelRheyPalaganas_CRUDExam.Validators;

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
            // Clear previous error messages
            lblAlbumNameError.Visible = false;
            lblArtistError.Visible = false;
            lblGenreError.Visible = false;
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

            var validator = new AlbumValidator();
            ValidationResult result = validator.Validate(newAlbum);

            

            // Clear text from previous errors
            lblAlbumNameError.Text = "";
            lblArtistError.Text = "";
            lblGenreError.Text = "";

            if (!result.IsValid)
            {
                // Iterate over validation errors and show them in the corresponding labels
                foreach (var error in result.Errors)
                {
                    switch (error.PropertyName)
                    {
                        case "AlbumName":
                            lblAlbumNameError.Visible = true;
                            lblAlbumNameError.Text = error.ErrorMessage;
                            break;
                        case "Artist":
                            lblArtistError.Visible = true;
                            lblArtistError.Text = error.ErrorMessage;
                            break;
                        case "Genre":
                            lblGenreError.Visible = true;
                            lblGenreError.Text = error.ErrorMessage;
                            break;
                    }
                }
                return;
            }

            // If validation is successful, save the new album
            _context.Albums.Add(newAlbum);
            _context.SaveChanges();

            ClearAlbumFields();
            _parentForm.LoadAlbumsDashboard();
        }


    }
}
