namespace PolymorhismSample
{
    public partial class FormCookie : Form
    {
        public FormCookie()
        {
            InitializeComponent();
        }
        Animal animalCookie;//クラス全体で使えるAnimalクラスのインスタンス変数

        //動物クッキー.鳴く()の実装
        private void buttonSing_Click(object sender, EventArgs e)
        {
            animalCookie = new Dog();
            pictureBoxDog.Image = animalCookie.Sing();
            animalCookie = new Cat();
            pictureBoxCat.Image = animalCookie.Sing();
            animalCookie = new Bird();
            pictureBoxBird.Image = animalCookie.Sing();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            animalCookie = new Dog();
            pictureBoxDog.Image = animalCookie.Reset();
            animalCookie = new Cat();
            pictureBoxCat.Image = animalCookie.Reset();
            animalCookie = new Bird();
            pictureBoxBird.Image = animalCookie.Reset();
        }
    }
}
