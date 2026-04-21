namespace WinFormsApp1
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
            textName = new TextBox();
            button1 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            monthCalendar1 = new MonthCalendar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Location = new Point(59, 55);
            textName.Name = "textName";
            textName.Size = new Size(146, 23);
            textName.TabIndex = 0;
            textName.TextChanged += textName_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(106, 106);
            button1.Name = "button1";
            button1.Size = new Size(99, 34);
            button1.TabIndex = 1;
            button1.Text = "入力";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 23);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 2;
            label1.Text = "こんにちは (here will be...?)";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "餃子", "卵スープ", "ラーメン", "チンジャオロース", "天津飯" });
            listBox1.Location = new Point(59, 161);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(146, 94);
            listBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "コーラ", "ジンジャエール", "ウーロン茶" });
            comboBox1.Location = new Point(59, 283);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "ドリンクを選んでください";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(226, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 5;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(46, 53);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "不味い...";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(46, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "美味い!!!";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "美味しかった", "不味かった", "清潔だった", "汚かった", "対応がよかった", "対応が悪かった" });
            checkedListBox1.Location = new Point(226, 129);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(200, 112);
            checkedListBox1.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(227, 270);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(checkedListBox1);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textName);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private Button button1;
        private Label label1;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private MonthCalendar monthCalendar1;
    }
}
