namespace MyHouseKeeping
{
    partial class ItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monCalendar = new System.Windows.Forms.MonthCalendar();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.categoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataSet = new MyHouseKeeping.CategoryDataSet();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.mtxtMoney = new System.Windows.Forms.MaskedTextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // monCalendar
            // 
            this.monCalendar.Location = new System.Drawing.Point(26, 29);
            this.monCalendar.Name = "monCalendar";
            this.monCalendar.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataSource = this.categoryTableBindingSource;
            this.cmbCategory.DisplayMember = "分類";
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(302, 29);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 20);
            this.cmbCategory.TabIndex = 1;
            // 
            // categoryTableBindingSource
            // 
            this.categoryTableBindingSource.DataMember = "CategoryTable";
            this.categoryTableBindingSource.DataSource = this.categoryDataSet;
            // 
            // categoryDataSet
            // 
            this.categoryDataSet.DataSetName = "CategoryDataSet";
            this.categoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(302, 77);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(121, 19);
            this.txtItem.TabIndex = 2;
            // 
            // mtxtMoney
            // 
            this.mtxtMoney.Location = new System.Drawing.Point(302, 124);
            this.mtxtMoney.Mask = "999999";
            this.mtxtMoney.Name = "mtxtMoney";
            this.mtxtMoney.Size = new System.Drawing.Size(121, 19);
            this.mtxtMoney.TabIndex = 3;
            this.mtxtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(302, 171);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(121, 19);
            this.txtRemarks.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(85, 227);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 32);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "登録";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(233, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 32);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "分類";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "品名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "金額";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "備考";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 283);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.mtxtMoney);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.monCalendar);
            this.Name = "ItemForm";
            this.Text = "登録";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MonthCalendar monCalendar;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.TextBox txtItem;
        public System.Windows.Forms.MaskedTextBox mtxtMoney;
        public System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.BindingSource categoryTableBindingSource;
        private CategoryDataSet categoryDataSet;
    }
}