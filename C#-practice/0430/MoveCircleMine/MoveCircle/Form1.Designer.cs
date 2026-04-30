namespace MoveCircle
{
    partial class FormBallGame
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
            splitContainer1 = new SplitContainer();
            selectPictureBox = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            restartButton = new Button();
            textTimer = new TextBox();
            textHunt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mainPictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(selectPictureBox);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(restartButton);
            splitContainer1.Panel1.Controls.Add(textTimer);
            splitContainer1.Panel1.Controls.Add(textHunt);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(mainPictureBox);
            splitContainer1.Size = new Size(1084, 661);
            splitContainer1.SplitterDistance = 70;
            splitContainer1.TabIndex = 0;
            // 
            // selectPictureBox
            // 
            selectPictureBox.BackColor = Color.White;
            selectPictureBox.Location = new Point(430, 10);
            selectPictureBox.Name = "selectPictureBox";
            selectPictureBox.Size = new Size(275, 50);
            selectPictureBox.TabIndex = 11;
            selectPictureBox.TabStop = false;
            selectPictureBox.MouseClick += selectPictureBox_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 40);
            label5.Name = "label5";
            label5.Size = new Size(259, 15);
            label5.TabIndex = 10;
            label5.Text = "↓下のエリアをクリックするとボールの位置が変わります";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 16);
            label4.Name = "label4";
            label4.Size = new Size(257, 15);
            label4.TabIndex = 9;
            label4.Text = "下の背景に表示された漢字と同じ色の円をクリック→";
            // 
            // restartButton
            // 
            restartButton.Font = new Font("游ゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            restartButton.Location = new Point(735, 20);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(100, 35);
            restartButton.TabIndex = 8;
            restartButton.Text = "再スタート";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // textTimer
            // 
            textTimer.Font = new Font("游ゴシック", 16F);
            textTimer.Location = new Point(917, 16);
            textTimer.Name = "textTimer";
            textTimer.Size = new Size(130, 42);
            textTimer.TabIndex = 6;
            textTimer.TextAlign = HorizontalAlignment.Right;
            // 
            // textHunt
            // 
            textHunt.Font = new Font("游ゴシック", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textHunt.Location = new Point(16, 16);
            textHunt.Name = "textHunt";
            textHunt.Size = new Size(55, 41);
            textHunt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1053, 31);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 3;
            label3.Text = "秒";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(877, 31);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "記録:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 31);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "を探せ";
            // 
            // mainPictureBox
            // 
            mainPictureBox.BackColor = Color.White;
            mainPictureBox.Dock = DockStyle.Fill;
            mainPictureBox.Location = new Point(0, 0);
            mainPictureBox.Name = "mainPictureBox";
            mainPictureBox.Size = new Size(1084, 587);
            mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            mainPictureBox.TabIndex = 0;
            mainPictureBox.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // FormBallGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(splitContainer1);
            Name = "FormBallGame";
            Text = "間違いボール探し";
            Load += FormBallGame_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)selectPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button restartButton;
        private TextBox textTimer;
        private TextBox textHunt;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox selectPictureBox;
        private Label label5;
        private Label label4;
        private PictureBox mainPictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}
