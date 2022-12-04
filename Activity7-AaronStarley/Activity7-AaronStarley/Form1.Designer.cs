namespace Activity7_AaronStarley
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.outputText1 = new System.Windows.Forms.Label();
            this.outputText2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter # of terms:";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(136, 41);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(125, 27);
            this.inputBox.TabIndex = 1;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(22, 94);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(94, 29);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // outputText1
            // 
            this.outputText1.AutoSize = true;
            this.outputText1.Location = new System.Drawing.Point(22, 144);
            this.outputText1.Name = "outputText1";
            this.outputText1.Size = new System.Drawing.Size(170, 20);
            this.outputText1.TabIndex = 3;
            this.outputText1.Text = "Approximate value of pi";
            // 
            // outputText2
            // 
            this.outputText2.AutoSize = true;
            this.outputText2.Location = new System.Drawing.Point(22, 173);
            this.outputText2.Name = "outputText2";
            this.outputText2.Size = new System.Drawing.Size(19, 20);
            this.outputText2.TabIndex = 4;
            this.outputText2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 263);
            this.Controls.Add(this.outputText2);
            this.Controls.Add(this.outputText1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inputBox;
        private Button calcButton;
        private Label outputText1;
        private Label outputText2;
    }
}