namespace Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loggedLbl = new MaterialSkin.Controls.MaterialLabel();
            this.logoutBtt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.resultLbl = new MaterialSkin.Controls.MaterialLabel();
            this.quoteTxtLbl = new MaterialSkin.Controls.MaterialLabel();
            this.registerBtt = new MaterialSkin.Controls.MaterialFlatButton();
            this.loginBtt = new MaterialSkin.Controls.MaterialFlatButton();
            this.userTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nicknameTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.signInBtt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.signUpBtt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.diginotesLbl = new MaterialSkin.Controls.MaterialLabel();
            this.mTransactionTextArea = new System.Windows.Forms.TextBox();
            this.transactionsTxt = new MaterialSkin.Controls.MaterialLabel();
            this.buyAmountBtt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sellDiginoteBtt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.diginoteAmountUD = new System.Windows.Forms.NumericUpDown();
            this.pendingPurchaseTxt = new MaterialSkin.Controls.MaterialLabel();
            this.mPurchaseOrderTextArea = new System.Windows.Forms.TextBox();
            this.pendingSellTxt = new MaterialSkin.Controls.MaterialLabel();
            this.mSellOrderTextArea = new System.Windows.Forms.TextBox();
            this.mTransactionsTxt = new MaterialSkin.Controls.MaterialLabel();
            this.mTradesTextArea = new System.Windows.Forms.TextBox();
            this.statusLbl = new MaterialSkin.Controls.MaterialLabel();
            this.cancelSellOrderBtt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancelPurchaseBtt = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.diginoteAmountUD)).BeginInit();
            this.SuspendLayout();
            // 
            // loggedLbl
            // 
            this.loggedLbl.AutoSize = true;
            this.loggedLbl.BackColor = System.Drawing.SystemColors.Window;
            this.loggedLbl.Depth = 0;
            this.loggedLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.loggedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loggedLbl.Location = new System.Drawing.Point(114, 565);
            this.loggedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loggedLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.loggedLbl.Name = "loggedLbl";
            this.loggedLbl.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.loggedLbl.Size = new System.Drawing.Size(102, 23);
            this.loggedLbl.TabIndex = 15;
            this.loggedLbl.Text = "Logged in as: ";
            // 
            // logoutBtt
            // 
            this.logoutBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtt.Depth = 0;
            this.logoutBtt.Font = new System.Drawing.Font("Verdana", 11F);
            this.logoutBtt.Location = new System.Drawing.Point(18, 566);
            this.logoutBtt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoutBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.logoutBtt.Name = "logoutBtt";
            this.logoutBtt.Primary = true;
            this.logoutBtt.Size = new System.Drawing.Size(88, 22);
            this.logoutBtt.TabIndex = 16;
            this.logoutBtt.Text = "Logout";
            this.logoutBtt.UseVisualStyleBackColor = true;
            this.logoutBtt.Click += new System.EventHandler(this.logoutBtt_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.BackColor = System.Drawing.SystemColors.Window;
            this.resultLbl.Depth = 0;
            this.resultLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.resultLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultLbl.Location = new System.Drawing.Point(15, 247);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.resultLbl.Size = new System.Drawing.Size(51, 23);
            this.resultLbl.TabIndex = 17;
            this.resultLbl.Text = "Result";
            // 
            // quoteTxtLbl
            // 
            this.quoteTxtLbl.AutoSize = true;
            this.quoteTxtLbl.BackColor = System.Drawing.SystemColors.Window;
            this.quoteTxtLbl.Depth = 0;
            this.quoteTxtLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.quoteTxtLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quoteTxtLbl.Location = new System.Drawing.Point(392, 108);
            this.quoteTxtLbl.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.quoteTxtLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.quoteTxtLbl.Name = "quoteTxtLbl";
            this.quoteTxtLbl.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.quoteTxtLbl.Size = new System.Drawing.Size(106, 23);
            this.quoteTxtLbl.TabIndex = 18;
            this.quoteTxtLbl.Text = "Current Quote:";
            // 
            // registerBtt
            // 
            this.registerBtt.AutoSize = true;
            this.registerBtt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtt.Depth = 0;
            this.registerBtt.Location = new System.Drawing.Point(153, 180);
            this.registerBtt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerBtt.Name = "registerBtt";
            this.registerBtt.Primary = false;
            this.registerBtt.Size = new System.Drawing.Size(74, 36);
            this.registerBtt.TabIndex = 19;
            this.registerBtt.Text = "Register";
            this.registerBtt.UseVisualStyleBackColor = true;
            this.registerBtt.Click += new System.EventHandler(this.registerBtt_Click);
            // 
            // loginBtt
            // 
            this.loginBtt.AutoSize = true;
            this.loginBtt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtt.Depth = 0;
            this.loginBtt.Location = new System.Drawing.Point(154, 180);
            this.loginBtt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtt.Name = "loginBtt";
            this.loginBtt.Primary = false;
            this.loginBtt.Size = new System.Drawing.Size(52, 36);
            this.loginBtt.TabIndex = 20;
            this.loginBtt.Text = "Login";
            this.loginBtt.UseVisualStyleBackColor = true;
            this.loginBtt.Click += new System.EventHandler(this.loginBtt_Click);
            // 
            // userTxt
            // 
            this.userTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTxt.Depth = 0;
            this.userTxt.Hint = "Username";
            this.userTxt.Location = new System.Drawing.Point(18, 164);
            this.userTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.userTxt.Name = "userTxt";
            this.userTxt.PasswordChar = '\0';
            this.userTxt.SelectedText = "";
            this.userTxt.SelectionLength = 0;
            this.userTxt.SelectionStart = 0;
            this.userTxt.Size = new System.Drawing.Size(127, 23);
            this.userTxt.TabIndex = 1;
            this.userTxt.UseSystemPasswordChar = false;
            // 
            // passTxt
            // 
            this.passTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxt.Depth = 0;
            this.passTxt.Hint = "Password";
            this.passTxt.Location = new System.Drawing.Point(18, 193);
            this.passTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.SelectedText = "";
            this.passTxt.SelectionLength = 0;
            this.passTxt.SelectionStart = 0;
            this.passTxt.Size = new System.Drawing.Size(127, 23);
            this.passTxt.TabIndex = 2;
            this.passTxt.UseSystemPasswordChar = true;
            // 
            // nicknameTxt
            // 
            this.nicknameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nicknameTxt.Depth = 0;
            this.nicknameTxt.Hint = "Nickname";
            this.nicknameTxt.Location = new System.Drawing.Point(18, 135);
            this.nicknameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nicknameTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.nicknameTxt.Name = "nicknameTxt";
            this.nicknameTxt.PasswordChar = '\0';
            this.nicknameTxt.SelectedText = "";
            this.nicknameTxt.SelectionLength = 0;
            this.nicknameTxt.SelectionStart = 0;
            this.nicknameTxt.Size = new System.Drawing.Size(127, 23);
            this.nicknameTxt.TabIndex = 0;
            this.nicknameTxt.UseSystemPasswordChar = false;
            // 
            // signInBtt
            // 
            this.signInBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInBtt.Depth = 0;
            this.signInBtt.Location = new System.Drawing.Point(0, 66);
            this.signInBtt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signInBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.signInBtt.Name = "signInBtt";
            this.signInBtt.Primary = true;
            this.signInBtt.Size = new System.Drawing.Size(125, 30);
            this.signInBtt.TabIndex = 24;
            this.signInBtt.Text = "Sign In";
            this.signInBtt.UseVisualStyleBackColor = true;
            this.signInBtt.Click += new System.EventHandler(this.signInBtt_Click);
            // 
            // signUpBtt
            // 
            this.signUpBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtt.Depth = 0;
            this.signUpBtt.Location = new System.Drawing.Point(125, 66);
            this.signUpBtt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signUpBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpBtt.Name = "signUpBtt";
            this.signUpBtt.Primary = true;
            this.signUpBtt.Size = new System.Drawing.Size(125, 30);
            this.signUpBtt.TabIndex = 25;
            this.signUpBtt.Text = "Sign Up";
            this.signUpBtt.UseVisualStyleBackColor = true;
            this.signUpBtt.Click += new System.EventHandler(this.signUpBtt_Click);
            // 
            // diginotesLbl
            // 
            this.diginotesLbl.AutoSize = true;
            this.diginotesLbl.BackColor = System.Drawing.SystemColors.Window;
            this.diginotesLbl.Depth = 0;
            this.diginotesLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.diginotesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diginotesLbl.Location = new System.Drawing.Point(392, 75);
            this.diginotesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diginotesLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.diginotesLbl.Name = "diginotesLbl";
            this.diginotesLbl.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.diginotesLbl.Size = new System.Drawing.Size(81, 23);
            this.diginotesLbl.TabIndex = 26;
            this.diginotesLbl.Text = "Diginotes: ";
            // 
            // mTransactionTextArea
            // 
            this.mTransactionTextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTransactionTextArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.mTransactionTextArea.Enabled = false;
            this.mTransactionTextArea.Location = new System.Drawing.Point(396, 371);
            this.mTransactionTextArea.Multiline = true;
            this.mTransactionTextArea.Name = "mTransactionTextArea";
            this.mTransactionTextArea.ReadOnly = true;
            this.mTransactionTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mTransactionTextArea.Size = new System.Drawing.Size(294, 217);
            this.mTransactionTextArea.TabIndex = 27;
            // 
            // transactionsTxt
            // 
            this.transactionsTxt.AutoSize = true;
            this.transactionsTxt.BackColor = System.Drawing.SystemColors.Window;
            this.transactionsTxt.Depth = 0;
            this.transactionsTxt.Font = new System.Drawing.Font("Roboto", 11F);
            this.transactionsTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transactionsTxt.Location = new System.Drawing.Point(392, 349);
            this.transactionsTxt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.transactionsTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionsTxt.Name = "transactionsTxt";
            this.transactionsTxt.Size = new System.Drawing.Size(143, 19);
            this.transactionsTxt.TabIndex = 28;
            this.transactionsTxt.Text = "Recent transactions";
            // 
            // buyAmountBtt
            // 
            this.buyAmountBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyAmountBtt.Depth = 0;
            this.buyAmountBtt.Font = new System.Drawing.Font("Verdana", 11F);
            this.buyAmountBtt.Location = new System.Drawing.Point(102, 104);
            this.buyAmountBtt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buyAmountBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.buyAmountBtt.Name = "buyAmountBtt";
            this.buyAmountBtt.Primary = true;
            this.buyAmountBtt.Size = new System.Drawing.Size(76, 22);
            this.buyAmountBtt.TabIndex = 30;
            this.buyAmountBtt.Text = "Buy";
            this.buyAmountBtt.UseVisualStyleBackColor = true;
            this.buyAmountBtt.Click += new System.EventHandler(this.buyAmountBtt_Click);
            // 
            // sellDiginoteBtt
            // 
            this.sellDiginoteBtt.BackColor = System.Drawing.SystemColors.Control;
            this.sellDiginoteBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellDiginoteBtt.Depth = 0;
            this.sellDiginoteBtt.Font = new System.Drawing.Font("Verdana", 11F);
            this.sellDiginoteBtt.Location = new System.Drawing.Point(18, 104);
            this.sellDiginoteBtt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sellDiginoteBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.sellDiginoteBtt.Name = "sellDiginoteBtt";
            this.sellDiginoteBtt.Primary = true;
            this.sellDiginoteBtt.Size = new System.Drawing.Size(76, 22);
            this.sellDiginoteBtt.TabIndex = 31;
            this.sellDiginoteBtt.Text = "Sell";
            this.sellDiginoteBtt.UseVisualStyleBackColor = false;
            this.sellDiginoteBtt.Click += new System.EventHandler(this.sellDiginoteBtt_Click);
            // 
            // diginoteAmountUD
            // 
            this.diginoteAmountUD.BackColor = System.Drawing.SystemColors.Control;
            this.diginoteAmountUD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.diginoteAmountUD.Location = new System.Drawing.Point(19, 75);
            this.diginoteAmountUD.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.diginoteAmountUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diginoteAmountUD.Name = "diginoteAmountUD";
            this.diginoteAmountUD.Size = new System.Drawing.Size(159, 21);
            this.diginoteAmountUD.TabIndex = 32;
            this.diginoteAmountUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pendingPurchaseTxt
            // 
            this.pendingPurchaseTxt.AutoSize = true;
            this.pendingPurchaseTxt.BackColor = System.Drawing.SystemColors.Window;
            this.pendingPurchaseTxt.Depth = 0;
            this.pendingPurchaseTxt.Font = new System.Drawing.Font("Roboto", 11F);
            this.pendingPurchaseTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pendingPurchaseTxt.Location = new System.Drawing.Point(203, 133);
            this.pendingPurchaseTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.pendingPurchaseTxt.Name = "pendingPurchaseTxt";
            this.pendingPurchaseTxt.Size = new System.Drawing.Size(135, 19);
            this.pendingPurchaseTxt.TabIndex = 34;
            this.pendingPurchaseTxt.Text = "Pending purchases";
            // 
            // mPurchaseOrderTextArea
            // 
            this.mPurchaseOrderTextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPurchaseOrderTextArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.mPurchaseOrderTextArea.Enabled = false;
            this.mPurchaseOrderTextArea.Location = new System.Drawing.Point(207, 155);
            this.mPurchaseOrderTextArea.Multiline = true;
            this.mPurchaseOrderTextArea.Name = "mPurchaseOrderTextArea";
            this.mPurchaseOrderTextArea.ReadOnly = true;
            this.mPurchaseOrderTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mPurchaseOrderTextArea.Size = new System.Drawing.Size(165, 115);
            this.mPurchaseOrderTextArea.TabIndex = 33;
            // 
            // pendingSellTxt
            // 
            this.pendingSellTxt.AutoSize = true;
            this.pendingSellTxt.BackColor = System.Drawing.SystemColors.Window;
            this.pendingSellTxt.Depth = 0;
            this.pendingSellTxt.Font = new System.Drawing.Font("Roboto", 11F);
            this.pendingSellTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pendingSellTxt.Location = new System.Drawing.Point(15, 133);
            this.pendingSellTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.pendingSellTxt.Name = "pendingSellTxt";
            this.pendingSellTxt.Size = new System.Drawing.Size(137, 19);
            this.pendingSellTxt.TabIndex = 36;
            this.pendingSellTxt.Text = "Pending sell orders";
            // 
            // mSellOrderTextArea
            // 
            this.mSellOrderTextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mSellOrderTextArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.mSellOrderTextArea.Enabled = false;
            this.mSellOrderTextArea.Location = new System.Drawing.Point(19, 155);
            this.mSellOrderTextArea.Multiline = true;
            this.mSellOrderTextArea.Name = "mSellOrderTextArea";
            this.mSellOrderTextArea.ReadOnly = true;
            this.mSellOrderTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mSellOrderTextArea.Size = new System.Drawing.Size(165, 115);
            this.mSellOrderTextArea.TabIndex = 35;
            // 
            // mTransactionsTxt
            // 
            this.mTransactionsTxt.AutoSize = true;
            this.mTransactionsTxt.BackColor = System.Drawing.SystemColors.Window;
            this.mTransactionsTxt.Depth = 0;
            this.mTransactionsTxt.Font = new System.Drawing.Font("Roboto", 11F);
            this.mTransactionsTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mTransactionsTxt.Location = new System.Drawing.Point(392, 141);
            this.mTransactionsTxt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.mTransactionsTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTransactionsTxt.Name = "mTransactionsTxt";
            this.mTransactionsTxt.Size = new System.Drawing.Size(117, 19);
            this.mTransactionsTxt.TabIndex = 38;
            this.mTransactionsTxt.Text = "My transactions";
            // 
            // mTradesTextArea
            // 
            this.mTradesTextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTradesTextArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.mTradesTextArea.Enabled = false;
            this.mTradesTextArea.Location = new System.Drawing.Point(396, 163);
            this.mTradesTextArea.Multiline = true;
            this.mTradesTextArea.Name = "mTradesTextArea";
            this.mTradesTextArea.ReadOnly = true;
            this.mTradesTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mTradesTextArea.Size = new System.Drawing.Size(294, 173);
            this.mTradesTextArea.TabIndex = 37;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.BackColor = System.Drawing.SystemColors.Window;
            this.statusLbl.Depth = 0;
            this.statusLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.statusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusLbl.Location = new System.Drawing.Point(15, 313);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.statusLbl.Size = new System.Drawing.Size(52, 23);
            this.statusLbl.TabIndex = 39;
            this.statusLbl.Text = "Status";
            // 
            // cancelSellOrderBtt
            // 
            this.cancelSellOrderBtt.BackColor = System.Drawing.SystemColors.Control;
            this.cancelSellOrderBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelSellOrderBtt.Depth = 0;
            this.cancelSellOrderBtt.Font = new System.Drawing.Font("Verdana", 11F);
            this.cancelSellOrderBtt.Location = new System.Drawing.Point(19, 276);
            this.cancelSellOrderBtt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelSellOrderBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelSellOrderBtt.Name = "cancelSellOrderBtt";
            this.cancelSellOrderBtt.Primary = true;
            this.cancelSellOrderBtt.Size = new System.Drawing.Size(76, 22);
            this.cancelSellOrderBtt.TabIndex = 40;
            this.cancelSellOrderBtt.Text = "Cancel";
            this.cancelSellOrderBtt.UseVisualStyleBackColor = false;
            this.cancelSellOrderBtt.Click += new System.EventHandler(this.cancelSellOrderBtt_Click);
            // 
            // cancelPurchaseBtt
            // 
            this.cancelPurchaseBtt.BackColor = System.Drawing.SystemColors.Control;
            this.cancelPurchaseBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelPurchaseBtt.Depth = 0;
            this.cancelPurchaseBtt.Font = new System.Drawing.Font("Verdana", 11F);
            this.cancelPurchaseBtt.Location = new System.Drawing.Point(207, 276);
            this.cancelPurchaseBtt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelPurchaseBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelPurchaseBtt.Name = "cancelPurchaseBtt";
            this.cancelPurchaseBtt.Primary = true;
            this.cancelPurchaseBtt.Size = new System.Drawing.Size(76, 22);
            this.cancelPurchaseBtt.TabIndex = 41;
            this.cancelPurchaseBtt.Text = "Cancel";
            this.cancelPurchaseBtt.UseVisualStyleBackColor = false;
            this.cancelPurchaseBtt.Click += new System.EventHandler(this.cancelPurchaseBtt_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.cancelPurchaseBtt);
            this.Controls.Add(this.cancelSellOrderBtt);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.mTransactionsTxt);
            this.Controls.Add(this.mTradesTextArea);
            this.Controls.Add(this.pendingSellTxt);
            this.Controls.Add(this.mSellOrderTextArea);
            this.Controls.Add(this.pendingPurchaseTxt);
            this.Controls.Add(this.mPurchaseOrderTextArea);
            this.Controls.Add(this.diginoteAmountUD);
            this.Controls.Add(this.sellDiginoteBtt);
            this.Controls.Add(this.buyAmountBtt);
            this.Controls.Add(this.transactionsTxt);
            this.Controls.Add(this.mTransactionTextArea);
            this.Controls.Add(this.diginotesLbl);
            this.Controls.Add(this.quoteTxtLbl);
            this.Controls.Add(this.logoutBtt);
            this.Controls.Add(this.loggedLbl);
            this.Controls.Add(this.signUpBtt);
            this.Controls.Add(this.signInBtt);
            this.Controls.Add(this.registerBtt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.nicknameTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.loginBtt);
            this.Controls.Add(this.resultLbl);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientForm";
            this.Text = "Diginote Exchange System";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diginoteAmountUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel loggedLbl;
        private MaterialSkin.Controls.MaterialRaisedButton logoutBtt;
        private MaterialSkin.Controls.MaterialLabel resultLbl;
        private MaterialSkin.Controls.MaterialLabel quoteTxtLbl;
        private MaterialSkin.Controls.MaterialFlatButton registerBtt;
        private MaterialSkin.Controls.MaterialFlatButton loginBtt;
        private MaterialSkin.Controls.MaterialSingleLineTextField userTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField passTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField nicknameTxt;
        private MaterialSkin.Controls.MaterialRaisedButton signInBtt;
        private MaterialSkin.Controls.MaterialRaisedButton signUpBtt;
        private MaterialSkin.Controls.MaterialLabel diginotesLbl;
        private System.Windows.Forms.TextBox mTransactionTextArea;
        private MaterialSkin.Controls.MaterialLabel transactionsTxt;
        private MaterialSkin.Controls.MaterialRaisedButton buyAmountBtt;
        private MaterialSkin.Controls.MaterialRaisedButton sellDiginoteBtt;
        private System.Windows.Forms.NumericUpDown diginoteAmountUD;
        private MaterialSkin.Controls.MaterialLabel pendingPurchaseTxt;
        private System.Windows.Forms.TextBox mPurchaseOrderTextArea;
        private MaterialSkin.Controls.MaterialLabel pendingSellTxt;
        private System.Windows.Forms.TextBox mSellOrderTextArea;
        private MaterialSkin.Controls.MaterialLabel mTransactionsTxt;
        private System.Windows.Forms.TextBox mTradesTextArea;
        private MaterialSkin.Controls.MaterialLabel statusLbl;
        private MaterialSkin.Controls.MaterialRaisedButton cancelSellOrderBtt;
        private MaterialSkin.Controls.MaterialRaisedButton cancelPurchaseBtt;
    }
}