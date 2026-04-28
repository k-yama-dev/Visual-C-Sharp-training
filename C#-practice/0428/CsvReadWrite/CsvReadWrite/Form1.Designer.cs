namespace CsvReadWrite
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
            textBoxInputCsvFileName = new TextBox();
            textBoxOutputCsvFileName = new TextBox();
            buttonCsvRead = new Button();
            buttonCsvWrite = new Button();
            openFileDialogCsv = new OpenFileDialog();
            dataGridViewCsv = new DataGridView();
            saveFileDialogCsv = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCsv).BeginInit();
            SuspendLayout();
            // 
            // textBoxInputCsvFileName
            // 
            textBoxInputCsvFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInputCsvFileName.Location = new Point(12, 13);
            textBoxInputCsvFileName.Name = "textBoxInputCsvFileName";
            textBoxInputCsvFileName.Size = new Size(654, 23);
            textBoxInputCsvFileName.TabIndex = 0;
            // 
            // textBoxOutputCsvFileName
            // 
            textBoxOutputCsvFileName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOutputCsvFileName.Location = new Point(12, 415);
            textBoxOutputCsvFileName.Name = "textBoxOutputCsvFileName";
            textBoxOutputCsvFileName.Size = new Size(654, 23);
            textBoxOutputCsvFileName.TabIndex = 1;
            // 
            // buttonCsvRead
            // 
            buttonCsvRead.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCsvRead.Location = new Point(672, 12);
            buttonCsvRead.Name = "buttonCsvRead";
            buttonCsvRead.Size = new Size(100, 23);
            buttonCsvRead.TabIndex = 2;
            buttonCsvRead.Text = "CSV取得";
            buttonCsvRead.UseVisualStyleBackColor = true;
            buttonCsvRead.Click += buttonCsvRead_Click;
            // 
            // buttonCsvWrite
            // 
            buttonCsvWrite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCsvWrite.Location = new Point(672, 414);
            buttonCsvWrite.Name = "buttonCsvWrite";
            buttonCsvWrite.Size = new Size(100, 23);
            buttonCsvWrite.TabIndex = 3;
            buttonCsvWrite.Text = "CSV出力";
            buttonCsvWrite.UseVisualStyleBackColor = true;
            buttonCsvWrite.Click += buttonCsvWrite_Click;
            // 
            // openFileDialogCsv
            // 
            openFileDialogCsv.FileName = "*.csv";
            openFileDialogCsv.InitialDirectory = ".\\";
            // 
            // dataGridViewCsv
            // 
            dataGridViewCsv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCsv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCsv.Location = new Point(12, 42);
            dataGridViewCsv.Name = "dataGridViewCsv";
            dataGridViewCsv.Size = new Size(760, 366);
            dataGridViewCsv.TabIndex = 4;
            // 
            // saveFileDialogCsv
            // 
            saveFileDialogCsv.Filter = "CSVファイル|*.csv|すべてのファイル|*.*";
            saveFileDialogCsv.InitialDirectory = ".\\";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewCsv);
            Controls.Add(buttonCsvWrite);
            Controls.Add(buttonCsvRead);
            Controls.Add(textBoxOutputCsvFileName);
            Controls.Add(textBoxInputCsvFileName);
            Name = "Form1";
            Text = "CSVの読み書き";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCsv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputCsvFileName;
        private TextBox textBoxOutputCsvFileName;
        private Button buttonCsvRead;
        private Button buttonCsvWrite;
        private OpenFileDialog openFileDialogCsv;
        private DataGridView dataGridViewCsv;
        private SaveFileDialog saveFileDialogCsv;
    }
}
