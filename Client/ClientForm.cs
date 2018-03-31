using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        ClientRules clientRules;

        public ClientForm()
        {
            InitializeComponent();

            clientRules = new ClientRules();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            resultLbl.Hide();
            loggedLbl.Hide();
            logoutBtt.Hide();
        }

        private void registerBtt_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string password = passTxt.Text;

            resultLbl.Text = clientRules.Register(username, password);
            resultLbl.Show();
        }

        private void loginBtt_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string password = passTxt.Text;

            if(clientRules.Login(username, password))
            {
                resultLbl.Hide();
                userTxt.Hide();
                passTxt.Hide();
                registerBtt.Hide();
                loginBtt.Hide();
  
                logoutBtt.Show();
                loggedLbl.Text = loggedLbl.Text + username;
                loggedLbl.Show();
            }
            else
            {
                resultLbl.Text = "Login unsuccessful";
                resultLbl.Show();
            }
        }

        private void logoutBtt_Click(object sender, EventArgs e)
        {
            resultLbl.Hide();
            loggedLbl.Hide();
            logoutBtt.Hide();

            userTxt.Show();
            userTxt.Text = "Username";
            passTxt.Show();
            passTxt.Text = "Password";
            registerBtt.Hide();
            loginBtt.Hide();
        }
    }
}
