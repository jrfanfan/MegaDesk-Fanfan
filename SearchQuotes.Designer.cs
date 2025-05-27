namespace MegaDesk_Fanfan
{
    partial class SearchQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            labelSearch = new Label();
            comboBoxSearch = new ComboBox();
            buttonSearch = new Button();
            dataGridViewSearch = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe Script", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelSearch.ForeColor = Color.Salmon;
            labelSearch.Location = new Point(217, 9);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(663, 53);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Search Quotes For A Surface Material";
            labelSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.BackColor = SystemColors.GradientInactiveCaption;
            comboBoxSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBoxSearch.ForeColor = SystemColors.HotTrack;
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Items.AddRange(new object[] { "", "laminate", "Oak", "Pine", "Rosewood", "Veneer" });
            comboBoxSearch.Location = new Point(849, 65);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(182, 40);
            comboBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.BackgroundImage = (Image)resources.GetObject("buttonSearch.BackgroundImage");
            buttonSearch.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearch.FlatAppearance.BorderColor = Color.Teal;
            buttonSearch.FlatAppearance.BorderSize = 4;
            buttonSearch.Location = new Point(1037, 65);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(51, 40);
            buttonSearch.TabIndex = 2;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click_1;
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.AllowUserToAddRows = false;
            dataGridViewSearch.AllowUserToDeleteRows = false;
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Location = new Point(10, 123);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.ReadOnly = true;
            dataGridViewSearch.RowHeadersWidth = 62;
            dataGridViewSearch.Size = new Size(1098, 449);
            dataGridViewSearch.TabIndex = 3;
            // 
            // SearchQuotes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1120, 576);
            Controls.Add(dataGridViewSearch);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxSearch);
            Controls.Add(labelSearch);
            MaximizeBox = false;
            Name = "SearchQuotes";
            Text = "SearchQuotes";
            Load += SearchQuotes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch;
        private ComboBox comboBoxSearch;
        private Button buttonSearch;
        private DataGridView dataGridViewSearch;
    }
}