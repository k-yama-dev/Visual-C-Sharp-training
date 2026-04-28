using System.Diagnostics;

namespace Uranai
{
    public partial class FormUranai : Form
    {
        public FormUranai()
        {
            InitializeComponent();
        }

        private void buttonUranaiStart_Click(object sender, EventArgs e)
        {
            int dateNumber; //年間累積日を記憶する変数
            dateNumber = dateTimeUranai.Value.DayOfYear;    //選んだ日付から年間累積日を計算

            Debug.Print("dateNumber:" + dateNumber.ToString());

            switch (dateNumber % 5)  //年間累積日を5で割った余りは？
            {
                case 0: //大吉
                    pictureBoxResult.Image = Uranai.Properties.Resources.Daikichi;
                    textResult.Text = "いい流れが来てるから素直に乗ってみて";
                    break;
                case 1: //中吉
                    pictureBoxResult.Image = Uranai.Properties.Resources.Cyukichi;
                    textResult.Text = "無理しなければ良い方向に流れていきそう";
                    break;
                case 2: //小吉
                    pictureBoxResult.Image = Uranai.Properties.Resources.Syoukichi;
                    textResult.Text = "今日は小さな幸せを拾うつもりで過ごしてみて";
                    break;
                case 3: //吉
                    pictureBoxResult.Image = Uranai.Properties.Resources.Kichi;
                    textResult.Text = "小さな積み重ねが後で大きな力になる日だよ";
                    break;
                case 4: //凶
                    pictureBoxResult.Image = Uranai.Properties.Resources.Kyou;
                    textResult.Text = "少し休むくらいの気持ちで過ごすと流れが落ち着くよ";
                    break;
                default:
                    pictureBoxResult.Image = null;
                    textResult.Text = "";
                    break;
            }
        }

        private void dateTimeUranai_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
