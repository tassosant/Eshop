namespace Eshop
{
    partial class PaypallGateForm
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
            textBox8 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox8
            // 
            textBox8.Location = new Point(572, 256);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(139, 31);
            textBox8.TabIndex = 29;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(572, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 31);
            textBox4.TabIndex = 28;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(572, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 31);
            textBox3.TabIndex = 27;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(572, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 31);
            textBox2.TabIndex = 26;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(572, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 31);
            textBox1.TabIndex = 25;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(432, 259);
            label8.Name = "label8";
            label8.Size = new Size(45, 25);
            label8.TabIndex = 24;
            label8.Text = "CVV";
            label8.Click += label8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(432, 172);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 23;
            label6.Text = "Card number";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 216);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 22;
            label7.Text = "Expiry date";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 124);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 21;
            label5.Text = "Surename";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 80);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 20;
            label4.Text = "Name";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 71);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 30;
            label1.Text = "total amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 133);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 31;
            label2.Text = "Payment Methods:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(40, 199);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(158, 29);
            radioButton1.TabIndex = 32;
            radioButton1.TabStop = true;
            radioButton1.Text = "cash at delivery";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(40, 246);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(120, 29);
            radioButton2.TabIndex = 33;
            radioButton2.TabStop = true;
            radioButton2.Text = "credit card";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(454, 348);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 34;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 80);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 35;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // PaypallGateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "PaypallGateForm";
            Text = "PaypallGateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox8;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Label label3;
    }
}