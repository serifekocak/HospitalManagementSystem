namespace HospitalManagementSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pic_background = new System.Windows.Forms.PictureBox();
            this.pic_patient = new System.Windows.Forms.PictureBox();
            this.pic_doctor = new System.Windows.Forms.PictureBox();
            this.hospital_name = new System.Windows.Forms.Label();
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_employee = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_doctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_background
            // 
            this.pic_background.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic_background.Location = new System.Drawing.Point(-2, -2);
            this.pic_background.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_background.Name = "pic_background";
            this.pic_background.Size = new System.Drawing.Size(580, 447);
            this.pic_background.TabIndex = 0;
            this.pic_background.TabStop = false;
            this.pic_background.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pic_patient
            // 
            this.pic_patient.Image = ((System.Drawing.Image)(resources.GetObject("pic_patient.Image")));
            this.pic_patient.Location = new System.Drawing.Point(240, 157);
            this.pic_patient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_patient.Name = "pic_patient";
            this.pic_patient.Size = new System.Drawing.Size(115, 105);
            this.pic_patient.TabIndex = 1;
            this.pic_patient.TabStop = false;
            // 
            // pic_doctor
            // 
            this.pic_doctor.Image = ((System.Drawing.Image)(resources.GetObject("pic_doctor.Image")));
            this.pic_doctor.Location = new System.Drawing.Point(25, 157);
            this.pic_doctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_doctor.Name = "pic_doctor";
            this.pic_doctor.Size = new System.Drawing.Size(115, 105);
            this.pic_doctor.TabIndex = 2;
            this.pic_doctor.TabStop = false;
            this.pic_doctor.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // hospital_name
            // 
            this.hospital_name.AutoSize = true;
            this.hospital_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hospital_name.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.hospital_name.Location = new System.Drawing.Point(171, 27);
            this.hospital_name.Name = "hospital_name";
            this.hospital_name.Size = new System.Drawing.Size(241, 38);
            this.hospital_name.TabIndex = 3;
            this.hospital_name.Text = "MedLife Hospital";
            this.hospital_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_doctor
            // 
            this.btn_doctor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_doctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_doctor.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_doctor.Location = new System.Drawing.Point(49, 105);
            this.btn_doctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(91, 33);
            this.btn_doctor.TabIndex = 6;
            this.btn_doctor.Text = "Doctor";
            this.btn_doctor.UseVisualStyleBackColor = false;
            this.btn_doctor.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // btn_patient
            // 
            this.btn_patient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_patient.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_patient.Location = new System.Drawing.Point(254, 105);
            this.btn_patient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(91, 33);
            this.btn_patient.TabIndex = 7;
            this.btn_patient.Text = "Patient";
            this.btn_patient.UseVisualStyleBackColor = false;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(433, 157);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 105);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_employee.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_employee.Location = new System.Drawing.Point(441, 105);
            this.btn_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(105, 33);
            this.btn_employee.TabIndex = 9;
            this.btn_employee.Text = "Employee";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(215, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "Rooms";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1155, 632);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 395);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_patient);
            this.Controls.Add(this.btn_doctor);
            this.Controls.Add(this.hospital_name);
            this.Controls.Add(this.pic_doctor);
            this.Controls.Add(this.pic_patient);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic_background);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_doctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_background;
        private PictureBox pic_patient;
        private PictureBox pic_doctor;
        private Label hospital_name;
        private Button btn_doctor;
        private Button btn_patient;
        private PictureBox pictureBox1;
        private Button btn_employee;
        private Button button3;
        private PictureBox pictureBox2;
    }
}