namespace Client
{
    partial class ConfirmForm
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
            this.confirmBtt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancelBtt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.infoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.info1Lbl = new MaterialSkin.Controls.MaterialLabel();
            this.info2Lbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // confirmBtt
            // 
            this.confirmBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtt.Depth = 0;
            this.confirmBtt.Location = new System.Drawing.Point(32, 152);
            this.confirmBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmBtt.Name = "confirmBtt";
            this.confirmBtt.Primary = true;
            this.confirmBtt.Size = new System.Drawing.Size(94, 54);
            this.confirmBtt.TabIndex = 1;
            this.confirmBtt.Text = "Confirm";
            this.confirmBtt.UseVisualStyleBackColor = true;
            this.confirmBtt.Click += new System.EventHandler(this.confirmBtt_Click);
            // 
            // cancelBtt
            // 
            this.cancelBtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtt.Depth = 0;
            this.cancelBtt.Location = new System.Drawing.Point(153, 152);
            this.cancelBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelBtt.Name = "cancelBtt";
            this.cancelBtt.Primary = true;
            this.cancelBtt.Size = new System.Drawing.Size(94, 54);
            this.cancelBtt.TabIndex = 2;
            this.cancelBtt.Text = "Cancel";
            this.cancelBtt.UseVisualStyleBackColor = true;
            this.cancelBtt.Click += new System.EventHandler(this.cancelBtt_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.BackColor = System.Drawing.SystemColors.Window;
            this.infoLbl.Depth = 0;
            this.infoLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.infoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoLbl.Location = new System.Drawing.Point(28, 82);
            this.infoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(38, 19);
            this.infoLbl.TabIndex = 3;
            this.infoLbl.Text = "Text";
            // 
            // info1Lbl
            // 
            this.info1Lbl.AutoSize = true;
            this.info1Lbl.BackColor = System.Drawing.SystemColors.Window;
            this.info1Lbl.Depth = 0;
            this.info1Lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.info1Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.info1Lbl.Location = new System.Drawing.Point(28, 101);
            this.info1Lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.info1Lbl.Name = "info1Lbl";
            this.info1Lbl.Size = new System.Drawing.Size(38, 19);
            this.info1Lbl.TabIndex = 4;
            this.info1Lbl.Text = "Text";
            // 
            // info2Lbl
            // 
            this.info2Lbl.AutoSize = true;
            this.info2Lbl.BackColor = System.Drawing.SystemColors.Window;
            this.info2Lbl.Depth = 0;
            this.info2Lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.info2Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.info2Lbl.Location = new System.Drawing.Point(28, 120);
            this.info2Lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.info2Lbl.Name = "info2Lbl";
            this.info2Lbl.Size = new System.Drawing.Size(38, 19);
            this.info2Lbl.TabIndex = 5;
            this.info2Lbl.Text = "Text";
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 250);
            this.Controls.Add(this.info2Lbl);
            this.Controls.Add(this.info1Lbl);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.cancelBtt);
            this.Controls.Add(this.confirmBtt);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "ConfirmForm";
            this.Text = "Confirm new price";
            this.Load += new System.EventHandler(this.ConfirmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton confirmBtt;
        private MaterialSkin.Controls.MaterialRaisedButton cancelBtt;
        private MaterialSkin.Controls.MaterialLabel infoLbl;
        private MaterialSkin.Controls.MaterialLabel info1Lbl;
        private MaterialSkin.Controls.MaterialLabel info2Lbl;
    }
}