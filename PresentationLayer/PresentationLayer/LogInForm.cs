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
    public partial class LogInForm : Form
    {
        private readonly BLayer bl;
        public bool login = false;
        public LogInForm()
        {
            InitializeComponent();
            bl = new BLayer();
        }

        private void txtLogIn(object sender, EventArgs e)
        {
            bunifuTextboxUsernameLogIn.text = "";
        }

        private void leaveLogIn(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuTextboxUsernameLogIn.text))
                bunifuTextboxUsernameLogIn.text = "Username";
        }

        private void passLogIn(object sender, EventArgs e)
        {
            bunifuTextboxPasswordLogIn.text = "";
            bunifuTextboxPasswordLogIn._TextBox.PasswordChar = '*';
            
        }

        private void leavepassLogIn(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuTextboxPasswordLogIn.text))
            {
                bunifuTextboxPasswordLogIn.text = "Password";
                bunifuTextboxPasswordLogIn._TextBox.PasswordChar = '*';

            }
                

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
        public static Game playGame = new Game() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };

        private void bunifuThinButtonLogIn_Click(object sender, EventArgs e)
        {
            string username = bunifuTextboxUsernameLogIn.text;
            string password = bunifuTextboxPasswordLogIn.text;

            if (bl.PlayerLogIn(username, password))
            {
                MessageBox.Show("You have successfully logged in, press Play in the menu on the left!");
                login = true;
                Game.username = username;
            }
            else
            {
                MessageBox.Show("Player not found, please register first!");
                
            }
        }

    }
}
