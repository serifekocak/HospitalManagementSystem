namespace HospitalManagementSystem
{
    partial class DoctorPage
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
            this.btn_doctor_save = new System.Windows.Forms.Button();
            this.btn_doctor_update = new System.Windows.Forms.Button();
            this.txt_DoctorSpecial = new System.Windows.Forms.TextBox();
            this.txt_DoctorPhone = new System.Windows.Forms.TextBox();
            this.txt_DoctorDegree = new System.Windows.Forms.TextBox();
            this.txt_DoctorGender = new System.Windows.Forms.TextBox();
            this.txt_DoctorAge = new System.Windows.Forms.TextBox();
            this.txt_DoctorLastName = new System.Windows.Forms.TextBox();
            this.txt_DoctorName = new System.Windows.Forms.TextBox();
            this.txt_DoctorAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.doctor_gridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DoctorDelete = new System.Windows.Forms.Button();
            this.btn_DoctorHome = new System.Windows.Forms.Button();
            this.List_Doctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_doctor_save
            // 
            this.btn_doctor_save.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_doctor_save.Location = new System.Drawing.Point(644, 243);
            this.btn_doctor_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doctor_save.Name = "btn_doctor_save";
            this.btn_doctor_save.Size = new System.Drawing.Size(120, 35);
            this.btn_doctor_save.TabIndex = 0;
            this.btn_doctor_save.Text = "SAVE";
            this.btn_doctor_save.UseVisualStyleBackColor = false;
            this.btn_doctor_save.Click += new System.EventHandler(this.btn_doctor_save_Click);
            // 
            // btn_doctor_update
            // 
            this.btn_doctor_update.BackColor = System.Drawing.Color.Yellow;
            this.btn_doctor_update.Location = new System.Drawing.Point(644, 293);
            this.btn_doctor_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doctor_update.Name = "btn_doctor_update";
            this.btn_doctor_update.Size = new System.Drawing.Size(120, 35);
            this.btn_doctor_update.TabIndex = 1;
            this.btn_doctor_update.Text = "UPDATE";
            this.btn_doctor_update.UseVisualStyleBackColor = false;
            this.btn_doctor_update.Click += new System.EventHandler(this.btn_doctor_update_Click);
            // 
            // txt_DoctorSpecial
            // 
            this.txt_DoctorSpecial.Location = new System.Drawing.Point(479, 83);
            this.txt_DoctorSpecial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DoctorSpecial.Name = "txt_DoctorSpecial";
            this.txt_DoctorSpecial.Size = new System.Drawing.Size(153, 23);
            this.txt_DoctorSpecial.TabIndex = 10;
            this.txt_DoctorSpecial.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_DoctorPhone
            // 
            this.txt_DoctorPhone.Location = new System.Drawing.Point(171, 164);
            this.txt_DoctorPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DoctorPhone.Name = "txt_DoctorPhone";
            this.txt_DoctorPhone.Size = new System.Drawing.Size(153, 23);
            this.txt_DoctorPhone.TabIndex = 11;
            this.txt_DoctorPhone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_DoctorDegree
            // 
            this.txt_DoctorDegree.Location = new System.Drawing.Point(479, 56);
            this.txt_DoctorDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DoctorDegree.Name = "txt_DoctorDegree";
            this.txt_DoctorDegree.Size = new System.Drawing.Size(153, 23);
            this.txt_DoctorDegree.TabIndex = 12;
            this.txt_DoctorDegree.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_DoctorGender
            // 
            this.txt_DoctorGender.Location = new System.Drawing.Point(171, 137);
            this.txt_DoctorGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DoctorGender.Name = "txt_DoctorGender";
            this.txt_DoctorGender.Size = new System.Drawing.Size(153, 23);
            this.txt_DoctorGender.TabIndex = 13;
            this.txt_DoctorGender.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_DoctorAge
            // 
            this.txt_DoctorAge.Location = new System.Drawing.Point(171, 110);
            this.txt_DoctorAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DoctorAge.Name = "txt_DoctorAge";
            this.txt_DoctorAge.Size = new System.Drawing.Size(153, 23);
            this.txt_DoctorAge.TabIndex = 14;
            this.txt_DoctorAge.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_DoctorLastName
            // 
            this.txt_DoctorLastName.Location = new System.Drawing.Point(171, 83);
            this.txt_DoctorLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DoctorLastName.Name = "txt_DoctorLastName";
            this.txt_DoctorLastName.Size = new System.Drawing.Size(153, 23);
            this.txt_DoctorLastName.TabIndex = 15;
            this.txt_DoctorLastName.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txt_DoctorName
            // 
            this.txt_DoctorName.Location = new System.Drawing.Point(171, 56);
            this.txt_DoctorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DoctorName.Name = "txt_DoctorName";
            this.txt_DoctorName.Size = new System.Drawing.Size(153, 23);
            this.txt_DoctorName.TabIndex = 16;
            this.txt_DoctorName.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txt_DoctorAddress
            // 
            this.txt_DoctorAddress.Location = new System.Drawing.Point(479, 110);
            this.txt_DoctorAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DoctorAddress.Multiline = true;
            this.txt_DoctorAddress.Name = "txt_DoctorAddress";
            this.txt_DoctorAddress.Size = new System.Drawing.Size(285, 87);
            this.txt_DoctorAddress.TabIndex = 17;
            this.txt_DoctorAddress.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Surname:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gender:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phone:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Degree:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Specialization:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Address:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Age:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // doctor_gridView
            // 
            this.doctor_gridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.doctor_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctor_gridView.Location = new System.Drawing.Point(23, 243);
            this.doctor_gridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctor_gridView.Name = "doctor_gridView";
            this.doctor_gridView.RowHeadersWidth = 51;
            this.doctor_gridView.RowTemplate.Height = 29;
            this.doctor_gridView.Size = new System.Drawing.Size(596, 196);
            this.doctor_gridView.TabIndex = 27;
            this.doctor_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctor_gridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "DOCTOR";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_DoctorDelete
            // 
            this.btn_DoctorDelete.BackColor = System.Drawing.Color.Red;
            this.btn_DoctorDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DoctorDelete.Location = new System.Drawing.Point(644, 346);
            this.btn_DoctorDelete.Name = "btn_DoctorDelete";
            this.btn_DoctorDelete.Size = new System.Drawing.Size(120, 35);
            this.btn_DoctorDelete.TabIndex = 53;
            this.btn_DoctorDelete.Text = "DELETE";
            this.btn_DoctorDelete.UseVisualStyleBackColor = false;
            this.btn_DoctorDelete.Click += new System.EventHandler(this.btn_DoctorDelete_Click);
            // 
            // btn_DoctorHome
            // 
            this.btn_DoctorHome.BackColor = System.Drawing.Color.Lavender;
            this.btn_DoctorHome.Location = new System.Drawing.Point(644, 404);
            this.btn_DoctorHome.Name = "btn_DoctorHome";
            this.btn_DoctorHome.Size = new System.Drawing.Size(120, 35);
            this.btn_DoctorHome.TabIndex = 54;
            this.btn_DoctorHome.Text = "Home Page";
            this.btn_DoctorHome.UseVisualStyleBackColor = false;
            this.btn_DoctorHome.Click += new System.EventHandler(this.btn_DoctorHome_Click);
            // 
            // List_Doctor
            // 
            this.List_Doctor.BackColor = System.Drawing.Color.GhostWhite;
            this.List_Doctor.Location = new System.Drawing.Point(23, 203);
            this.List_Doctor.Name = "List_Doctor";
            this.List_Doctor.Size = new System.Drawing.Size(120, 35);
            this.List_Doctor.TabIndex = 55;
            this.List_Doctor.Text = "LIST";
            this.List_Doctor.UseVisualStyleBackColor = false;
            this.List_Doctor.Click += new System.EventHandler(this.List_Doctor_Click);
            // 
            // DoctorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.List_Doctor);
            this.Controls.Add(this.btn_DoctorHome);
            this.Controls.Add(this.btn_DoctorDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctor_gridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DoctorAddress);
            this.Controls.Add(this.txt_DoctorName);
            this.Controls.Add(this.txt_DoctorLastName);
            this.Controls.Add(this.txt_DoctorAge);
            this.Controls.Add(this.txt_DoctorGender);
            this.Controls.Add(this.txt_DoctorDegree);
            this.Controls.Add(this.txt_DoctorPhone);
            this.Controls.Add(this.txt_DoctorSpecial);
            this.Controls.Add(this.btn_doctor_update);
            this.Controls.Add(this.btn_doctor_save);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoctorPage";
            this.Text = "DoctorPage";
            this.Load += new System.EventHandler(this.DoctorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctor_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_doctor_save;
        private Button btn_doctor_update;
        private TextBox txt_DoctorSpecial;
        private TextBox txt_DoctorPhone;
        private TextBox txt_DoctorDegree;
        private TextBox txt_DoctorGender;
        private TextBox txt_DoctorAge;
        private TextBox txt_DoctorLastName;
        private TextBox txt_DoctorName;
        private TextBox txt_DoctorAddress;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView doctor_gridView;
        private Label label1;
        private Button btn_DoctorDelete;
        private Button btn_DoctorHome;
        private Button List_Doctor;
    }
}