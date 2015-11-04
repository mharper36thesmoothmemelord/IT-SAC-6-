namespace Price_Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Title = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SoleMaterial = new System.Windows.Forms.Label();
            this.ShoeColour = new System.Windows.Forms.Label();
            this.ShoeType = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CustomPrice = new System.Windows.Forms.Label();
            this.PriceColour = new System.Windows.Forms.TextBox();
            this.PriceSole = new System.Windows.Forms.TextBox();
            this.PriceType = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.BackgroundImage = global::Price_Calculator.Properties.Resources.light_wood_texture;
            this.LayoutPanel.ColumnCount = 3;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.LayoutPanel.Controls.Add(this.Title, 1, 0);
            this.LayoutPanel.Controls.Add(this.Company, 0, 0);
            this.LayoutPanel.Controls.Add(this.comboBox3, 2, 2);
            this.LayoutPanel.Controls.Add(this.comboBox1, 0, 2);
            this.LayoutPanel.Controls.Add(this.SoleMaterial, 0, 1);
            this.LayoutPanel.Controls.Add(this.ShoeColour, 1, 1);
            this.LayoutPanel.Controls.Add(this.ShoeType, 2, 1);
            this.LayoutPanel.Controls.Add(this.comboBox2, 1, 2);
            this.LayoutPanel.Controls.Add(this.CustomPrice, 1, 4);
            this.LayoutPanel.Controls.Add(this.PriceColour, 1, 3);
            this.LayoutPanel.Controls.Add(this.PriceSole, 0, 3);
            this.LayoutPanel.Controls.Add(this.PriceType, 2, 3);
            this.LayoutPanel.Controls.Add(this.TotalTextBox, 1, 5);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 6;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LayoutPanel.Size = new System.Drawing.Size(1088, 575);
            this.LayoutPanel.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(365, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(356, 115);
            this.Title.TabIndex = 0;
            this.Title.Text = "Shoe Price Calculator";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.BackColor = System.Drawing.Color.Transparent;
            this.Company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Company.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company.Location = new System.Drawing.Point(3, 0);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(356, 115);
            this.Company.TabIndex = 1;
            this.Company.Text = "Hot Shoe Shuffle 2015";
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Balmoral ",
            "Brouge",
            "Demi-Boot",
            "Dress Pump",
            "Loafer",
            "Oxford",
            "Ranch Boot",
            "Sandal ",
            "Shenandoah"});
            this.comboBox3.Location = new System.Drawing.Point(727, 233);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(358, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Leather\t",
            "Rubber\t",
            "Composite"});
            this.comboBox1.Location = new System.Drawing.Point(3, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // SoleMaterial
            // 
            this.SoleMaterial.AutoSize = true;
            this.SoleMaterial.BackColor = System.Drawing.Color.Transparent;
            this.SoleMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoleMaterial.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoleMaterial.Location = new System.Drawing.Point(3, 115);
            this.SoleMaterial.Name = "SoleMaterial";
            this.SoleMaterial.Size = new System.Drawing.Size(356, 115);
            this.SoleMaterial.TabIndex = 7;
            this.SoleMaterial.Text = "Select Sole Material ";
            this.SoleMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ShoeColour
            // 
            this.ShoeColour.AutoSize = true;
            this.ShoeColour.BackColor = System.Drawing.Color.Transparent;
            this.ShoeColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShoeColour.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoeColour.Location = new System.Drawing.Point(365, 115);
            this.ShoeColour.Name = "ShoeColour";
            this.ShoeColour.Size = new System.Drawing.Size(356, 115);
            this.ShoeColour.TabIndex = 8;
            this.ShoeColour.Text = "Select Shoe Colour";
            this.ShoeColour.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ShoeType
            // 
            this.ShoeType.AutoSize = true;
            this.ShoeType.BackColor = System.Drawing.Color.Transparent;
            this.ShoeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShoeType.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoeType.Location = new System.Drawing.Point(727, 115);
            this.ShoeType.Name = "ShoeType";
            this.ShoeType.Size = new System.Drawing.Size(358, 115);
            this.ShoeType.TabIndex = 9;
            this.ShoeType.Text = "Select Shoe Type";
            this.ShoeType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Tan",
            "Red",
            "Blue"});
            this.comboBox2.Location = new System.Drawing.Point(365, 233);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(356, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // CustomPrice
            // 
            this.CustomPrice.AutoSize = true;
            this.CustomPrice.BackColor = System.Drawing.Color.Transparent;
            this.CustomPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomPrice.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomPrice.Location = new System.Drawing.Point(365, 402);
            this.CustomPrice.Name = "CustomPrice";
            this.CustomPrice.Size = new System.Drawing.Size(356, 86);
            this.CustomPrice.TabIndex = 13;
            this.CustomPrice.Text = "Price of Custom Shoe";
            this.CustomPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PriceColour
            // 
            this.PriceColour.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PriceColour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceColour.Location = new System.Drawing.Point(365, 370);
            this.PriceColour.Name = "PriceColour";
            this.PriceColour.Size = new System.Drawing.Size(356, 29);
            this.PriceColour.TabIndex = 14;
            this.PriceColour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceSole
            // 
            this.PriceSole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PriceSole.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceSole.Location = new System.Drawing.Point(3, 370);
            this.PriceSole.Name = "PriceSole";
            this.PriceSole.Size = new System.Drawing.Size(356, 29);
            this.PriceSole.TabIndex = 15;
            this.PriceSole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceType
            // 
            this.PriceType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PriceType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceType.Location = new System.Drawing.Point(727, 370);
            this.PriceType.Name = "PriceType";
            this.PriceType.Size = new System.Drawing.Size(358, 29);
            this.PriceType.TabIndex = 16;
            this.PriceType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(365, 491);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(356, 35);
            this.TotalTextBox.TabIndex = 17;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1088, 575);
            this.Controls.Add(this.LayoutPanel);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ShoeColour;
        private System.Windows.Forms.Label SoleMaterial;
        private System.Windows.Forms.Label ShoeType;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label CustomPrice;
        private System.Windows.Forms.TextBox PriceColour;
        private System.Windows.Forms.TextBox PriceSole;
        private System.Windows.Forms.TextBox PriceType;
        private System.Windows.Forms.TextBox TotalTextBox;


    }
}

