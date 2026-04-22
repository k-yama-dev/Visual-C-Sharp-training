namespace Fusen
{
    partial class FormFusen
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
            textFusenMemo = new TextBox();
            colorDialogFusen = new ColorDialog();
            SuspendLayout();
            // 
            // textFusenMemo
            // 
            textFusenMemo.BackColor = Color.Orange;
            textFusenMemo.BorderStyle = BorderStyle.FixedSingle;
            textFusenMemo.Dock = DockStyle.Fill;
            textFusenMemo.Location = new Point(0, 0);
            textFusenMemo.Multiline = true;
            textFusenMemo.Name = "textFusenMemo";
            textFusenMemo.Size = new Size(613, 353);
            textFusenMemo.TabIndex = 0;
            textFusenMemo.KeyDown += textFusenMemo_KeyDown;
            textFusenMemo.MouseDoubleClick += textFusenMemo_MouseDoubleClick;
            textFusenMemo.MouseDown += textFusenMemo_MouseDown;
            textFusenMemo.MouseMove += textFusenMemo_MouseMove;
            // 
            // FormFusen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 353);
            Controls.Add(textFusenMemo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFusen";
            Opacity = 0.6D;
            Text = "Form1";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFusenMemo;
        private ColorDialog colorDialogFusen;
    }
}
