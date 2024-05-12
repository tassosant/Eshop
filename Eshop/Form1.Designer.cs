namespace Eshop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            navbar1 = new CustomComponents.Navbar(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(114, 80);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(177, 51);
            button1.TabIndex = 0;
            button1.Text = "view products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += viewProducts;
            // 
            // button2
            // 
            button2.Location = new Point(114, 181);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(177, 45);
            button2.TabIndex = 1;
            button2.Text = "go to cart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // navbar1
            // 
            navbar1.ImageScalingSize = new Size(32, 32);
            navbar1.Location = new Point(0, 0);
            navbar1.Name = "navbar1";
            navbar1.Size = new Size(1040, 40);
            navbar1.TabIndex = 2;
            navbar1.Text = "navbar1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(navbar1);
            MainMenuStrip = navbar1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private CustomComponents.Navbar navbar1;
    }
}