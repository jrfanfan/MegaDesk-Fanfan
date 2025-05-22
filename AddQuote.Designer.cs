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
            labelCustomerName = new Label();
            labelDeskDepth = new Label();
            labelDeskWidth = new Label();
            customerName = new TextBox();
            labelNumberofdrawers = new Label();
            labelMaterial = new Label();
            listBoxmaterial = new ListBox();
            labelRushDays = new Label();
            dateTime = new DateTimePicker();
            panel1 = new Panel();
            labelDate = new Label();
            rushDays = new TextBox();
            numberDrawers = new TextBox();
            deskDepth = new TextBox();
            deskWide = new TextBox();
            save = new Button();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCustomerName.Location = new Point(3, 85);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(190, 32);
            labelCustomerName.TabIndex = 3;
            labelCustomerName.Text = "Customer name";
            // 
            // labelDeskDepth
            // 
            labelDeskDepth.AutoSize = true;
            labelDeskDepth.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDeskDepth.Location = new Point(3, 221);
            labelDeskDepth.Name = "labelDeskDepth";
            labelDeskDepth.Size = new Size(138, 32);
            labelDeskDepth.TabIndex = 7;
            labelDeskDepth.Text = "Desk depth";
            labelDeskDepth.Click += label1_Click;
            // 
            // labelDeskWidth
            // 
            labelDeskWidth.AutoSize = true;
            labelDeskWidth.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDeskWidth.Location = new Point(3, 153);
            labelDeskWidth.Name = "labelDeskWidth";
            labelDeskWidth.Size = new Size(139, 32);
            labelDeskWidth.TabIndex = 5;
            labelDeskWidth.Text = "Desk width";
            // 
            // customerName
            // 
            customerName.BackColor = SystemColors.ControlLight;
            customerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerName.Location = new Point(251, 78);
            customerName.Name = "customerName";
            customerName.PlaceholderText = "       Full  Name";
            customerName.Size = new Size(324, 39);
            customerName.TabIndex = 4;
            customerName.TextAlign = HorizontalAlignment.Center;
            customerName.TextChanged += textBox1_TextChanged;
            // 
            // labelNumberofdrawers
            // 
            labelNumberofdrawers.AutoSize = true;
            labelNumberofdrawers.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNumberofdrawers.Location = new Point(3, 289);
            labelNumberofdrawers.Name = "labelNumberofdrawers";
            labelNumberofdrawers.Size = new Size(232, 32);
            labelNumberofdrawers.TabIndex = 9;
            labelNumberofdrawers.Text = "Number of drawers";
            // 
            // labelMaterial
            // 
            labelMaterial.AutoSize = true;
            labelMaterial.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMaterial.Location = new Point(3, 357);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(110, 32);
            labelMaterial.TabIndex = 11;
            labelMaterial.Text = "Material";
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
            listBoxmaterial.Size = new Size(150, 36);
            listBoxmaterial.TabIndex = 12;
            // 
            // labelRushDays
            // 
            labelRushDays.AutoSize = true;
            labelRushDays.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelRushDays.Location = new Point(3, 425);
            labelRushDays.Name = "labelRushDays";
            labelRushDays.Size = new Size(131, 32);
            labelRushDays.TabIndex = 13;
            labelRushDays.Text = "Rush Days";
            // 
            // dateTime
            // 
            dateTime.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            dateTime.Location = new Point(251, 26);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(324, 31);
            dateTime.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(rushDays);
            panel1.Controls.Add(numberDrawers);
            panel1.Controls.Add(deskDepth);
            panel1.Controls.Add(deskWide);
            panel1.Controls.Add(save);
            panel1.Controls.Add(dateTime);
            panel1.Controls.Add(labelNumberofdrawers);
            panel1.Controls.Add(labelRushDays);
            panel1.Controls.Add(labelCustomerName);
            panel1.Controls.Add(listBoxmaterial);
            panel1.Controls.Add(labelDeskDepth);
            panel1.Controls.Add(labelMaterial);
            panel1.Controls.Add(labelDeskWidth);
            panel1.Controls.Add(customerName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 552);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(3, 26);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(67, 32);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date";
            // 
            // rushDays
            // 
            rushDays.BackColor = SystemColors.ControlLight;
            rushDays.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rushDays.Location = new Point(251, 426);
            rushDays.Name = "rushDays";
            rushDays.Size = new Size(150, 39);
            rushDays.TabIndex = 14;
            // 
            // numberDrawers
            // 
            numberDrawers.BackColor = SystemColors.ControlLight;
            numberDrawers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberDrawers.Location = new Point(251, 292);
            numberDrawers.Name = "numberDrawers";
            numberDrawers.Size = new Size(150, 39);
            numberDrawers.TabIndex = 10;
            // 
            // deskDepth
            // 
            deskDepth.BackColor = SystemColors.ControlLight;
            deskDepth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deskDepth.Location = new Point(251, 221);
            deskDepth.Name = "deskDepth";
            deskDepth.Size = new Size(150, 39);
            deskDepth.TabIndex = 8;
            // 
            // deskWide
            // 
            deskWide.BackColor = SystemColors.ControlLight;
            deskWide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deskWide.Location = new Point(251, 156);
            deskWide.Name = "deskWide";
            deskWide.Size = new Size(150, 39);
            deskWide.TabIndex = 6;
            // 
            // save
            // 
            save.BackColor = Color.MediumSeaGreen;
            save.Cursor = Cursors.Hand;
            save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.Location = new Point(251, 476);
            save.Name = "save";
            save.Size = new Size(150, 51);
            save.TabIndex = 15;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaption;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = SystemColors.HotTrack;
            richTextBox1.Location = new Point(611, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(497, 552);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1120, 576);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddQuote";
            Text = "Required Inputs and Input Constraints:";
            Load += AddQuote_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCustomerName;
        private Label labelDeskDepth;
        private Label labelDeskWidth;
        private TextBox customerName;
        private Label labelNumberofdrawers;
        private Label labelMaterial;
        private ListBox listBoxmaterial;
        private Label labelRushDays;
        private DateTimePicker dateTime;
        private Panel panel1;
        private Button save;
        private TextBox deskWide;
        private TextBox rushDays;
        private TextBox numberDrawers;
        private TextBox deskDepth;
        private Label labelDate;
        private RichTextBox richTextBox1;
    }
}