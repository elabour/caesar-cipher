namespace caesar_cipher
{
    partial class Form1
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
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_plain_text = new System.Windows.Forms.TextBox();
            this.txt_shift = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_encrypted_text = new System.Windows.Forms.TextBox();
            this.txt_decrypted_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(190, 146);
            this.btn_encrypt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(178, 51);
            this.btn_encrypt.TabIndex = 0;
            this.btn_encrypt.Text = "encrypt_text";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(181, 290);
            this.btn_decrypt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(178, 51);
            this.btn_decrypt.TabIndex = 1;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "text to encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "shift";
            // 
            // txt_plain_text
            // 
            this.txt_plain_text.Location = new System.Drawing.Point(204, 49);
            this.txt_plain_text.Name = "txt_plain_text";
            this.txt_plain_text.Size = new System.Drawing.Size(325, 30);
            this.txt_plain_text.TabIndex = 4;
            // 
            // txt_shift
            // 
            this.txt_shift.Location = new System.Drawing.Point(203, 88);
            this.txt_shift.Name = "txt_shift";
            this.txt_shift.Size = new System.Drawing.Size(68, 30);
            this.txt_shift.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "encrypted text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "plain text ";
            // 
            // txt_encrypted_text
            // 
            this.txt_encrypted_text.Location = new System.Drawing.Point(204, 222);
            this.txt_encrypted_text.Name = "txt_encrypted_text";
            this.txt_encrypted_text.Size = new System.Drawing.Size(325, 30);
            this.txt_encrypted_text.TabIndex = 8;
            // 
            // txt_decrypted_text
            // 
            this.txt_decrypted_text.Location = new System.Drawing.Point(203, 370);
            this.txt_decrypted_text.Name = "txt_decrypted_text";
            this.txt_decrypted_text.Size = new System.Drawing.Size(325, 30);
            this.txt_decrypted_text.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 477);
            this.Controls.Add(this.txt_decrypted_text);
            this.Controls.Add(this.txt_encrypted_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_shift);
            this.Controls.Add(this.txt_plain_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Caesar Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_plain_text;
        private System.Windows.Forms.TextBox txt_shift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_encrypted_text;
        private System.Windows.Forms.TextBox txt_decrypted_text;
    }
}

