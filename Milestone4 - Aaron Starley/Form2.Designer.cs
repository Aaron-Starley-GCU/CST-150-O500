namespace Milestone4_AaronStarley {
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
            this.addItemButton = new System.Windows.Forms.Button();
            this.priceInputBox = new System.Windows.Forms.TextBox();
            this.stockInputBox = new System.Windows.Forms.TextBox();
            this.upcInputBox = new System.Windows.Forms.TextBox();
            this.skuInputBox = new System.Windows.Forms.TextBox();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(83, 157);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 27;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // priceInputBox
            // 
            this.priceInputBox.Location = new System.Drawing.Point(48, 128);
            this.priceInputBox.Name = "priceInputBox";
            this.priceInputBox.Size = new System.Drawing.Size(138, 23);
            this.priceInputBox.TabIndex = 26;
            // 
            // stockInputBox
            // 
            this.stockInputBox.Location = new System.Drawing.Point(48, 99);
            this.stockInputBox.Name = "stockInputBox";
            this.stockInputBox.Size = new System.Drawing.Size(138, 23);
            this.stockInputBox.TabIndex = 25;
            // 
            // upcInputBox
            // 
            this.upcInputBox.Location = new System.Drawing.Point(48, 70);
            this.upcInputBox.Name = "upcInputBox";
            this.upcInputBox.Size = new System.Drawing.Size(138, 23);
            this.upcInputBox.TabIndex = 24;
            // 
            // skuInputBox
            // 
            this.skuInputBox.Location = new System.Drawing.Point(48, 41);
            this.skuInputBox.Name = "skuInputBox";
            this.skuInputBox.Size = new System.Drawing.Size(138, 23);
            this.skuInputBox.TabIndex = 23;
            // 
            // nameInputBox
            // 
            this.nameInputBox.Location = new System.Drawing.Point(48, 12);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(138, 23);
            this.nameInputBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "UPC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "SKU:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 206);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.priceInputBox);
            this.Controls.Add(this.stockInputBox);
            this.Controls.Add(this.upcInputBox);
            this.Controls.Add(this.skuInputBox);
            this.Controls.Add(this.nameInputBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addItemButton;
        private TextBox priceInputBox;
        private TextBox stockInputBox;
        private TextBox upcInputBox;
        private TextBox skuInputBox;
        private TextBox nameInputBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}