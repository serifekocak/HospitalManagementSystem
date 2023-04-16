namespace HospitalManagementSystem
{
    partial class PatientPage
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PatientAddress = new System.Windows.Forms.TextBox();
            this.txt_PatientName = new System.Windows.Forms.TextBox();
            this.txt_PatientLastName = new System.Windows.Forms.TextBox();
            this.txt_PatientAge = new System.Windows.Forms.TextBox();
            this.txt_PatientGender = new System.Windows.Forms.TextBox();
            this.txt_BloodType = new System.Windows.Forms.TextBox();
            this.txt_ContactNo = new System.Windows.Forms.TextBox();
            this.txt_NationalNumber = new System.Windows.Forms.TextBox();
            this.txt_Disease = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.patient_gridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PatientHome = new System.Windows.Forms.Button();
            this.btn_patient_delete = new System.Windows.Forms.Button();
            this.btn_patient_update = new System.Windows.Forms.Button();
            this.btn_patient_save = new System.Windows.Forms.Button();
            this.List_Patient = new System.Windows.Forms.Button();
            this.view_doctor_gridView = new System.Windows.Forms.DataGridView();
            this.view_doctors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patient_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_doctor_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Adress:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "National Number:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Blood Type:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Contact No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name:";
            // 
            // txt_PatientAddress
            // 
            this.txt_PatientAddress.Location = new System.Drawing.Point(503, 137);
            this.txt_PatientAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PatientAddress.Multiline = true;
            this.txt_PatientAddress.Name = "txt_PatientAddress";
            this.txt_PatientAddress.Size = new System.Drawing.Size(285, 57);
            this.txt_PatientAddress.TabIndex = 35;
            this.txt_PatientAddress.TextChanged += new System.EventHandler(this.txt_PatientAddress_TextChanged);
            // 
            // txt_PatientName
            // 
            this.txt_PatientName.Location = new System.Drawing.Point(146, 46);
            this.txt_PatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PatientName.Name = "txt_PatientName";
            this.txt_PatientName.Size = new System.Drawing.Size(153, 23);
            this.txt_PatientName.TabIndex = 34;
            // 
            // txt_PatientLastName
            // 
            this.txt_PatientLastName.Location = new System.Drawing.Point(146, 73);
            this.txt_PatientLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PatientLastName.Name = "txt_PatientLastName";
            this.txt_PatientLastName.Size = new System.Drawing.Size(153, 23);
            this.txt_PatientLastName.TabIndex = 33;
            // 
            // txt_PatientAge
            // 
            this.txt_PatientAge.Location = new System.Drawing.Point(146, 100);
            this.txt_PatientAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PatientAge.Name = "txt_PatientAge";
            this.txt_PatientAge.Size = new System.Drawing.Size(153, 23);
            this.txt_PatientAge.TabIndex = 32;
            this.txt_PatientAge.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_PatientGender
            // 
            this.txt_PatientGender.Location = new System.Drawing.Point(146, 127);
            this.txt_PatientGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PatientGender.Name = "txt_PatientGender";
            this.txt_PatientGender.Size = new System.Drawing.Size(153, 23);
            this.txt_PatientGender.TabIndex = 31;
            // 
            // txt_BloodType
            // 
            this.txt_BloodType.Location = new System.Drawing.Point(503, 46);
            this.txt_BloodType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_BloodType.Name = "txt_BloodType";
            this.txt_BloodType.Size = new System.Drawing.Size(153, 23);
            this.txt_BloodType.TabIndex = 30;
            // 
            // txt_ContactNo
            // 
            this.txt_ContactNo.Location = new System.Drawing.Point(146, 154);
            this.txt_ContactNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ContactNo.Name = "txt_ContactNo";
            this.txt_ContactNo.Size = new System.Drawing.Size(153, 23);
            this.txt_ContactNo.TabIndex = 29;
            // 
            // txt_NationalNumber
            // 
            this.txt_NationalNumber.Location = new System.Drawing.Point(503, 75);
            this.txt_NationalNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NationalNumber.Name = "txt_NationalNumber";
            this.txt_NationalNumber.Size = new System.Drawing.Size(153, 23);
            this.txt_NationalNumber.TabIndex = 28;
            // 
            // txt_Disease
            // 
            this.txt_Disease.Location = new System.Drawing.Point(503, 105);
            this.txt_Disease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Disease.Name = "txt_Disease";
            this.txt_Disease.Size = new System.Drawing.Size(153, 23);
            this.txt_Disease.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 46;
            this.label10.Text = "Disease:";
            // 
            // patient_gridView
            // 
            this.patient_gridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.patient_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_gridView.Location = new System.Drawing.Point(28, 248);
            this.patient_gridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patient_gridView.Name = "patient_gridView";
            this.patient_gridView.RowHeadersWidth = 51;
            this.patient_gridView.RowTemplate.Height = 29;
            this.patient_gridView.Size = new System.Drawing.Size(381, 191);
            this.patient_gridView.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(314, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "PATIENT";
            // 
            // btn_PatientHome
            // 
            this.btn_PatientHome.BackColor = System.Drawing.Color.Lavender;
            this.btn_PatientHome.Location = new System.Drawing.Point(668, 403);
            this.btn_PatientHome.Name = "btn_PatientHome";
            this.btn_PatientHome.Size = new System.Drawing.Size(120, 35);
            this.btn_PatientHome.TabIndex = 56;
            this.btn_PatientHome.Text = "Home Page";
            this.btn_PatientHome.UseVisualStyleBackColor = false;
            this.btn_PatientHome.Click += new System.EventHandler(this.btn_PatientHome_Click_1);
            // 
            // btn_patient_delete
            // 
            this.btn_patient_delete.BackColor = System.Drawing.Color.Red;
            this.btn_patient_delete.Location = new System.Drawing.Point(668, 354);
            this.btn_patient_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_patient_delete.Name = "btn_patient_delete";
            this.btn_patient_delete.Size = new System.Drawing.Size(120, 35);
            this.btn_patient_delete.TabIndex = 55;
            this.btn_patient_delete.Text = "DELETE";
            this.btn_patient_delete.UseVisualStyleBackColor = false;
            this.btn_patient_delete.Click += new System.EventHandler(this.btn_patient_delete_Click_1);
            // 
            // btn_patient_update
            // 
            this.btn_patient_update.BackColor = System.Drawing.Color.Yellow;
            this.btn_patient_update.Location = new System.Drawing.Point(668, 302);
            this.btn_patient_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_patient_update.Name = "btn_patient_update";
            this.btn_patient_update.Size = new System.Drawing.Size(120, 35);
            this.btn_patient_update.TabIndex = 54;
            this.btn_patient_update.Text = "UPDATE";
            this.btn_patient_update.UseVisualStyleBackColor = false;
            this.btn_patient_update.Click += new System.EventHandler(this.btn_patient_update_Click_1);
            // 
            // btn_patient_save
            // 
            this.btn_patient_save.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_patient_save.Location = new System.Drawing.Point(668, 248);
            this.btn_patient_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_patient_save.Name = "btn_patient_save";
            this.btn_patient_save.Size = new System.Drawing.Size(120, 35);
            this.btn_patient_save.TabIndex = 53;
            this.btn_patient_save.Text = "SAVE";
            this.btn_patient_save.UseVisualStyleBackColor = false;
            this.btn_patient_save.Click += new System.EventHandler(this.btn_patient_save_Click_1);
            // 
            // List_Patient
            // 
            this.List_Patient.BackColor = System.Drawing.Color.GhostWhite;
            this.List_Patient.Location = new System.Drawing.Point(28, 199);
            this.List_Patient.Name = "List_Patient";
            this.List_Patient.Size = new System.Drawing.Size(120, 35);
            this.List_Patient.TabIndex = 57;
            this.List_Patient.Text = "LIST";
            this.List_Patient.UseVisualStyleBackColor = false;
            this.List_Patient.Click += new System.EventHandler(this.List_Patient_Click_1);
            // 
            // view_doctor_gridView
            // 
            this.view_doctor_gridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.view_doctor_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_doctor_gridView.Location = new System.Drawing.Point(422, 248);
            this.view_doctor_gridView.Name = "view_doctor_gridView";
            this.view_doctor_gridView.RowTemplate.Height = 25;
            this.view_doctor_gridView.Size = new System.Drawing.Size(234, 190);
            this.view_doctor_gridView.TabIndex = 58;
            this.view_doctor_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // view_doctors
            // 
            this.view_doctors.BackColor = System.Drawing.Color.GhostWhite;
            this.view_doctors.Location = new System.Drawing.Point(422, 199);
            this.view_doctors.Name = "view_doctors";
            this.view_doctors.Size = new System.Drawing.Size(120, 35);
            this.view_doctors.TabIndex = 59;
            this.view_doctors.Text = "View Doctors";
            this.view_doctors.UseVisualStyleBackColor = false;
            this.view_doctors.Click += new System.EventHandler(this.view_doctors_Click);
            // 
            // PatientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_doctors);
            this.Controls.Add(this.view_doctor_gridView);
            this.Controls.Add(this.List_Patient);
            this.Controls.Add(this.btn_patient_save);
            this.Controls.Add(this.btn_PatientHome);
            this.Controls.Add(this.btn_patient_delete);
            this.Controls.Add(this.btn_patient_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patient_gridView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Disease);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PatientAddress);
            this.Controls.Add(this.txt_PatientName);
            this.Controls.Add(this.txt_PatientLastName);
            this.Controls.Add(this.txt_PatientAge);
            this.Controls.Add(this.txt_PatientGender);
            this.Controls.Add(this.txt_BloodType);
            this.Controls.Add(this.txt_ContactNo);
            this.Controls.Add(this.txt_NationalNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PatientPage";
            this.Text = "PatientPage";
            ((System.ComponentModel.ISupportInitialize)(this.patient_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_doctor_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_PatientAddress;
        private TextBox txt_PatientName;
        private TextBox txt_PatientLastName;
        private TextBox txt_PatientAge;
        private TextBox txt_PatientGender;
        private TextBox txt_BloodType;
        private TextBox txt_ContactNo;
        private TextBox txt_NationalNumber;
        private TextBox txt_Disease;
        private Label label10;
        private DataGridView patient_gridView;
        private Label label1;
        private Button btn_PatientHome;
        private Button btn_patient_delete;
        private Button btn_patient_update;
        private Button btn_patient_save;
        private Button List_Patient;
        private DataGridView view_doctor_gridView;
        private Button view_doctors;
    }
}