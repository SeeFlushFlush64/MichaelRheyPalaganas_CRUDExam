using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.Models.Entities;
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
    public partial class AddTrack : Form
    {
        private readonly AppDbContext _context;
        private Album _album;
        public AddTrack(Album album, AppDbContext context)
        {
            _album = album;
            _context = context;
            InitializeComponent();
        }
    }
}
