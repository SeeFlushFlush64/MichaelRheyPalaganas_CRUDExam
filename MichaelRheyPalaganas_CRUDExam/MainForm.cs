using MichaelRheyPalaganas_CRUDExam.Data;
using MichaelRheyPalaganas_CRUDExam.RequiredForms;
using MichaelRheyPalaganas_CRUDExam.SubForms;

namespace MichaelRheyPalaganas_CRUDExam
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context;
        private Stack<Form> _backStack = new Stack<Form>();
        private Stack<Form> _forwardStack = new Stack<Form>();
        public MainForm(AppDbContext context)
        {

            InitializeComponent();
            _context = context;
            LoadAlbumsDashboard(); // Load the initial form
        }
        private void LoadForms(Form newForm)
        {
            // If there is a form currently in panelBody, move it to the back stack
            if (panelBody.Controls.Count > 0)
            {
                Form currentForm = panelBody.Controls[0] as Form;
                if (currentForm != null)
                {
                    _backStack.Push(currentForm);
                }
                panelBody.Controls.Clear();
            }

            // Set up the new form
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(newForm);
            newForm.Show();

            // Clear forward stack whenever a new form is loaded
            _forwardStack.Clear();

            // Update navigation buttons
            UpdateNavigationButtons();
        }
        private void LoadAlbumsDashboard()
        {
            LoadForms(new AlbumsDashboard(this, _context)); // Pass 'this' (MainForm) as reference to Form1
        }
        private void UpdateNavigationButtons()
        {
            // Enable or disable back and forward buttons based on the stack contents
            picBoxBackButton.Enabled = _backStack.Count > 0;
            picBoxForwardButton.Enabled = _forwardStack.Count > 0;
        }

        // This method will be called by the forms to navigate
        public void NavigateToForm(Form form)
        {
            LoadForms(form);
        }

        private void picBoxBackButton_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxBackButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxForwardButton_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxForwardButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picBoxAddAlbum_Click(object sender, EventArgs e)
        {
            this.NavigateToForm(new AddAlbum(this, _context));
        }

        private void picBoxBackButton_Click(object sender, EventArgs e)
        {
            if (_backStack.Count > 0)
            {
                // Move the current form to the forward stack
                Form currentForm = panelBody.Controls[0] as Form;
                if (currentForm != null)
                {
                    _forwardStack.Push(currentForm);
                }

                // Pop the previous form from backStack and show it
                Form lastForm = _backStack.Pop();
                panelBody.Controls.Clear();
                lastForm.TopLevel = false;
                lastForm.Dock = DockStyle.Fill;
                panelBody.Controls.Add(lastForm);
                lastForm.Show();

                // Update navigation buttons
                UpdateNavigationButtons();
            }
        }

        private void picBoxForwardButton_Click(object sender, EventArgs e)
        {
            if (_forwardStack.Count > 0)
            {
                // Move the current form to the back stack
                Form currentForm = panelBody.Controls[0] as Form;
                if (currentForm != null)
                {
                    _backStack.Push(currentForm);
                }

                // Pop the next form from forwardStack and show it
                Form nextForm = _forwardStack.Pop();
                panelBody.Controls.Clear();
                nextForm.TopLevel = false;
                nextForm.Dock = DockStyle.Fill;
                panelBody.Controls.Add(nextForm);
                nextForm.Show();

                // Update navigation buttons
                UpdateNavigationButtons();
            }
        }
    }
}
