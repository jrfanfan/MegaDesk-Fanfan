namespace MegaDesk_Fanfan
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            addnewquote = new Button();
            viewQuote = new Button();
            SearchQuotes = new Button();
            exit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addnewquote
            // 
            addnewquote.BackColor = SystemColors.ActiveCaption;
            addnewquote.Location = new Point(34, 63);
            addnewquote.Margin = new Padding(4);
            addnewquote.Name = "addnewquote";
            addnewquote.Size = new Size(346, 93);
            addnewquote.TabIndex = 1;
            addnewquote.Text = "Add New Quote";
            addnewquote.UseVisualStyleBackColor = false;
            addnewquote.Click += addnewquote_Click;
            // 
            // viewQuote
            // 
            viewQuote.BackColor = SystemColors.ActiveCaption;
            viewQuote.Location = new Point(34, 164);
            viewQuote.Margin = new Padding(4);
            viewQuote.Name = "viewQuote";
            viewQuote.Size = new Size(346, 93);
            viewQuote.TabIndex = 2;
            viewQuote.Text = "View All Quotes";
            viewQuote.UseVisualStyleBackColor = false;
            viewQuote.Click += button1_Click;
            // 
            // SearchQuotes
            // 
            SearchQuotes.BackColor = SystemColors.ActiveCaption;
            SearchQuotes.Location = new Point(34, 265);
            SearchQuotes.Margin = new Padding(4);
            SearchQuotes.Name = "SearchQuotes";
            SearchQuotes.Size = new Size(346, 93);
            SearchQuotes.TabIndex = 3;
            SearchQuotes.Text = "Search Quotes";
            SearchQuotes.UseVisualStyleBackColor = false;
            SearchQuotes.Click += button3_Click;
            // 
            // exit
            // 
            exit.BackColor = SystemColors.ActiveCaption;
            exit.Location = new Point(34, 366);
            exit.Margin = new Padding(4);
            exit.Name = "exit";
            exit.Size = new Size(346, 93);
            exit.TabIndex = 4;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(425, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(631, 396);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainMenu
            // 
            AcceptButton = exit;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1120, 576);
            Controls.Add(pictureBox1);
            Controls.Add(exit);
            Controls.Add(SearchQuotes);
            Controls.Add(viewQuote);
            Controls.Add(addnewquote);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "MegaDesk";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addnewquote;
        private Button viewQuote;
        private Button SearchQuotes;
        private Button exit;
        private PictureBox pictureBox1;
    }
}
