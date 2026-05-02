namespace BillingForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IcedCappuccinoRB = new System.Windows.Forms.RadioButton();
            this.IcedLatteRB = new System.Windows.Forms.RadioButton();
            this.LatteRB = new System.Windows.Forms.RadioButton();
            this.EspressoRB = new System.Windows.Forms.RadioButton();
            this.CappuccinoRB = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TaxCB = new System.Windows.Forms.CheckBox();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.CalculateBT = new System.Windows.Forms.Button();
            this.ClearBT = new System.Windows.Forms.Button();
            this.ItemAmountTB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SubTotalTB = new System.Windows.Forms.TextBox();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.TaxTB = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItemAmountTB);
            this.groupBox1.Controls.Add(this.ClearBT);
            this.groupBox1.Controls.Add(this.CalculateBT);
            this.groupBox1.Controls.Add(this.QuantityTB);
            this.groupBox1.Controls.Add(this.TaxCB);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Informations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IcedCappuccinoRB);
            this.groupBox2.Controls.Add(this.IcedLatteRB);
            this.groupBox2.Controls.Add(this.LatteRB);
            this.groupBox2.Controls.Add(this.EspressoRB);
            this.groupBox2.Controls.Add(this.CappuccinoRB);
            this.groupBox2.Location = new System.Drawing.Point(253, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coffee Selections";
            // 
            // IcedCappuccinoRB
            // 
            this.IcedCappuccinoRB.AutoSize = true;
            this.IcedCappuccinoRB.Location = new System.Drawing.Point(6, 145);
            this.IcedCappuccinoRB.Name = "IcedCappuccinoRB";
            this.IcedCappuccinoRB.Size = new System.Drawing.Size(153, 24);
            this.IcedCappuccinoRB.TabIndex = 4;
            this.IcedCappuccinoRB.TabStop = true;
            this.IcedCappuccinoRB.Text = "Iced Cappuccino";
            this.IcedCappuccinoRB.UseVisualStyleBackColor = true;
            // 
            // IcedLatteRB
            // 
            this.IcedLatteRB.AutoSize = true;
            this.IcedLatteRB.Location = new System.Drawing.Point(6, 115);
            this.IcedLatteRB.Name = "IcedLatteRB";
            this.IcedLatteRB.Size = new System.Drawing.Size(106, 24);
            this.IcedLatteRB.TabIndex = 3;
            this.IcedLatteRB.TabStop = true;
            this.IcedLatteRB.Text = "Iced Latte";
            this.IcedLatteRB.UseVisualStyleBackColor = true;
            // 
            // LatteRB
            // 
            this.LatteRB.AutoSize = true;
            this.LatteRB.Location = new System.Drawing.Point(6, 85);
            this.LatteRB.Name = "LatteRB";
            this.LatteRB.Size = new System.Drawing.Size(71, 24);
            this.LatteRB.TabIndex = 2;
            this.LatteRB.TabStop = true;
            this.LatteRB.Text = "Latte";
            this.LatteRB.UseVisualStyleBackColor = true;
            // 
            // EspressoRB
            // 
            this.EspressoRB.AutoSize = true;
            this.EspressoRB.Location = new System.Drawing.Point(6, 55);
            this.EspressoRB.Name = "EspressoRB";
            this.EspressoRB.Size = new System.Drawing.Size(101, 24);
            this.EspressoRB.TabIndex = 1;
            this.EspressoRB.TabStop = true;
            this.EspressoRB.Text = "Espresso";
            this.EspressoRB.UseVisualStyleBackColor = true;
            // 
            // CappuccinoRB
            // 
            this.CappuccinoRB.AutoSize = true;
            this.CappuccinoRB.Cursor = System.Windows.Forms.Cursors.Default;
            this.CappuccinoRB.Location = new System.Drawing.Point(6, 25);
            this.CappuccinoRB.Name = "CappuccinoRB";
            this.CappuccinoRB.Size = new System.Drawing.Size(118, 24);
            this.CappuccinoRB.TabIndex = 0;
            this.CappuccinoRB.Text = "Cappuccino";
            this.CappuccinoRB.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(6, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Item Amount";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Quantity";
            // 
            // TaxCB
            // 
            this.TaxCB.AutoSize = true;
            this.TaxCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.TaxCB.Location = new System.Drawing.Point(6, 67);
            this.TaxCB.Name = "TaxCB";
            this.TaxCB.Size = new System.Drawing.Size(102, 24);
            this.TaxCB.TabIndex = 4;
            this.TaxCB.Text = "Takeout?";
            this.TaxCB.UseVisualStyleBackColor = true;
            this.TaxCB.CheckedChanged += new System.EventHandler(this.TaxCB_CheckedChanged);
            // 
            // QuantityTB
            // 
            this.QuantityTB.Location = new System.Drawing.Point(114, 25);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(102, 26);
            this.QuantityTB.TabIndex = 5;
            this.QuantityTB.TextChanged += new System.EventHandler(this.QuantityTB_TextChanged);
            // 
            // CalculateBT
            // 
            this.CalculateBT.Location = new System.Drawing.Point(6, 110);
            this.CalculateBT.Name = "CalculateBT";
            this.CalculateBT.Size = new System.Drawing.Size(102, 84);
            this.CalculateBT.TabIndex = 6;
            this.CalculateBT.Text = "Calculate Selection";
            this.CalculateBT.UseVisualStyleBackColor = true;
            this.CalculateBT.Click += new System.EventHandler(this.CalculateBT_Click);
            // 
            // ClearBT
            // 
            this.ClearBT.Location = new System.Drawing.Point(114, 110);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(102, 84);
            this.ClearBT.TabIndex = 7;
            this.ClearBT.Text = "Clear for Next Item";
            this.ClearBT.UseVisualStyleBackColor = true;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // ItemAmountTB
            // 
            this.ItemAmountTB.Location = new System.Drawing.Point(114, 200);
            this.ItemAmountTB.Name = "ItemAmountTB";
            this.ItemAmountTB.Size = new System.Drawing.Size(102, 26);
            this.ItemAmountTB.TabIndex = 8;
            this.ItemAmountTB.TextChanged += new System.EventHandler(this.ItemAmountTB_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TaxTB);
            this.groupBox3.Controls.Add(this.TotalTB);
            this.groupBox3.Controls.Add(this.SubTotalTB);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(5, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 120);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(6, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 26);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Subtotal";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(6, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 26);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Total Due";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(6, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 26);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "Tax (if Takeout)";
            // 
            // SubTotalTB
            // 
            this.SubTotalTB.Location = new System.Drawing.Point(142, 16);
            this.SubTotalTB.Name = "SubTotalTB";
            this.SubTotalTB.Size = new System.Drawing.Size(114, 26);
            this.SubTotalTB.TabIndex = 5;
            this.SubTotalTB.TextChanged += new System.EventHandler(this.SubTotalTB_TextChanged);
            // 
            // TotalTB
            // 
            this.TotalTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TotalTB.Location = new System.Drawing.Point(142, 80);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(114, 26);
            this.TotalTB.TabIndex = 6;
            this.TotalTB.TextChanged += new System.EventHandler(this.TotalTB_TextChanged);
            // 
            // TaxTB
            // 
            this.TaxTB.Location = new System.Drawing.Point(142, 48);
            this.TaxTB.Name = "TaxTB";
            this.TaxTB.Size = new System.Drawing.Size(114, 26);
            this.TaxTB.TabIndex = 7;
            this.TaxTB.TextChanged += new System.EventHandler(this.TaxTB_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateSelectionToolStripMenuItem,
            this.clearItemToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // calculateSelectionToolStripMenuItem
            // 
            this.calculateSelectionToolStripMenuItem.Name = "calculateSelectionToolStripMenuItem";
            this.calculateSelectionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.calculateSelectionToolStripMenuItem.Text = "Calculate Selection";
            this.calculateSelectionToolStripMenuItem.Click += new System.EventHandler(this.calculateSelectionToolStripMenuItem_Click);
            // 
            // clearItemToolStripMenuItem
            // 
            this.clearItemToolStripMenuItem.Name = "clearItemToolStripMenuItem";
            this.clearItemToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clearItemToolStripMenuItem.Text = "Clear Item";
            this.clearItemToolStripMenuItem.Click += new System.EventHandler(this.clearItemToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 443);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Billing Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton IcedCappuccinoRB;
        private System.Windows.Forms.RadioButton IcedLatteRB;
        private System.Windows.Forms.RadioButton LatteRB;
        private System.Windows.Forms.RadioButton EspressoRB;
        private System.Windows.Forms.RadioButton CappuccinoRB;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox TaxCB;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.Button CalculateBT;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.TextBox ItemAmountTB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TaxTB;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.TextBox SubTotalTB;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

