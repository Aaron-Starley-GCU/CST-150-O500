namespace Activity11_AaronStarley
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
            this.rollButton = new System.Windows.Forms.Button();
            this.dieTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dieTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rollButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rollButton.Location = new System.Drawing.Point(174, 93);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(152, 50);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // dieTextBox1
            // 
            this.dieTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dieTextBox1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dieTextBox1.Location = new System.Drawing.Point(132, 173);
            this.dieTextBox1.MaximumSize = new System.Drawing.Size(100, 100);
            this.dieTextBox1.MinimumSize = new System.Drawing.Size(100, 100);
            this.dieTextBox1.Multiline = false;
            this.dieTextBox1.Name = "dieTextBox1";
            this.dieTextBox1.Size = new System.Drawing.Size(100, 100);
            this.dieTextBox1.TabIndex = 1;
            this.dieTextBox1.Text = "1";
            // 
            // dieTextBox2
            // 
            this.dieTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dieTextBox2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dieTextBox2.Location = new System.Drawing.Point(273, 173);
            this.dieTextBox2.MaximumSize = new System.Drawing.Size(100, 100);
            this.dieTextBox2.MinimumSize = new System.Drawing.Size(100, 100);
            this.dieTextBox2.Multiline = false;
            this.dieTextBox2.Name = "dieTextBox2";
            this.dieTextBox2.Size = new System.Drawing.Size(100, 100);
            this.dieTextBox2.TabIndex = 2;
            this.dieTextBox2.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(517, 392);
            this.Controls.Add(this.dieTextBox2);
            this.Controls.Add(this.dieTextBox1);
            this.Controls.Add(this.rollButton);
            this.MaximumSize = new System.Drawing.Size(533, 431);
            this.MinimumSize = new System.Drawing.Size(533, 431);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button rollButton;
        private RichTextBox dieTextBox1;
        private RichTextBox dieTextBox2;
    }
}