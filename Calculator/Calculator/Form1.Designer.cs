namespace Calculator
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
            groupBox1 = new GroupBox();
            backspace = new Button();
            modulus = new Button();
            equal = new Button();
            clear = new Button();
            divide = new Button();
            number9 = new Button();
            number8 = new Button();
            number7 = new Button();
            multiply = new Button();
            number6 = new Button();
            number5 = new Button();
            number4 = new Button();
            minus = new Button();
            number3 = new Button();
            number2 = new Button();
            number1 = new Button();
            plus = new Button();
            comma = new Button();
            button2 = new Button();
            number0 = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(backspace);
            groupBox1.Controls.Add(modulus);
            groupBox1.Controls.Add(equal);
            groupBox1.Controls.Add(clear);
            groupBox1.Controls.Add(divide);
            groupBox1.Controls.Add(number9);
            groupBox1.Controls.Add(number8);
            groupBox1.Controls.Add(number7);
            groupBox1.Controls.Add(multiply);
            groupBox1.Controls.Add(number6);
            groupBox1.Controls.Add(number5);
            groupBox1.Controls.Add(number4);
            groupBox1.Controls.Add(minus);
            groupBox1.Controls.Add(number3);
            groupBox1.Controls.Add(number2);
            groupBox1.Controls.Add(number1);
            groupBox1.Controls.Add(plus);
            groupBox1.Controls.Add(comma);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(number0);
            groupBox1.Location = new Point(39, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 353);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // backspace
            // 
            backspace.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backspace.Location = new Point(258, 30);
            backspace.Name = "backspace";
            backspace.Size = new Size(57, 59);
            backspace.TabIndex = 20;
            backspace.Text = "<-";
            backspace.UseVisualStyleBackColor = true;
            backspace.Click += backspace_Click;
            // 
            // modulus
            // 
            modulus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modulus.Location = new Point(258, 184);
            modulus.Name = "modulus";
            modulus.Size = new Size(57, 65);
            modulus.TabIndex = 19;
            modulus.Text = "%";
            modulus.UseVisualStyleBackColor = true;
            modulus.Click += modulus_Click;
            // 
            // equal
            // 
            equal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equal.Location = new Point(258, 266);
            equal.Name = "equal";
            equal.Size = new Size(57, 65);
            equal.TabIndex = 18;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += button19_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.Location = new Point(258, 104);
            clear.Name = "clear";
            clear.Size = new Size(57, 64);
            clear.TabIndex = 17;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += button18_Click;
            // 
            // divide
            // 
            divide.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            divide.Location = new Point(195, 30);
            divide.Name = "divide";
            divide.Size = new Size(57, 59);
            divide.TabIndex = 15;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += button16_Click;
            // 
            // number9
            // 
            number9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number9.Location = new Point(132, 30);
            number9.Name = "number9";
            number9.Size = new Size(57, 59);
            number9.TabIndex = 14;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = true;
            number9.Click += button15_Click;
            // 
            // number8
            // 
            number8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number8.Location = new Point(69, 30);
            number8.Name = "number8";
            number8.Size = new Size(57, 59);
            number8.TabIndex = 13;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = true;
            number8.Click += button14_Click;
            // 
            // number7
            // 
            number7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number7.Location = new Point(6, 30);
            number7.Name = "number7";
            number7.Size = new Size(57, 59);
            number7.TabIndex = 12;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = true;
            number7.Click += button13_Click;
            // 
            // multiply
            // 
            multiply.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiply.Location = new Point(195, 104);
            multiply.Name = "multiply";
            multiply.Size = new Size(57, 64);
            multiply.TabIndex = 11;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += button12_Click;
            // 
            // number6
            // 
            number6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number6.Location = new Point(132, 104);
            number6.Name = "number6";
            number6.Size = new Size(57, 64);
            number6.TabIndex = 10;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = true;
            number6.Click += button11_Click;
            // 
            // number5
            // 
            number5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number5.Location = new Point(69, 104);
            number5.Name = "number5";
            number5.Size = new Size(57, 64);
            number5.TabIndex = 9;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = true;
            number5.Click += button10_Click;
            // 
            // number4
            // 
            number4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number4.Location = new Point(6, 104);
            number4.Name = "number4";
            number4.Size = new Size(57, 64);
            number4.TabIndex = 8;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = true;
            number4.Click += button9_Click;
            // 
            // minus
            // 
            minus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minus.Location = new Point(195, 184);
            minus.Name = "minus";
            minus.Size = new Size(57, 65);
            minus.TabIndex = 7;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += button8_Click;
            // 
            // number3
            // 
            number3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number3.Location = new Point(132, 184);
            number3.Name = "number3";
            number3.Size = new Size(57, 65);
            number3.TabIndex = 6;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = true;
            number3.Click += button7_Click;
            // 
            // number2
            // 
            number2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number2.Location = new Point(69, 184);
            number2.Name = "number2";
            number2.Size = new Size(57, 65);
            number2.TabIndex = 5;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = true;
            number2.Click += button6_Click;
            // 
            // number1
            // 
            number1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number1.Location = new Point(6, 184);
            number1.Name = "number1";
            number1.Size = new Size(57, 65);
            number1.TabIndex = 4;
            number1.Text = "1";
            number1.UseVisualStyleBackColor = true;
            number1.Click += button5_Click;
            // 
            // plus
            // 
            plus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plus.Location = new Point(195, 266);
            plus.Name = "plus";
            plus.Size = new Size(57, 65);
            plus.TabIndex = 3;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += button4_Click;
            // 
            // comma
            // 
            comma.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comma.Location = new Point(132, 266);
            comma.Name = "comma";
            comma.Size = new Size(57, 65);
            comma.TabIndex = 2;
            comma.Text = ".";
            comma.UseVisualStyleBackColor = true;
            comma.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(69, 266);
            button2.Name = "button2";
            button2.Size = new Size(57, 65);
            button2.TabIndex = 1;
            button2.Text = "+/-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // number0
            // 
            number0.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number0.Location = new Point(6, 266);
            number0.Name = "number0";
            number0.Size = new Size(57, 65);
            number0.TabIndex = 0;
            number0.Text = "0";
            number0.UseVisualStyleBackColor = true;
            number0.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 48);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(327, 31);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 450);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Calculator";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button equal;
        private Button clear;
        private Button divide;
        private Button number9;
        private Button number8;
        private Button number7;
        private Button multiply;
        private Button number6;
        private Button number5;
        private Button number4;
        private Button minus;
        private Button number3;
        private Button number2;
        private Button number1;
        private Button plus;
        private Button comma;
        private Button button2;
        private Button number0;
        private TextBox textBox1;
        private Button backspace;
        private Button modulus;
    }
}
