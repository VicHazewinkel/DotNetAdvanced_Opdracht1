namespace Oefening7
{
    partial class Sum
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
            this.label_number = new System.Windows.Forms.Label();
            this.TB_Number = new System.Windows.Forms.TextBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(115, 86);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(51, 15);
            this.label_number.TabIndex = 0;
            this.label_number.Text = "Number";
            // 
            // TB_Number
            // 
            this.TB_Number.Location = new System.Drawing.Point(172, 83);
            this.TB_Number.Name = "TB_Number";
            this.TB_Number.Size = new System.Drawing.Size(100, 23);
            this.TB_Number.TabIndex = 1;
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(115, 123);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(75, 23);
            this.button_calculate.TabIndex = 2;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(194, 172);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(47, 15);
            this.label_Total.TabIndex = 3;
            this.label_Total.Text = "________";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(278, 91);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 15);
            this.label_error.TabIndex = 4;
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.TB_Number);
            this.Controls.Add(this.label_number);
            this.Name = "Sum";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_number;
        private TextBox TB_Number;
        private Button button_calculate;
        private Label label_Total;
        private Label label_error;
    }
}