using WinFormsApp1.Players;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Attacker attacker;
        private readonly Witch witch;

        public Form1()
        {
            InitializeComponent();

            attacker = new Attacker();
            witch = new Witch();

            SetLabel2Text();
            SetPlayersHp();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                LevelStore.SetLevel("Easy");
                SetLabel2Text();
                SetPlayersHp();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                LevelStore.SetLevel("Normal");
                SetLabel2Text();
                SetPlayersHp();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                LevelStore.SetLevel("Hard");
                SetLabel2Text();
                SetPlayersHp();
            }
        }

        private void SetLabel2Text()
        {
            label2.Text = LevelStore.GetLevel();
        }

        private void SetPlayersHp()
        {
            label3.Text = attacker.GetHp().ToString();
            label4.Text = witch.GetHp().ToString();
        }
    }
}
