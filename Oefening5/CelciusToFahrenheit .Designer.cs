namespace Oefening5
{
    partial class CelciusToFahrenheit
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
            this.text_F = new System.Windows.Forms.TextBox();
            this.text_C = new System.Windows.Forms.TextBox();
            this.Celsius = new System.Windows.Forms.Label();
            this.Fahrenheit = new System.Windows.Forms.Label();
            this.C_F = new System.Windows.Forms.Button();
            this.F_C = new System.Windows.Forms.Button();
            this.label_C_error = new System.Windows.Forms.Label();
            this.label_F_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_F
            // 
            this.text_F.Location = new System.Drawing.Point(291, 175);
            this.text_F.Name = "text_F";
            this.text_F.Size = new System.Drawing.Size(100, 23);
            this.text_F.TabIndex = 0;
            // 
            // text_C
            // 
            this.text_C.Location = new System.Drawing.Point(141, 175);
            this.text_C.Name = "text_C";
            this.text_C.Size = new System.Drawing.Size(100, 23);
            this.text_C.TabIndex = 1;
            this.text_C.Click += new System.EventHandler(this.C_Click);
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(141, 146);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(44, 15);
            this.Celsius.TabIndex = 2;
            this.Celsius.Text = "Celsius";
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.Location = new System.Drawing.Point(291, 146);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(63, 15);
            this.Fahrenheit.TabIndex = 3;
            this.Fahrenheit.Text = "Fahrenheit";
            // 
            // C_F
            // 
            this.C_F.Location = new System.Drawing.Point(141, 223);
            this.C_F.Name = "C_F";
            this.C_F.Size = new System.Drawing.Size(75, 23);
            this.C_F.TabIndex = 4;
            this.C_F.Text = "C to F";
            this.C_F.UseVisualStyleBackColor = true;
            this.C_F.Click += new System.EventHandler(this.C_F_Click);
            // 
            // F_C
            // 
            this.F_C.Location = new System.Drawing.Point(291, 223);
            this.F_C.Name = "F_C";
            this.F_C.Size = new System.Drawing.Size(75, 23);
            this.F_C.TabIndex = 5;
            this.F_C.Text = "F to C";
            this.F_C.UseVisualStyleBackColor = true;
            this.F_C.Click += new System.EventHandler(this.F_C_Click);
            // 
            // label_C_error
            // 
            this.label_C_error.AutoSize = true;
            this.label_C_error.Location = new System.Drawing.Point(141, 201);
            this.label_C_error.Name = "label_C_error";
            this.label_C_error.Size = new System.Drawing.Size(0, 15);
            this.label_C_error.TabIndex = 6;
            // 
            // label_F_error
            // 
            this.label_F_error.AutoSize = true;
            this.label_F_error.Location = new System.Drawing.Point(291, 201);
            this.label_F_error.Name = "label_F_error";
            this.label_F_error.Size = new System.Drawing.Size(0, 15);
            this.label_F_error.TabIndex = 7;
            // 
            // CelciusToFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_F_error);
            this.Controls.Add(this.label_C_error);
            this.Controls.Add(this.F_C);
            this.Controls.Add(this.C_F);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.text_C);
            this.Controls.Add(this.text_F);
            this.Name = "CelciusToFahrenheit";
            this.Text = "CelciusToFahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text_F;
        private TextBox text_C;
        private Label Celsius;
        private Label Fahrenheit;
        private Button C_F;
        private Button F_C;
        private Label label_C_error;
        private Label label_F_error;
    }
}