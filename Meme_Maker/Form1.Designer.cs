namespace Meme_Maker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtBottomTextBox = new TextBox();
            txtTopTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            imgPreview = new PictureBox();
            btnOpen = new Button();
            btnSave = new Button();
            lblTopText = new Label();
            lblBottomText = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPreview).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtBottomTextBox);
            groupBox1.Controls.Add(txtTopTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 35);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(467, 518);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Texts";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 192, 192);
            button6.Location = new Point(131, 428);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(42, 37);
            button6.TabIndex = 10;
            button6.UseVisualStyleBackColor = false;
            button6.Click += ChangeTextColour;
            // 
            // button5
            // 
            button5.BackColor = Color.Fuchsia;
            button5.Location = new Point(82, 428);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(42, 37);
            button5.TabIndex = 9;
            button5.UseVisualStyleBackColor = false;
            button5.Click += ChangeTextColour;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Location = new Point(33, 428);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(42, 37);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = false;
            button4.Click += ChangeTextColour;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(131, 372);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(42, 37);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = false;
            button3.Click += ChangeTextColour;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(82, 372);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(42, 37);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            button2.Click += ChangeTextColour;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Location = new Point(33, 372);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(42, 37);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += ChangeTextColour;
            // 
            // txtBottomTextBox
            // 
            txtBottomTextBox.Location = new Point(29, 208);
            txtBottomTextBox.Margin = new Padding(4, 3, 4, 3);
            txtBottomTextBox.Multiline = true;
            txtBottomTextBox.Name = "txtBottomTextBox";
            txtBottomTextBox.Size = new Size(430, 80);
            txtBottomTextBox.TabIndex = 4;
            txtBottomTextBox.TextChanged += ChangeBottomText;
            // 
            // txtTopTextBox
            // 
            txtTopTextBox.Location = new Point(29, 67);
            txtTopTextBox.Margin = new Padding(4, 3, 4, 3);
            txtTopTextBox.Multiline = true;
            txtTopTextBox.Name = "txtTopTextBox";
            txtTopTextBox.Size = new Size(430, 80);
            txtTopTextBox.TabIndex = 3;
            txtTopTextBox.TextChanged += ChangeTopText;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 338);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Change Colour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 189);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Bottom Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Top Text";
            // 
            // imgPreview
            // 
            imgPreview.BackColor = Color.Black;
            imgPreview.Location = new Point(493, 36);
            imgPreview.Margin = new Padding(4, 3, 4, 3);
            imgPreview.Name = "imgPreview";
            imgPreview.Size = new Size(493, 518);
            imgPreview.SizeMode = PictureBoxSizeMode.Zoom;
            imgPreview.TabIndex = 1;
            imgPreview.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(219, 588);
            btnOpen.Margin = new Padding(4, 3, 4, 3);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(142, 85);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += OpenImage;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(611, 588);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 85);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += SaveImage;
            // 
            // lblTopText
            // 
            lblTopText.BackColor = Color.Transparent;
            lblTopText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopText.ForeColor = Color.White;
            lblTopText.Location = new Point(493, 36);
            lblTopText.Margin = new Padding(4, 0, 4, 0);
            lblTopText.Name = "lblTopText";
            lblTopText.Size = new Size(493, 100);
            lblTopText.TabIndex = 4;
            lblTopText.Text = "Sample Top Text";
            lblTopText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBottomText
            // 
            lblBottomText.BackColor = Color.Transparent;
            lblBottomText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBottomText.ForeColor = Color.White;
            lblBottomText.Location = new Point(493, 463);
            lblBottomText.Margin = new Padding(4, 0, 4, 0);
            lblBottomText.Name = "lblBottomText";
            lblBottomText.Size = new Size(493, 91);
            lblBottomText.TabIndex = 5;
            lblBottomText.Text = "Sample Bottom Text";
            lblBottomText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 705);
            Controls.Add(lblBottomText);
            Controls.Add(lblTopText);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(imgPreview);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Meme Maker by RoMeRo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBottomTextBox;
        private System.Windows.Forms.TextBox txtTopTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTopText;
        private System.Windows.Forms.Label lblBottomText;
    }
}