using BusinessLayer;
using DataAccessLayer.Models;
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
    public partial class RegistrationForm : Form
    {
        private readonly BLayer bl;
        public RegistrationForm()
        {
            InitializeComponent();
            bl = new BLayer();
        }

        private void txtUsername(object sender, EventArgs e)
        {
            bunifuTextboxUsername.text = "";
        }
        private void leaveUsername(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuTextboxUsername.text))
                bunifuTextboxUsername.text = "Username";
        }
        private void txtPassword(object sender, EventArgs e)
        {
            bunifuTextboxPassword.text = "";
            bunifuTextboxPassword._TextBox.PasswordChar = '*';
        }
        private void leavePassword(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuTextboxPassword.text))
            {
                bunifuTextboxPassword.text = "Password";
                bunifuTextboxPassword._TextBox.PasswordChar = '*';
            }
                
        }
        private void txtIGN(object sender, EventArgs e)
        {
            bunifuTextboxIGN.text = "";
        }
        private void leaveIGN(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(bunifuTextboxIGN.text))
                bunifuTextboxIGN.text = "IGN (In Game Name)";
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButtonSignUp_Click(object sender, EventArgs e)
        {
            Player pl = new Player();
            pl.Username = bunifuTextboxUsername.text;
            pl.Password = bunifuTextboxPassword.text;
            pl.InGameName = bunifuTextboxIGN.text;

            if (bunifuTextboxIGN.text.Length >= 6)
            {
                MessageBox.Show("In Game Name must be 6 or less characters long!");
                return;
            }
                

            if(bl.GetPlayerList().Where(s => s.Username == pl.Username || s.InGameName == pl.InGameName).ToList().Count > 0)
            {
                MessageBox.Show("This user already exists in database!");
                return;
            }

            if (bl.InsertNewPlayer(pl))
                MessageBox.Show("Player is inserted in DB"); 
            else
                MessageBox.Show("Error something went wrong");
        }
    }
}
