namespace Milestone4_AaronStarley {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.skuLabel = new System.Windows.Forms.Label();
            this.skuSearchBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockSearchBox = new System.Windows.Forms.TextBox();
            this.searchResultBox = new System.Windows.Forms.TextBox();
            this.updateStockButton = new System.Windows.Forms.Button();
            this.updatePriceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.Location = new System.Drawing.Point(159, 285);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(31, 15);
            this.skuLabel.TabIndex = 0;
            this.skuLabel.Text = "SKU:";
            // 
            // skuSearchBox
            // 
            this.skuSearchBox.Location = new System.Drawing.Point(187, 281);
            this.skuSearchBox.Name = "skuSearchBox";
            this.skuSearchBox.Size = new System.Drawing.Size(100, 23);
            this.skuSearchBox.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(524, 206);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(596, 60);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(104, 23);
            this.addItemButton.TabIndex = 16;
            this.addItemButton.Text = "New Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(461, 281);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(300, 284);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(39, 15);
            this.stockLabel.TabIndex = 19;
            this.stockLabel.Text = "Stock:";
            // 
            // stockSearchBox
            // 
            this.stockSearchBox.Location = new System.Drawing.Point(336, 281);
            this.stockSearchBox.Name = "stockSearchBox";
            this.stockSearchBox.Size = new System.Drawing.Size(100, 23);
            this.stockSearchBox.TabIndex = 20;
            // 
            // searchResultBox
            // 
            this.searchResultBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchResultBox.Location = new System.Drawing.Point(12, 310);
            this.searchResultBox.Name = "searchResultBox";
            this.searchResultBox.ReadOnly = true;
            this.searchResultBox.Size = new System.Drawing.Size(524, 23);
            this.searchResultBox.TabIndex = 21;
            // 
            // updateStockButton
            // 
            this.updateStockButton.Location = new System.Drawing.Point(596, 102);
            this.updateStockButton.Name = "updateStockButton";
            this.updateStockButton.Size = new System.Drawing.Size(104, 23);
            this.updateStockButton.TabIndex = 22;
            this.updateStockButton.Text = "Update Stock";
            this.updateStockButton.UseVisualStyleBackColor = true;
            this.updateStockButton.Click += new System.EventHandler(this.updateStockButton_Click);
            // 
            // updatePriceButton
            // 
            this.updatePriceButton.Location = new System.Drawing.Point(596, 147);
            this.updatePriceButton.Name = "updatePriceButton";
            this.updatePriceButton.Size = new System.Drawing.Size(104, 23);
            this.updatePriceButton.TabIndex = 23;
            this.updatePriceButton.Text = "Update Price";
            this.updatePriceButton.UseVisualStyleBackColor = true;
            this.updatePriceButton.Click += new System.EventHandler(this.updatePriceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Inventory Items:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Inventory Control:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatePriceButton);
            this.Controls.Add(this.updateStockButton);
            this.Controls.Add(this.searchResultBox);
            this.Controls.Add(this.stockSearchBox);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.skuSearchBox);
            this.Controls.Add(this.skuLabel);
            this.Name = "Form1";
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label skuLabel;
        private TextBox skuSearchBox;
        private Button addItemButton;
        private Button searchButton;
        private Label stockLabel;
        private TextBox stockSearchBox;
        private TextBox searchResultBox;
        private Button updateStockButton;
        public RichTextBox richTextBox1;
        private Button updatePriceButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}