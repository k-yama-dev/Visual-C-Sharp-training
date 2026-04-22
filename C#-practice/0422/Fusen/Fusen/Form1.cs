namespace Fusen
{
    public partial class FormFusen : Form
    {
        private int mouseX;//マウスの横位置(X座標)
        private int mouseY;//マウスの縦位置(Y座標)
        public FormFusen()
        {
            InitializeComponent();
        }
        //テキストボックスにキーボードから文字を入力したとき
        private void textFusenMemo_KeyDown(object sender, KeyEventArgs e)
        {
            //<判定>押されたキーがエスケープキー？
            if (e.KeyCode == Keys.Escape)
            {
                //Yesの場合
                //アプリケーションを終了
                this.Close();
            }
        }
        //テキストボックスをマウスでクリックしたとき
        private void textFusenMemo_MouseDown(object sender, MouseEventArgs e)
        {
            //<判定>押されたボタンがマウスの左ボタン？
            if (e.Button == MouseButtons.Left)
            {
                //Yesの場合
                this.mouseX = e.X;//マウスの横位置(X座標)を記憶
                this.mouseY = e.Y;//マウスの縦位置(Y座標)を記憶
            }
        }
        //テキストボックスでクリックしたマウスを移動させたとき
        private void textFusenMemo_MouseMove(object sender, MouseEventArgs e)
        {
            //<判定>押されたボタンがマウスの左ボタン？
            if (e.Button == MouseButtons.Left)
            {
                //Yesの場合
                this.Left += e.X - mouseX;//フォームの横位置(X座標)を更新
                this.Top += e.Y - mouseY;//フォームの縦位置(Y座標)を更新
            }
        }
        //テキストボックスをマウスでダブルクリックしたとき
        private void textFusenMemo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //色の設定ダイアログを表示する
            colorDialogFusen.ShowDialog();
            //テキストボックスの背景色を色の設定ダイアログで選んだ色に設定する
            textFusenMemo.BackColor = colorDialogFusen.Color;
        }
    }
}
