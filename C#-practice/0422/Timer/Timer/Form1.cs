namespace Timer
{
    public partial class FormTimer : Form
    {
        int endTime;//終了時間の変数を整数型で定義
        int nowTime;//経過時間の変数を整数型で定義
        public FormTimer()
        {
            InitializeComponent();
        }
        //timerコントロールのtickイベントのイベントハンドラー(タイマーの処理)
        private void timer1_Tick(object sender, EventArgs e)
        {
            int remainingTime;//残り時間の変数を整数型で定義
            nowTime++;//経過時間に1秒を加える
            //残り時間を計算して表示
            remainingTime = endTime - nowTime;
            textRemainingTime.Text = remainingTime.ToString();
            //<判定>設定時間になった？
            if(endTime == nowTime)
            {
                //「yes」の場合の処理
                //タイマーを止める
                timerControl.Stop();
                //終了時間になったことを知らせる
                MessageBox.Show("時間になりましたぁ");
            }
            else
            {
                //「no」の場合の処理
            }

           

        }

        private void FormTimer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //ボタンクリック時の処理
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //時間設定のtextboxの内容を終了時間の変数に取得
            if (!int.TryParse(textSetTime.Text, out endTime)) {
                endTime = 1;
            }
            //残り時間を計算するため経過時間の変数を0で初期化
            nowTime = 0;
            //タイマースタート
            timerControl.Start();
        }
    }
}
