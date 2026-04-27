namespace ClassSamples
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
            ButtonAnimalInstanceCreate = new Button();
            textBoxName1 = new TextBox();
            texBoxtColor1 = new TextBox();
            textBoxSing1 = new TextBox();
            textBoxName2 = new TextBox();
            textBoxColor2 = new TextBox();
            textBoxSing2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // ButtonAnimalInstanceCreate
            // 
            ButtonAnimalInstanceCreate.BackColor = Color.Brown;
            ButtonAnimalInstanceCreate.ForeColor = Color.White;
            ButtonAnimalInstanceCreate.Location = new Point(42, 76);
            ButtonAnimalInstanceCreate.Name = "ButtonAnimalInstanceCreate";
            ButtonAnimalInstanceCreate.Size = new Size(423, 31);
            ButtonAnimalInstanceCreate.TabIndex = 0;
            ButtonAnimalInstanceCreate.Text = "動物クラスのインスタンス生成ボタン!?";
            ButtonAnimalInstanceCreate.UseVisualStyleBackColor = false;
            ButtonAnimalInstanceCreate.Click += ButtonAnimalInstanceCreate_Click;
            // 
            // textBoxName1
            // 
            textBoxName1.Location = new Point(104, 143);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(145, 23);
            textBoxName1.TabIndex = 1;
            // 
            // texBoxtColor1
            // 
            texBoxtColor1.Location = new Point(104, 199);
            texBoxtColor1.Name = "texBoxtColor1";
            texBoxtColor1.Size = new Size(145, 23);
            texBoxtColor1.TabIndex = 2;
            // 
            // textBoxSing1
            // 
            textBoxSing1.Location = new Point(104, 252);
            textBoxSing1.Name = "textBoxSing1";
            textBoxSing1.Size = new Size(145, 23);
            textBoxSing1.TabIndex = 3;
            // 
            // textBoxName2
            // 
            textBoxName2.Location = new Point(320, 143);
            textBoxName2.Name = "textBoxName2";
            textBoxName2.Size = new Size(145, 23);
            textBoxName2.TabIndex = 4;
            // 
            // textBoxColor2
            // 
            textBoxColor2.Location = new Point(320, 199);
            textBoxColor2.Name = "textBoxColor2";
            textBoxColor2.Size = new Size(145, 23);
            textBoxColor2.TabIndex = 5;
            // 
            // textBoxSing2
            // 
            textBoxSing2.Location = new Point(320, 252);
            textBoxSing2.Name = "textBoxSing2";
            textBoxSing2.Size = new Size(145, 23);
            textBoxSing2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 125);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "動物1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 125);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 8;
            label2.Text = "動物2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 143);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "名前";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 202);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 10;
            label4.Text = "色";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 255);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "鳴き声";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSing2);
            Controls.Add(textBoxColor2);
            Controls.Add(textBoxName2);
            Controls.Add(textBoxSing1);
            Controls.Add(texBoxtColor1);
            Controls.Add(textBoxName1);
            Controls.Add(ButtonAnimalInstanceCreate);
            Name = "Form1";
            Text = "Animal Class Instance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAnimalInstanceCreate;
        private TextBox textBoxName1;
        private TextBox texBoxtColor1;
        private TextBox textBoxSing1;
        private TextBox textBoxName2;
        private TextBox textBoxColor2;
        private TextBox textBoxSing2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ToolTip toolTip1;
    }
}
