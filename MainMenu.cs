using System.Xml.Linq;

namespace MegaDesk_Fanfan
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addnewquote_Click(object sender, EventArgs e)
        {
            // Open the Add New Quote form
            AddQuote addQuote = new AddQuote();
            addQuote.Show();




        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // load view quote
            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open the serach quote form
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Show();


        }

        private void exit_Click(object sender, EventArgs e)
        {
            // Close the appplication
            Application.Exit();

        }
    }
}
