namespace Activity2_AaronStarley
{
    partial class Activity2
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 68);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(153, 15);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Enter wavelength in meters:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(159, 152);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(63, 15);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Megahertz";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 86);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 23);
            this.inputBox.TabIndex = 2;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 144);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(141, 23);
            this.outputBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(12, 115);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(52, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(231, 30);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Wavelength Converter";
            // 
            // Activity2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 197);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Name = "Activity2";
            this.Text = "Wavelength (m to MHz) Converter";
            this.Load += new System.EventHandler(this.Activity2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label inputLabel;
        private Label outputLabel;
        private TextBox inputBox;
        private TextBox outputBox;
        private Button convertButton;
        private Label titleLabel;
    }
}