﻿namespace Practica__25_vsed
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
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 14.25F);
            label1.Location = new Point(123, 51);
            label1.Name = "label1";
            label1.Size = new Size(496, 21);
            label1.TabIndex = 0;
            label1.Text = "GENERA LOS NUMEROS DEL 1 AL 20 CON WHITE";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Cooper Black", 14.25F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(123, 164);
            button1.Name = "button1";
            button1.Size = new Size(157, 84);
            button1.TabIndex = 1;
            button1.Text = "IMPRIME EN PANTALLEA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Blue;
            listBox1.Font = new Font("Cooper Black", 14.25F);
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(485, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(165, 277);
            listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListBox listBox1;
    }
}
