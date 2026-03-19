namespace Usersignup_withSQL
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
            btn_submit = new Button();
            textBox1 = new TextBox();
            lfname = new Label();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            contact = new Label();
            textBox2 = new TextBox();
            llastname = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            textBox6 = new TextBox();
            lconfpassword = new Label();
            textBox7 = new TextBox();
            lpassword = new Label();
            lusername = new Label();
            textBox8 = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_submit
            // 
            btn_submit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_submit.Location = new Point(445, 285);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(112, 34);
            btn_submit.TabIndex = 0;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(688, 31);
            textBox1.TabIndex = 2;
            // 
            // lfname
            // 
            lfname.AutoSize = true;
            lfname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lfname.Location = new Point(42, 45);
            lfname.Name = "lfname";
            lfname.Size = new Size(129, 32);
            lfname.TabIndex = 3;
            lfname.Text = "First Name";
            lfname.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(contact);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(llastname);
            groupBox1.Controls.Add(lfname);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(46, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(990, 412);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(225, 269);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(688, 119);
            textBox4.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 266);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 8;
            label1.Text = "Address";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(225, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(688, 31);
            textBox3.TabIndex = 7;
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contact.Location = new Point(57, 186);
            contact.Name = "contact";
            contact.Size = new Size(96, 32);
            contact.TabIndex = 6;
            contact.Text = "Contact";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(688, 31);
            textBox2.TabIndex = 5;
            // 
            // llastname
            // 
            llastname.AutoSize = true;
            llastname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llastname.Location = new Point(42, 111);
            llastname.Name = "llastname";
            llastname.Size = new Size(126, 32);
            llastname.TabIndex = 4;
            llastname.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(522, 13);
            label2.Name = "label2";
            label2.Size = new Size(81, 38);
            label2.TabIndex = 5;
            label2.Text = "Form";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(lconfpassword);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(btn_submit);
            groupBox2.Controls.Add(lpassword);
            groupBox2.Controls.Add(lusername);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Location = new Point(56, 472);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(980, 325);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(919, 114);
            label4.Name = "label4";
            label4.Size = new Size(24, 32);
            label4.TabIndex = 9;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(919, 48);
            label3.Name = "label3";
            label3.Size = new Size(24, 32);
            label3.TabIndex = 8;
            label3.Text = "*";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(225, 186);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(688, 31);
            textBox6.TabIndex = 7;
            // 
            // lconfpassword
            // 
            lconfpassword.AutoSize = true;
            lconfpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lconfpassword.Location = new Point(15, 186);
            lconfpassword.Name = "lconfpassword";
            lconfpassword.Size = new Size(204, 32);
            lconfpassword.TabIndex = 6;
            lconfpassword.Text = "Confirm Password";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(225, 114);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(688, 31);
            textBox7.TabIndex = 5;
            // 
            // lpassword
            // 
            lpassword.AutoSize = true;
            lpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lpassword.Location = new Point(42, 111);
            lpassword.Name = "lpassword";
            lpassword.Size = new Size(111, 32);
            lpassword.TabIndex = 4;
            lpassword.Text = "Password";
            // 
            // lusername
            // 
            lusername.AutoSize = true;
            lusername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lusername.Location = new Point(42, 45);
            lusername.Name = "lusername";
            lusername.Size = new Size(121, 32);
            lusername.TabIndex = 3;
            lusername.Text = "Username";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(225, 48);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(688, 31);
            textBox8.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(919, 186);
            label5.Name = "label5";
            label5.Size = new Size(24, 32);
            label5.TabIndex = 10;
            label5.Text = "*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 809);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "User Registration - Signup Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_submit;
        private TextBox textBox1;
        private Label lfname;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label llastname;
        private Label label1;
        private TextBox textBox3;
        private Label contact;
        private TextBox textBox4;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private Label lconfpassword;
        private TextBox textBox7;
        private Label lpassword;
        private Label lusername;
        private TextBox textBox8;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}
