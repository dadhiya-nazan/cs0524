﻿namespace cs0524
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
            label1 = new Label();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(395, 77);
            button1.Name = "button1";
            button1.Size = new Size(117, 44);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, 152);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(395, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 43);
            textBox1.TabIndex = 2;
            textBox1.Text = "長崎湧斗";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(598, 77);
            button2.Name = "button2";
            button2.Size = new Size(146, 73);
            button2.TabIndex = 3;
            button2.Text = "演習7-1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(598, 170);
            button3.Name = "button3";
            button3.Size = new Size(146, 73);
            button3.TabIndex = 4;
            button3.Text = "演習7-2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(598, 266);
            button4.Name = "button4";
            button4.Size = new Size(146, 73);
            button4.TabIndex = 5;
            button4.Text = "演習7-4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 504);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}