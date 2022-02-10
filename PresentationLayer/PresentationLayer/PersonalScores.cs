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
    public partial class PersonalScores : Form
    {
        private GameMechanics gameMechanics;
        private BLayer bLayer;
        public PersonalScores()
        {
            this.gameMechanics = new GameMechanics();
            this.bLayer = new BLayer();
            InitializeComponent();
        }

        private void PersonalScores_Load(object sender, EventArgs e)
        {
           for(int i=0; i < bLayer.getPlayerPersonalScores().Count(); i++)
            {
                listBoxPersoanlScores.Items.Add(bLayer.getPlayerPersonalScores()[i].toString());
            }
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            label1TextMain.Text = "Welcome " + bLayer.getPlayer().InGameName + "! Here's list of your personal scores";
        }
    }
}
