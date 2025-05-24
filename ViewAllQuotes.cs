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
        public int Price { get; set; } 
        public int RushOrder { get; set; } 

        public int DrawerCount { get; set; }

        public int SurfaceMaterial { get; set; }

        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        //date
        public DateTime Date { get; set; }
       
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

                // Bind the quotes to the DataGridView
                dataGridView1.DataSource = quotes;
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
