namespace TI
{
    partial class Lab2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.publicKey_field = new System.Windows.Forms.TextBox();
            this.privateKey_field = new System.Windows.Forms.TextBox();
            this.generateKey_btn = new System.Windows.Forms.Button();
            this.inText_field = new System.Windows.Forms.TextBox();
            this.encryptText_field = new System.Windows.Forms.TextBox();
            this.decryptText_field = new System.Windows.Forms.TextBox();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.publicKey_label = new System.Windows.Forms.Label();
            this.privateKey_label = new System.Windows.Forms.Label();
            this.inText_label = new System.Windows.Forms.Label();
            this.encrypt_label = new System.Windows.Forms.Label();
            this.decrypt_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // publicKey_field
            // 
            this.publicKey_field.Location = new System.Drawing.Point(137, 300);
            this.publicKey_field.Margin = new System.Windows.Forms.Padding(2);
            this.publicKey_field.Name = "publicKey_field";
            this.publicKey_field.Size = new System.Drawing.Size(241, 20);
            this.publicKey_field.TabIndex = 0;
            // 
            // privateKey_field
            // 
            this.privateKey_field.Location = new System.Drawing.Point(137, 337);
            this.privateKey_field.Margin = new System.Windows.Forms.Padding(2);
            this.privateKey_field.Name = "privateKey_field";
            this.privateKey_field.Size = new System.Drawing.Size(241, 20);
            this.privateKey_field.TabIndex = 1;
            // 
            // generateKey_btn
            // 
            this.generateKey_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.generateKey_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.generateKey_btn.FlatAppearance.BorderSize = 0;
            this.generateKey_btn.Location = new System.Drawing.Point(137, 361);
            this.generateKey_btn.Margin = new System.Windows.Forms.Padding(2);
            this.generateKey_btn.Name = "generateKey_btn";
            this.generateKey_btn.Size = new System.Drawing.Size(241, 24);
            this.generateKey_btn.TabIndex = 2;
            this.generateKey_btn.Text = "Создать";
            this.generateKey_btn.UseVisualStyleBackColor = false;
            this.generateKey_btn.Click += new System.EventHandler(this.GenerateKey);
            // 
            // inText_field
            // 
            this.inText_field.Location = new System.Drawing.Point(11, 24);
            this.inText_field.Margin = new System.Windows.Forms.Padding(2);
            this.inText_field.Multiline = true;
            this.inText_field.Name = "inText_field";
            this.inText_field.Size = new System.Drawing.Size(493, 58);
            this.inText_field.TabIndex = 3;
            // 
            // encryptText_field
            // 
            this.encryptText_field.Location = new System.Drawing.Point(11, 99);
            this.encryptText_field.Margin = new System.Windows.Forms.Padding(2);
            this.encryptText_field.Multiline = true;
            this.encryptText_field.Name = "encryptText_field";
            this.encryptText_field.Size = new System.Drawing.Size(493, 107);
            this.encryptText_field.TabIndex = 4;
            // 
            // decryptText_field
            // 
            this.decryptText_field.Location = new System.Drawing.Point(11, 223);
            this.decryptText_field.Margin = new System.Windows.Forms.Padding(2);
            this.decryptText_field.Multiline = true;
            this.decryptText_field.Name = "decryptText_field";
            this.decryptText_field.Size = new System.Drawing.Size(493, 58);
            this.decryptText_field.TabIndex = 5;
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.encrypt_btn.FlatAppearance.BorderSize = 0;
            this.encrypt_btn.Location = new System.Drawing.Point(11, 285);
            this.encrypt_btn.Margin = new System.Windows.Forms.Padding(2);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(122, 100);
            this.encrypt_btn.TabIndex = 6;
            this.encrypt_btn.Text = "Шифрование";
            this.encrypt_btn.UseVisualStyleBackColor = false;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_Text);
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.decrypt_btn.Location = new System.Drawing.Point(382, 285);
            this.decrypt_btn.Margin = new System.Windows.Forms.Padding(2);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(122, 100);
            this.decrypt_btn.TabIndex = 7;
            this.decrypt_btn.Text = "Дешифрование";
            this.decrypt_btn.UseVisualStyleBackColor = false;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_Text);
            // 
            // publicKey_label
            // 
            this.publicKey_label.AutoSize = true;
            this.publicKey_label.Location = new System.Drawing.Point(208, 285);
            this.publicKey_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publicKey_label.Name = "publicKey_label";
            this.publicKey_label.Size = new System.Drawing.Size(90, 13);
            this.publicKey_label.TabIndex = 8;
            this.publicKey_label.Text = "Открытый ключ:";
            // 
            // privateKey_label
            // 
            this.privateKey_label.AutoSize = true;
            this.privateKey_label.Location = new System.Drawing.Point(208, 322);
            this.privateKey_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.privateKey_label.Name = "privateKey_label";
            this.privateKey_label.Size = new System.Drawing.Size(94, 13);
            this.privateKey_label.TabIndex = 9;
            this.privateKey_label.Text = "Секретный ключ:";
            // 
            // inText_label
            // 
            this.inText_label.AutoSize = true;
            this.inText_label.Location = new System.Drawing.Point(206, 9);
            this.inText_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inText_label.Name = "inText_label";
            this.inText_label.Size = new System.Drawing.Size(92, 13);
            this.inText_label.TabIndex = 10;
            this.inText_label.Text = "Исходный текст:";
            // 
            // encrypt_label
            // 
            this.encrypt_label.AutoSize = true;
            this.encrypt_label.Location = new System.Drawing.Point(193, 84);
            this.encrypt_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.encrypt_label.Name = "encrypt_label";
            this.encrypt_label.Size = new System.Drawing.Size(126, 13);
            this.encrypt_label.TabIndex = 11;
            this.encrypt_label.Text = "Зашифрованный текст:";
            // 
            // decrypt_label
            // 
            this.decrypt_label.AutoSize = true;
            this.decrypt_label.Location = new System.Drawing.Point(187, 208);
            this.decrypt_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.decrypt_label.Name = "decrypt_label";
            this.decrypt_label.Size = new System.Drawing.Size(132, 13);
            this.decrypt_label.TabIndex = 12;
            this.decrypt_label.Text = "Расшифрованный текст:";
            // 
            // Lab_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(515, 397);
            this.Controls.Add(this.decrypt_label);
            this.Controls.Add(this.encrypt_label);
            this.Controls.Add(this.inText_label);
            this.Controls.Add(this.privateKey_label);
            this.Controls.Add(this.publicKey_label);
            this.Controls.Add(this.decrypt_btn);
            this.Controls.Add(this.encrypt_btn);
            this.Controls.Add(this.decryptText_field);
            this.Controls.Add(this.encryptText_field);
            this.Controls.Add(this.inText_field);
            this.Controls.Add(this.generateKey_btn);
            this.Controls.Add(this.privateKey_field);
            this.Controls.Add(this.publicKey_field);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lab2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox publicKey_field;
        private System.Windows.Forms.TextBox privateKey_field;
        private System.Windows.Forms.Button generateKey_btn;
        private System.Windows.Forms.TextBox inText_field;
        private System.Windows.Forms.TextBox encryptText_field;
        private System.Windows.Forms.TextBox decryptText_field;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.Label publicKey_label;
        private System.Windows.Forms.Label privateKey_label;
        private System.Windows.Forms.Label inText_label;
        private System.Windows.Forms.Label encrypt_label;
        private System.Windows.Forms.Label decrypt_label;
    }
}

