using FluentValidation;
using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using System;
using System.Linq;

namespace MichaelRheyPalaganas_CRUDExam.Validators
{
    public class AlbumValidator : AbstractValidator<Album>
    {
        private readonly AppDbContext _context;

        public AlbumValidator(AppDbContext context)
        {
            _context = context;

            RuleFor(a => a.AlbumName)
                .NotEmpty().WithMessage("Album name is required.")
                .MaximumLength(100).WithMessage("Album name cannot exceed 100 characters.")
                .Matches(@"^[a-zA-Z0-9\s]+$").WithMessage("Album name can only contain alphanumeric characters and spaces.")
                .Must(BeUniqueAlbumName).WithMessage("An album with this name already exists.");

            RuleFor(a => a.Artist)
                .NotEmpty().WithMessage("Artist is required.")
                .MaximumLength(100).WithMessage("Artist name cannot exceed 100 characters.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("Artist name can only contain letters and spaces.");

            RuleFor(a => a.Genre)
                .NotEmpty().WithMessage("Genre is required.")
                .MaximumLength(50).WithMessage("Genre cannot exceed 50 characters.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("Genre can only contain letters and spaces.");
        }

        // Custom validation for unique album name
        private bool BeUniqueAlbumName(Album album, string albumName)
        {
            // Check if there's an album with the same name in the database (excluding the current album if editing)
            return !_context.Albums.Any(a => a.AlbumName.Equals(albumName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
