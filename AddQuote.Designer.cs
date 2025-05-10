namespace MegaDesk_Fanfan
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            customername = new Label();
            label1 = new Label();
            deskwidth = new Label();
            textBoxcustname = new TextBox();
            numericUpDownDeskdepth = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            numberofdrawers = new Label();
            Material = new Label();
            listBoxmaterial = new ListBox();
            numericUpDownDeskWide = new NumericUpDown();
            rush = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            save = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeskdepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeskWide).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // customername
            // 
            customername.AutoSize = true;
            customername.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            customername.Location = new Point(3, 85);
            customername.Name = "customername";
            customername.Size = new Size(190, 32);
            customername.TabIndex = 0;
            customername.Text = "Customer name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 221);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 4;
            label1.Text = "Desk depth";
            label1.Click += label1_Click;
            // 
            // deskwidth
            // 
            deskwidth.AutoSize = true;
            deskwidth.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            deskwidth.Location = new Point(3, 153);
            deskwidth.Name = "deskwidth";
            deskwidth.Size = new Size(139, 32);
            deskwidth.TabIndex = 2;
            deskwidth.Text = "Desk width";
            // 
            // textBoxcustname
            // 
            textBoxcustname.BackColor = SystemColors.ControlLight;
            textBoxcustname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxcustname.Location = new Point(251, 78);
            textBoxcustname.Name = "textBoxcustname";
            textBoxcustname.PlaceholderText = "       Full  Name";
            textBoxcustname.Size = new Size(324, 39);
            textBoxcustname.TabIndex = 1;
            textBoxcustname.TextAlign = HorizontalAlignment.Center;
            textBoxcustname.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDownDeskdepth
            // 
            numericUpDownDeskdepth.BackColor = SystemColors.ControlLight;
            numericUpDownDeskdepth.DecimalPlaces = 2;
            numericUpDownDeskdepth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownDeskdepth.Increment = new decimal(new int[] { 11, 0, 0, 65536 });
            numericUpDownDeskdepth.Location = new Point(251, 221);
            numericUpDownDeskdepth.Name = "numericUpDownDeskdepth";
            numericUpDownDeskdepth.Size = new Size(180, 39);
            numericUpDownDeskdepth.TabIndex = 5;
            numericUpDownDeskdepth.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.ControlLight;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Increment = new decimal(new int[] { 11, 0, 0, 65536 });
            numericUpDown1.Location = new Point(251, 289);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 39);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // numberofdrawers
            // 
            numberofdrawers.AutoSize = true;
            numberofdrawers.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            numberofdrawers.Location = new Point(3, 289);
            numberofdrawers.Name = "numberofdrawers";
            numberofdrawers.Size = new Size(232, 32);
            numberofdrawers.TabIndex = 6;
            numberofdrawers.Text = "Number of drawers";
            // 
            // Material
            // 
            Material.AutoSize = true;
            Material.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Material.Location = new Point(3, 357);
            Material.Name = "Material";
            Material.Size = new Size(110, 32);
            Material.TabIndex = 8;
            Material.Text = "Material";
            // 
            // listBoxmaterial
            // 
            listBoxmaterial.BackColor = SystemColors.ControlLight;
            listBoxmaterial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxmaterial.FormattingEnabled = true;
            listBoxmaterial.ItemHeight = 32;
            listBoxmaterial.Items.AddRange(new object[] { "None", "laminate", "oak", "pine", "rosewood", "veneer" });
            listBoxmaterial.Location = new Point(251, 357);
            listBoxmaterial.Name = "listBoxmaterial";
            listBoxmaterial.Size = new Size(180, 36);
            listBoxmaterial.TabIndex = 9;
            // 
            // numericUpDownDeskWide
            // 
            numericUpDownDeskWide.BackColor = SystemColors.ControlLight;
            numericUpDownDeskWide.DecimalPlaces = 2;
            numericUpDownDeskWide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownDeskWide.Increment = new decimal(new int[] { 11, 0, 0, 65536 });
            numericUpDownDeskWide.Location = new Point(251, 154);
            numericUpDownDeskWide.Name = "numericUpDownDeskWide";
            numericUpDownDeskWide.Size = new Size(180, 39);
            numericUpDownDeskWide.TabIndex = 3;
            numericUpDownDeskWide.TextAlign = HorizontalAlignment.Center;
            // 
            // rush
            // 
            rush.AutoSize = true;
            rush.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rush.Location = new Point(3, 425);
            rush.Name = "rush";
            rush.Size = new Size(68, 32);
            rush.TabIndex = 10;
            rush.Text = "Rush";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.ControlLightLight;
            dateTimePicker1.Location = new Point(12, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(save);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(numberofdrawers);
            panel1.Controls.Add(rush);
            panel1.Controls.Add(customername);
            panel1.Controls.Add(listBoxmaterial);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Material);
            panel1.Controls.Add(deskwidth);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(textBoxcustname);
            panel1.Controls.Add(numericUpDownDeskWide);
            panel1.Controls.Add(numericUpDownDeskdepth);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 552);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // save
            // 
            save.BackColor = Color.MediumSeaGreen;
            save.Cursor = Cursors.Hand;
            save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.Location = new Point(463, 464);
            save.Name = "save";
            save.Size = new Size(112, 51);
            save.TabIndex = 12;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1120, 576);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddQuote";
            Text = "Add Quote";
            Load += AddQuote_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeskdepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeskWide).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label customername;
        private Label label1;
        private Label deskwidth;
        private TextBox textBoxcustname;
        private NumericUpDown numericUpDownDeskdepth;
        private NumericUpDown numericUpDown1;
        private Label numberofdrawers;
        private Label Material;
        private ListBox listBoxmaterial;
        private NumericUpDown numericUpDownDeskWide;
        private Label rush;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Button save;
    }
}