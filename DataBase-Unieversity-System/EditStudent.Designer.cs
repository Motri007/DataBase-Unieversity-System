namespace DataBase_Unieversity_System
{
    partial class EditStudent
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
            this.btnCODStudent = new System.Windows.Forms.Label();
            this.txtCOD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNEWPhone = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCODStudent
            // 
            this.btnCODStudent.AutoSize = true;
            this.btnCODStudent.Location = new System.Drawing.Point(290, 63);
            this.btnCODStudent.Name = "btnCODStudent";
            this.btnCODStudent.Size = new System.Drawing.Size(92, 16);
            this.btnCODStudent.TabIndex = 0;
            this.btnCODStudent.Text = "کد دانشجویی فرد";
            // 
            // txtCOD
            // 
            this.txtCOD.Location = new System.Drawing.Point(293, 99);
            this.txtCOD.Name = "txtCOD";
            this.txtCOD.Size = new System.Drawing.Size(100, 22);
            this.txtCOD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "شماره موبایل جدید";
            // 
            // txtNEWPhone
            // 
            this.txtNEWPhone.Location = new System.Drawing.Point(114, 99);
            this.txtNEWPhone.Name = "txtNEWPhone";
            this.txtNEWPhone.Size = new System.Drawing.Size(100, 22);
            this.txtNEWPhone.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(197, 145);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(122, 82);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "ثبت";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 257);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtNEWPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCOD);
            this.Controls.Add(this.btnCODStudent);
            this.Name = "EditStudent";
            this.Text = "Edit Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditStudent_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCODStudent;
        private System.Windows.Forms.TextBox txtCOD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNEWPhone;
        private System.Windows.Forms.Button btnEnter;
    }
}