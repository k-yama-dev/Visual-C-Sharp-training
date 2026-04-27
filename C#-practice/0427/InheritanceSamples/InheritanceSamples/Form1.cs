namespace InheritanceSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnimal_Click(object sender, EventArgs e)
        {
            Animal animalCookie = new Animal();

            animalCookie.Color = "茶";
            animalCookie.Flavor = "チョコレート";
            animalCookie.Smell = "紅茶";
            //対応するテキストボックスに表示する
            textBoxAnimalColor.Text = animalCookie.Color;
            textBoxAnimalFlavor.Text = animalCookie.Flavor;
            textBoxAnimalSmell.Text = animalCookie.Smell;
            textBoxAnimalSing.Text = animalCookie.Sing();
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Cat catCookie = new Cat();

            catCookie.Color = "黒";
            catCookie.Flavor = "ごま";
            catCookie.Smell = "ほうじ茶";
            catCookie.Ear = "桜";
            //対応するテキストボックスに表示する
            textBoxCatColor.Text = catCookie.Color;
            textBoxCatFlavor.Text = catCookie.Flavor;
            textBoxCatSmell.Text = catCookie.Smell;
            textBoxCatEar.Text = catCookie.Ear;
            textBoxCatSing.Text = catCookie.CatSing();
        }

    }
}
