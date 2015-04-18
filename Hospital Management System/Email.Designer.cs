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
            this.btnExcit = new System.Windows.Forms.Button();
            this.btnRefrsh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSub1
            // 
            this.txtSub1.Location = new System.Drawing.Point(61, 96);
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.Size = new System.Drawing.Size(305, 20);
            this.txtSub1.TabIndex = 0;
            // 
            // txtBody2
            // 
            this.txtBody2.Location = new System.Drawing.Point(61, 135);
            this.txtBody2.Multiline = true;
            this.txtBody2.Name = "txtBody2";
            this.txtBody2.Size = new System.Drawing.Size(305, 149);
            this.txtBody2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Body";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // txtEm3
            // 
            this.txtEm3.Location = new System.Drawing.Point(77, 308);
            this.txtEm3.Name = "txtEm3";
            this.txtEm3.Size = new System.Drawing.Size(289, 20);
            this.txtEm3.TabIndex = 0;
            // 
            // txtPas4
            // 
            this.txtPas4.Location = new System.Drawing.Point(77, 344);
            this.txtPas4.Name = "txtPas4";
            this.txtPas4.PasswordChar = '*';
            this.txtPas4.Size = new System.Drawing.Size(289, 20);
            this.txtPas4.TabIndex = 2;
            // 
            // txtRes5
            // 
            this.txtRes5.Location = new System.Drawing.Point(15, 26);
            this.txtRes5.Multiline = true;
            this.txtRes5.Name = "txtRes5";
            this.txtRes5.Size = new System.Drawing.Size(351, 56);
            this.txtRes5.TabIndex = 3;
            // 
            // btnMail
            // 
            this.btnMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMail.Location = new System.Drawing.Point(172, 381);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(95, 35);
            this.btnMail.TabIndex = 4;
            this.btnMail.Text = "Send Mail";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnExcit
            // 
            this.btnExcit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcit.Location = new System.Drawing.Point(283, 381);
            this.btnExcit.Name = "btnExcit";
            this.btnExcit.Size = new System.Drawing.Size(83, 35);
            this.btnExcit.TabIndex = 5;
            this.btnExcit.Text = "Exit";
            this.btnExcit.UseVisualStyleBackColor = true;
            this.btnExcit.Click += new System.EventHandler(this.btnExcit_Click);
            // 
            // btnRefrsh
            // 
            this.btnRefrsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrsh.Location = new System.Drawing.Point(61, 381);
            this.btnRefrsh.Name = "btnRefrsh";
            this.btnRefrsh.Size = new System.Drawing.Size(91, 34);
            this.btnRefrsh.TabIndex = 6;
            this.btnRefrsh.Text = "Refresh";
            this.btnRefrsh.UseVisualStyleBackColor = true;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(378, 428);
            this.Controls.Add(this.btnRefrsh);
            this.Controls.Add(this.btnExcit);
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
            this.Load += new System.EventHandler(this.Email_Load);
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
        private System.Windows.Forms.Button btnExcit;
        private System.Windows.Forms.Button btnRefrsh;
    }
}