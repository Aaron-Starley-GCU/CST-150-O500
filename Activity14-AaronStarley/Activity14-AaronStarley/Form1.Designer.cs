namespace Activity14_AaronStarley {
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
            this.techRadioButton = new System.Windows.Forms.RadioButton();
            this.genRadioButton = new System.Windows.Forms.RadioButton();
            this.extraRadioButton = new System.Windows.Forms.RadioButton();
            this.verifyBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.privilegeInfo = new System.Windows.Forms.Label();
            this.bandLabel = new System.Windows.Forms.Label();
            this.MHzLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.abbrevBox1 = new System.Windows.Forms.CheckBox();
            this.classesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // techRadioButton
            // 
            this.techRadioButton.AutoSize = true;
            this.techRadioButton.Checked = true;
            this.techRadioButton.Location = new System.Drawing.Point(155, 51);
            this.techRadioButton.Name = "techRadioButton";
            this.techRadioButton.Size = new System.Drawing.Size(81, 19);
            this.techRadioButton.TabIndex = 0;
            this.techRadioButton.TabStop = true;
            this.techRadioButton.Text = "Technician";
            this.techRadioButton.UseVisualStyleBackColor = true;
            // 
            // genRadioButton
            // 
            this.genRadioButton.AutoSize = true;
            this.genRadioButton.Location = new System.Drawing.Point(155, 76);
            this.genRadioButton.Name = "genRadioButton";
            this.genRadioButton.Size = new System.Drawing.Size(65, 19);
            this.genRadioButton.TabIndex = 1;
            this.genRadioButton.Text = "General";
            this.genRadioButton.UseVisualStyleBackColor = true;
            // 
            // extraRadioButton
            // 
            this.extraRadioButton.AutoSize = true;
            this.extraRadioButton.Location = new System.Drawing.Point(155, 101);
            this.extraRadioButton.Name = "extraRadioButton";
            this.extraRadioButton.Size = new System.Drawing.Size(100, 19);
            this.extraRadioButton.TabIndex = 2;
            this.extraRadioButton.Text = "Amateur Extra";
            this.extraRadioButton.UseVisualStyleBackColor = true;
            // 
            // verifyBox
            // 
            this.verifyBox.AutoSize = true;
            this.verifyBox.Location = new System.Drawing.Point(10, 240);
            this.verifyBox.Name = "verifyBox";
            this.verifyBox.Size = new System.Drawing.Size(377, 19);
            this.verifyBox.TabIndex = 3;
            this.verifyBox.Text = "I understand that this program is for demonstration purposes only.";
            this.verifyBox.UseVisualStyleBackColor = true;
            this.verifyBox.CheckedChanged += new System.EventHandler(this.verifyBox_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "70cm",
            "2m",
            "6m",
            "10m",
            "17m",
            "20m",
            "40m",
            "80m",
            "160m"});
            this.listBox1.Location = new System.Drawing.Point(10, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 4;
            // 
            // privilegeInfo
            // 
            this.privilegeInfo.AutoSize = true;
            this.privilegeInfo.Location = new System.Drawing.Point(12, 211);
            this.privilegeInfo.Name = "privilegeInfo";
            this.privilegeInfo.Size = new System.Drawing.Size(57, 15);
            this.privilegeInfo.TabIndex = 5;
            this.privilegeInfo.Text = "Privileges";
            // 
            // bandLabel
            // 
            this.bandLabel.AutoSize = true;
            this.bandLabel.Location = new System.Drawing.Point(10, 8);
            this.bandLabel.Name = "bandLabel";
            this.bandLabel.Size = new System.Drawing.Size(71, 15);
            this.bandLabel.TabIndex = 6;
            this.bandLabel.Text = "Select Band:";
            // 
            // MHzLabel
            // 
            this.MHzLabel.AutoSize = true;
            this.MHzLabel.Location = new System.Drawing.Point(112, 188);
            this.MHzLabel.Name = "MHzLabel";
            this.MHzLabel.Size = new System.Drawing.Size(32, 15);
            this.MHzLabel.TabIndex = 7;
            this.MHzLabel.Text = "MHz";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(36, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(11, 185);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(100, 23);
            this.outputBox.TabIndex = 9;
            this.outputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // abbrevBox1
            // 
            this.abbrevBox1.AutoSize = true;
            this.abbrevBox1.Location = new System.Drawing.Point(164, 187);
            this.abbrevBox1.Name = "abbrevBox1";
            this.abbrevBox1.Size = new System.Drawing.Size(187, 19);
            this.abbrevBox1.TabIndex = 10;
            this.abbrevBox1.Text = "Shorten to four decimal places";
            this.abbrevBox1.UseVisualStyleBackColor = true;
            // 
            // classesLabel
            // 
            this.classesLabel.AutoSize = true;
            this.classesLabel.Location = new System.Drawing.Point(141, 26);
            this.classesLabel.Name = "classesLabel";
            this.classesLabel.Size = new System.Drawing.Size(79, 15);
            this.classesLabel.TabIndex = 11;
            this.classesLabel.Text = "License Class:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 278);
            this.Controls.Add(this.classesLabel);
            this.Controls.Add(this.abbrevBox1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MHzLabel);
            this.Controls.Add(this.bandLabel);
            this.Controls.Add(this.privilegeInfo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.verifyBox);
            this.Controls.Add(this.extraRadioButton);
            this.Controls.Add(this.genRadioButton);
            this.Controls.Add(this.techRadioButton);
            this.Name = "Form1";
            this.Text = "Ham Band Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton techRadioButton;
        private RadioButton genRadioButton;
        private RadioButton extraRadioButton;
        private CheckBox verifyBox;
        private ListBox listBox1;
        private Label privilegeInfo;
        private Label bandLabel;
        private Label MHzLabel;
        private Button button1;
        private TextBox outputBox;
        private CheckBox abbrevBox1;
        private Label classesLabel;
    }
}