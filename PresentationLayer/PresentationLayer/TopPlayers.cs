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
    public partial class TopPlayers : Form
    {
        private GameMechanics gameMechanics;
        private BLayer bLayer;
        public TopPlayers()
        {
            this.gameMechanics = new GameMechanics();
            this.bLayer = new BLayer();
            InitializeComponent();
        }

        private void TopPlayers_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < bLayer.GetTopPlayers().Count(); i++)
            {
                listBoxTopPlayers.Items.Add(bLayer.GetTopPlayers()[i].toString());
            }
        }
    }
}
