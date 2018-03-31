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
            this.passTxt = new System.Windows.Forms.TextBox();
            this.loginBtt = new System.Windows.Forms.Button();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.registerBtt = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.logoutBtt = new System.Windows.Forms.Button();
            this.loggedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(153, 13);
            this.passTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(132, 22);
            this.passTxt.TabIndex = 6;
            this.passTxt.Text = "Password";
            // 
            // loginBtt
            // 
            this.loginBtt.Location = new System.Drawing.Point(152, 43);
            this.loginBtt.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtt.Name = "loginBtt";
            this.loginBtt.Size = new System.Drawing.Size(133, 28);
            this.loginBtt.TabIndex = 4;
            this.loginBtt.Text = "Login";
            this.loginBtt.UseVisualStyleBackColor = true;
            this.loginBtt.Click += new System.EventHandler(this.loginBtt_Click);
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(13, 13);
            this.userTxt.Margin = new System.Windows.Forms.Padding(4);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(132, 22);
            this.userTxt.TabIndex = 7;
            this.userTxt.Text = "Username";
            // 
            // registerBtt
            // 
            this.registerBtt.Location = new System.Drawing.Point(13, 43);
            this.registerBtt.Margin = new System.Windows.Forms.Padding(4);
            this.registerBtt.Name = "registerBtt";
            this.registerBtt.Size = new System.Drawing.Size(133, 28);
            this.registerBtt.TabIndex = 8;
            this.registerBtt.Text = "Register";
            this.registerBtt.UseVisualStyleBackColor = true;
            this.registerBtt.Click += new System.EventHandler(this.registerBtt_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(12, 75);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(48, 17);
            this.resultLbl.TabIndex = 9;
            this.resultLbl.Text = "Result";
            // 
            // logoutBtt
            // 
            this.logoutBtt.Location = new System.Drawing.Point(15, 414);
            this.logoutBtt.Name = "logoutBtt";
            this.logoutBtt.Size = new System.Drawing.Size(75, 27);
            this.logoutBtt.TabIndex = 10;
            this.logoutBtt.Text = "Logout";
            this.logoutBtt.UseVisualStyleBackColor = true;
            this.logoutBtt.Click += new System.EventHandler(this.logoutBtt_Click);
            // 
            // loggedLbl
            // 
            this.loggedLbl.AutoSize = true;
            this.loggedLbl.Location = new System.Drawing.Point(96, 421);
            this.loggedLbl.Name = "loggedLbl";
            this.loggedLbl.Size = new System.Drawing.Size(98, 17);
            this.loggedLbl.TabIndex = 11;
            this.loggedLbl.Text = "Logged in as: ";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 453);
            this.Controls.Add(this.loggedLbl);
            this.Controls.Add(this.logoutBtt);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.registerBtt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.loginBtt);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Button loginBtt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Button registerBtt;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button logoutBtt;
        private System.Windows.Forms.Label loggedLbl;
    }
}