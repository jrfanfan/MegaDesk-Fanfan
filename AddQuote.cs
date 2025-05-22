using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Fanfan
{
    public partial class AddQuote : Form
    {
        // Define rush order day limits
        private const int MIN_RUSH = 3;
        private const int MAX_RUSH = 14;

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
            DeskQuote quote = new DeskQuote(customerName.Text, desk, parsedRushDays, 0);
            quote.CalculateQuote();

            // show the quote
            MessageBox.Show($"Quote for {customerName.Text}:\n" +
                            $"Desk Size: {desk.Width} x {desk.Depth}\n" +
                            $"Number of Drawers: {desk.NumberOfDrawers}\n" +
                            $"Surface Material: {desk.SurfaceMaterial}\n" +
                            $"Rush Order Days: {quote.RushOrderDays}\n" +
                            $"Total Price: {quote.QuotePrice:C}");
            // conditionally save the quote
            if (MessageBox.Show("Do you want to save this quote?", "Save Quote", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // SaveQuote(quote); // Removed because the method does not exist; saving is handled below.
            }
            // Store the desk quotes in an appended JSON file named quotes.json.
            string json = JsonConvert.SerializeObject(quote);
            System.IO.File.AppendAllText("quotes.json", json);
            System.IO.File.AppendAllText("quotes.json", Environment.NewLine);
            // Show a success message
            MessageBox.Show("Quote saved successfully!");
            // Optionally, you can clear the form fields after saving
            customerName.Clear();
            deskWide.Clear();
            deskDepth.Clear();
            numberDrawers.Clear();
            listBoxmaterial.ClearSelected();
            rushDays.Clear();
        }
    }
}
