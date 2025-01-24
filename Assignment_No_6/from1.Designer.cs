
namespace Assignment_No_6
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
            this.lb_Employee_Details = new System.Windows.Forms.Label();
            this.lb_Employee_Name = new System.Windows.Forms.Label();
            this.lb_Known_Languages = new System.Windows.Forms.Label();
            this.lb_Employee_Department = new System.Windows.Forms.Label();
            this.lb_Hobbies = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.lb_Output = new System.Windows.Forms.Label();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.cmb_Dept = new System.Windows.Forms.ComboBox();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.CheckBox();
            this.rb_Male = new System.Windows.Forms.CheckBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Gender_Error = new System.Windows.Forms.Label();
            this.lbl_Lang_Error = new System.Windows.Forms.Label();
            this.lbl_Dept_Error = new System.Windows.Forms.Label();
            this.lbl_Name_Error = new System.Windows.Forms.Label();
            this.lbl_Hobby_Error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Out = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Employee_Details
            // 
            this.lb_Employee_Details.AutoSize = true;
            this.lb_Employee_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lb_Employee_Details.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Employee_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lb_Employee_Details.Location = new System.Drawing.Point(549, 30);
            this.lb_Employee_Details.Name = "lb_Employee_Details";
            this.lb_Employee_Details.Size = new System.Drawing.Size(301, 40);
            this.lb_Employee_Details.TabIndex = 0;
            this.lb_Employee_Details.Text = "Employee Details";
            // 
            // lb_Employee_Name
            // 
            this.lb_Employee_Name.AutoSize = true;
            this.lb_Employee_Name.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Employee_Name.Location = new System.Drawing.Point(12, 119);
            this.lb_Employee_Name.Name = "lb_Employee_Name";
            this.lb_Employee_Name.Size = new System.Drawing.Size(212, 30);
            this.lb_Employee_Name.TabIndex = 1;
            this.lb_Employee_Name.Text = "Employee Name";
            this.lb_Employee_Name.Click += new System.EventHandler(this.lb_Employee_Name_Click);
            // 
            // lb_Known_Languages
            // 
            this.lb_Known_Languages.AutoSize = true;
            this.lb_Known_Languages.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Known_Languages.Location = new System.Drawing.Point(648, 120);
            this.lb_Known_Languages.Name = "lb_Known_Languages";
            this.lb_Known_Languages.Size = new System.Drawing.Size(237, 30);
            this.lb_Known_Languages.TabIndex = 2;
            this.lb_Known_Languages.Text = "Known Languages";
            // 
            // lb_Employee_Department
            // 
            this.lb_Employee_Department.AutoSize = true;
            this.lb_Employee_Department.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Employee_Department.Location = new System.Drawing.Point(14, 234);
            this.lb_Employee_Department.Name = "lb_Employee_Department";
            this.lb_Employee_Department.Size = new System.Drawing.Size(283, 30);
            this.lb_Employee_Department.TabIndex = 3;
            this.lb_Employee_Department.Text = "Employee Department";
            this.lb_Employee_Department.Click += new System.EventHandler(this.lb_Employee_Department_Click);
            // 
            // lb_Hobbies
            // 
            this.lb_Hobbies.AutoSize = true;
            this.lb_Hobbies.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hobbies.Location = new System.Drawing.Point(648, 264);
            this.lb_Hobbies.Name = "lb_Hobbies";
            this.lb_Hobbies.Size = new System.Drawing.Size(113, 30);
            this.lb_Hobbies.TabIndex = 4;
            this.lb_Hobbies.Text = "Hobbies";
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.Location = new System.Drawing.Point(23, 333);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(100, 30);
            this.lb_Gender.TabIndex = 5;
            this.lb_Gender.Text = "Gender";
            this.lb_Gender.Click += new System.EventHandler(this.lb_Gender_Click);
            // 
            // lb_Output
            // 
            this.lb_Output.AutoSize = true;
            this.lb_Output.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Output.Location = new System.Drawing.Point(26, 635);
            this.lb_Output.Name = "lb_Output";
            this.lb_Output.Size = new System.Drawing.Size(97, 30);
            this.lb_Output.TabIndex = 6;
            this.lb_Output.Text = "Output";
            this.lb_Output.Click += new System.EventHandler(this.lb_Output_Click);
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Location = new System.Drawing.Point(316, 120);
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(269, 22);
            this.tb_Employee_Name.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cb_French);
            this.groupBox1.Controls.Add(this.cb_English);
            this.groupBox1.Controls.Add(this.cb_Hindi);
            this.groupBox1.Controls.Add(this.cb_Marathi);
            this.groupBox1.Location = new System.Drawing.Point(910, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 138);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_French.Location = new System.Drawing.Point(193, 95);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(85, 22);
            this.cb_French.TabIndex = 12;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            this.cb_French.CheckedChanged += new System.EventHandler(this.cb_French_CheckedChanged);
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_English.Location = new System.Drawing.Point(36, 40);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(91, 22);
            this.cb_English.TabIndex = 14;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Hindi.Location = new System.Drawing.Point(203, 40);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(75, 22);
            this.cb_Hindi.TabIndex = 13;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marathi.Location = new System.Drawing.Point(36, 95);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(93, 22);
            this.cb_Marathi.TabIndex = 12;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            this.cb_Marathi.CheckedChanged += new System.EventHandler(this.cb_Marathi_CheckedChanged);
            // 
            // cmb_Dept
            // 
            this.cmb_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dept.FormattingEnabled = true;
            this.cmb_Dept.Items.AddRange(new object[] {
            " HRD",
            " R&D",
            "Testing",
            "Management"});
            this.cmb_Dept.Location = new System.Drawing.Point(316, 240);
            this.cmb_Dept.Name = "cmb_Dept";
            this.cmb_Dept.Size = new System.Drawing.Size(280, 24);
            this.cmb_Dept.TabIndex = 11;
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clb_Hobbies.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Reading",
            "Driving",
            "Teaching",
            "Gameing",
            "Dancing",
            "Swwiming",
            "Cycling",
            "Tracking"});
            this.clb_Hobbies.Location = new System.Drawing.Point(920, 310);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(338, 164);
            this.clb_Hobbies.TabIndex = 12;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(316, 343);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(291, 100);
            this.gb_Gender.TabIndex = 13;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(182, 49);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(87, 22);
            this.rb_Female.TabIndex = 14;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(42, 49);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(70, 22);
            this.rb_Male.TabIndex = 15;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Red;
            this.btn_Reset.Location = new System.Drawing.Point(613, 550);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(178, 45);
            this.btn_Reset.TabIndex = 14;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Red;
            this.btn_Submit.Location = new System.Drawing.Point(811, 550);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(178, 45);
            this.btn_Submit.TabIndex = 15;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Gender_Error
            // 
            this.lbl_Gender_Error.AutoSize = true;
            this.lbl_Gender_Error.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Gender_Error.Location = new System.Drawing.Point(495, 456);
            this.lbl_Gender_Error.Name = "lbl_Gender_Error";
            this.lbl_Gender_Error.Size = new System.Drawing.Size(113, 18);
            this.lbl_Gender_Error.TabIndex = 16;
            this.lbl_Gender_Error.Text = "Gender Error";
            // 
            // lbl_Lang_Error
            // 
            this.lbl_Lang_Error.AutoSize = true;
            this.lbl_Lang_Error.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lang_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Lang_Error.Location = new System.Drawing.Point(1153, 264);
            this.lbl_Lang_Error.Name = "lbl_Lang_Error";
            this.lbl_Lang_Error.Size = new System.Drawing.Size(95, 18);
            this.lbl_Lang_Error.TabIndex = 17;
            this.lbl_Lang_Error.Text = "Lang Error";
            // 
            // lbl_Dept_Error
            // 
            this.lbl_Dept_Error.AutoSize = true;
            this.lbl_Dept_Error.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dept_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Dept_Error.Location = new System.Drawing.Point(495, 276);
            this.lbl_Dept_Error.Name = "lbl_Dept_Error";
            this.lbl_Dept_Error.Size = new System.Drawing.Size(93, 18);
            this.lbl_Dept_Error.TabIndex = 18;
            this.lbl_Dept_Error.Text = "Dept Error";
            // 
            // lbl_Name_Error
            // 
            this.lbl_Name_Error.AutoSize = true;
            this.lbl_Name_Error.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name_Error.Location = new System.Drawing.Point(485, 156);
            this.lbl_Name_Error.Name = "lbl_Name_Error";
            this.lbl_Name_Error.Size = new System.Drawing.Size(100, 18);
            this.lbl_Name_Error.TabIndex = 19;
            this.lbl_Name_Error.Text = "Name Error";
            // 
            // lbl_Hobby_Error
            // 
            this.lbl_Hobby_Error.AutoSize = true;
            this.lbl_Hobby_Error.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobby_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Hobby_Error.Location = new System.Drawing.Point(1150, 477);
            this.lbl_Hobby_Error.Name = "lbl_Hobby_Error";
            this.lbl_Hobby_Error.Size = new System.Drawing.Size(108, 18);
            this.lbl_Hobby_Error.TabIndex = 20;
            this.lbl_Hobby_Error.Text = "Hobby Error";
            this.lbl_Hobby_Error.Click += new System.EventHandler(this.lbl_Hobbies_Error_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbl_Out);
            this.panel1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(147, 635);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 40);
            this.panel1.TabIndex = 21;
            // 
            // lbl_Out
            // 
            this.lbl_Out.AutoSize = true;
            this.lbl_Out.Location = new System.Drawing.Point(19, 12);
            this.lbl_Out.Name = "lbl_Out";
            this.lbl_Out.Size = new System.Drawing.Size(58, 18);
            this.lbl_Out.TabIndex = 0;
            this.lbl_Out.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Hobby_Error);
            this.Controls.Add(this.lbl_Name_Error);
            this.Controls.Add(this.lbl_Dept_Error);
            this.Controls.Add(this.lbl_Lang_Error);
            this.Controls.Add(this.lbl_Gender_Error);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.cmb_Dept);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_Employee_Name);
            this.Controls.Add(this.lb_Output);
            this.Controls.Add(this.lb_Gender);
            this.Controls.Add(this.lb_Hobbies);
            this.Controls.Add(this.lb_Employee_Department);
            this.Controls.Add(this.lb_Known_Languages);
            this.Controls.Add(this.lb_Employee_Name);
            this.Controls.Add(this.lb_Employee_Details);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Employee_Details;
        private System.Windows.Forms.Label lb_Employee_Name;
        private System.Windows.Forms.Label lb_Known_Languages;
        private System.Windows.Forms.Label lb_Employee_Department;
        private System.Windows.Forms.Label lb_Hobbies;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Label lb_Output;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.ComboBox cmb_Dept;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.CheckBox rb_Female;
        private System.Windows.Forms.CheckBox rb_Male;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Gender_Error;
        private System.Windows.Forms.Label lbl_Lang_Error;
        private System.Windows.Forms.Label lbl_Dept_Error;
        private System.Windows.Forms.Label lbl_Name_Error;
        private System.Windows.Forms.Label lbl_Hobby_Error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Out;
    }
}

