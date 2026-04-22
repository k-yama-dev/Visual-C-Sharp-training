namespace Timer
{
    partial class FormTimer
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
            buttonStart = new Button();
            textRemainingTime = new TextBox();
            textSetTime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timerControl = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Elephant", 27F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStart.Location = new Point(65, 88);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(210, 54);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "すたぁと";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textRemainingTime
            // 
            textRemainingTime.Location = new Point(119, 148);
            textRemainingTime.Name = "textRemainingTime";
            textRemainingTime.Size = new Size(100, 23);
            textRemainingTime.TabIndex = 1;
            textRemainingTime.Text = "10";
            textRemainingTime.TextAlign = HorizontalAlignment.Right;
            // 
            // textSetTime
            // 
            textSetTime.Location = new Point(119, 59);
            textSetTime.Name = "textSetTime";
            textSetTime.Size = new Size(100, 23);
            textSetTime.TabIndex = 2;
            textSetTime.Text = "10";
            textSetTime.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 62);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "時間設定";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 62);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 4;
            label2.Text = "秒";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 151);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "残り時間";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 151);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 6;
            label4.Text = "秒";
            // 
            // timerControl
            // 
            timerControl.Interval = 1000;
            timerControl.Tick += timer1_Tick;
            // 
            // FormTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 217);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSetTime);
            Controls.Add(textRemainingTime);
            Controls.Add(buttonStart);
            Name = "FormTimer";
            Text = "タイマー";
            Load += FormTimer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private TextBox textRemainingTime;
        private TextBox textSetTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timerControl;
    }
}
