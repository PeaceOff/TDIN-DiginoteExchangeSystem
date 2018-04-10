using MaterialSkin.Controls;
using Shared;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    public partial class ClientForm : MaterialForm
    {
        public static string LOGGED_TEXT = "Logged in as: ";
        public static string QUOTE_TEXT = "Current Quote: ";
        public static string DIGINOTES_TEXT = "Diginotes: ";
        ClientRules clientRules;

        public ClientForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(250, 300);
            clientRules = new ClientRules(this);
        }

        
        #region Callback Functions

        public void UpdateQuote(double newQuote) {

            quoteTxtLbl.Text = QUOTE_TEXT + newQuote.ToString();

        }

        public void UpdateDiginotes(string amount) {

            diginotesLbl.Text = DIGINOTES_TEXT + amount;

        }

        public void UpdateSellOrders(List<SellOrder> orders) {

            mSellOrderTextArea.Clear();
            foreach (var order in orders)
            {
                mSellOrderTextArea.AppendText(order.quantity.ToString() + " diginote(s)\n");
            }
        }

        public void UpdateMyTransactions(List<Transaction> transactions) {

            mTradesTextArea.Clear();
            foreach (var trans in transactions)
            {
                AddOneMyTransactions(trans);
            }
        }

        public void AddOneMyTransactions(Transaction t) {

            mTradesTextArea.AppendText(t.oldOwner + " sold " + t.quantity + " diginote(s) to " + t.newOwner + "\n");

        }

        public void UpdateGlobalTransactions(List<Transaction> transactions) {

            mTransactionTextArea.Clear();
            foreach (var trans in transactions) {
                AddOneGlobalTransactions(trans);
            }
        }

        public void AddOneGlobalTransactions(Transaction t) {

            mTransactionTextArea.AppendText(t.oldOwner + " sold " + t.quantity + " diginote(s) to " + t.newOwner + "\n");

        }

        public void UpdatePurchaseOrders(List<PurchaseOrder> orders)
        {
            mPurchaseOrderTextArea.Clear();
            foreach (var order in orders)
            {
                mPurchaseOrderTextArea.AppendText(order.quantity.ToString() + " diginote(s)\n");
            }
        }

        public void UpdateStatus(string s, bool isPositive)
        {
            if (isPositive)
            {
                statusLbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                statusLbl.ForeColor = System.Drawing.Color.Red;
            }

            statusLbl.Text = s;
            statusLbl.Show();
        }

        private void HideStatus() {
            statusLbl.Hide();
        }

        #endregion

        #region Event Handlers

        private void LoginShows() {

            sellDiginoteBtt.Show();
            buyAmountBtt.Show();
            diginoteAmountUD.Show();
            pendingPurchaseTxt.Show();
            pendingSellTxt.Show();
            mPurchaseOrderTextArea.Show();
            mSellOrderTextArea.Show();
            mTradesTextArea.Show();
            mTransactionsTxt.Show();
            diginotesLbl.Show();
            transactionsTxt.Show();
            mTransactionTextArea.Show();
            logoutBtt.Show();
            cancelPurchaseBtt.Show();
            cancelSellOrderBtt.Show();
            increasePurchaseOrderPriceBtt.Show();
            decreaseSellOrderPriceBtt.Show();

        }

        private void LogoutHide() {

            statusLbl.Hide();
            resultLbl.Hide();
            loggedLbl.Hide();
            logoutBtt.Hide();
            quoteTxtLbl.Hide();
            nicknameTxt.Hide();
            registerBtt.Hide();
            sellDiginoteBtt.Hide();
            buyAmountBtt.Hide();
            diginoteAmountUD.Hide();
            pendingPurchaseTxt.Hide();
            pendingSellTxt.Hide();
            mPurchaseOrderTextArea.Hide();
            mSellOrderTextArea.Hide();
            mTradesTextArea.Hide();
            mTransactionsTxt.Hide();
            diginotesLbl.Hide();
            transactionsTxt.Hide();
            mTransactionTextArea.Hide();
            cancelPurchaseBtt.Hide();
            cancelSellOrderBtt.Hide();
            increasePurchaseOrderPriceBtt.Hide();
            decreaseSellOrderPriceBtt.Hide();

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LogoutHide();
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

            username = clientRules.Login(username, password);

            if (username != null)
            {
                this.Size = new System.Drawing.Size(700, 600);
                clientRules.SetUsername(username);
                resultLbl.Hide();
                userTxt.Hide();
                passTxt.Hide();
                nicknameTxt.Hide();
                registerBtt.Hide();
                loginBtt.Hide();
                signInBtt.Hide();
                signUpBtt.Hide();

                LoginShows();

                loggedLbl.Text = LOGGED_TEXT + username;
                loggedLbl.Show();
                quoteTxtLbl.Show();

                // When the client logs in we get the current quote
                // Afterwards the quote will be updated in real time via events
                UpdateQuote(clientRules.GetCurrentQuote());
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

            clientRules.Logout();
            this.Size = new System.Drawing.Size(250, 300);
            userTxt.Show();
            passTxt.Show();
            userTxt.Clear();
            passTxt.Clear();
            nicknameTxt.Clear();
            loginBtt.Show();
            signInBtt.Show();
            signUpBtt.Show();

            mPurchaseOrderTextArea.Clear();
            mSellOrderTextArea.Clear();
            mTradesTextArea.Clear();
            mTransactionTextArea.Clear();
            diginoteAmountUD.Value = 1;

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

        private void sellDiginoteBtt_Click(object sender, EventArgs e)
        {

            int amount = (int)diginoteAmountUD.Value;

            clientRules.CreateSellingOrder(amount);

            diginoteAmountUD.Value = 1;
        }

        private void cancelSellOrderBtt_Click(object sender, EventArgs e)
        {
            clientRules.CancelSellOrder();
        }

        private void cancelPurchaseBtt_Click(object sender, EventArgs e)
        {
            clientRules.CancelPurchaseOrder();
        }

        private void buyAmountBtt_Click(object sender, EventArgs e)
        {
            int amount = (int)diginoteAmountUD.Value;
            clientRules.CreatePurchaseOrder(amount);
            diginoteAmountUD.Value = 1;
        }

        #endregion

        private void decreaseSellOrderPriceBtt_Click(object sender, EventArgs e)
        {
            clientRules.DecreaseSellOrderPrice();
        }

        private void increasePurchaseOrderPriceBtt_Click(object sender, EventArgs e)
        {
            clientRules.IncreasePurchaseOrderPrice();
        }

        private void passTxt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                loginBtt.PerformClick();
            }
        }
    }
}
