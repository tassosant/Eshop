namespace Eshop
{
    partial class OrderForm
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
            components = new System.ComponentModel.Container();
            totalPriceLabel = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            checkBox2 = new CheckBox();
            label12 = new Label();
            button1 = new Button();
            OrderDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).BeginInit();
            navbar1 = new CustomComponents.Navbar(components);
            SuspendLayout();
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new Point(241, 279);
            totalPriceLabel.Margin = new Padding(4, 0, 4, 0);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(78, 32);
            totalPriceLabel.TabIndex = 4;
            totalPriceLabel.Text = "label2";
            totalPriceLabel.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 279);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 3;
            label1.Text = "total";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(46, 343);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(192, 36);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "confirm order";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(469, 76);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(325, 45);
            label3.TabIndex = 6;
            label3.Text = "add shipping address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 135);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 7;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 191);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 32);
            label5.TabIndex = 8;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 253);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 32);
            label6.TabIndex = 10;
            label6.Text = "Post code";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(343, 309);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 32);
            label7.TabIndex = 9;
            label7.Text = "Street";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(343, 364);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 32);
            label8.TabIndex = 14;
            label8.Text = "Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(724, 130);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 32);
            label9.TabIndex = 13;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(728, 187);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(82, 32);
            label10.TabIndex = 12;
            label10.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(728, 244);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 32);
            label11.TabIndex = 11;
            label11.Text = "email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(525, 127);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 39);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(525, 183);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 39);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(525, 245);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 39);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(525, 301);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 39);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(906, 244);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(180, 39);
            textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(906, 187);
            textBox6.Margin = new Padding(4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(180, 39);
            textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(906, 126);
            textBox7.Margin = new Padding(4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(180, 39);
            textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(525, 360);
            textBox8.Margin = new Padding(4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(180, 39);
            textBox8.TabIndex = 19;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(754, 359);
            checkBox2.Margin = new Padding(4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(303, 36);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "confirm shipping details";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(469, 477);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(0, 45);
            label12.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(489, 477);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(231, 74);
            button1.TabIndex = 25;
            button1.Text = "continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OrderDataGridView
            // 
            OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGridView.Location = new Point(3, 60);
            OrderDataGridView.Name = "OrderDataGridView";
            OrderDataGridView.RowHeadersWidth = 82;
            OrderDataGridView.RowTemplate.Height = 41;
            OrderDataGridView.Size = new Size(333, 224);
            OrderDataGridView.TabIndex = 26;
            // 
            // navbar1
            // 
            navbar1.ImageScalingSize = new Size(32, 32);
            navbar1.Location = new Point(0, 0);
            navbar1.Name = "navbar1";
            navbar1.Size = new Size(1152, 40);
            navbar1.TabIndex = 26;
            navbar1.Text = "navbar1";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 623);
            Controls.Add(OrderDataGridView);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(checkBox2);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(totalPriceLabel);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "OrderForm";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label totalPriceLabel;
        private Label label1;
        private CheckBox checkBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private CheckBox checkBox2;
        private Label label12;
        private Button button1;
        private CustomComponents.Navbar navbar1;
        private DataGridView OrderDataGridView;
    }
}