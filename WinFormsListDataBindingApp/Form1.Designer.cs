﻿namespace WinFormsListDataBindingApp
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
            lstUsers = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lstUsers
            // 
            lstUsers.Font = new Font("Segoe UI", 22F);
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 40;
            lstUsers.Location = new Point(21, 25);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(448, 364);
            lstUsers.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(698, 366);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 414);
            Controls.Add(button1);
            Controls.Add(lstUsers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstUsers;
        private Button button1;
    }
}
