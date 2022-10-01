namespace Oefening4
{
    partial class SalesTaxCalculator
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
            this.Item = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Ext_Price = new System.Windows.Forms.Label();
            this.Price_Each = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Subtotal = new System.Windows.Forms.Label();
            this.TaxRate = new System.Windows.Forms.Label();
            this.SalesTax = new System.Windows.Forms.Label();
            this.Shoppig = new System.Windows.Forms.Label();
            this.GrandTotal = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label_ExtPriceShipping = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(72, 51);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(31, 15);
            this.Item.TabIndex = 1;
            this.Item.Text = "Item";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(177, 51);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(53, 15);
            this.Quantity.TabIndex = 2;
            this.Quantity.Text = "Quantity";
            // 
            // Ext_Price
            // 
            this.Ext_Price.AutoSize = true;
            this.Ext_Price.Location = new System.Drawing.Point(415, 51);
            this.Ext_Price.Name = "Ext_Price";
            this.Ext_Price.Size = new System.Drawing.Size(54, 15);
            this.Ext_Price.TabIndex = 3;
            this.Ext_Price.Text = "Ext_Price";
            // 
            // Price_Each
            // 
            this.Price_Each.AutoSize = true;
            this.Price_Each.Location = new System.Drawing.Point(304, 51);
            this.Price_Each.Name = "Price_Each";
            this.Price_Each.Size = new System.Drawing.Size(61, 15);
            this.Price_Each.TabIndex = 4;
            this.Price_Each.Text = "Price Each";
            this.Price_Each.Click += new System.EventHandler(this.Price_Each_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(72, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(178, 70);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(177, 98);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 10;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(178, 127);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown3.TabIndex = 11;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(177, 156);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(304, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(304, 127);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(304, 98);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(304, 69);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(72, 228);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 21;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(353, 228);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(51, 15);
            this.Subtotal.TabIndex = 22;
            this.Subtotal.Text = "Subtotal";
            // 
            // TaxRate
            // 
            this.TaxRate.AutoSize = true;
            this.TaxRate.Location = new System.Drawing.Point(354, 258);
            this.TaxRate.Name = "TaxRate";
            this.TaxRate.Size = new System.Drawing.Size(50, 15);
            this.TaxRate.TabIndex = 23;
            this.TaxRate.Text = "Tax Rate";
            // 
            // SalesTax
            // 
            this.SalesTax.AutoSize = true;
            this.SalesTax.Location = new System.Drawing.Point(351, 286);
            this.SalesTax.Name = "SalesTax";
            this.SalesTax.Size = new System.Drawing.Size(53, 15);
            this.SalesTax.TabIndex = 24;
            this.SalesTax.Text = "Sales Tax";
            this.SalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Shoppig
            // 
            this.Shoppig.AutoSize = true;
            this.Shoppig.Location = new System.Drawing.Point(346, 316);
            this.Shoppig.Name = "Shoppig";
            this.Shoppig.Size = new System.Drawing.Size(58, 15);
            this.Shoppig.TabIndex = 25;
            this.Shoppig.Text = "Shopping";
            // 
            // GrandTotal
            // 
            this.GrandTotal.AutoSize = true;
            this.GrandTotal.Location = new System.Drawing.Point(337, 342);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.Size = new System.Drawing.Size(67, 15);
            this.GrandTotal.TabIndex = 26;
            this.GrandTotal.Text = "Grand Total";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(415, 250);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 23);
            this.textBox10.TabIndex = 28;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label_ExtPriceShipping
            // 
            this.label_ExtPriceShipping.Location = new System.Drawing.Point(415, 308);
            this.label_ExtPriceShipping.Name = "label_ExtPriceShipping";
            this.label_ExtPriceShipping.Size = new System.Drawing.Size(100, 23);
            this.label_ExtPriceShipping.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "label7";
            // 
            // SalesTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_ExtPriceShipping);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.GrandTotal);
            this.Controls.Add(this.Shoppig);
            this.Controls.Add(this.SalesTax);
            this.Controls.Add(this.TaxRate);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Price_Each);
            this.Controls.Add(this.Ext_Price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Item);
            this.Name = "SalesTaxCalculator";
            this.Text = "SalesTaxCalculator:";
            this.Load += new System.EventHandler(this.Calculate_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Item;
        private Label Quantity;
        private Label Ext_Price;
        private Label Price_Each;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Calculate;
        private Label Subtotal;
        private Label TaxRate;
        private Label SalesTax;
        private Label Shoppig;
        private Label GrandTotal;
        private TextBox textBox10;
        private TextBox label_ExtPriceShipping;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}