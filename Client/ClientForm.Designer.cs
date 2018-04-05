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
            this.textLbl = new System.Windows.Forms.Label();
            this.quoteLbl = new System.Windows.Forms.Label();
            this.loggedLbl = new MaterialSkin.Controls.MaterialLabel();
            this.logoutBtt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.resultLbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(118, 69);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(100, 20);
            this.passTxt.TabIndex = 6;
            this.passTxt.Text = "Password";
            // 
            // loginBtt
            // 
            this.loginBtt.Location = new System.Drawing.Point(117, 93);
            this.loginBtt.Name = "loginBtt";
            this.loginBtt.Size = new System.Drawing.Size(100, 23);
            this.loginBtt.TabIndex = 4;
            this.loginBtt.Text = "Login";
            this.loginBtt.UseVisualStyleBackColor = true;
            this.loginBtt.Click += new System.EventHandler(this.loginBtt_Click);
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(13, 69);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(100, 20);
            this.userTxt.TabIndex = 7;
            this.userTxt.Text = "Username";
            // 
            // registerBtt
            // 
            this.registerBtt.Location = new System.Drawing.Point(13, 93);
            this.registerBtt.Name = "registerBtt";
            this.registerBtt.Size = new System.Drawing.Size(100, 23);
            this.registerBtt.TabIndex = 8;
            this.registerBtt.Text = "Register";
            this.registerBtt.UseVisualStyleBackColor = true;
            this.registerBtt.Click += new System.EventHandler(this.registerBtt_Click);
            // 
            // textLbl
            // 
            this.textLbl.AutoSize = true;
            this.textLbl.Location = new System.Drawing.Point(237, 69);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(74, 13);
            this.textLbl.TabIndex = 12;
            this.textLbl.Text = "Current quote:";
            // 
            // quoteLbl
            // 
            this.quoteLbl.AutoSize = true;
            this.quoteLbl.Location = new System.Drawing.Point(315, 69);
            this.quoteLbl.Name = "quoteLbl";
            this.quoteLbl.Size = new System.Drawing.Size(0, 13);
            this.quoteLbl.TabIndex = 14;
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
            this.resultLbl.Location = new System.Drawing.Point(12, 119);
            this.resultLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(51, 19);
            this.resultLbl.TabIndex = 17;
            this.resultLbl.Text = "Result";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 456);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.logoutBtt);
            this.Controls.Add(this.loggedLbl);
            this.Controls.Add(this.quoteLbl);
            this.Controls.Add(this.textLbl);
            this.Controls.Add(this.registerBtt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.loginBtt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.Text = "DiginoteExchangeSystem";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Button loginBtt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Button registerBtt;
        private System.Windows.Forms.Label textLbl;
        private System.Windows.Forms.Label quoteLbl;
        private MaterialSkin.Controls.MaterialLabel loggedLbl;
        private MaterialSkin.Controls.MaterialRaisedButton logoutBtt;
        private MaterialSkin.Controls.MaterialLabel resultLbl;
    }
}