﻿namespace DataBase_Unieversity_System
{
    partial class DeleteTeacher
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtIDTeacher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(97, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 92);
            this.button1.TabIndex = 5;
            this.button1.Text = "حذف استاد";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIDTeacher
            // 
            this.txtIDTeacher.Location = new System.Drawing.Point(68, 81);
            this.txtIDTeacher.Name = "txtIDTeacher";
            this.txtIDTeacher.Size = new System.Drawing.Size(192, 22);
            this.txtIDTeacher.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "کد استاد";
            // 
            // DeleteTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIDTeacher);
            this.Controls.Add(this.label1);
            this.Name = "DeleteTeacher";
            this.Text = "DeleteTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteTeacher_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIDTeacher;
        private System.Windows.Forms.Label label1;
    }
}