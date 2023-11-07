namespace Jokenpo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pedra_Click(object sender, EventArgs e)
        {
            StarGame(0);
        }

        private void Papel_Click(object sender, EventArgs e)
        {
            StarGame(2);
        }

        private void Tesoura_Click(object sender, EventArgs e)
        {
            StarGame(1);
        }
        private void StarGame(int opcao)
        {
            labelResultado.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    goto default;
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    goto default;
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Empatar.png");
                    goto default;
                default:
                    pictureBox1.Image = jogo.ImgJogador;
                    pictureBox2.Image = jogo.ImgPC;
                    break;
            }
        }
    }
}