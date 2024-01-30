namespace WinFormsApp3
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
            chSarı = new CheckBox();
            chTuruncu = new CheckBox();
            chMor = new CheckBox();
            chMavi = new CheckBox();
            chKırmızı = new CheckBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAge = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            groupBox3 = new GroupBox();
            rdErkek = new RadioButton();
            rdKadın = new RadioButton();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chSarı);
            groupBox1.Controls.Add(chTuruncu);
            groupBox1.Controls.Add(chMor);
            groupBox1.Controls.Add(chMavi);
            groupBox1.Controls.Add(chKırmızı);
            groupBox1.Location = new Point(33, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 347);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Colors";
            // 
            // chSarı
            // 
            chSarı.AutoSize = true;
            chSarı.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            chSarı.Location = new Point(21, 260);
            chSarı.Name = "chSarı";
            chSarı.Size = new Size(64, 34);
            chSarı.TabIndex = 4;
            chSarı.Text = "sarı";
            chSarı.UseVisualStyleBackColor = true;
            // 
            // chTuruncu
            // 
            chTuruncu.AutoSize = true;
            chTuruncu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            chTuruncu.Location = new Point(17, 203);
            chTuruncu.Name = "chTuruncu";
            chTuruncu.Size = new Size(104, 34);
            chTuruncu.TabIndex = 3;
            chTuruncu.Text = "turuncu";
            chTuruncu.UseVisualStyleBackColor = true;
            // 
            // chMor
            // 
            chMor.AutoSize = true;
            chMor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            chMor.Location = new Point(17, 139);
            chMor.Name = "chMor";
            chMor.Size = new Size(69, 34);
            chMor.TabIndex = 2;
            chMor.Text = "mor";
            chMor.UseVisualStyleBackColor = true;
            // 
            // chMavi
            // 
            chMavi.AutoSize = true;
            chMavi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            chMavi.Location = new Point(17, 90);
            chMavi.Name = "chMavi";
            chMavi.Size = new Size(76, 34);
            chMavi.TabIndex = 1;
            chMavi.Text = "mavi";
            chMavi.UseVisualStyleBackColor = true;
            // 
            // chKırmızı
            // 
            chKırmızı.AutoSize = true;
            chKırmızı.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            chKırmızı.Location = new Point(17, 39);
            chKırmızı.Name = "chKırmızı";
            chKırmızı.Size = new Size(92, 34);
            chKırmızı.TabIndex = 0;
            chKırmızı.Text = "kırmızı";
            chKırmızı.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtAge);
            groupBox2.Controls.Add(txtSurname);
            groupBox2.Controls.Add(txtName);
            groupBox2.Location = new Point(285, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 220);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 137);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 5;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 80);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Sur Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(80, 134);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 2;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(80, 80);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdErkek);
            groupBox3.Controls.Add(rdKadın);
            groupBox3.Location = new Point(285, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gender";
            // 
            // rdErkek
            // 
            rdErkek.AutoSize = true;
            rdErkek.Location = new Point(45, 63);
            rdErkek.Name = "rdErkek";
            rdErkek.Size = new Size(53, 19);
            rdErkek.TabIndex = 1;
            rdErkek.TabStop = true;
            rdErkek.Text = "Erkek";
            rdErkek.UseVisualStyleBackColor = true;
            // 
            // rdKadın
            // 
            rdKadın.AutoSize = true;
            rdKadın.Location = new Point(45, 38);
            rdKadın.Name = "rdKadın";
            rdKadın.Size = new Size(55, 19);
            rdKadın.TabIndex = 0;
            rdKadın.TabStop = true;
            rdKadın.Text = "Kadın";
            rdKadın.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(158, 393);
            button1.Name = "button1";
            button1.Size = new Size(273, 45);
            button1.TabIndex = 3;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(517, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 364);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(597, 404);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "List All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(499, 408);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chSarı;
        private CheckBox chTuruncu;
        private CheckBox chMor;
        private CheckBox chMavi;
        private CheckBox chKırmızı;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAge;
        private TextBox txtSurname;
        private TextBox txtName;
        private RadioButton rdErkek;
        private RadioButton rdKadın;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
    }
}
