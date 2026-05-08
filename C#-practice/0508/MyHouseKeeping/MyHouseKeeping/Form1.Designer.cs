namespace MyHouseKeeping
{
    partial class FormView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.追加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.変更CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一覧表示LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.集計表示SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyDataSet = new MyHouseKeeping.MoneyDataSet();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.categoryDataSet1 = new MyHouseKeeping.CategoryDataSet();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(716, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存SToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.追加AToolStripMenuItem,
            this.変更CToolStripMenuItem,
            this.削除DToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 追加AToolStripMenuItem
            // 
            this.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem";
            this.追加AToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.追加AToolStripMenuItem.Text = "追加(&A)";
            // 
            // 変更CToolStripMenuItem
            // 
            this.変更CToolStripMenuItem.Name = "変更CToolStripMenuItem";
            this.変更CToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.変更CToolStripMenuItem.Text = "変更(&C)";
            // 
            // 削除DToolStripMenuItem
            // 
            this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
            this.削除DToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.削除DToolStripMenuItem.Text = "削除(&D)";
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一覧表示LToolStripMenuItem,
            this.集計表示SToolStripMenuItem});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            this.表示VToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.表示VToolStripMenuItem.Text = "表示(&V)";
            // 
            // 一覧表示LToolStripMenuItem
            // 
            this.一覧表示LToolStripMenuItem.Name = "一覧表示LToolStripMenuItem";
            this.一覧表示LToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.一覧表示LToolStripMenuItem.Text = "一覧表示(&L)";
            // 
            // 集計表示SToolStripMenuItem
            // 
            this.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem";
            this.集計表示SToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.集計表示SToolStripMenuItem.Text = "集計表示(&S)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報VToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // バージョン情報VToolStripMenuItem
            // 
            this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
            this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)";
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.日付DataGridViewTextBoxColumn,
            this.分類DataGridViewTextBoxColumn,
            this.品名DataGridViewTextBoxColumn,
            this.金額DataGridViewTextBoxColumn,
            this.備考DataGridViewTextBoxColumn});
            this.dgv.DataSource = this.moneyTableBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 27);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 21;
            this.dgv.Size = new System.Drawing.Size(692, 270);
            this.dgv.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            // 
            // 分類DataGridViewTextBoxColumn
            // 
            this.分類DataGridViewTextBoxColumn.DataPropertyName = "分類";
            this.分類DataGridViewTextBoxColumn.HeaderText = "分類";
            this.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn";
            // 
            // 品名DataGridViewTextBoxColumn
            // 
            this.品名DataGridViewTextBoxColumn.DataPropertyName = "品名";
            this.品名DataGridViewTextBoxColumn.HeaderText = "品名";
            this.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn";
            // 
            // 金額DataGridViewTextBoxColumn
            // 
            this.金額DataGridViewTextBoxColumn.DataPropertyName = "金額";
            this.金額DataGridViewTextBoxColumn.HeaderText = "金額";
            this.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn";
            // 
            // 備考DataGridViewTextBoxColumn
            // 
            this.備考DataGridViewTextBoxColumn.DataPropertyName = "備考";
            this.備考DataGridViewTextBoxColumn.HeaderText = "備考";
            this.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn";
            // 
            // moneyTableBindingSource
            // 
            this.moneyTableBindingSource.DataMember = "MoneyTable";
            this.moneyTableBindingSource.DataSource = this.moneyDataSet;
            // 
            // moneyDataSet
            // 
            this.moneyDataSet.DataSetName = "MoneyDataSet";
            this.moneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 306);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 37);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(138, 306);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(119, 37);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "変更";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(263, 306);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 37);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(585, 306);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(119, 37);
            this.buttonEnd.TabIndex = 2;
            this.buttonEnd.Text = "終了";
            this.buttonEnd.UseVisualStyleBackColor = true;
            // 
            // categoryDataSet1
            // 
            this.categoryDataSet1.DataSetName = "CategoryDataSet";
            this.categoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 350);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FormView";
            this.Text = "簡易家計簿";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 追加AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 変更CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一覧表示LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 集計表示SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分類DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource moneyTableBindingSource;
        private MoneyDataSet moneyDataSet;
        private CategoryDataSet categoryDataSet1;
    }
}

