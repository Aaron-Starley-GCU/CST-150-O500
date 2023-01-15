namespace Activity15_AaronStarley {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.numLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numLabel
            // 
            this.numLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numLabel.ForeColor = System.Drawing.Color.Orange;
            this.numLabel.Location = new System.Drawing.Point(69, 108);
            this.numLabel.MinimumSize = new System.Drawing.Size(200, 100);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(200, 135);
            this.numLabel.TabIndex = 0;
            this.numLabel.Text = "0";
            this.numLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Coral;
            this.titleLabel.Location = new System.Drawing.Point(10, 53);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(323, 40);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Your Lucky Number is:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(345, 252);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.numLabel);
            this.Name = "Form2";
            this.Text = "Your Lucky Number!!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numLabel;
        private Label titleLabel;
    }
}