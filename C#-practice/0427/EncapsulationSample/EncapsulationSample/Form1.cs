namespace EncapsulationSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //クラス内部の変数。外から操作できないようにしている！
        private string _colorName;

        //プロパティのサンプルコード
        public string ColorName
        {
            get//値を取得するメソッドに該当。getは固定、引数や()は書かない。
            {
                return _colorName;//内部の変数の値を取得
            }
            set//値を設定するメソッドに該当、setは固定、引数や()は書かない。
            {
                //setは引数を書かない代わりにvalueに値が入っています
                //値のチェックをして内部の変数に適切な値を設定
                if (value == "")
                {
                    //値が入力されていない場合、内部の変数にblackを設定
                    _colorName = "black";
                }
                else
                {
                    //上記以外は入力した値をそのまま入力
                    _colorName = value;
                }
            }
        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            //テキストボックスに入力された値をプロパティに設定
            ColorName = textBoxColorValue.Text;
            //プロパティから値を取得して、色に変換。定義されていない色はblackになる。
            labelColorResult.ForeColor = Color.FromName(ColorName);
        }
    }
}
