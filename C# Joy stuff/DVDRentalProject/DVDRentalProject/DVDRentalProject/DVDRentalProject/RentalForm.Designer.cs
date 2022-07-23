namespace DVDRentalProject
{
    partial class RentalForm
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
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CalculationGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.GenreGroupBox = new System.Windows.Forms.GroupBox();
            this.AdventureGenre = new System.Windows.Forms.RadioButton();
            this.ComedyGenre = new System.Windows.Forms.RadioButton();
            this.ActionGenre = new System.Windows.Forms.RadioButton();
            this.ChildrenGenre = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerGroupBox.SuspendLayout();
            this.CalculationGroupBox.SuspendLayout();
            this.GenreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.Controls.Add(this.CustomerLabel);
            this.CustomerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGroupBox.Location = new System.Drawing.Point(79, 259);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(359, 119);
            this.CustomerGroupBox.TabIndex = 17;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Customer Details";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(107, 32);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(0, 16);
            this.CustomerLabel.TabIndex = 18;
            // 
            // CalculationGroupBox
            // 
            this.CalculationGroupBox.Controls.Add(this.ClearButton);
            this.CalculationGroupBox.Controls.Add(this.CalculateButton);
            this.CalculationGroupBox.Controls.Add(this.AmountTextBox);
            this.CalculationGroupBox.Controls.Add(this.AmountLabel);
            this.CalculationGroupBox.Controls.Add(this.TaxTextBox);
            this.CalculationGroupBox.Controls.Add(this.TaxLabel);
            this.CalculationGroupBox.Controls.Add(this.PriceTextBox);
            this.CalculationGroupBox.Controls.Add(this.PriceLabel);
            this.CalculationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationGroupBox.Location = new System.Drawing.Point(266, 95);
            this.CalculationGroupBox.Name = "CalculationGroupBox";
            this.CalculationGroupBox.Size = new System.Drawing.Size(200, 125);
            this.CalculationGroupBox.TabIndex = 8;
            this.CalculationGroupBox.TabStop = false;
            this.CalculationGroupBox.Text = "Calculations";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(119, 96);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 25);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(25, 95);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(88, 24);
            this.CalculateButton.TabIndex = 15;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(114, 68);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(80, 22);
            this.AmountTextBox.TabIndex = 14;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(8, 71);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(91, 16);
            this.AmountLabel.TabIndex = 13;
            this.AmountLabel.Text = "Amount Due";
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(114, 45);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.Size = new System.Drawing.Size(80, 22);
            this.TaxTextBox.TabIndex = 12;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(8, 45);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(51, 16);
            this.TaxLabel.TabIndex = 11;
            this.TaxLabel.Text = "Taxes";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(114, 23);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(80, 22);
            this.PriceTextBox.TabIndex = 10;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(8, 23);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(80, 16);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "DVD Price";
            // 
            // GenreGroupBox
            // 
            this.GenreGroupBox.Controls.Add(this.AdventureGenre);
            this.GenreGroupBox.Controls.Add(this.ComedyGenre);
            this.GenreGroupBox.Controls.Add(this.ActionGenre);
            this.GenreGroupBox.Controls.Add(this.ChildrenGenre);
            this.GenreGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreGroupBox.Location = new System.Drawing.Point(79, 95);
            this.GenreGroupBox.Name = "GenreGroupBox";
            this.GenreGroupBox.Size = new System.Drawing.Size(135, 134);
            this.GenreGroupBox.TabIndex = 3;
            this.GenreGroupBox.TabStop = false;
            this.GenreGroupBox.Text = "Genre type";
            // 
            // AdventureGenre
            // 
            this.AdventureGenre.AutoSize = true;
            this.AdventureGenre.Location = new System.Drawing.Point(23, 101);
            this.AdventureGenre.Name = "AdventureGenre";
            this.AdventureGenre.Size = new System.Drawing.Size(96, 20);
            this.AdventureGenre.TabIndex = 7;
            this.AdventureGenre.Text = "Adventure";
            this.AdventureGenre.UseVisualStyleBackColor = true;
            // 
            // ComedyGenre
            // 
            this.ComedyGenre.AutoSize = true;
            this.ComedyGenre.Location = new System.Drawing.Point(23, 55);
            this.ComedyGenre.Name = "ComedyGenre";
            this.ComedyGenre.Size = new System.Drawing.Size(83, 20);
            this.ComedyGenre.TabIndex = 5;
            this.ComedyGenre.TabStop = true;
            this.ComedyGenre.Text = "Comedy";
            this.ComedyGenre.UseVisualStyleBackColor = true;
            // 
            // ActionGenre
            // 
            this.ActionGenre.AutoSize = true;
            this.ActionGenre.Location = new System.Drawing.Point(23, 78);
            this.ActionGenre.Name = "ActionGenre";
            this.ActionGenre.Size = new System.Drawing.Size(69, 20);
            this.ActionGenre.TabIndex = 6;
            this.ActionGenre.TabStop = true;
            this.ActionGenre.Text = "Action";
            this.ActionGenre.UseVisualStyleBackColor = true;
            // 
            // ChildrenGenre
            // 
            this.ChildrenGenre.AutoSize = true;
            this.ChildrenGenre.Location = new System.Drawing.Point(23, 32);
            this.ChildrenGenre.Name = "ChildrenGenre";
            this.ChildrenGenre.Size = new System.Drawing.Size(83, 20);
            this.ChildrenGenre.TabIndex = 4;
            this.ChildrenGenre.Text = "Children";
            this.ChildrenGenre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // CustomerName
            // 
            this.CustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.CustomerName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(224, 37);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(236, 25);
            this.CustomerName.TabIndex = 1;
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 390);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerGroupBox);
            this.Controls.Add(this.CalculationGroupBox);
            this.Controls.Add(this.GenreGroupBox);
            this.Name = "RentalForm";
            this.Text = "Rental Form";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.CustomerGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.PerformLayout();
            this.CalculationGroupBox.ResumeLayout(false);
            this.CalculationGroupBox.PerformLayout();
            this.GenreGroupBox.ResumeLayout(false);
            this.GenreGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox CustomerGroupBox;
        internal System.Windows.Forms.Label CustomerLabel;
        internal System.Windows.Forms.GroupBox CalculationGroupBox;
        internal System.Windows.Forms.Button ClearButton;
        internal System.Windows.Forms.Button CalculateButton;
        internal System.Windows.Forms.TextBox AmountTextBox;
        internal System.Windows.Forms.Label AmountLabel;
        internal System.Windows.Forms.TextBox TaxTextBox;
        internal System.Windows.Forms.Label TaxLabel;
        internal System.Windows.Forms.TextBox PriceTextBox;
        internal System.Windows.Forms.Label PriceLabel;
        internal System.Windows.Forms.GroupBox GenreGroupBox;
        internal System.Windows.Forms.RadioButton AdventureGenre;
        internal System.Windows.Forms.RadioButton ComedyGenre;
        internal System.Windows.Forms.RadioButton ActionGenre;
        internal System.Windows.Forms.RadioButton ChildrenGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerName;
    }
}

