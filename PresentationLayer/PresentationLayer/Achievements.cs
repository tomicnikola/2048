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
    public partial class Achievements : Form
    {
        private GameMechanics gameMechanics;
        private BLayer bLayer;
        public Achievements()
        {
            this.gameMechanics = new GameMechanics();
            this.bLayer = new BLayer();
            InitializeComponent();
        }

        private void Achievements_Load(object sender, EventArgs e)
        {
            if(bLayer.getAchievement().CompletedGame == 1)
            {
                labelAU1.Visible = true;
                labelAL1.Visible = false;
                labelDesc1.Text = "Congratulation " + bLayer.getPlayer().InGameName + "!\nYou've unlocked this achievement.\nAchievement: Completed game.";
            }
            else
            {
                labelAU1.Visible = false;
                labelAL1.Visible = true;
                labelDesc1.Text = "You haven't unlocked this achievement yet.\nKeep trying!";
            }

            if (bLayer.getAchievement().BetterThanAverageMoves == 1)
            {
                labelAU2.Visible = true;
                labelAL2.Visible = false;
                labelDesc2.Text = "Congratulation " + bLayer.getPlayer().InGameName + "!\nYou've unlocked this achievement.\nAchievement: Better Than Average Moves.";
            }
            else
            {
                labelAU2.Visible = false;
                labelAL2.Visible = true;
                labelDesc2.Text = "You haven't unlocked this achievement yet.\nKeep trying!";
            }

            if (bLayer.getAchievement().BetterThanAverageTime == 1)
            {
                labelAU3.Visible = true;
                labelAL3.Visible = false;
                labelDesc3.Text = "Congratulation " + bLayer.getPlayer().InGameName + "!\nYou've unlocked this achievement\nAchievement: Better Than Average Time.";
            }
            else
            {
                labelAU3.Visible = false;
                labelAL3.Visible = true;
                labelDesc3.Text = "You haven't unlocked this achievement yet.\nKeep trying!";
            }

        }
    }
}
