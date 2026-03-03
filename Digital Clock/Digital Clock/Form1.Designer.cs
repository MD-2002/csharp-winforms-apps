namespace Digital_Clock
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1_Time = new Label();
            label3_Date = new Label();
            label4_DayOfWeek = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1_Time
            // 
            label1_Time.AutoSize = true;
            label1_Time.BackColor = SystemColors.ActiveCaption;
            label1_Time.BorderStyle = BorderStyle.Fixed3D;
            label1_Time.FlatStyle = FlatStyle.Popup;
            label1_Time.Font = new Font("DS-Digital", 38F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1_Time.ForeColor = SystemColors.ActiveCaptionText;
            label1_Time.Location = new Point(178, 165);
            label1_Time.Name = "label1_Time";
            label1_Time.Size = new Size(382, 77);
            label1_Time.TabIndex = 0;
            label1_Time.Text = "HH:MM:SS XX";
            // 
            // label3_Date
            // 
            label3_Date.AutoSize = true;
            label3_Date.BackColor = SystemColors.ActiveCaption;
            label3_Date.BorderStyle = BorderStyle.Fixed3D;
            label3_Date.FlatStyle = FlatStyle.Popup;
            label3_Date.Font = new Font("DS-Digital", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3_Date.ForeColor = SystemColors.ActiveCaptionText;
            label3_Date.Location = new Point(48, 353);
            label3_Date.Name = "label3_Date";
            label3_Date.Size = new Size(157, 42);
            label3_Date.TabIndex = 2;
            label3_Date.Text = "DD MM YY";
            label3_Date.Click += label3_Date_Click;
            // 
            // label4_DayOfWeek
            // 
            label4_DayOfWeek.AutoSize = true;
            label4_DayOfWeek.BackColor = SystemColors.ActiveCaption;
            label4_DayOfWeek.BorderStyle = BorderStyle.Fixed3D;
            label4_DayOfWeek.FlatStyle = FlatStyle.Popup;
            label4_DayOfWeek.Font = new Font("DS-Digital", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4_DayOfWeek.ForeColor = SystemColors.ActiveCaptionText;
            label4_DayOfWeek.Location = new Point(460, 353);
            label4_DayOfWeek.Name = "label4_DayOfWeek";
            label4_DayOfWeek.Size = new Size(199, 42);
            label4_DayOfWeek.TabIndex = 3;
            label4_DayOfWeek.Text = "DayOfWeek";
            label4_DayOfWeek.Click += label4_DayOfWeek_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(152, 9);
            label1.Name = "label1";
            label1.Size = new Size(430, 72);
            label1.TabIndex = 4;
            label1.Text = " Digital Clock ";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(735, 427);
            Controls.Add(label1);
            Controls.Add(label4_DayOfWeek);
            Controls.Add(label3_Date);
            Controls.Add(label1_Time);
            Name = "Form1";
            Text = "Clock";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1_Time;
        private Label label3_Date;
        private Label label4_DayOfWeek;
        private Label label1;
    }
}
