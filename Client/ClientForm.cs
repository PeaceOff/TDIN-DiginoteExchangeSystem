using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : MaterialForm
    {
        public static string LOGGED_TEXT = "Logged in as: ";
        public static string QUOTE_TEXT = "Current Quote: ";
        ClientRules clientRules;

        public ClientForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(250, 300);
            clientRules = new ClientRules(this);
        }

        // Callback functions

        public void UpdateQuote(double newQuote) {

            quoteTxtLbl.Text = QUOTE_TEXT + newQuote.ToString();

        }

        // Event Handlers

        private void ClientForm_Load(object sender, EventArgs e)
        {
            resultLbl.Hide();
            loggedLbl.Hide();
            logoutBtt.Hide();
            quoteTxtLbl.Hide();
            nicknameTxt.Hide();
            registerBtt.Hide();
        }

        private void registerBtt_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string password = passTxt.Text;
            string nickname = nicknameTxt.Text;

            if (username == "" || password == "" || nickname == "") {
                resultLbl.Text = "Input cannot be empty";
                resultLbl.Show();
                return;
            }

            resultLbl.Text = clientRules.Register(username, nickname, password);
            resultLbl.Show();
        }

        private void loginBtt_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string password = passTxt.Text;

            if (username == "" || password == "") {
                resultLbl.Text = "Username or Password is empty";
                resultLbl.Show();
                return;
            }

            string nickname = clientRules.Login(username, password);

            if (nickname != null)
            {
                this.Size = new System.Drawing.Size(700, 600);
                clientRules.SetUsername(username);
                clientRules.SetNickname(nickname);
                resultLbl.Hide();
                userTxt.Hide();
                passTxt.Hide();
                nicknameTxt.Hide();
                registerBtt.Hide();
                loginBtt.Hide();
                signInBtt.Hide();
                signUpBtt.Hide();
  
                logoutBtt.Show();
                loggedLbl.Text = LOGGED_TEXT + nickname;
                loggedLbl.Show();
                quoteTxtLbl.Show();

                // When the client logs in we get the current quote
                // Afterwards the quote will be updated in real time via events
                quoteTxtLbl.Text = QUOTE_TEXT + clientRules.GetCurrentQuote().ToString();
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

            this.Size = new System.Drawing.Size(250, 300);
            userTxt.Show();
            passTxt.Show();
            userTxt.Clear();
            passTxt.Clear();
            nicknameTxt.Clear();
            loginBtt.Show();
            signInBtt.Show();
            signUpBtt.Show();
        }

        private void signInBtt_Click(object sender, EventArgs e)
        {
            userTxt.Show();
            passTxt.Show();
            loginBtt.Show();
            registerBtt.Hide();
            nicknameTxt.Hide();
        }

        private void signUpBtt_Click(object sender, EventArgs e)
        {
            userTxt.Show();
            passTxt.Show();
            registerBtt.Show();
            nicknameTxt.Show();
            loginBtt.Hide();
        }
    }
}
