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
    // This class represents a search for quotes based on various criteria.

    public partial class SearchQuotes : Form
    {
        public class DeskQSearch
        {
            public int Width { get; set; }
            public int Depth { get; set; }
            public int NumberOfDrawers { get; set; }
            public string? SurfaceMaterial { get; set; }
        }

        public class QuoteSearch
        {
            public string? CustomerName { get; set; }
            public DeskQSearch? Desk { get; set; } // Made nullable to satisfy non-nullable property rule
            public int Width => Desk?.Width ?? 0; // Safely access Desk.Width or return 0 if Desk is null
            public int Depth => Desk?.Depth ?? 0; // Safely access Desk.Depth or return 0 if Desk is null
            public int NumberOfDrawers => Desk?.NumberOfDrawers ?? 0; // Safely access Desk.NumberOfDrawers or return 0 if Desk is null
            public string? SurfaceMaterial => Desk?.SurfaceMaterial; // Safely access Desk.SurfaceMaterial or return null if Desk is null
            public int RushOrderDays { get; set; }
            public int QuotePrice { get; set; }
            public DateTime QuoteDate { get; set; }
        }

        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            // Read the quotes from the JSON file and bind to the DataGridView
            string filePath = "quotes.json"; // Adjust the path as needed
            // Create a list to hold the quotes
            List<QuoteSearch> quotes = new List<QuoteSearch>();
            // deserialize the JSON data into a list of QuoteSearch objects
            string json = System.IO.File.ReadAllText(filePath);
            quotes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<QuoteSearch>>(json) ?? new List<QuoteSearch>();
            // Use selected criteria to filter the quotes
            string selectedCriteria = comboBoxSearch.SelectedItem?.ToString() ?? string.Empty;
            var filteredQuotes = quotes.Where(q => q.SurfaceMaterial?.Contains(selectedCriteria, StringComparison.OrdinalIgnoreCase) == true).ToList();
            // if no quotes match the criteria, show a message box
            if (filteredQuotes.Count == 0)
            {
                MessageBox.Show("No quotes found matching the selected criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dataGridViewSearch.DataSource = filteredQuotes;

        }
    }
}
