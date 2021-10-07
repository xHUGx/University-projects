namespace WindowsFormsApp69
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.folder_button = new System.Windows.Forms.Button();
            this.folder_box = new System.Windows.Forms.TextBox();
            this.open_button = new System.Windows.Forms.Button();
            this.files_list_box = new System.Windows.Forms.ComboBox();
            this.sbox_3 = new System.Windows.Forms.PictureBox();
            this.sbox_2 = new System.Windows.Forms.PictureBox();
            this.sbox_1 = new System.Windows.Forms.PictureBox();
            this.sbox_0 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbox_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbox_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Генерация выборки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(432, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 512);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // folder_button
            // 
            this.folder_button.Location = new System.Drawing.Point(223, 81);
            this.folder_button.Name = "folder_button";
            this.folder_button.Size = new System.Drawing.Size(62, 23);
            this.folder_button.TabIndex = 4;
            this.folder_button.Text = "Папка";
            this.folder_button.UseVisualStyleBackColor = true;
            this.folder_button.Click += new System.EventHandler(this.folder_button_Click);
            // 
            // folder_box
            // 
            this.folder_box.Enabled = false;
            this.folder_box.Location = new System.Drawing.Point(11, 81);
            this.folder_box.Margin = new System.Windows.Forms.Padding(2);
            this.folder_box.Multiline = true;
            this.folder_box.Name = "folder_box";
            this.folder_box.Size = new System.Drawing.Size(207, 20);
            this.folder_box.TabIndex = 5;
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(223, 110);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(62, 23);
            this.open_button.TabIndex = 6;
            this.open_button.Text = "Файл";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // files_list_box
            // 
            this.files_list_box.Enabled = false;
            this.files_list_box.FormattingEnabled = true;
            this.files_list_box.Location = new System.Drawing.Point(11, 110);
            this.files_list_box.Name = "files_list_box";
            this.files_list_box.Size = new System.Drawing.Size(208, 21);
            this.files_list_box.TabIndex = 7;
            this.files_list_box.SelectedIndexChanged += new System.EventHandler(this.files_list_box_SelectedIndexChanged);
            // 
            // sbox_3
            // 
            this.sbox_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sbox_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sbox_3.Location = new System.Drawing.Point(221, 12);
            this.sbox_3.Name = "sbox_3";
            this.sbox_3.Size = new System.Drawing.Size(64, 64);
            this.sbox_3.TabIndex = 3;
            this.sbox_3.TabStop = false;
            // 
            // sbox_2
            // 
            this.sbox_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sbox_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sbox_2.Location = new System.Drawing.Point(151, 12);
            this.sbox_2.Name = "sbox_2";
            this.sbox_2.Size = new System.Drawing.Size(64, 64);
            this.sbox_2.TabIndex = 2;
            this.sbox_2.TabStop = false;
            // 
            // sbox_1
            // 
            this.sbox_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sbox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sbox_1.Location = new System.Drawing.Point(81, 12);
            this.sbox_1.Name = "sbox_1";
            this.sbox_1.Size = new System.Drawing.Size(64, 64);
            this.sbox_1.TabIndex = 1;
            this.sbox_1.TabStop = false;
            // 
            // sbox_0
            // 
            this.sbox_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sbox_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sbox_0.Location = new System.Drawing.Point(11, 12);
            this.sbox_0.Name = "sbox_0";
            this.sbox_0.Size = new System.Drawing.Size(64, 64);
            this.sbox_0.TabIndex = 0;
            this.sbox_0.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(160, 195);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1-ый знак";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(160, 218);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2-ой знак";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(160, 242);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3-й знак";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(160, 266);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(75, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4-ый знак";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 58);
            this.button3.TabIndex = 13;
            this.button3.Text = "Генерация связей S-A";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(432, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(461, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 492);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button4.Size = new System.Drawing.Size(100, 61);
            this.button4.TabIndex = 16;
            this.button4.Text = "Обучить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(322, 472);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(322, 496);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown2.TabIndex = 20;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(322, 539);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown3.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(160, 472);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Последовательно:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(160, 542);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Случайно:";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Кол-во";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 818);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.sbox_3);
            this.Controls.Add(this.sbox_2);
            this.Controls.Add(this.files_list_box);
            this.Controls.Add(this.sbox_1);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.sbox_0);
            this.Controls.Add(this.folder_box);
            this.Controls.Add(this.folder_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbox_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbox_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button folder_button;
        private System.Windows.Forms.TextBox folder_box;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.ComboBox files_list_box;
        private System.Windows.Forms.PictureBox sbox_3;
        private System.Windows.Forms.PictureBox sbox_2;
        private System.Windows.Forms.PictureBox sbox_1;
        private System.Windows.Forms.PictureBox sbox_0;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

