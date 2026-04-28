namespace Uranai
{
    partial class FormUranai
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
            label1 = new Label();
            dateTimeUranai = new DateTimePicker();
            buttonUranaiStart = new Button();
            pictureBoxResult = new PictureBox();
            textResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "今日の占い";
            // 
            // dateTimeUranai
            // 
            dateTimeUranai.Location = new Point(106, 7);
            dateTimeUranai.Name = "dateTimeUranai";
            dateTimeUranai.Size = new Size(166, 23);
            dateTimeUranai.TabIndex = 1;
            dateTimeUranai.ValueChanged += dateTimeUranai_ValueChanged;
            // 
            // buttonUranaiStart
            // 
            buttonUranaiStart.Location = new Point(17, 43);
            buttonUranaiStart.Name = "buttonUranaiStart";
            buttonUranaiStart.Size = new Size(256, 30);
            buttonUranaiStart.TabIndex = 2;
            buttonUranaiStart.Text = "占い";
            buttonUranaiStart.UseVisualStyleBackColor = true;
            buttonUranaiStart.Click += buttonUranaiStart_Click;
            // 
            // pictureBoxResult
            // 
            pictureBoxResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxResult.Image = Properties.Resources.title;
            pictureBoxResult.Location = new Point(17, 83);
            pictureBoxResult.Name = "pictureBoxResult";
            pictureBoxResult.Size = new Size(256, 100);
            pictureBoxResult.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResult.TabIndex = 3;
            pictureBoxResult.TabStop = false;
            // 
            // textResult
            // 
            textResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textResult.Location = new Point(16, 200);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.Size = new Size(256, 70);
            textResult.TabIndex = 4;
            // 
            // FormUranai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 291);
            Controls.Add(textResult);
            Controls.Add(pictureBoxResult);
            Controls.Add(buttonUranaiStart);
            Controls.Add(dateTimeUranai);
            Controls.Add(label1);
            MinimumSize = new Size(300, 330);
            Name = "FormUranai";
            Text = "占い";
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimeUranai;
        private Button buttonUranaiStart;
        private PictureBox pictureBoxResult;
        private TextBox textResult;
    }
}
