using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Fanfan
{
    // Define the Quote class if it does not exist elsewhere
    public class Quote
    {
        public string? CustomerName { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        // Add other properties as needed
        public string? Material { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawerCount { get; set; }
        public string? RushOrder { get; set; }
        
        
    }

    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to View All Quotes!");
            // Load quotes from a json file and bind it into DataGridView
            string filePath = "quotes.json"; // Adjust the path as necessary
            string json = System.IO.File.ReadAllText(filePath);
            var quotes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Quote>>(json) ?? new List<Quote>();
            // Set the DataGridView's DataSource to the list of quotes
            dataGridView1.AutoGenerateColumns = true; // Enable auto generation of columns
            dataGridView1.DataSource = quotes;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("You clicked on a cell!");

        }
    }
}
