namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            x, o
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int aiWinCount = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            Restart();
        }

        private void AIMove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.o;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Red;
                buttons.RemoveAt(index);
                CheckGame();
                AITimer.Stop();
            }
        }

        private void PlayerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.x;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Green;
            buttons.Remove(button);
            CheckGame();
            AITimer.Start();
        }

        private void Restart(object sender, EventArgs e)
        {
            Restart();
        }

        private void CheckGame()
        {
            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x"
                || button4.Text == "x" && button5.Text == "x" && button6.Text == "x"
                || button7.Text == "x" && button8.Text == "x" && button9.Text == "x"
                || button1.Text == "x" && button4.Text == "x" && button7.Text == "x"
                || button2.Text == "x" && button5.Text == "x" && button8.Text == "x"
                || button3.Text == "x" && button6.Text == "x" && button9.Text == "x"
                || button1.Text == "x" && button5.Text == "x" && button9.Text == "x"
                || button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            {
                AITimer.Stop();
                MessageBox.Show("Player wins");
                playerWinCount++;
                label1.Text = "Player wins: " + playerWinCount;
                Restart();
            }
            else if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o"
                || button4.Text == "o" && button5.Text == "o" && button6.Text == "o"
                || button7.Text == "o" && button8.Text == "o" && button9.Text == "o"
                || button1.Text == "o" && button4.Text == "o" && button7.Text == "o"
                || button2.Text == "o" && button5.Text == "o" && button8.Text == "o"
                || button3.Text == "o" && button6.Text == "o" && button9.Text == "o"
                || button1.Text == "o" && button5.Text == "o" && button9.Text == "o"
                || button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            {
                AITimer.Stop();
                MessageBox.Show("AI wins");
                aiWinCount++;
                label2.Text = "AI wins: " + aiWinCount;
                Restart();
            }
        }

        private void Restart()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor;
            }
        }
    }
}