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
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // loggedLbl
            // 
            this.loggedLbl.AutoSize = true;
            this.loggedLbl.BackColor = System.Drawing.SystemColors.Window;
            this.loggedLbl.Depth = 0;
            this.loggedLbl.Font = new System.Drawing.Font("Verdana", 11F);
            this.loggedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loggedLbl.Location = new System.Drawing.Point(15, 534);
            this.loggedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loggedLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.loggedLbl.Name = "loggedLbl";
            this.loggedLbl.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.loggedLbl.Size = new System.Drawing.Size(113, 22);
            this.loggedLbl.TabIndex = 15;
            this.loggedLbl.Text = "Logged in as: ";
            // 
            // logoutBtt
            // 
            this.logoutBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtt.Depth = 0;
            this.logoutBtt.Font = new System.Drawing.Font("Verdana", 11F);
            this.logoutBtt.Location = new System.Drawing.Point(18, 559);
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
            this.resultLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultLbl.Location = new System.Drawing.Point(15, 247);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.resultLbl.Size = new System.Drawing.Size(53, 22);
            this.resultLbl.TabIndex = 17;
            this.resultLbl.Text = "Result";
            // 
            // quoteTxtLbl
            // 
            this.quoteTxtLbl.AutoSize = true;
            this.quoteTxtLbl.BackColor = System.Drawing.SystemColors.Window;
            this.quoteTxtLbl.Depth = 0;
            this.quoteTxtLbl.Font = new System.Drawing.Font("Verdana", 11F);
            this.quoteTxtLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quoteTxtLbl.Location = new System.Drawing.Point(391, 109);
            this.quoteTxtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quoteTxtLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.quoteTxtLbl.Name = "quoteTxtLbl";
            this.quoteTxtLbl.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.quoteTxtLbl.Size = new System.Drawing.Size(122, 22);
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
            this.diginotesLbl.Font = new System.Drawing.Font("Verdana", 11F);
            this.diginotesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diginotesLbl.Location = new System.Drawing.Point(392, 75);
            this.diginotesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diginotesLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.diginotesLbl.Name = "diginotesLbl";
            this.diginotesLbl.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.diginotesLbl.Size = new System.Drawing.Size(121, 22);
            this.diginotesLbl.TabIndex = 26;
            this.diginotesLbl.Text = "Your Diginotes:";
            // 
            // logTextBox
            // 
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.logTextBox.Enabled = false;
            this.logTextBox.Location = new System.Drawing.Point(394, 161);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.logTextBox.Size = new System.Drawing.Size(294, 420);
            this.logTextBox.TabIndex = 27;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(391, 141);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(171, 18);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Recent transactions";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.diginotesLbl);
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
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientForm";
            this.Text = "Diginote Exchange System";
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
        private MaterialSkin.Controls.MaterialLabel diginotesLbl;
        private System.Windows.Forms.TextBox logTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}