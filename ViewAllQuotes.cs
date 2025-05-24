// Description: This file contains the ViewAllQuotes class, which is responsible for displaying all quotes in a DataGridView.
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json; // Install via NuGet: Newtonsoft.Json
using System.Windows.Forms;
using System.Linq;
using System.Data;

namespace MegaDesk_Fanfan
{
    // Desk class definition
    // The Desk class is defined elsewhere in the project.

    // Define the Quote class if it does not exist elsewhere
    public class Quote
    {
        public string? CustomerName { get; set; }
        public int QuotePrice { get; set; } 
        public int RushOrderDays { get; set; } 

        public int NumberOfDrawers { get; set; }

        public string? SurfaceMaterial { get; set; }

        public int Width { get; set; }
        public int Depth { get; set; }
        //date
        public DateTime QuoteDate { get; set; }

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
            // Read the quotes from the JSON file and bind to the DataGridView
            string filePath = "quotes.json"; // Adjust the path as needed
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<Quote> quotes = JsonConvert.DeserializeObject<List<Quote>>(json) ?? new List<Quote>();

                // Bind the quotes to the DataGridView with a mapping
                // Create a DataTable to hold the data
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Price");
                dataTable.Columns.Add("Rush");
                dataTable.Columns.Add("Drawer");
                dataTable.Columns.Add("Material");
                dataTable.Columns.Add("Width");
                dataTable.Columns.Add("Depth");
                dataTable.Columns.Add("Date");

                foreach (var quote in quotes)
                {
                    dataTable.Rows.Add(quote.CustomerName, quote.QuotePrice, quote.RushOrderDays,
                        quote.NumberOfDrawers, quote.SurfaceMaterial,
                        quote.Width, quote.Depth, quote.QuoteDate);
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No quotes found.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("You clicked on a cell!");

        }

        
    }
}
