using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Game : Form
    {
        public static string username = "John Doe";
        private int timerInterval = 1;
        private GameMechanics gameMechanics;
        public Game()
        {
            this.gameMechanics = new GameMechanics();
            InitializeComponent();
            gameMechanics.randomGenerator();
            Test();
        }

        private void Test()
        {
            if (gameMechanics.GameBoard[0, 0] != 0)
                button5.Text = "" + gameMechanics.GameBoard[0, 0];
            else
                button5.Text = "";
            if (gameMechanics.GameBoard[0, 1] != 0)
                button6.Text = "" + gameMechanics.GameBoard[0, 1];
            else
                button6.Text = "";
            if (gameMechanics.GameBoard[0, 2] != 0)
                button7.Text = "" + gameMechanics.GameBoard[0, 2];
            else
                button7.Text = "";
            if (gameMechanics.GameBoard[0, 3] != 0)
                button8.Text = "" + gameMechanics.GameBoard[0, 3];
            else
                button8.Text = "";
            if (gameMechanics.GameBoard[1, 0] != 0)
                button9.Text = "" + gameMechanics.GameBoard[1, 0];
            else
                button9.Text = "";
            if (gameMechanics.GameBoard[1, 1] != 0)
                button10.Text = "" + gameMechanics.GameBoard[1, 1];
            else
                button10.Text = "";
            if (gameMechanics.GameBoard[1, 2] != 0)
                button11.Text = "" + gameMechanics.GameBoard[1, 2];
            else
                button11.Text = "";
            if (gameMechanics.GameBoard[1, 3] != 0)
                button12.Text = "" + gameMechanics.GameBoard[1, 3];
            else
                button12.Text = "";
            if (gameMechanics.GameBoard[2, 0] != 0)
                button13.Text = "" + gameMechanics.GameBoard[2, 0];
            else
                button13.Text = "";
            if (gameMechanics.GameBoard[2, 1] != 0)
                button14.Text = "" + gameMechanics.GameBoard[2, 1];
            else
                button14.Text = "";
            if (gameMechanics.GameBoard[2, 2] != 0)
                button15.Text = "" + gameMechanics.GameBoard[2, 2];
            else
                button15.Text = "";
            if (gameMechanics.GameBoard[2, 3] != 0)
                button16.Text = "" + gameMechanics.GameBoard[2, 3];
            else
                button16.Text = "";
            if (gameMechanics.GameBoard[3, 0] != 0)
                button17.Text = "" + gameMechanics.GameBoard[3, 0];
            else
                button17.Text = "";
            if (gameMechanics.GameBoard[3, 1] != 0)
                button18.Text = "" + gameMechanics.GameBoard[3, 1];
            else
                button18.Text = "";
            if (gameMechanics.GameBoard[3, 2] != 0)
                button19.Text = "" + gameMechanics.GameBoard[3, 2];
            else
                button19.Text = "";
            if (gameMechanics.GameBoard[3, 3] != 0)
                button20.Text = "" + gameMechanics.GameBoard[3, 3];
            else
                button20.Text = "";

        }
        private void ResetColors()
        {
            bunifuThinButtonLeftA.ForeColor = Color.Black;
            bunifuThinButtonUpW.ForeColor = Color.Black;
            bunifuThinButtonRightD.ForeColor = Color.Black;
            bunifuThinButtonDownS.ForeColor = Color.Black;
        }
        public void isGameOver()
        {
            if (gameMechanics.isGameOver == true)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Game Over! Try again?", "Game Over", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                if (result == DialogResult.Yes)
                {
                    gameMechanics.restartGame();
                    Test();
                    timerInterval = 0;
                    label2Score.Text = "" + gameMechanics.Score;
                    label3Moves.Text = "" + gameMechanics.moveCounter;
                    labeltimer.Text = "" + timerInterval + "s";

                }

            }
            else if(gameMechanics.isGameComplete == true)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Game Complete! Try again?", "Game Complete", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                if (result == DialogResult.Yes)
                {
                    gameMechanics.restartGame();
                    Test();
                    timerInterval = 0;
                    label2Score.Text = "" + gameMechanics.Score;
                    label3Moves.Text = "" + gameMechanics.moveCounter;
                    labeltimer.Text = "" + timerInterval + "s";
                }
            }
                
                
                
                
        }
      
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                gameMechanics.timePlayed = labeltimer.Text;
                gameMechanics.moveLeft();
                label2Score.Text = "" + gameMechanics.Score;
                label3Moves.Text = "" + gameMechanics.moveCounter;
                Test();              
                ResetColors();
                bunifuThinButtonLeftA.ForeColor = Color.White;
                if(!timer1.Enabled)
                {
                    timer1.Start();
                }
                isGameOver();
                



            }
            else  if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                gameMechanics.timePlayed = labeltimer.Text;
                gameMechanics.moveRight();
                label2Score.Text = "" + gameMechanics.Score;
                label3Moves.Text = "" + gameMechanics.moveCounter;
                Test();
                ResetColors();
                bunifuThinButtonRightD.ForeColor = Color.White;
                if (!timer1.Enabled)
                {
                    timer1.Start();
                }
                isGameOver();
                
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                gameMechanics.timePlayed = labeltimer.Text;
                gameMechanics.moveUp();
                label2Score.Text = "" + gameMechanics.Score;
                label3Moves.Text = "" + gameMechanics.moveCounter;
                Test();
                ResetColors();
                bunifuThinButtonUpW.ForeColor = Color.White;
                if (!timer1.Enabled)
                {
                    timer1.Start();
                }
                isGameOver();
                


            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                gameMechanics.timePlayed = labeltimer.Text;
                gameMechanics.moveDown();
                label2Score.Text = "" + gameMechanics.Score;
                label3Moves.Text = "" + gameMechanics.moveCounter;
                Test();
                ResetColors();
                bunifuThinButtonDownS.ForeColor = Color.White;
                if (!timer1.Enabled)
                {
                    timer1.Start();
                }
                isGameOver();
                
            }
        }

        private void labelUser_VisibleChanged(object sender, EventArgs e)
        {
            labelUser.Text = "Welcome  " + username + ", have fun!";
        }

        private void timer(object sender, EventArgs e)
        {
            labeltimer.Text = timerInterval++ + "s";
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
