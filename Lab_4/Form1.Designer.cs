namespace Lab_4
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tabPage2 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDown2 = new NumericUpDown();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(594, 344);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 0;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0.001", "0.01", "1", "0.5", "0.05", "0.005" });
            comboBox1.Location = new Point(78, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "0.01";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(78, 44);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(34, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(337, 301);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(329, 273);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Функция";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Cos", "Log10", "Tan" });
            listBox1.Location = new Point(24, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(94, 49);
            listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(144, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Точность вычислений";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(26, 111);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(58, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "0.0001";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(26, 72);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "0.001";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 33);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(46, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "0.01";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(numericUpDown2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(329, 273);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Диапазон";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 52);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "от X1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 102);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "от X2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 163);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 5;
            label1.Text = "Шаг";
            label1.Click += label1_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(78, 100);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(392, 119);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(227, 205);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 90);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 8;
            label4.Text = "Результат вычислений";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(674, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 205);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(674, 90);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "График";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 450);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label2;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
    }
}