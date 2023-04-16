namespace HospitalManagementSystem
{
    partial class EmployeePage
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
            this.btn_PatientHome = new System.Windows.Forms.Button();
            this.btn_employee_delete = new System.Windows.Forms.Button();
            this.btn_employee_update = new System.Windows.Forms.Button();
            this.btn_employee_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employee_gridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EmployeeAddress = new System.Windows.Forms.TextBox();
            this.txt_EmployeeName = new System.Windows.Forms.TextBox();
            this.txt_EmployeeLastName = new System.Windows.Forms.TextBox();
            this.txt_EmployeeAge = new System.Windows.Forms.TextBox();
            this.txt_EmployeeGender = new System.Windows.Forms.TextBox();
            this.txt_EmployeeType = new System.Windows.Forms.TextBox();
            this.txt_EmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.List_Employee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employee_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PatientHome
            // 
            this.btn_PatientHome.BackColor = System.Drawing.Color.Lavender;
            this.btn_PatientHome.Location = new System.Drawing.Point(647, 387);
            this.btn_PatientHome.Name = "btn_PatientHome";
            this.btn_PatientHome.Size = new System.Drawing.Size(120, 35);
            this.btn_PatientHome.TabIndex = 80;
            this.btn_PatientHome.Text = "Home Page";
            this.btn_PatientHome.UseVisualStyleBackColor = false;
            this.btn_PatientHome.Click += new System.EventHandler(this.btn_PatientHome_Click);
            // 
            // btn_employee_delete
            // 
            this.btn_employee_delete.BackColor = System.Drawing.Color.Red;
            this.btn_employee_delete.Location = new System.Drawing.Point(647, 326);
            this.btn_employee_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_employee_delete.Name = "btn_employee_delete";
            this.btn_employee_delete.Size = new System.Drawing.Size(120, 35);
            this.btn_employee_delete.TabIndex = 79;
            this.btn_employee_delete.Text = "DELETE";
            this.btn_employee_delete.UseVisualStyleBackColor = false;
            this.btn_employee_delete.Click += new System.EventHandler(this.btn_employee_delete_Click);
            // 
            // btn_employee_update
            // 
            this.btn_employee_update.BackColor = System.Drawing.Color.Yellow;
            this.btn_employee_update.Location = new System.Drawing.Point(647, 266);
            this.btn_employee_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_employee_update.Name = "btn_employee_update";
            this.btn_employee_update.Size = new System.Drawing.Size(120, 35);
            this.btn_employee_update.TabIndex = 78;
            this.btn_employee_update.Text = "UPDATE";
            this.btn_employee_update.UseVisualStyleBackColor = false;
            this.btn_employee_update.Click += new System.EventHandler(this.btn_employee_update_Click);
            // 
            // btn_employee_save
            // 
            this.btn_employee_save.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_employee_save.Location = new System.Drawing.Point(647, 204);
            this.btn_employee_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_employee_save.Name = "btn_employee_save";
            this.btn_employee_save.Size = new System.Drawing.Size(120, 35);
            this.btn_employee_save.TabIndex = 77;
            this.btn_employee_save.Text = "SAVE";
            this.btn_employee_save.UseVisualStyleBackColor = false;
            this.btn_employee_save.Click += new System.EventHandler(this.btn_patient_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(306, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 76;
            this.label1.Text = "EMPLOYEE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // employee_gridView
            // 
            this.employee_gridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.employee_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_gridView.Location = new System.Drawing.Point(20, 229);
            this.employee_gridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employee_gridView.Name = "employee_gridView";
            this.employee_gridView.RowHeadersWidth = 51;
            this.employee_gridView.RowTemplate.Height = 29;
            this.employee_gridView.Size = new System.Drawing.Size(598, 209);
            this.employee_gridView.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 72;
            this.label9.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 71;
            this.label8.Text = "Adress:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 70;
            this.label7.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 69;
            this.label6.Text = "Employee Type:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 68;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 67;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 66;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "Name:";
            // 
            // txt_EmployeeAddress
            // 
            this.txt_EmployeeAddress.Location = new System.Drawing.Point(495, 95);
            this.txt_EmployeeAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_EmployeeAddress.Multiline = true;
            this.txt_EmployeeAddress.Name = "txt_EmployeeAddress";
            this.txt_EmployeeAddress.Size = new System.Drawing.Size(285, 79);
            this.txt_EmployeeAddress.TabIndex = 64;
            // 
            // txt_EmployeeName
            // 
            this.txt_EmployeeName.Location = new System.Drawing.Point(138, 45);
            this.txt_EmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_EmployeeName.Name = "txt_EmployeeName";
            this.txt_EmployeeName.Size = new System.Drawing.Size(153, 23);
            this.txt_EmployeeName.TabIndex = 63;
            // 
            // txt_EmployeeLastName
            // 
            this.txt_EmployeeLastName.Location = new System.Drawing.Point(138, 72);
            this.txt_EmployeeLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_EmployeeLastName.Name = "txt_EmployeeLastName";
            this.txt_EmployeeLastName.Size = new System.Drawing.Size(153, 23);
            this.txt_EmployeeLastName.TabIndex = 62;
            // 
            // txt_EmployeeAge
            // 
            this.txt_EmployeeAge.Location = new System.Drawing.Point(138, 99);
            this.txt_EmployeeAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_EmployeeAge.Name = "txt_EmployeeAge";
            this.txt_EmployeeAge.Size = new System.Drawing.Size(153, 23);
            this.txt_EmployeeAge.TabIndex = 61;
            // 
            // txt_EmployeeGender
            // 
            this.txt_EmployeeGender.Location = new System.Drawing.Point(138, 126);
            this.txt_EmployeeGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_EmployeeGender.Name = "txt_EmployeeGender";
            this.txt_EmployeeGender.Size = new System.Drawing.Size(153, 23);
            this.txt_EmployeeGender.TabIndex = 60;
            // 
            // txt_EmployeeType
            // 
            this.txt_EmployeeType.Location = new System.Drawing.Point(495, 40);
            this.txt_EmployeeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_EmployeeType.Name = "txt_EmployeeType";
            this.txt_EmployeeType.Size = new System.Drawing.Size(153, 23);
            this.txt_EmployeeType.TabIndex = 59;
            // 
            // txt_EmployeePhoneNumber
            // 
            this.txt_EmployeePhoneNumber.Location = new System.Drawing.Point(138, 153);
            this.txt_EmployeePhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_EmployeePhoneNumber.Name = "txt_EmployeePhoneNumber";
            this.txt_EmployeePhoneNumber.Size = new System.Drawing.Size(153, 23);
            this.txt_EmployeePhoneNumber.TabIndex = 58;
            // 
            // txt_Salary
            // 
            this.txt_Salary.Location = new System.Drawing.Point(495, 68);
            this.txt_Salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(153, 23);
            this.txt_Salary.TabIndex = 57;
            // 
            // List_Employee
            // 
            this.List_Employee.BackColor = System.Drawing.Color.GhostWhite;
            this.List_Employee.Location = new System.Drawing.Point(20, 189);
            this.List_Employee.Name = "List_Employee";
            this.List_Employee.Size = new System.Drawing.Size(120, 35);
            this.List_Employee.TabIndex = 81;
            this.List_Employee.Text = "LIST";
            this.List_Employee.UseVisualStyleBackColor = false;
            this.List_Employee.Click += new System.EventHandler(this.List_Employee_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.List_Employee);
            this.Controls.Add(this.btn_PatientHome);
            this.Controls.Add(this.btn_employee_delete);
            this.Controls.Add(this.btn_employee_update);
            this.Controls.Add(this.btn_employee_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employee_gridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_EmployeeAddress);
            this.Controls.Add(this.txt_EmployeeName);
            this.Controls.Add(this.txt_EmployeeLastName);
            this.Controls.Add(this.txt_EmployeeAge);
            this.Controls.Add(this.txt_EmployeeGender);
            this.Controls.Add(this.txt_EmployeeType);
            this.Controls.Add(this.txt_EmployeePhoneNumber);
            this.Controls.Add(this.txt_Salary);
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            ((System.ComponentModel.ISupportInitialize)(this.employee_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_PatientHome;
        private Button btn_patient_delete;
        private Button btn_patient_update;
        private Button btn_patient_save;
        private Label label1;
        private DataGridView patient_gridView;
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
        private Button btn_employee_delete;
        private Button btn_employee_update;
        private Button btn_employee_save;
        private TextBox txt_EmployeeAddress;
        private TextBox txt_Salary;
        private DataGridView employee_gridView;
        private TextBox txt_EmployeeName;
        private TextBox txt_EmployeeLastName;
        private TextBox txt_EmployeeAge;
        private TextBox txt_EmployeeGender;
        private TextBox txt_EmployeeType;
        private TextBox txt_EmployeePhoneNumber;
        private Button List_Employee;
    }
}