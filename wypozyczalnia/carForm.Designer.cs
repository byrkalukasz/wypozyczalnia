namespace wypozyczalnia
{
    partial class carForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carForm));
            this.carIdentifier_groupBox = new System.Windows.Forms.GroupBox();
            this.carRemove_button = new System.Windows.Forms.Button();
            this.carIdentifierNextID_button = new System.Windows.Forms.Button();
            this.carIdentifierID_label = new System.Windows.Forms.Label();
            this.carIdentifierPrevID_button = new System.Windows.Forms.Button();
            this.carIdentifierID_textBox = new System.Windows.Forms.TextBox();
            this.carCancel_button = new System.Windows.Forms.Button();
            this.carSave_button = new System.Windows.Forms.Button();
            this.carInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.carInfoDataTechnicalReview_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.carInfoDataOC_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.carInfoReservedTRUE_checkBox = new System.Windows.Forms.CheckBox();
            this.carInfoAvailability_label = new System.Windows.Forms.Label();
            this.carInfoAvailabileTRUE_checkBox = new System.Windows.Forms.CheckBox();
            this.carInfoBody_comboBox = new System.Windows.Forms.ComboBox();
            this.carInfoVIN_textBox = new System.Windows.Forms.TextBox();
            this.carInfoVIN_label = new System.Windows.Forms.Label();
            this.carInfoLicensePlate_textBox = new System.Windows.Forms.TextBox();
            this.carInfoLicensePlate_label = new System.Windows.Forms.Label();
            this.carInfoMileage_textBox = new System.Windows.Forms.TextBox();
            this.carInfoMileage_label = new System.Windows.Forms.Label();
            this.carInfoDataOC_label = new System.Windows.Forms.Label();
            this.carInfoDataTechnicalReview_label = new System.Windows.Forms.Label();
            this.carInfoBodyColor_textBox = new System.Windows.Forms.TextBox();
            this.carInfoBodyColor_label = new System.Windows.Forms.Label();
            this.carInfoPassengers_textBox = new System.Windows.Forms.TextBox();
            this.carInfoPassengers_label = new System.Windows.Forms.Label();
            this.carInfoDoors_textBox = new System.Windows.Forms.TextBox();
            this.carInfoDoors_label = new System.Windows.Forms.Label();
            this.carInfoBody_label = new System.Windows.Forms.Label();
            this.carInfoYear_textBox = new System.Windows.Forms.TextBox();
            this.carInfoYear_label = new System.Windows.Forms.Label();
            this.carInfoModel_textBox = new System.Windows.Forms.TextBox();
            this.carInfoModel_label = new System.Windows.Forms.Label();
            this.carInfoProducent_textBox = new System.Windows.Forms.TextBox();
            this.carInfoProducent_label = new System.Windows.Forms.Label();
            this.carPrice_groupBox = new System.Windows.Forms.GroupBox();
            this.carPriceYear_textBox = new System.Windows.Forms.TextBox();
            this.carPriceYear_label = new System.Windows.Forms.Label();
            this.carPriceMonth_textBox = new System.Windows.Forms.TextBox();
            this.carPriceWeek_textBox = new System.Windows.Forms.TextBox();
            this.carPriceWeek_label = new System.Windows.Forms.Label();
            this.carPriceMonth_label = new System.Windows.Forms.Label();
            this.carPriceDay_label = new System.Windows.Forms.Label();
            this.carPriceDay_textBox = new System.Windows.Forms.TextBox();
            this.carAdditional_groupBox = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.carIdentifier_groupBox.SuspendLayout();
            this.carInfo_groupBox.SuspendLayout();
            this.carPrice_groupBox.SuspendLayout();
            this.carAdditional_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // carIdentifier_groupBox
            // 
            this.carIdentifier_groupBox.Controls.Add(this.carRemove_button);
            this.carIdentifier_groupBox.Controls.Add(this.carIdentifierNextID_button);
            this.carIdentifier_groupBox.Controls.Add(this.carIdentifierID_label);
            this.carIdentifier_groupBox.Controls.Add(this.carIdentifierPrevID_button);
            this.carIdentifier_groupBox.Controls.Add(this.carIdentifierID_textBox);
            this.carIdentifier_groupBox.ForeColor = System.Drawing.Color.Purple;
            this.carIdentifier_groupBox.Location = new System.Drawing.Point(12, 12);
            this.carIdentifier_groupBox.Name = "carIdentifier_groupBox";
            this.carIdentifier_groupBox.Size = new System.Drawing.Size(664, 57);
            this.carIdentifier_groupBox.TabIndex = 1;
            this.carIdentifier_groupBox.TabStop = false;
            this.carIdentifier_groupBox.Text = "Identyfikator pojazdu";
            // 
            // carRemove_button
            // 
            this.carRemove_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carRemove_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.carRemove_button.ForeColor = System.Drawing.Color.Purple;
            this.carRemove_button.Location = new System.Drawing.Point(435, 17);
            this.carRemove_button.Name = "carRemove_button";
            this.carRemove_button.Size = new System.Drawing.Size(138, 30);
            this.carRemove_button.TabIndex = 26;
            this.carRemove_button.Text = "USUŃ";
            this.carRemove_button.UseVisualStyleBackColor = false;
            this.carRemove_button.Click += new System.EventHandler(this.carRemove_button_Click);
            // 
            // carIdentifierNextID_button
            // 
            this.carIdentifierNextID_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carIdentifierNextID_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.carIdentifierNextID_button.Location = new System.Drawing.Point(251, 17);
            this.carIdentifierNextID_button.Name = "carIdentifierNextID_button";
            this.carIdentifierNextID_button.Size = new System.Drawing.Size(69, 30);
            this.carIdentifierNextID_button.TabIndex = 1;
            this.carIdentifierNextID_button.Text = "> > >";
            this.carIdentifierNextID_button.UseVisualStyleBackColor = false;
            // 
            // carIdentifierID_label
            // 
            this.carIdentifierID_label.AutoSize = true;
            this.carIdentifierID_label.Location = new System.Drawing.Point(81, 26);
            this.carIdentifierID_label.Name = "carIdentifierID_label";
            this.carIdentifierID_label.Size = new System.Drawing.Size(58, 13);
            this.carIdentifierID_label.TabIndex = 3;
            this.carIdentifierID_label.Text = "ID pojazdu";
            // 
            // carIdentifierPrevID_button
            // 
            this.carIdentifierPrevID_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carIdentifierPrevID_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.carIdentifierPrevID_button.Location = new System.Drawing.Point(6, 17);
            this.carIdentifierPrevID_button.Name = "carIdentifierPrevID_button";
            this.carIdentifierPrevID_button.Size = new System.Drawing.Size(69, 30);
            this.carIdentifierPrevID_button.TabIndex = 0;
            this.carIdentifierPrevID_button.Text = "< < <";
            this.carIdentifierPrevID_button.UseVisualStyleBackColor = false;
            // 
            // carIdentifierID_textBox
            // 
            this.carIdentifierID_textBox.Location = new System.Drawing.Point(145, 23);
            this.carIdentifierID_textBox.Name = "carIdentifierID_textBox";
            this.carIdentifierID_textBox.Size = new System.Drawing.Size(100, 20);
            this.carIdentifierID_textBox.TabIndex = 2;
            this.carIdentifierID_textBox.Text = "0";
            // 
            // carCancel_button
            // 
            this.carCancel_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carCancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.carCancel_button.ForeColor = System.Drawing.Color.Purple;
            this.carCancel_button.Location = new System.Drawing.Point(356, 390);
            this.carCancel_button.Name = "carCancel_button";
            this.carCancel_button.Size = new System.Drawing.Size(138, 30);
            this.carCancel_button.TabIndex = 5;
            this.carCancel_button.Text = "WRÓĆ DO MENU";
            this.carCancel_button.UseVisualStyleBackColor = false;
            this.carCancel_button.Click += new System.EventHandler(this.carCancel_button_Click);
            // 
            // carSave_button
            // 
            this.carSave_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carSave_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold);
            this.carSave_button.ForeColor = System.Drawing.Color.Purple;
            this.carSave_button.Location = new System.Drawing.Point(523, 390);
            this.carSave_button.Name = "carSave_button";
            this.carSave_button.Size = new System.Drawing.Size(138, 30);
            this.carSave_button.TabIndex = 4;
            this.carSave_button.Text = "ZAPISZ";
            this.carSave_button.UseVisualStyleBackColor = false;
            this.carSave_button.Click += new System.EventHandler(this.carSave_button_Click);
            // 
            // carInfo_groupBox
            // 
            this.carInfo_groupBox.Controls.Add(this.carInfoDataTechnicalReview_dateTimePicker);
            this.carInfo_groupBox.Controls.Add(this.carInfoDataOC_dateTimePicker);
            this.carInfo_groupBox.Controls.Add(this.carInfoReservedTRUE_checkBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoAvailability_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoAvailabileTRUE_checkBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoBody_comboBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoVIN_textBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoVIN_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoLicensePlate_textBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoLicensePlate_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoMileage_textBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoMileage_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoDataOC_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoDataTechnicalReview_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoBodyColor_textBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoBodyColor_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoPassengers_textBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoPassengers_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoDoors_textBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoDoors_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoBody_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoYear_textBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoYear_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoModel_textBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoModel_label);
            this.carInfo_groupBox.Controls.Add(this.carInfoProducent_textBox);
            this.carInfo_groupBox.Controls.Add(this.carInfoProducent_label);
            this.carInfo_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.carInfo_groupBox.ForeColor = System.Drawing.Color.Purple;
            this.carInfo_groupBox.Location = new System.Drawing.Point(12, 75);
            this.carInfo_groupBox.Name = "carInfo_groupBox";
            this.carInfo_groupBox.Size = new System.Drawing.Size(329, 363);
            this.carInfo_groupBox.TabIndex = 2;
            this.carInfo_groupBox.TabStop = false;
            this.carInfo_groupBox.Text = "Podstawowe informacje o pojezdzie";
            // 
            // carInfoDataTechnicalReview_dateTimePicker
            // 
            this.carInfoDataTechnicalReview_dateTimePicker.CustomFormat = "";
            this.carInfoDataTechnicalReview_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.carInfoDataTechnicalReview_dateTimePicker.Location = new System.Drawing.Point(184, 201);
            this.carInfoDataTechnicalReview_dateTimePicker.MinDate = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.carInfoDataTechnicalReview_dateTimePicker.Name = "carInfoDataTechnicalReview_dateTimePicker";
            this.carInfoDataTechnicalReview_dateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.carInfoDataTechnicalReview_dateTimePicker.TabIndex = 30;
            this.carInfoDataTechnicalReview_dateTimePicker.Value = new System.DateTime(2019, 12, 6, 0, 0, 0, 0);
            // 
            // carInfoDataOC_dateTimePicker
            // 
            this.carInfoDataOC_dateTimePicker.CustomFormat = "";
            this.carInfoDataOC_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.carInfoDataOC_dateTimePicker.Location = new System.Drawing.Point(184, 227);
            this.carInfoDataOC_dateTimePicker.MinDate = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.carInfoDataOC_dateTimePicker.Name = "carInfoDataOC_dateTimePicker";
            this.carInfoDataOC_dateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.carInfoDataOC_dateTimePicker.TabIndex = 3;
            this.carInfoDataOC_dateTimePicker.Value = new System.DateTime(2019, 12, 6, 0, 0, 0, 0);
            // 
            // carInfoReservedTRUE_checkBox
            // 
            this.carInfoReservedTRUE_checkBox.AutoSize = true;
            this.carInfoReservedTRUE_checkBox.Enabled = false;
            this.carInfoReservedTRUE_checkBox.Location = new System.Drawing.Point(209, 332);
            this.carInfoReservedTRUE_checkBox.Name = "carInfoReservedTRUE_checkBox";
            this.carInfoReservedTRUE_checkBox.Size = new System.Drawing.Size(114, 17);
            this.carInfoReservedTRUE_checkBox.TabIndex = 29;
            this.carInfoReservedTRUE_checkBox.Text = "Zarezerwowany";
            this.carInfoReservedTRUE_checkBox.UseVisualStyleBackColor = true;
            // 
            // carInfoAvailability_label
            // 
            this.carInfoAvailability_label.AutoSize = true;
            this.carInfoAvailability_label.Location = new System.Drawing.Point(6, 332);
            this.carInfoAvailability_label.Name = "carInfoAvailability_label";
            this.carInfoAvailability_label.Size = new System.Drawing.Size(120, 13);
            this.carInfoAvailability_label.TabIndex = 28;
            this.carInfoAvailability_label.Text = "Czy samochód jest: ";
            // 
            // carInfoAvailabileTRUE_checkBox
            // 
            this.carInfoAvailabileTRUE_checkBox.AutoSize = true;
            this.carInfoAvailabileTRUE_checkBox.Enabled = false;
            this.carInfoAvailabileTRUE_checkBox.Location = new System.Drawing.Point(132, 332);
            this.carInfoAvailabileTRUE_checkBox.Name = "carInfoAvailabileTRUE_checkBox";
            this.carInfoAvailabileTRUE_checkBox.Size = new System.Drawing.Size(79, 17);
            this.carInfoAvailabileTRUE_checkBox.TabIndex = 27;
            this.carInfoAvailabileTRUE_checkBox.Text = "Dostępny";
            this.carInfoAvailabileTRUE_checkBox.UseVisualStyleBackColor = true;
            // 
            // carInfoBody_comboBox
            // 
            this.carInfoBody_comboBox.DisplayMember = "1";
            this.carInfoBody_comboBox.FormattingEnabled = true;
            this.carInfoBody_comboBox.Items.AddRange(new object[] {
            "SUV",
            "coupé",
            "fastback",
            "hatchback",
            "kabriolet",
            "kombi",
            "liftback",
            "limuzyna",
            "mikrovan",
            "minivan",
            "pick-up",
            "roadster",
            "sedan",
            "van"});
            this.carInfoBody_comboBox.Location = new System.Drawing.Point(184, 96);
            this.carInfoBody_comboBox.Name = "carInfoBody_comboBox";
            this.carInfoBody_comboBox.Size = new System.Drawing.Size(136, 21);
            this.carInfoBody_comboBox.TabIndex = 3;
            this.carInfoBody_comboBox.Text = "(wybierz z listy)";
            this.carInfoBody_comboBox.ValueMember = "1";
            // 
            // carInfoVIN_textBox
            // 
            this.carInfoVIN_textBox.Location = new System.Drawing.Point(184, 305);
            this.carInfoVIN_textBox.Name = "carInfoVIN_textBox";
            this.carInfoVIN_textBox.Size = new System.Drawing.Size(136, 20);
            this.carInfoVIN_textBox.TabIndex = 23;
            // 
            // carInfoVIN_label
            // 
            this.carInfoVIN_label.AutoSize = true;
            this.carInfoVIN_label.Location = new System.Drawing.Point(6, 308);
            this.carInfoVIN_label.Name = "carInfoVIN_label";
            this.carInfoVIN_label.Size = new System.Drawing.Size(133, 13);
            this.carInfoVIN_label.TabIndex = 22;
            this.carInfoVIN_label.Text = "Numer nadwozia (VIN)";
            // 
            // carInfoLicensePlate_textBox
            // 
            this.carInfoLicensePlate_textBox.Location = new System.Drawing.Point(184, 279);
            this.carInfoLicensePlate_textBox.Name = "carInfoLicensePlate_textBox";
            this.carInfoLicensePlate_textBox.Size = new System.Drawing.Size(136, 20);
            this.carInfoLicensePlate_textBox.TabIndex = 21;
            // 
            // carInfoLicensePlate_label
            // 
            this.carInfoLicensePlate_label.AutoSize = true;
            this.carInfoLicensePlate_label.Location = new System.Drawing.Point(6, 282);
            this.carInfoLicensePlate_label.Name = "carInfoLicensePlate_label";
            this.carInfoLicensePlate_label.Size = new System.Drawing.Size(118, 13);
            this.carInfoLicensePlate_label.TabIndex = 20;
            this.carInfoLicensePlate_label.Text = "Numer rejestracyjny";
            // 
            // carInfoMileage_textBox
            // 
            this.carInfoMileage_textBox.Location = new System.Drawing.Point(184, 253);
            this.carInfoMileage_textBox.Name = "carInfoMileage_textBox";
            this.carInfoMileage_textBox.Size = new System.Drawing.Size(136, 20);
            this.carInfoMileage_textBox.TabIndex = 19;
            // 
            // carInfoMileage_label
            // 
            this.carInfoMileage_label.AutoSize = true;
            this.carInfoMileage_label.Location = new System.Drawing.Point(6, 256);
            this.carInfoMileage_label.Name = "carInfoMileage_label";
            this.carInfoMileage_label.Size = new System.Drawing.Size(176, 13);
            this.carInfoMileage_label.TabIndex = 18;
            this.carInfoMileage_label.Text = "Wskazania licznika (przebieg)";
            // 
            // carInfoDataOC_label
            // 
            this.carInfoDataOC_label.AutoSize = true;
            this.carInfoDataOC_label.Location = new System.Drawing.Point(6, 230);
            this.carInfoDataOC_label.Name = "carInfoDataOC_label";
            this.carInfoDataOC_label.Size = new System.Drawing.Size(119, 13);
            this.carInfoDataOC_label.TabIndex = 16;
            this.carInfoDataOC_label.Text = "Data ubezpieczenia";
            // 
            // carInfoDataTechnicalReview_label
            // 
            this.carInfoDataTechnicalReview_label.AutoSize = true;
            this.carInfoDataTechnicalReview_label.Location = new System.Drawing.Point(6, 204);
            this.carInfoDataTechnicalReview_label.Name = "carInfoDataTechnicalReview_label";
            this.carInfoDataTechnicalReview_label.Size = new System.Drawing.Size(170, 13);
            this.carInfoDataTechnicalReview_label.TabIndex = 14;
            this.carInfoDataTechnicalReview_label.Text = "Data badania tecchnicznego";
            // 
            // carInfoBodyColor_textBox
            // 
            this.carInfoBodyColor_textBox.Location = new System.Drawing.Point(184, 175);
            this.carInfoBodyColor_textBox.Name = "carInfoBodyColor_textBox";
            this.carInfoBodyColor_textBox.Size = new System.Drawing.Size(136, 20);
            this.carInfoBodyColor_textBox.TabIndex = 13;
            // 
            // carInfoBodyColor_label
            // 
            this.carInfoBodyColor_label.AutoSize = true;
            this.carInfoBodyColor_label.Location = new System.Drawing.Point(6, 178);
            this.carInfoBodyColor_label.Name = "carInfoBodyColor_label";
            this.carInfoBodyColor_label.Size = new System.Drawing.Size(93, 13);
            this.carInfoBodyColor_label.TabIndex = 12;
            this.carInfoBodyColor_label.Text = "Kolor nadwozia";
            // 
            // carInfoPassengers_textBox
            // 
            this.carInfoPassengers_textBox.Location = new System.Drawing.Point(184, 149);
            this.carInfoPassengers_textBox.Name = "carInfoPassengers_textBox";
            this.carInfoPassengers_textBox.Size = new System.Drawing.Size(136, 20);
            this.carInfoPassengers_textBox.TabIndex = 11;
            // 
            // carInfoPassengers_label
            // 
            this.carInfoPassengers_label.AutoSize = true;
            this.carInfoPassengers_label.Location = new System.Drawing.Point(6, 152);
            this.carInfoPassengers_label.Name = "carInfoPassengers_label";
            this.carInfoPassengers_label.Size = new System.Drawing.Size(170, 13);
            this.carInfoPassengers_label.TabIndex = 10;
            this.carInfoPassengers_label.Text = "Maksymalna ilość pasażerów";
            // 
            // carInfoDoors_textBox
            // 
            this.carInfoDoors_textBox.Location = new System.Drawing.Point(184, 123);
            this.carInfoDoors_textBox.Name = "carInfoDoors_textBox";
            this.carInfoDoors_textBox.Size = new System.Drawing.Size(136, 20);
            this.carInfoDoors_textBox.TabIndex = 9;
            // 
            // carInfoDoors_label
            // 
            this.carInfoDoors_label.AutoSize = true;
            this.carInfoDoors_label.Location = new System.Drawing.Point(6, 126);
            this.carInfoDoors_label.Name = "carInfoDoors_label";
            this.carInfoDoors_label.Size = new System.Drawing.Size(67, 13);
            this.carInfoDoors_label.TabIndex = 8;
            this.carInfoDoors_label.Text = "Ilość drzwi";
            // 
            // carInfoBody_label
            // 
            this.carInfoBody_label.AutoSize = true;
            this.carInfoBody_label.Location = new System.Drawing.Point(6, 100);
            this.carInfoBody_label.Name = "carInfoBody_label";
            this.carInfoBody_label.Size = new System.Drawing.Size(85, 13);
            this.carInfoBody_label.TabIndex = 6;
            this.carInfoBody_label.Text = "Typ nadwozia";
            // 
            // carInfoYear_textBox
            // 
            this.carInfoYear_textBox.Location = new System.Drawing.Point(184, 71);
            this.carInfoYear_textBox.Name = "carInfoYear_textBox";
            this.carInfoYear_textBox.Size = new System.Drawing.Size(136, 20);
            this.carInfoYear_textBox.TabIndex = 5;
            // 
            // carInfoYear_label
            // 
            this.carInfoYear_label.AutoSize = true;
            this.carInfoYear_label.Location = new System.Drawing.Point(6, 74);
            this.carInfoYear_label.Name = "carInfoYear_label";
            this.carInfoYear_label.Size = new System.Drawing.Size(53, 13);
            this.carInfoYear_label.TabIndex = 4;
            this.carInfoYear_label.Text = "Rocznik";
            // 
            // carInfoModel_textBox
            // 
            this.carInfoModel_textBox.Location = new System.Drawing.Point(184, 45);
            this.carInfoModel_textBox.Name = "carInfoModel_textBox";
            this.carInfoModel_textBox.Size = new System.Drawing.Size(136, 20);
            this.carInfoModel_textBox.TabIndex = 3;
            // 
            // carInfoModel_label
            // 
            this.carInfoModel_label.AutoSize = true;
            this.carInfoModel_label.Location = new System.Drawing.Point(6, 48);
            this.carInfoModel_label.Name = "carInfoModel_label";
            this.carInfoModel_label.Size = new System.Drawing.Size(41, 13);
            this.carInfoModel_label.TabIndex = 2;
            this.carInfoModel_label.Text = "Model";
            // 
            // carInfoProducent_textBox
            // 
            this.carInfoProducent_textBox.Location = new System.Drawing.Point(184, 19);
            this.carInfoProducent_textBox.Name = "carInfoProducent_textBox";
            this.carInfoProducent_textBox.Size = new System.Drawing.Size(136, 20);
            this.carInfoProducent_textBox.TabIndex = 1;
            // 
            // carInfoProducent_label
            // 
            this.carInfoProducent_label.AutoSize = true;
            this.carInfoProducent_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.carInfoProducent_label.Location = new System.Drawing.Point(6, 22);
            this.carInfoProducent_label.Name = "carInfoProducent_label";
            this.carInfoProducent_label.Size = new System.Drawing.Size(65, 13);
            this.carInfoProducent_label.TabIndex = 0;
            this.carInfoProducent_label.Text = "Producent";
            // 
            // carPrice_groupBox
            // 
            this.carPrice_groupBox.Controls.Add(this.carPriceYear_textBox);
            this.carPrice_groupBox.Controls.Add(this.carPriceYear_label);
            this.carPrice_groupBox.Controls.Add(this.carPriceMonth_textBox);
            this.carPrice_groupBox.Controls.Add(this.carPriceWeek_textBox);
            this.carPrice_groupBox.Controls.Add(this.carPriceWeek_label);
            this.carPrice_groupBox.Controls.Add(this.carPriceMonth_label);
            this.carPrice_groupBox.Controls.Add(this.carPriceDay_label);
            this.carPrice_groupBox.Controls.Add(this.carPriceDay_textBox);
            this.carPrice_groupBox.ForeColor = System.Drawing.Color.Purple;
            this.carPrice_groupBox.Location = new System.Drawing.Point(347, 75);
            this.carPrice_groupBox.Name = "carPrice_groupBox";
            this.carPrice_groupBox.Size = new System.Drawing.Size(329, 75);
            this.carPrice_groupBox.TabIndex = 24;
            this.carPrice_groupBox.TabStop = false;
            this.carPrice_groupBox.Text = "Podstawowy cennik";
            // 
            // carPriceYear_textBox
            // 
            this.carPriceYear_textBox.Location = new System.Drawing.Point(226, 46);
            this.carPriceYear_textBox.Name = "carPriceYear_textBox";
            this.carPriceYear_textBox.Size = new System.Drawing.Size(88, 20);
            this.carPriceYear_textBox.TabIndex = 9;
            this.carPriceYear_textBox.Text = "0";
            // 
            // carPriceYear_label
            // 
            this.carPriceYear_label.AutoSize = true;
            this.carPriceYear_label.Location = new System.Drawing.Point(174, 48);
            this.carPriceYear_label.Name = "carPriceYear_label";
            this.carPriceYear_label.Size = new System.Drawing.Size(27, 13);
            this.carPriceYear_label.TabIndex = 8;
            this.carPriceYear_label.Text = "Rok";
            // 
            // carPriceMonth_textBox
            // 
            this.carPriceMonth_textBox.Location = new System.Drawing.Point(58, 45);
            this.carPriceMonth_textBox.Name = "carPriceMonth_textBox";
            this.carPriceMonth_textBox.Size = new System.Drawing.Size(88, 20);
            this.carPriceMonth_textBox.TabIndex = 5;
            this.carPriceMonth_textBox.Text = "0";
            // 
            // carPriceWeek_textBox
            // 
            this.carPriceWeek_textBox.Location = new System.Drawing.Point(226, 19);
            this.carPriceWeek_textBox.Name = "carPriceWeek_textBox";
            this.carPriceWeek_textBox.Size = new System.Drawing.Size(88, 20);
            this.carPriceWeek_textBox.TabIndex = 3;
            this.carPriceWeek_textBox.Text = "0";
            // 
            // carPriceWeek_label
            // 
            this.carPriceWeek_label.AutoSize = true;
            this.carPriceWeek_label.Location = new System.Drawing.Point(174, 22);
            this.carPriceWeek_label.Name = "carPriceWeek_label";
            this.carPriceWeek_label.Size = new System.Drawing.Size(44, 13);
            this.carPriceWeek_label.TabIndex = 2;
            this.carPriceWeek_label.Text = "Tydzień";
            // 
            // carPriceMonth_label
            // 
            this.carPriceMonth_label.AutoSize = true;
            this.carPriceMonth_label.Location = new System.Drawing.Point(6, 48);
            this.carPriceMonth_label.Name = "carPriceMonth_label";
            this.carPriceMonth_label.Size = new System.Drawing.Size(43, 13);
            this.carPriceMonth_label.TabIndex = 4;
            this.carPriceMonth_label.Text = "Miesiąc";
            // 
            // carPriceDay_label
            // 
            this.carPriceDay_label.AutoSize = true;
            this.carPriceDay_label.Location = new System.Drawing.Point(6, 22);
            this.carPriceDay_label.Name = "carPriceDay_label";
            this.carPriceDay_label.Size = new System.Drawing.Size(34, 13);
            this.carPriceDay_label.TabIndex = 0;
            this.carPriceDay_label.Text = "Dzień";
            // 
            // carPriceDay_textBox
            // 
            this.carPriceDay_textBox.Location = new System.Drawing.Point(58, 19);
            this.carPriceDay_textBox.Name = "carPriceDay_textBox";
            this.carPriceDay_textBox.Size = new System.Drawing.Size(88, 20);
            this.carPriceDay_textBox.TabIndex = 1;
            this.carPriceDay_textBox.Text = "0";
            // 
            // carAdditional_groupBox
            // 
            this.carAdditional_groupBox.Controls.Add(this.checkedListBox1);
            this.carAdditional_groupBox.ForeColor = System.Drawing.Color.Purple;
            this.carAdditional_groupBox.Location = new System.Drawing.Point(348, 157);
            this.carAdditional_groupBox.Name = "carAdditional_groupBox";
            this.carAdditional_groupBox.Size = new System.Drawing.Size(328, 213);
            this.carAdditional_groupBox.TabIndex = 25;
            this.carAdditional_groupBox.TabStop = false;
            this.carAdditional_groupBox.Text = "Dodatkowe informacje ";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Radio CD/DVD",
            "Fotelik dla dziecka",
            "Nawigacja GPS",
            "Koło zapasowe",
            "Zestaw naprawczy koła",
            "Relingi dachowe"});
            this.checkedListBox1.Location = new System.Drawing.Point(8, 18);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(305, 184);
            this.checkedListBox1.TabIndex = 2;
            // 
            // carForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 444);
            this.Controls.Add(this.carCancel_button);
            this.Controls.Add(this.carSave_button);
            this.Controls.Add(this.carAdditional_groupBox);
            this.Controls.Add(this.carPrice_groupBox);
            this.Controls.Add(this.carInfo_groupBox);
            this.Controls.Add(this.carIdentifier_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "carForm";
            this.Text = "Zarządzanie pojazdami";
            this.carIdentifier_groupBox.ResumeLayout(false);
            this.carIdentifier_groupBox.PerformLayout();
            this.carInfo_groupBox.ResumeLayout(false);
            this.carInfo_groupBox.PerformLayout();
            this.carPrice_groupBox.ResumeLayout(false);
            this.carPrice_groupBox.PerformLayout();
            this.carAdditional_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox carIdentifier_groupBox;
        private System.Windows.Forms.Button carIdentifierPrevID_button;
        private System.Windows.Forms.Label carIdentifierID_label;
        private System.Windows.Forms.Button carIdentifierNextID_button;
        private System.Windows.Forms.TextBox carIdentifierID_textBox;
        private System.Windows.Forms.GroupBox carInfo_groupBox;
        private System.Windows.Forms.TextBox carInfoVIN_textBox;
        private System.Windows.Forms.Label carInfoVIN_label;
        private System.Windows.Forms.TextBox carInfoLicensePlate_textBox;
        private System.Windows.Forms.Label carInfoLicensePlate_label;
        private System.Windows.Forms.TextBox carInfoMileage_textBox;
        private System.Windows.Forms.Label carInfoMileage_label;
        private System.Windows.Forms.Label carInfoDataOC_label;
        private System.Windows.Forms.Label carInfoDataTechnicalReview_label;
        private System.Windows.Forms.TextBox carInfoBodyColor_textBox;
        private System.Windows.Forms.Label carInfoBodyColor_label;
        private System.Windows.Forms.TextBox carInfoPassengers_textBox;
        private System.Windows.Forms.Label carInfoPassengers_label;
        private System.Windows.Forms.TextBox carInfoDoors_textBox;
        private System.Windows.Forms.Label carInfoDoors_label;
        private System.Windows.Forms.Label carInfoBody_label;
        private System.Windows.Forms.TextBox carInfoYear_textBox;
        private System.Windows.Forms.Label carInfoYear_label;
        private System.Windows.Forms.TextBox carInfoModel_textBox;
        private System.Windows.Forms.Label carInfoModel_label;
        private System.Windows.Forms.TextBox carInfoProducent_textBox;
        private System.Windows.Forms.Label carInfoProducent_label;
        private System.Windows.Forms.ComboBox carInfoBody_comboBox;
        private System.Windows.Forms.Button carCancel_button;
        private System.Windows.Forms.Button carSave_button;
        private System.Windows.Forms.GroupBox carPrice_groupBox;
        private System.Windows.Forms.TextBox carPriceYear_textBox;
        private System.Windows.Forms.Label carPriceYear_label;
        private System.Windows.Forms.TextBox carPriceMonth_textBox;
        private System.Windows.Forms.TextBox carPriceWeek_textBox;
        private System.Windows.Forms.Label carPriceWeek_label;
        private System.Windows.Forms.Label carPriceMonth_label;
        private System.Windows.Forms.Label carPriceDay_label;
        private System.Windows.Forms.TextBox carPriceDay_textBox;
        private System.Windows.Forms.Label carInfoAvailability_label;
        private System.Windows.Forms.CheckBox carInfoAvailabileTRUE_checkBox;
        private System.Windows.Forms.GroupBox carAdditional_groupBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox carInfoReservedTRUE_checkBox;
        private System.Windows.Forms.Button carRemove_button;
        private System.Windows.Forms.DateTimePicker carInfoDataOC_dateTimePicker;
        private System.Windows.Forms.DateTimePicker carInfoDataTechnicalReview_dateTimePicker;
    }
}