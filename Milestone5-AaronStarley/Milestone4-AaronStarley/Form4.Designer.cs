namespace Milestone4_AaronStarley {
    partial class Form4 {
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
            this.updateSkuBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updatePriceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newPriceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateSkuBox
            // 
            this.updateSkuBox.Location = new System.Drawing.Point(86, 42);
            this.updateSkuBox.Name = "updateSkuBox";
            this.updateSkuBox.Size = new System.Drawing.Size(100, 23);
            this.updateSkuBox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "SKU:";
            // 
            // updatePriceButton
            // 
            this.updatePriceButton.Location = new System.Drawing.Point(86, 112);
            this.updatePriceButton.Name = "updatePriceButton";
            this.updatePriceButton.Size = new System.Drawing.Size(100, 23);
            this.updatePriceButton.TabIndex = 33;
            this.updatePriceButton.Text = "Update Price";
            this.updatePriceButton.UseVisualStyleBackColor = true;
            this.updatePriceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "New Price: $";
            // 
            // newPriceBox
            // 
            this.newPriceBox.Location = new System.Drawing.Point(86, 71);
            this.newPriceBox.Name = "newPriceBox";
            this.newPriceBox.Size = new System.Drawing.Size(100, 23);
            this.newPriceBox.TabIndex = 35;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 171);
            this.Controls.Add(this.newPriceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatePriceButton);
            this.Controls.Add(this.updateSkuBox);
            this.Controls.Add(this.label6);
            this.Name = "Form4";
            this.Text = "Update Price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox updateSkuBox;
        private Label label6;
        private Button updatePriceButton;
        private Label label1;
        private TextBox newPriceBox;
    }
}