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
            buttonsearch = new Button();
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe Script", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelSearch.ForeColor = Color.Tomato;
            labelSearch.Location = new Point(199, 65);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(663, 53);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Search Quotes For A Surface Material";
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.BackColor = SystemColors.InactiveCaption;
            comboBoxSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSearch.ForeColor = Color.FromArgb(0, 0, 192);
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Items.AddRange(new object[] { "", "laminate", "oak", "pine", "rosewood", "veneer" });
            comboBoxSearch.Location = new Point(851, 131);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(182, 35);
            comboBoxSearch.TabIndex = 1;
            comboBoxSearch.SelectedIndexChanged += comboBoxSearch_SelectedIndexChanged;
            // 
            // buttonsearch
            // 
            buttonsearch.BackgroundImage = (Image)resources.GetObject("buttonsearch.BackgroundImage");
            buttonsearch.BackgroundImageLayout = ImageLayout.Center;
            buttonsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonsearch.ForeColor = Color.Olive;
            buttonsearch.Location = new Point(1033, 131);
            buttonsearch.Name = "buttonsearch";
            buttonsearch.Size = new Size(64, 35);
            buttonsearch.TabIndex = 2;
            buttonsearch.UseVisualStyleBackColor = true;
            buttonsearch.Click += buttonsearch_Click;
            // 
            // SearchQuotes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1120, 576);
            Controls.Add(buttonsearch);
            Controls.Add(comboBoxSearch);
            Controls.Add(labelSearch);
            Name = "SearchQuotes";
            Text = "SearchQuotes";
            Load += SearchQuotes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch;
        private ComboBox comboBoxSearch;
        private Button buttonsearch;
    }
}