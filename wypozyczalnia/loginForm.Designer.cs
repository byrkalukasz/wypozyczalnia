namespace wypozyczalnia
{
    partial class loginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginData_groupBox = new System.Windows.Forms.GroupBox();
            this.login_button = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loginData_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginData_groupBox
            // 
            this.loginData_groupBox.BackColor = System.Drawing.SystemColors.Window;
            this.loginData_groupBox.Controls.Add(this.login_button);
            this.loginData_groupBox.Controls.Add(this.password_textBox);
            this.loginData_groupBox.Controls.Add(this.login_textBox);
            this.loginData_groupBox.Controls.Add(this.password_label);
            this.loginData_groupBox.Controls.Add(this.login_label);
            this.loginData_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginData_groupBox.ForeColor = System.Drawing.Color.Purple;
            this.loginData_groupBox.Location = new System.Drawing.Point(12, 12);
            this.loginData_groupBox.Name = "loginData_groupBox";
            this.loginData_groupBox.Size = new System.Drawing.Size(430, 105);
            this.loginData_groupBox.TabIndex = 1;
            this.loginData_groupBox.TabStop = false;
            this.loginData_groupBox.Text = "Wprowadz dane ";
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_button.ForeColor = System.Drawing.Color.Purple;
            this.login_button.Location = new System.Drawing.Point(324, 19);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(97, 46);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Zaloguj";
            this.login_button.UseVisualStyleBackColor = false;
			this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.password_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(57)))), ((int)(((byte)(128)))));
            this.password_textBox.Location = new System.Drawing.Point(112, 45);
            this.password_textBox.MaxLength = 32;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(206, 20);
            this.password_textBox.TabIndex = 3;
            // 
            // login_textBox
            // 
            this.login_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.login_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(57)))), ((int)(((byte)(128)))));
            this.login_textBox.Location = new System.Drawing.Point(112, 19);
            this.login_textBox.MaxLength = 32;
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(206, 20);
            this.login_textBox.TabIndex = 2;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.ForeColor = System.Drawing.Color.Purple;
            this.password_label.Location = new System.Drawing.Point(43, 39);
            this.password_label.Name = "password_label";
            this.password_label.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.password_label.Size = new System.Drawing.Size(63, 23);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Hasło : ";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.ForeColor = System.Drawing.Color.Purple;
            this.login_label.Location = new System.Drawing.Point(12, 16);
            this.login_label.Name = "login_label";
            this.login_label.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.login_label.Size = new System.Drawing.Size(94, 23);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Użytkownik : ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(220, 323);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(452, 125);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.loginData_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.Text = "Logowanie do systemu wypożyczalni";
            this.loginData_groupBox.ResumeLayout(false);
            this.loginData_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox loginData_groupBox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

