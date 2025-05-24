// Created by Fanfan
// This file contains the AddQuote class, which is responsible for handling the quote creation process in the MegaDesk application.
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace MegaDesk_Fanfan
{
    public partial class AddQuote : Form
    {
        // Define rush order day limits
        private const int MIN_RUSH = 3;
        private const int MAX_RUSH = 14;
        // datetime format
        private const string DATE_FORMAT = "MM/dd/yyyy";


        public AddQuote()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(customerName.Text))
            {
                _ = MessageBox.Show("Please enter a customer name.");
                return;
            }
            if (!int.TryParse(deskWide.Text, out int width) || width < Desk.MIN_WIDTH || width > Desk.MAX_WIDTH)
            {
                _ = MessageBox.Show($"Width must be between {Desk.MIN_WIDTH} and {Desk.MAX_WIDTH}.");
                return;
            }
            if (!int.TryParse(deskDepth.Text, out int depth) || depth < Desk.MIN_DEPTH || depth > Desk.MAX_DEPTH)
            {
                _ = MessageBox.Show($"Depth must be between {Desk.MIN_DEPTH} and {Desk.MAX_DEPTH}.");
                return;
            }
            if (!int.TryParse(numberDrawers.Text, out int drawers) || drawers < 0 || drawers > Desk.MAX_DRAWERS)
            {
                _ = MessageBox.Show($"Number of drawers must be between 0 and {Desk.MAX_DRAWERS}.");
                return;
            }
            if (string.IsNullOrWhiteSpace(listBoxmaterial.Text) || listBoxmaterial.Text == "None")
            {
                _ = MessageBox.Show("Please select a surface material.");
                return;
            }
            if (string.IsNullOrWhiteSpace(rushDays.Text) || !int.TryParse(rushDays.Text, out int parsedRushDays) || parsedRushDays < MIN_RUSH || parsedRushDays > MAX_RUSH)
            {
                _ = MessageBox.Show($"Rush order days must be between {MIN_RUSH} and {MAX_RUSH}.");
                return;
            }

            // Create a new DeskQuote object
            Desk desk = new Desk(width, depth, drawers, listBoxmaterial.Text);
            DeskQuote quote = new DeskQuote(
                customerName.Text,
                desk,
                int.Parse(rushDays.Text),
                DateTime.Now
            );
            quote.CalculateQuote();

            // show the quote
            MessageBox.Show($"Quote for {customerName.Text}:\n" +
                            $"Desk Size: {desk.Width} x {desk.Depth}\n" +
                            $"Number of Drawers: {desk.NumberOfDrawers}\n" +
                            $"Surface Material: {desk.SurfaceMaterial}\n" +
                            $"Rush Order Days: {quote.RushOrderDays}\n" +
                            $"Total Price: {quote.QuotePrice:C}\n" +
                            $"Date: {quote.QuoteDate.ToString(DATE_FORMAT)}");
            // conditionally save the quote
            if (MessageBox.Show("Do you want to save this quote?", "Save Quote", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // SaveQuote(quote); // Removed because the method does not exist; saving is handled below.
            }
            // Store the desk quotes  and append them to a JSON file named quotes.json.
            // Create a list to hold the quotes.
            List<DeskQuote> quotes = new List<DeskQuote>{quote};
            string json = JsonConvert.SerializeObject(quotes, Newtonsoft.Json.Formatting.Indented);
            // save and append the quotes to the list
            if (!File.Exists("quotes.json"))
            {
                // If the file does not exist, create it
                File.WriteAllText("quotes.json", json);
            }
            else
            {
                // If the file exists, append the new quote in an array format
                string NewLineHandli = File.ReadAllText("quotes.json");
                // Remove the last closing bracket
                NewLineHandli = NewLineHandli.TrimEnd(']');
                // Append the new quote
                File.WriteAllText("quotes.json", NewLineHandli + "," + json.TrimStart('[').TrimEnd(']') + "]");
            }

            // Clear the input fields
            customerName.Clear();
            deskWide.Clear();
            deskDepth.Clear();
            numberDrawers.Clear();
            listBoxmaterial.ClearSelected();
            rushDays.Clear();
            // Reset the surface material to default
            listBoxmaterial.SelectedIndex = -1;
            // Show a success message
            MessageBox.Show("Quote saved successfully!");

        }
    }
}
