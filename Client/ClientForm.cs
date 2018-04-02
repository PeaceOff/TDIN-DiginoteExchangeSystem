using System;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        ClientRules clientRules;

        public ClientForm()
        {
            InitializeComponent();

            clientRules = new ClientRules(this);
        }

        // Callback functions

        public void UpdateQuote(double newQuote) {

            quoteLbl.Text = newQuote.ToString();

        }


        // Event Handlers

        private void ClientForm_Load(object sender, EventArgs e)
        {
            resultLbl.Hide();
            loggedLbl.Hide();
            logoutBtt.Hide();
            textLbl.Hide();
            quoteLbl.Hide();
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
                clientRules.SetUsername(username);
                resultLbl.Hide();
                userTxt.Hide();
                passTxt.Hide();
                registerBtt.Hide();
                loginBtt.Hide();
  
                logoutBtt.Show();
                loggedLbl.Text = loggedLbl.Text + username;
                loggedLbl.Show();
                quoteLbl.Show();
                textLbl.Show();

                // When the client logs in we get the current quote
                // Afterwards the quote will be updated in real time via events
                quoteLbl.Text = clientRules.GetCurrentQuote().ToString();
            }
            else
            {
                resultLbl.Text = "Login unsuccessful";
                resultLbl.Show();
            }
        }

        private void logoutBtt_Click(object sender, EventArgs e)
        {
            ClientForm_Load(sender, e);

            userTxt.Show();
            userTxt.Text = "Username";
            passTxt.Show();
            passTxt.Text = "Password";
            registerBtt.Show();
            loginBtt.Show();
        }
    }
}
