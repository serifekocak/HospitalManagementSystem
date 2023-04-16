namespace HospitalManagementSystem
{
    partial class Rooms
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
            this.room_GridView = new System.Windows.Forms.DataGridView();
            this.btn_room = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_findByName = new System.Windows.Forms.TextBox();
            this.btn_RoomHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.room_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // room_GridView
            // 
            this.room_GridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.room_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.room_GridView.Location = new System.Drawing.Point(13, 74);
            this.room_GridView.Name = "room_GridView";
            this.room_GridView.RowHeadersWidth = 51;
            this.room_GridView.RowTemplate.Height = 25;
            this.room_GridView.Size = new System.Drawing.Size(573, 244);
            this.room_GridView.TabIndex = 1;
            // 
            // btn_room
            // 
            this.btn_room.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_room.Location = new System.Drawing.Point(13, 25);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(161, 23);
            this.btn_room.TabIndex = 2;
            this.btn_room.Text = "ROOM INFORMATION";
            this.btn_room.UseVisualStyleBackColor = false;
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_find.Location = new System.Drawing.Point(481, 26);
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(82, 22);
            this.btn_find.TabIndex = 3;
            this.btn_find.Text = "FIND";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(243, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient Name:";
            // 
            // txt_findByName
            // 
            this.txt_findByName.Location = new System.Drawing.Point(351, 26);
            this.txt_findByName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_findByName.Name = "txt_findByName";
            this.txt_findByName.Size = new System.Drawing.Size(110, 23);
            this.txt_findByName.TabIndex = 5;
            this.txt_findByName.TextChanged += new System.EventHandler(this.txt_findByName_TextChanged);
            // 
            // btn_RoomHome
            // 
            this.btn_RoomHome.BackColor = System.Drawing.Color.Lavender;
            this.btn_RoomHome.Location = new System.Drawing.Point(466, 323);
            this.btn_RoomHome.Name = "btn_RoomHome";
            this.btn_RoomHome.Size = new System.Drawing.Size(120, 35);
            this.btn_RoomHome.TabIndex = 57;
            this.btn_RoomHome.Text = "Home Page";
            this.btn_RoomHome.UseVisualStyleBackColor = false;
            this.btn_RoomHome.Click += new System.EventHandler(this.btn_RoomHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 666);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 365);
            this.Controls.Add(this.btn_RoomHome);
            this.Controls.Add(this.txt_findByName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_room);
            this.Controls.Add(this.room_GridView);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Rooms";
            this.Text = "Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.room_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView room_GridView;
        private Button btn_room;
        private Button btn_find;
        private Label label1;
        private TextBox txt_findPatient;
        private TextBox txt_findByName;
        private Button btn_RoomHome;
        private Label label2;
        private TextBox txt_findBySurname;
    }
}