namespace Hospital_Management_System
{
    partial class Email
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
            this.txtSub1 = new System.Windows.Forms.TextBox();
            this.txtBody2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEm3 = new System.Windows.Forms.TextBox();
            this.txtPas4 = new System.Windows.Forms.TextBox();
            this.txtRes5 = new System.Windows.Forms.TextBox();
            this.btnMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSub1
            // 
            this.txtSub1.Location = new System.Drawing.Point(61, 96);
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.Size = new System.Drawing.Size(194, 20);
            this.txtSub1.TabIndex = 0;
            // 
            // txtBody2
            // 
            this.txtBody2.Location = new System.Drawing.Point(61, 135);
            this.txtBody2.Multiline = true;
            this.txtBody2.Name = "txtBody2";
            this.txtBody2.Size = new System.Drawing.Size(194, 149);
            this.txtBody2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Body";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // txtEm3
            // 
            this.txtEm3.Location = new System.Drawing.Point(61, 308);
            this.txtEm3.Name = "txtEm3";
            this.txtEm3.Size = new System.Drawing.Size(194, 20);
            this.txtEm3.TabIndex = 0;
            // 
            // txtPas4
            // 
            this.txtPas4.Location = new System.Drawing.Point(61, 344);
            this.txtPas4.Name = "txtPas4";
            this.txtPas4.PasswordChar = '*';
            this.txtPas4.Size = new System.Drawing.Size(194, 20);
            this.txtPas4.TabIndex = 2;
            // 
            // txtRes5
            // 
            this.txtRes5.Location = new System.Drawing.Point(15, 26);
            this.txtRes5.Multiline = true;
            this.txtRes5.Name = "txtRes5";
            this.txtRes5.Size = new System.Drawing.Size(240, 56);
            this.txtRes5.TabIndex = 3;
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(160, 389);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(95, 27);
            this.btnMail.TabIndex = 4;
            this.btnMail.Text = "Send Mail";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 428);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.txtRes5);
            this.Controls.Add(this.txtPas4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBody2);
            this.Controls.Add(this.txtEm3);
            this.Controls.Add(this.txtSub1);
            this.Name = "Email";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSub1;
        private System.Windows.Forms.TextBox txtBody2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEm3;
        private System.Windows.Forms.TextBox txtPas4;
        private System.Windows.Forms.TextBox txtRes5;
        private System.Windows.Forms.Button btnMail;
    }
}