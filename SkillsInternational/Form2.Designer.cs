namespace SkillsInternational
{
    partial class Form2
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            groupBox1 = new GroupBox();
            btn_clear = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_reg = new Button();
            groupBox4 = new GroupBox();
            txt_parent_contact = new TextBox();
            txt_nic = new TextBox();
            txt_parent_name = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            txt_home = new TextBox();
            txt_mobile = new TextBox();
            txt_email = new TextBox();
            txt_address = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            dob = new DateTimePicker();
            txt_lname = new TextBox();
            txt_fname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmb_reg = new ComboBox();
            label2 = new Label();
            linklabel_exit = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 46);
            label1.TabIndex = 0;
            label1.Text = "Skills International";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(82, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_clear);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Controls.Add(btn_reg);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cmb_reg);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(68, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 823);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(445, 768);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(95, 31);
            btn_clear.TabIndex = 8;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(546, 768);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(95, 31);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(131, 768);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(95, 31);
            btn_update.TabIndex = 6;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_reg
            // 
            btn_reg.Location = new Point(30, 768);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(95, 31);
            btn_reg.TabIndex = 5;
            btn_reg.Text = "Register";
            btn_reg.UseVisualStyleBackColor = true;
            btn_reg.Click += btn_reg_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_parent_contact);
            groupBox4.Controls.Add(txt_nic);
            groupBox4.Controls.Add(txt_parent_name);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(30, 594);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(611, 168);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parent Details";
            // 
            // txt_parent_contact
            // 
            txt_parent_contact.Location = new Point(151, 117);
            txt_parent_contact.Name = "txt_parent_contact";
            txt_parent_contact.Size = new Size(216, 27);
            txt_parent_contact.TabIndex = 5;
            // 
            // txt_nic
            // 
            txt_nic.Location = new Point(151, 76);
            txt_nic.Name = "txt_nic";
            txt_nic.Size = new Size(216, 27);
            txt_nic.TabIndex = 4;
            // 
            // txt_parent_name
            // 
            txt_parent_name.Location = new Point(151, 36);
            txt_parent_name.Name = "txt_parent_name";
            txt_parent_name.Size = new Size(420, 27);
            txt_parent_name.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(34, 120);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 2;
            label13.Text = "Contact No";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 79);
            label12.Name = "label12";
            label12.Size = new Size(33, 20);
            label12.TabIndex = 1;
            label12.Text = "NIC";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 39);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 0;
            label11.Text = "Parent Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_home);
            groupBox3.Controls.Add(txt_mobile);
            groupBox3.Controls.Add(txt_email);
            groupBox3.Controls.Add(txt_address);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(30, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(611, 256);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // txt_home
            // 
            txt_home.Location = new Point(439, 197);
            txt_home.Name = "txt_home";
            txt_home.Size = new Size(132, 27);
            txt_home.TabIndex = 11;
            // 
            // txt_mobile
            // 
            txt_mobile.Location = new Point(151, 197);
            txt_mobile.Name = "txt_mobile";
            txt_mobile.Size = new Size(132, 27);
            txt_mobile.TabIndex = 10;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(151, 141);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(420, 27);
            txt_email.TabIndex = 9;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(151, 48);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(420, 75);
            txt_address.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(338, 200);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 3;
            label10.Text = "Home Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 200);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 2;
            label9.Text = "Mobile Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 144);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 1;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 51);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 0;
            label7.Text = "Address";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radio_female);
            groupBox2.Controls.Add(radio_male);
            groupBox2.Controls.Add(dob);
            groupBox2.Controls.Add(txt_lname);
            groupBox2.Controls.Add(txt_fname);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(30, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(611, 217);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Location = new Point(289, 173);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(78, 24);
            radio_female.TabIndex = 8;
            radio_female.TabStop = true;
            radio_female.Text = "Female";
            radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.Location = new Point(151, 173);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(63, 24);
            radio_male.TabIndex = 7;
            radio_male.TabStop = true;
            radio_male.Text = "Male";
            radio_male.UseVisualStyleBackColor = true;
            // 
            // dob
            // 
            dob.Format = DateTimePickerFormat.Short;
            dob.Location = new Point(151, 130);
            dob.Name = "dob";
            dob.Size = new Size(250, 27);
            dob.TabIndex = 6;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(151, 87);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(420, 27);
            txt_lname.TabIndex = 5;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(151, 39);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(420, 27);
            txt_fname.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 175);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 3;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 135);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 2;
            label5.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 90);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 1;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 42);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 0;
            label3.Text = "First Name";
            // 
            // cmb_reg
            // 
            cmb_reg.FormattingEnabled = true;
            cmb_reg.Location = new Point(103, 39);
            cmb_reg.Name = "cmb_reg";
            cmb_reg.Size = new Size(151, 28);
            cmb_reg.TabIndex = 1;
            cmb_reg.SelectedIndexChanged += cmb_reg_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 42);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 0;
            label2.Text = "RegNo";
            // 
            // linklabel_exit
            // 
            linklabel_exit.AutoSize = true;
            linklabel_exit.Location = new Point(708, 909);
            linklabel_exit.Name = "linklabel_exit";
            linklabel_exit.Size = new Size(33, 20);
            linklabel_exit.TabIndex = 3;
            linklabel_exit.TabStop = true;
            linklabel_exit.Text = "Exit";
            linklabel_exit.LinkClicked += linklabel_exit_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 945);
            Controls.Add(linklabel_exit);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Student Registration - Skills International";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txt_lname;
        private TextBox txt_fname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cmb_reg;
        private RadioButton radio_female;
        private RadioButton radio_male;
        private DateTimePicker dob;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txt_mobile;
        private TextBox txt_email;
        private TextBox txt_address;
        private Label label10;
        private TextBox txt_home;
        private GroupBox groupBox4;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btn_clear;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_reg;
        private TextBox txt_parent_contact;
        private TextBox txt_nic;
        private TextBox txt_parent_name;
        private LinkLabel linklabel_exit;
    }
}