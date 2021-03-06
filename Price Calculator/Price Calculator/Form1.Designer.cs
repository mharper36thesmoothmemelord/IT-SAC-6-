﻿namespace Price_Calculator
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
            this.typebox = new System.Windows.Forms.ComboBox();
            this.solematerialbox = new System.Windows.Forms.ComboBox();
            this.SoleMaterial = new System.Windows.Forms.Label();
            this.ShoeColour = new System.Windows.Forms.Label();
            this.ShoeType = new System.Windows.Forms.Label();
            this.colourbox = new System.Windows.Forms.ComboBox();
            this.CustomPrice = new System.Windows.Forms.Label();
            this.PriceColour = new System.Windows.Forms.TextBox();
            this.PriceSole = new System.Windows.Forms.TextBox();
            this.PriceType = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
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
            this.LayoutPanel.Controls.Add(this.typebox, 2, 2);
            this.LayoutPanel.Controls.Add(this.solematerialbox, 0, 2);
            this.LayoutPanel.Controls.Add(this.SoleMaterial, 0, 1);
            this.LayoutPanel.Controls.Add(this.ShoeColour, 1, 1);
            this.LayoutPanel.Controls.Add(this.ShoeType, 2, 1);
            this.LayoutPanel.Controls.Add(this.colourbox, 1, 2);
            this.LayoutPanel.Controls.Add(this.CustomPrice, 1, 4);
            this.LayoutPanel.Controls.Add(this.PriceColour, 1, 3);
            this.LayoutPanel.Controls.Add(this.PriceSole, 0, 3);
            this.LayoutPanel.Controls.Add(this.PriceType, 2, 3);
            this.LayoutPanel.Controls.Add(this.TotalTextBox, 1, 5);
            this.LayoutPanel.Controls.Add(this.calculate, 0, 5);
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
            // typebox
            // 
            this.typebox.Dock = System.Windows.Forms.DockStyle.Top;
            this.typebox.FormattingEnabled = true;
            this.typebox.Items.AddRange(new object[] {
            "Balmoral",
            "Brouge",
            "Demi Boot",
            "Dress Pump",
            "Loafer",
            "Oxford",
            "Ranch Boot",
            "Sandal",
            "Shenandoah"});
            this.typebox.Location = new System.Drawing.Point(727, 233);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(358, 21);
            this.typebox.TabIndex = 4;
            this.typebox.SelectedIndexChanged += new System.EventHandler(this.typebox_SelectedIndexChanged);
            // 
            // solematerialbox
            // 
            this.solematerialbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.solematerialbox.FormattingEnabled = true;
            this.solematerialbox.Items.AddRange(new object[] {
            "Leather",
            "Rubber",
            "Composite"});
            this.solematerialbox.Location = new System.Drawing.Point(3, 233);
            this.solematerialbox.Name = "solematerialbox";
            this.solematerialbox.Size = new System.Drawing.Size(356, 21);
            this.solematerialbox.TabIndex = 2;
            this.solematerialbox.SelectedIndexChanged += new System.EventHandler(this.solematerialbox_SelectedIndexChanged);
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
            // colourbox
            // 
            this.colourbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colourbox.FormattingEnabled = true;
            this.colourbox.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Tan",
            "Red",
            "Blue"});
            this.colourbox.Location = new System.Drawing.Point(365, 233);
            this.colourbox.Name = "colourbox";
            this.colourbox.Size = new System.Drawing.Size(356, 21);
            this.colourbox.TabIndex = 12;
            this.colourbox.SelectedIndexChanged += new System.EventHandler(this.colourbox_SelectedIndexChanged);
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
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate
            // 
            this.calculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(3, 491);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(356, 81);
            this.calculate.TabIndex = 18;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
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
        private System.Windows.Forms.ComboBox typebox;
        private System.Windows.Forms.ComboBox solematerialbox;
        private System.Windows.Forms.Label ShoeColour;
        private System.Windows.Forms.Label SoleMaterial;
        private System.Windows.Forms.Label ShoeType;
        private System.Windows.Forms.ComboBox colourbox;
        private System.Windows.Forms.Label CustomPrice;
        private System.Windows.Forms.TextBox PriceColour;
        private System.Windows.Forms.TextBox PriceSole;
        private System.Windows.Forms.TextBox PriceType;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button calculate;


    }
}

