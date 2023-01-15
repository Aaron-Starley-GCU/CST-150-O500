namespace Activity15_AaronStarley {
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
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.arbitraryLabel = new System.Windows.Forms.Label();
            this.graduationBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // monthBox
            // 
            this.monthBox.BackColor = System.Drawing.SystemColors.Window;
            this.monthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthBox.FormattingEnabled = true;
            this.monthBox.IntegralHeight = false;
            this.monthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(115, 45);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(121, 23);
            this.monthBox.TabIndex = 0;
            this.monthBox.SelectedIndexChanged += new System.EventHandler(this.monthBox_SelectedIndexChanged);
            // 
            // dayBox
            // 
            this.dayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayBox.FormattingEnabled = true;
            this.dayBox.IntegralHeight = false;
            this.dayBox.Items.AddRange(new object[] {
            ""});
            this.dayBox.Location = new System.Drawing.Point(115, 87);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(121, 23);
            this.dayBox.TabIndex = 1;
            this.dayBox.SelectedIndexChanged += new System.EventHandler(this.dayBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(102, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter Info First";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(58, 90);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(57, 15);
            this.dayLabel.TabIndex = 4;
            this.dayLabel.Text = "Birth day:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(41, 48);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(74, 15);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "Birth month:";
            // 
            // arbitraryLabel
            // 
            this.arbitraryLabel.AutoSize = true;
            this.arbitraryLabel.Location = new System.Drawing.Point(67, 139);
            this.arbitraryLabel.Name = "arbitraryLabel";
            this.arbitraryLabel.Size = new System.Drawing.Size(226, 15);
            this.arbitraryLabel.TabIndex = 6;
            this.arbitraryLabel.Text = "What year did you graduate High School?";
            // 
            // graduationBox
            // 
            this.graduationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graduationBox.FormattingEnabled = true;
            this.graduationBox.IntegralHeight = false;
            this.graduationBox.Location = new System.Drawing.Point(115, 157);
            this.graduationBox.Name = "graduationBox";
            this.graduationBox.Size = new System.Drawing.Size(121, 23);
            this.graduationBox.TabIndex = 7;
            this.graduationBox.SelectedIndexChanged += new System.EventHandler(this.graduationBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(349, 331);
            this.Controls.Add(this.graduationBox);
            this.Controls.Add(this.arbitraryLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.monthBox);
            this.Name = "Form1";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox monthBox;
        private ComboBox dayBox;
        private Button button1;
        private Label dayLabel;
        private Label monthLabel;
        private Label arbitraryLabel;
        private ComboBox graduationBox;
    }
}