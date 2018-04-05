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
            this.SuspendLayout();
            // 
            // loggedLbl
            // 
            this.loggedLbl.AutoSize = true;
            this.loggedLbl.Depth = 0;
            this.loggedLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.loggedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loggedLbl.Location = new System.Drawing.Point(94, 422);
            this.loggedLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.loggedLbl.Name = "loggedLbl";
            this.loggedLbl.Size = new System.Drawing.Size(102, 19);
            this.loggedLbl.TabIndex = 15;
            this.loggedLbl.Text = "Logged in as: ";
            // 
            // logoutBtt
            // 
            this.logoutBtt.Depth = 0;
            this.logoutBtt.Location = new System.Drawing.Point(13, 421);
            this.logoutBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.logoutBtt.Name = "logoutBtt";
            this.logoutBtt.Primary = true;
            this.logoutBtt.Size = new System.Drawing.Size(75, 23);
            this.logoutBtt.TabIndex = 16;
            this.logoutBtt.Text = "Logout";
            this.logoutBtt.UseVisualStyleBackColor = true;
            this.logoutBtt.Click += new System.EventHandler(this.logoutBtt_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Depth = 0;
            this.resultLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.resultLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultLbl.Location = new System.Drawing.Point(309, 309);
            this.resultLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(51, 19);
            this.resultLbl.TabIndex = 17;
            this.resultLbl.Text = "Result";
            // 
            // quoteTxtLbl
            // 
            this.quoteTxtLbl.AutoSize = true;
            this.quoteTxtLbl.Depth = 0;
            this.quoteTxtLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.quoteTxtLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quoteTxtLbl.Location = new System.Drawing.Point(505, 73);
            this.quoteTxtLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.quoteTxtLbl.Name = "quoteTxtLbl";
            this.quoteTxtLbl.Size = new System.Drawing.Size(106, 19);
            this.quoteTxtLbl.TabIndex = 18;
            this.quoteTxtLbl.Text = "Current Quote:";
            // 
            // registerBtt
            // 
            this.registerBtt.AutoSize = true;
            this.registerBtt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerBtt.Depth = 0;
            this.registerBtt.Location = new System.Drawing.Point(390, 142);
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
            this.loginBtt.Depth = 0;
            this.loginBtt.Location = new System.Drawing.Point(390, 187);
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
            this.userTxt.Depth = 0;
            this.userTxt.Hint = "";
            this.userTxt.Location = new System.Drawing.Point(285, 171);
            this.userTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.userTxt.Name = "userTxt";
            this.userTxt.PasswordChar = '\0';
            this.userTxt.SelectedText = "";
            this.userTxt.SelectionLength = 0;
            this.userTxt.SelectionStart = 0;
            this.userTxt.Size = new System.Drawing.Size(75, 23);
            this.userTxt.TabIndex = 21;
            this.userTxt.Text = "Username";
            this.userTxt.UseSystemPasswordChar = false;
            // 
            // passTxt
            // 
            this.passTxt.Depth = 0;
            this.passTxt.Hint = "";
            this.passTxt.Location = new System.Drawing.Point(285, 200);
            this.passTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '\0';
            this.passTxt.SelectedText = "";
            this.passTxt.SelectionLength = 0;
            this.passTxt.SelectionStart = 0;
            this.passTxt.Size = new System.Drawing.Size(75, 23);
            this.passTxt.TabIndex = 22;
            this.passTxt.Text = "Password";
            this.passTxt.UseSystemPasswordChar = false;
            // 
            // nicknameTxt
            // 
            this.nicknameTxt.Depth = 0;
            this.nicknameTxt.Hint = "";
            this.nicknameTxt.Location = new System.Drawing.Point(285, 142);
            this.nicknameTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.nicknameTxt.Name = "nicknameTxt";
            this.nicknameTxt.PasswordChar = '\0';
            this.nicknameTxt.SelectedText = "";
            this.nicknameTxt.SelectionLength = 0;
            this.nicknameTxt.SelectionStart = 0;
            this.nicknameTxt.Size = new System.Drawing.Size(75, 23);
            this.nicknameTxt.TabIndex = 23;
            this.nicknameTxt.Text = "Nickname";
            this.nicknameTxt.UseSystemPasswordChar = false;
            // 
            // signInBtt
            // 
            this.signInBtt.Depth = 0;
            this.signInBtt.Location = new System.Drawing.Point(251, 89);
            this.signInBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.signInBtt.Name = "signInBtt";
            this.signInBtt.Primary = true;
            this.signInBtt.Size = new System.Drawing.Size(75, 23);
            this.signInBtt.TabIndex = 24;
            this.signInBtt.Text = "Sign In";
            this.signInBtt.UseVisualStyleBackColor = true;
            this.signInBtt.Click += new System.EventHandler(this.signInBtt_Click);
            // 
            // signUpBtt
            // 
            this.signUpBtt.Depth = 0;
            this.signUpBtt.Location = new System.Drawing.Point(345, 89);
            this.signUpBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpBtt.Name = "signUpBtt";
            this.signUpBtt.Primary = true;
            this.signUpBtt.Size = new System.Drawing.Size(75, 23);
            this.signUpBtt.TabIndex = 25;
            this.signUpBtt.Text = "Sign Up";
            this.signUpBtt.UseVisualStyleBackColor = true;
            this.signUpBtt.Click += new System.EventHandler(this.signUpBtt_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 593);
            this.Controls.Add(this.signUpBtt);
            this.Controls.Add(this.signInBtt);
            this.Controls.Add(this.registerBtt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.nicknameTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.loginBtt);
            this.Controls.Add(this.quoteTxtLbl);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.logoutBtt);
            this.Controls.Add(this.loggedLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.Text = "DiginoteExchangeSystem";
            this.Load += new System.EventHandler(this.ClientForm_Load);
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
    }
}