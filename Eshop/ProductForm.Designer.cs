namespace Eshop
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 1;
            label1.Text = "teapot";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(372, 101);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(277, 210);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "product description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 349);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 3;
            label2.Text = "12,00";
            // 
            // button1
            // 
            button1.Location = new Point(372, 344);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "add ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(630, 367);
            button2.Name = "button2";
            button2.Size = new Size(147, 44);
            button2.TabIndex = 5;
            button2.Text = "go to cart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ProductForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}