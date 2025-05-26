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
    // Assuming it has properties like Width, Depth, NumberOfDrawers, and SurfaceMaterial.
    // The Quote class represents a quote for a desk order.
    // It contains properties for customer name, desk details, rush order days, quote price, and quote date.
    // If the Desk class is not defined, you can define it here or ensure it's included in the project.
    // Example Desk class definition (if not already defined)
    public class DeskQ
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public string? SurfaceMaterial { get; set; }
    }

    public class Quote
    {
        public string? CustomerName { get; set; }
        public required DeskQ Desk { get; set; } // Assuming Desk is a class defined elsewhere
        public int Width => Desk.Width; // Assuming Desk has Width property
        public int Depth => Desk.Depth; // Assuming Desk has Depth property
        public int NumberOfDrawers => Desk.NumberOfDrawers; // Assuming Desk has NumberOfDrawers property
        public string? SurfaceMaterial => Desk.SurfaceMaterial; // Assuming Desk has SurfaceMaterial property
        public int RushOrderDays { get; set; }
        public int QuotePrice { get; set; }
        public DateTime QuoteDate { get; set; }

    }

    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            
        }

        private async void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to View All Quotes!");
            // Read the quotes from the JSON file and bind to the DataGridView
            string filePath = "quotes.json"; // Adjust the path as needed
            // reding the quotes from the JSON file
            string json = await File.ReadAllTextAsync(filePath);
            // Deserialize the JSON data into a list of Quote objects
            List<Quote> quotes = JsonConvert.DeserializeObject<List<Quote>>(json) ?? new List<Quote>();

            // Create and set up the DataTable
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("CustomerName", typeof(string));
            dataTable1.Columns.Add("Width", typeof(int));
            dataTable1.Columns.Add("Depth", typeof(int));
            dataTable1.Columns.Add("NumberOfDrawers", typeof(int));
            dataTable1.Columns.Add("SurfaceMaterial", typeof(string));
            dataTable1.Columns.Add("RushOrderDays", typeof(int));
            dataTable1.Columns.Add("QuotePrice", typeof(int));
            dataTable1.Columns.Add("QuoteDate", typeof(string));

            // foreach quote, create a DataRow and add it to the DataTable
            foreach (var quote in quotes)
            {
                DataRow row = dataTable1.NewRow();
                row["CustomerName"] = quote.CustomerName;
                row["Width"] = quote.Width;
                row["Depth"] = quote.Depth;
                row["NumberOfDrawers"] = quote.NumberOfDrawers;
                row["SurfaceMaterial"] = quote.SurfaceMaterial;
                row["RushOrderDays"] = quote.RushOrderDays;
                row["QuotePrice"] = quote.QuotePrice;
                row["QuoteDate"] = quote.QuoteDate.ToString("MM/dd/yyyy");
                dataTable1.Rows.Add(row);
            }
            dataGridView1.DataSource = dataTable1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        }
    }

