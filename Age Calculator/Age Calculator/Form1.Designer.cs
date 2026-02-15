namespace Age_Calculator
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(222, 179);
            button1.Name = "button1";
            button1.Size = new Size(127, 45);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 59);
            label1.Name = "label1";
            label1.Size = new Size(141, 24);
            label1.TabIndex = 1;
            label1.Text = "Date Of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(222, 259);
            label2.Name = "label2";
            label2.Size = new Size(130, 24);
            label2.TabIndex = 2;
            label2.Text = "Current Age:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(185, 54);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 31);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(185, 306);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 55);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 116);
            label3.Name = "label3";
            label3.Size = new Size(138, 24);
            label3.TabIndex = 5;
            label3.Text = "Current Date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(185, 109);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(233, 31);
            dateTimePicker2.TabIndex = 14;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(585, 513);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Age Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
    }
}
