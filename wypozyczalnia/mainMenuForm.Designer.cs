namespace wypozyczalnia
{
    partial class mainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuForm));
            this.buttonCloseProgram = new System.Windows.Forms.Button();
            this.employeeCreateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carRemoveButton = new System.Windows.Forms.Button();
            this.carAddButton = new System.Windows.Forms.Button();
            this.carEditButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employeeRemoveButton = new System.Windows.Forms.Button();
            this.employeeEditButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.customerRemoveButton = new System.Windows.Forms.Button();
            this.customerCreateButton = new System.Windows.Forms.Button();
            this.customerEditButton = new System.Windows.Forms.Button();
            this.reservationsGroupBox = new System.Windows.Forms.GroupBox();
            this.reservationsRemoveButton = new System.Windows.Forms.Button();
            this.reservationsAddButton = new System.Windows.Forms.Button();
            this.reservationsEditButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.reservationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCloseProgram
            // 
            this.buttonCloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.buttonCloseProgram.ForeColor = System.Drawing.Color.Purple;
            this.buttonCloseProgram.Location = new System.Drawing.Point(633, 400);
            this.buttonCloseProgram.Name = "buttonCloseProgram";
            this.buttonCloseProgram.Size = new System.Drawing.Size(138, 30);
            this.buttonCloseProgram.TabIndex = 0;
            this.buttonCloseProgram.Text = "Zamknij aplikację";
            this.buttonCloseProgram.UseVisualStyleBackColor = true;
            // 
            // employeeCreateButton
            // 
            this.employeeCreateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.employeeCreateButton.ForeColor = System.Drawing.Color.Purple;
            this.employeeCreateButton.Location = new System.Drawing.Point(6, 19);
            this.employeeCreateButton.Name = "employeeCreateButton";
            this.employeeCreateButton.Size = new System.Drawing.Size(138, 30);
            this.employeeCreateButton.TabIndex = 1;
            this.employeeCreateButton.Text = "Dodaj pracownika";
            this.employeeCreateButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carRemoveButton);
            this.groupBox1.Controls.Add(this.carAddButton);
            this.groupBox1.Controls.Add(this.carEditButton);
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarządzanie pojazdami";
            // 
            // carRemoveButton
            // 
            this.carRemoveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.carRemoveButton.ForeColor = System.Drawing.Color.Purple;
            this.carRemoveButton.Location = new System.Drawing.Point(295, 20);
            this.carRemoveButton.Name = "carRemoveButton";
            this.carRemoveButton.Size = new System.Drawing.Size(138, 30);
            this.carRemoveButton.TabIndex = 6;
            this.carRemoveButton.Text = "Usuń samochód";
            this.carRemoveButton.UseVisualStyleBackColor = false;
            // 
            // carAddButton
            // 
            this.carAddButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.carAddButton.ForeColor = System.Drawing.Color.Purple;
            this.carAddButton.Location = new System.Drawing.Point(7, 20);
            this.carAddButton.Name = "carAddButton";
            this.carAddButton.Size = new System.Drawing.Size(138, 30);
            this.carAddButton.TabIndex = 0;
            this.carAddButton.Text = "Dodaj samochód";
            this.carAddButton.UseVisualStyleBackColor = false;
            this.carAddButton.Click += new System.EventHandler(this.carAddButton_Click);
            // 
            // carEditButton
            // 
            this.carEditButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.carEditButton.ForeColor = System.Drawing.Color.Purple;
            this.carEditButton.Location = new System.Drawing.Point(151, 20);
            this.carEditButton.Name = "carEditButton";
            this.carEditButton.Size = new System.Drawing.Size(138, 30);
            this.carEditButton.TabIndex = 5;
            this.carEditButton.Text = "Edytuj samochód";
            this.carEditButton.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.employeeRemoveButton);
            this.groupBox2.Controls.Add(this.employeeCreateButton);
            this.groupBox2.Controls.Add(this.employeeEditButton);
            this.groupBox2.Enabled = false;
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zarządzanie pracownikami";
            // 
            // employeeRemoveButton
            // 
            this.employeeRemoveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeRemoveButton.Enabled = false;
            this.employeeRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.employeeRemoveButton.ForeColor = System.Drawing.Color.Purple;
            this.employeeRemoveButton.Location = new System.Drawing.Point(294, 19);
            this.employeeRemoveButton.Name = "employeeRemoveButton";
            this.employeeRemoveButton.Size = new System.Drawing.Size(138, 30);
            this.employeeRemoveButton.TabIndex = 3;
            this.employeeRemoveButton.Text = "Usuń pracownika (?)";
            this.employeeRemoveButton.UseVisualStyleBackColor = false;
            // 
            // employeeEditButton
            // 
            this.employeeEditButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.employeeEditButton.ForeColor = System.Drawing.Color.Purple;
            this.employeeEditButton.Location = new System.Drawing.Point(150, 19);
            this.employeeEditButton.Name = "employeeEditButton";
            this.employeeEditButton.Size = new System.Drawing.Size(138, 30);
            this.employeeEditButton.TabIndex = 2;
            this.employeeEditButton.Text = "Edytuj pracownika";
            this.employeeEditButton.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.customerRemoveButton);
            this.groupBox3.Controls.Add(this.customerCreateButton);
            this.groupBox3.Controls.Add(this.customerEditButton);
            this.groupBox3.ForeColor = System.Drawing.Color.Purple;
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 91);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zarządzanie klientami";
            // 
            // customerRemoveButton
            // 
            this.customerRemoveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.customerRemoveButton.Enabled = false;
            this.customerRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.customerRemoveButton.ForeColor = System.Drawing.Color.Purple;
            this.customerRemoveButton.Location = new System.Drawing.Point(294, 19);
            this.customerRemoveButton.Name = "customerRemoveButton";
            this.customerRemoveButton.Size = new System.Drawing.Size(138, 30);
            this.customerRemoveButton.TabIndex = 2;
            this.customerRemoveButton.Text = "Usuń klienta (?)";
            this.customerRemoveButton.UseVisualStyleBackColor = false;
            // 
            // customerCreateButton
            // 
            this.customerCreateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.customerCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.customerCreateButton.ForeColor = System.Drawing.Color.Purple;
            this.customerCreateButton.Location = new System.Drawing.Point(6, 19);
            this.customerCreateButton.Name = "customerCreateButton";
            this.customerCreateButton.Size = new System.Drawing.Size(138, 30);
            this.customerCreateButton.TabIndex = 0;
            this.customerCreateButton.Text = "Dodaj klienta";
            this.customerCreateButton.UseVisualStyleBackColor = false;
            // 
            // customerEditButton
            // 
            this.customerEditButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.customerEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.customerEditButton.ForeColor = System.Drawing.Color.Purple;
            this.customerEditButton.Location = new System.Drawing.Point(150, 19);
            this.customerEditButton.Name = "customerEditButton";
            this.customerEditButton.Size = new System.Drawing.Size(138, 30);
            this.customerEditButton.TabIndex = 1;
            this.customerEditButton.Text = "Edytuj klienta";
            this.customerEditButton.UseVisualStyleBackColor = false;
            // 
            // reservationsGroupBox
            // 
            this.reservationsGroupBox.Controls.Add(this.reservationsRemoveButton);
            this.reservationsGroupBox.Controls.Add(this.reservationsAddButton);
            this.reservationsGroupBox.Controls.Add(this.reservationsEditButton);
            this.reservationsGroupBox.ForeColor = System.Drawing.Color.Purple;
            this.reservationsGroupBox.Location = new System.Drawing.Point(12, 206);
            this.reservationsGroupBox.Name = "reservationsGroupBox";
            this.reservationsGroupBox.Size = new System.Drawing.Size(759, 91);
            this.reservationsGroupBox.TabIndex = 4;
            this.reservationsGroupBox.TabStop = false;
            this.reservationsGroupBox.Text = "Zarządzanie rezerwacjami";
            // 
            // reservationsRemoveButton
            // 
            this.reservationsRemoveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reservationsRemoveButton.Enabled = false;
            this.reservationsRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.reservationsRemoveButton.ForeColor = System.Drawing.Color.Purple;
            this.reservationsRemoveButton.Location = new System.Drawing.Point(294, 19);
            this.reservationsRemoveButton.Name = "reservationsRemoveButton";
            this.reservationsRemoveButton.Size = new System.Drawing.Size(138, 30);
            this.reservationsRemoveButton.TabIndex = 3;
            this.reservationsRemoveButton.Text = "Usuń rezerwację";
            this.reservationsRemoveButton.UseVisualStyleBackColor = false;
            // 
            // reservationsAddButton
            // 
            this.reservationsAddButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reservationsAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.reservationsAddButton.ForeColor = System.Drawing.Color.Purple;
            this.reservationsAddButton.Location = new System.Drawing.Point(6, 19);
            this.reservationsAddButton.Name = "reservationsAddButton";
            this.reservationsAddButton.Size = new System.Drawing.Size(138, 30);
            this.reservationsAddButton.TabIndex = 1;
            this.reservationsAddButton.Text = "Dodaj rezerwację";
            this.reservationsAddButton.UseVisualStyleBackColor = false;
            // 
            // reservationsEditButton
            // 
            this.reservationsEditButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reservationsEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.reservationsEditButton.ForeColor = System.Drawing.Color.Purple;
            this.reservationsEditButton.Location = new System.Drawing.Point(150, 19);
            this.reservationsEditButton.Name = "reservationsEditButton";
            this.reservationsEditButton.Size = new System.Drawing.Size(138, 30);
            this.reservationsEditButton.TabIndex = 2;
            this.reservationsEditButton.Text = "Edytuj rezerwację";
            this.reservationsEditButton.UseVisualStyleBackColor = false;
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 444);
            this.Controls.Add(this.reservationsGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCloseProgram);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenuForm";
            this.Text = "Menu główne systemu wypożyczalni";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.reservationsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseProgram;
        private System.Windows.Forms.Button employeeCreateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button employeeRemoveButton;
        private System.Windows.Forms.Button employeeEditButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button customerRemoveButton;
        private System.Windows.Forms.Button customerCreateButton;
        private System.Windows.Forms.Button customerEditButton;
        private System.Windows.Forms.Button carRemoveButton;
        private System.Windows.Forms.Button carAddButton;
        private System.Windows.Forms.Button carEditButton;
        private System.Windows.Forms.GroupBox reservationsGroupBox;
        private System.Windows.Forms.Button reservationsRemoveButton;
        private System.Windows.Forms.Button reservationsAddButton;
        private System.Windows.Forms.Button reservationsEditButton;
    }
}