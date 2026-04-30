namespace MoveCircle
{
    public partial class FormBallGame : Form
    {
        //クラス共通の変数
        private Bitmap? canvas;
        private string correctText = "荻";   //正解の文字:1つだけ
        private string mistakeText = "萩";   //間違いの文字:ボールの個数分並ぶ
        //private Ball balls;//ボールを管理
        private Ball[] balls; //配列として複数のボールを管理
        private string[] kanjis;
        private Brush[] ballColor = new[]
            {
                Brushes.LightPink,
                Brushes.LightBlue,
                Brushes.LightGray,
                Brushes.LightCoral,
                Brushes.LightGreen
            };
        private string fontName;//表示する漢字のフォント名
        private double nowtime = 0.0;//経過時間
        private int ballCount = 5;
        private int randomResult = 0;
        public FormBallGame()
        {
            InitializeComponent();
        }

        private void FormBallGame_Load(object sender, EventArgs e)
        {
            DrawCircleSelectPictureBox();　//上のpictureBoxに円を描く
            DrawMainPictureBox(Brushes.Gray, correctText);  //下のpictureBoxに描画
            textHunt.Text = correctText;
            fontName = textHunt.Font.Name;
            //balls = new Ball(mainPictureBox, canvas, Brushes.LightBlue, correctText, fontName);
            balls = new Ball[ballCount];
            kanjis = new string[ballCount];
            for (int i = 0; i < ballCount; i++)
            {
                kanjis[i] = mistakeText;
            }
            randomResult = new Random().Next(ballCount);
            kanjis[randomResult] = correctText;
            for(int i = 0;i < ballCount; i++)
            {
                balls[i] = new Ball(mainPictureBox, canvas, ballColor[i], kanjis[i],fontName);
            }
            //balls.PutCircle(100,100);
            for(int i=0; i<ballCount;i++)
            {
                balls[i].PutCircle(new Random().Next(mainPictureBox.Width),
                    new Random().Next(mainPictureBox.Height));
            }
            nowtime = 0.0;
            timer1.Start();
         }

        private void selectPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                int selectCircle = e.X / selectPictureBox.Height;
                if(randomResult == selectCircle)
                {
                    timer1.Stop();
                    DrawMainPictureBox(Brushes.Red, "○");
                }
                else
                {
                    for (int i = 0; i < ballCount; i++)
                    {
                        balls[i].Pitch -= balls[i].Pitch/2;
                    }
                    nowtime = nowtime + 10;
                    DrawMainPictureBox(Brushes.Red, correctText);
                }
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            canvas = null;
            FormBallGame_Load(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //balls.Move();
            for (int i = 0; i < ballCount; i++)
            {
                balls[i].Move();
            }
            nowtime += 0.02;
            textTimer.Text = nowtime.ToString("0.00");
        }
        //上のpictureBoxに円を書いてみる
        private void DrawCircleSelectPictureBox()
        {
            var height = selectPictureBox.Height;
            var width = selectPictureBox.Width;

            var selectCanvas = new Bitmap(width, height);   //幅×高さのキャンバス作成
            using var g = Graphics.FromImage(selectCanvas);  //キャンバスに絵を描く準備
            //g.FillEllipse(Brushes.LightBlue, 0, 0, height, height);//円を描く
            for (int i = 0; i < ballCount; i++) 
            {
                g.FillEllipse(ballColor[i], i * height, 0, height, height);
            }
            selectPictureBox.Image = selectCanvas;          //キャンバスに描いた絵をImageに設定
        }
        //下のpictureBoxに描画する
        private void DrawMainPictureBox(Brush color, string text)
        {
            canvas ??= new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            using var g = Graphics.FromImage(canvas);   //キャンバスに絵を描く準備
            //背景に引数で指定した文字を表示する
            g.DrawString(text,
                new Font(textHunt.Font.FontFamily,      //フォント名はtextHuntに合わせる
                    mainPictureBox.Height*3/4),
                color,
                mainPictureBox.Width / 7,
                -mainPictureBox.Height / 9
                );
            mainPictureBox.Image = canvas;              //キャンバスに描いた絵をImageに設定
        }
    }
}
