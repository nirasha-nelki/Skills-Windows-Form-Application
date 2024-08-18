namespace SkillsInternational
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_login = new Button();
            btn_clear = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(264, 154);
            label1.Name = "label1";
            label1.Size = new Size(103, 46);
            label1.TabIndex = 1;
            label1.Text = "Skills";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(btn_clear);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(156, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 205);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(211, 153);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(110, 27);
            btn_login.TabIndex = 8;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(28, 153);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(110, 27);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(120, 81);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(201, 27);
            txt_password.TabIndex = 6;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(120, 41);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(201, 27);
            txt_username.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 88);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 44);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(95, 430);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(110, 27);
            btn_exit.TabIndex = 9;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 484);
            Controls.Add(btn_exit);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Login - Skills International";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label label3;
        private Label label2;
        private Button btn_login;
        private Button btn_clear;
        private Button btn_exit;
    }
}
