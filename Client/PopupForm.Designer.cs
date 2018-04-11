namespace Client
{
    partial class PopupForm
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
            this.newValueUD = new System.Windows.Forms.NumericUpDown();
            this.confirmBtt = new MaterialSkin.Controls.MaterialFlatButton();
            this.cancelBtt = new MaterialSkin.Controls.MaterialFlatButton();
            this.resultLbl = new MaterialSkin.Controls.MaterialLabel();
            this.currentLbl = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.newValueUD)).BeginInit();
            this.SuspendLayout();
            // 
            // newValueUD
            // 
            this.newValueUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newValueUD.DecimalPlaces = 2;
            this.newValueUD.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.newValueUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.newValueUD.Location = new System.Drawing.Point(67, 137);
            this.newValueUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.newValueUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.newValueUD.Name = "newValueUD";
            this.newValueUD.Size = new System.Drawing.Size(164, 21);
            this.newValueUD.TabIndex = 0;
            this.newValueUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // confirmBtt
            // 
            this.confirmBtt.AutoSize = true;
            this.confirmBtt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirmBtt.Depth = 0;
            this.confirmBtt.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.confirmBtt.Location = new System.Drawing.Point(67, 167);
            this.confirmBtt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirmBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmBtt.Name = "confirmBtt";
            this.confirmBtt.Primary = false;
            this.confirmBtt.Size = new System.Drawing.Size(72, 36);
            this.confirmBtt.TabIndex = 1;
            this.confirmBtt.Text = "Confirm";
            this.confirmBtt.UseVisualStyleBackColor = true;
            this.confirmBtt.Click += new System.EventHandler(this.confirmBtt_Click);
            // 
            // cancelBtt
            // 
            this.cancelBtt.AutoSize = true;
            this.cancelBtt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtt.Depth = 0;
            this.cancelBtt.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cancelBtt.Location = new System.Drawing.Point(167, 167);
            this.cancelBtt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelBtt.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelBtt.Name = "cancelBtt";
            this.cancelBtt.Primary = false;
            this.cancelBtt.Size = new System.Drawing.Size(64, 36);
            this.cancelBtt.TabIndex = 2;
            this.cancelBtt.Text = "Cancel";
            this.cancelBtt.UseVisualStyleBackColor = true;
            this.cancelBtt.Click += new System.EventHandler(this.cancelBtt_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.BackColor = System.Drawing.SystemColors.Window;
            this.resultLbl.Depth = 0;
            this.resultLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.resultLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultLbl.Location = new System.Drawing.Point(12, 272);
            this.resultLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(51, 19);
            this.resultLbl.TabIndex = 3;
            this.resultLbl.Text = "Result";
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.resultLbl.Visible = false;
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = true;
            this.currentLbl.BackColor = System.Drawing.SystemColors.Window;
            this.currentLbl.Depth = 0;
            this.currentLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.currentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.currentLbl.Location = new System.Drawing.Point(63, 104);
            this.currentLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(100, 19);
            this.currentLbl.TabIndex = 4;
            this.currentLbl.Text = "Current Value";
            this.currentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.currentLbl);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.cancelBtt);
            this.Controls.Add(this.confirmBtt);
            this.Controls.Add(this.newValueUD);
            this.Name = "PopupForm";
            this.Text = "Change price";
            this.Load += new System.EventHandler(this.PopupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newValueUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown newValueUD;
        private MaterialSkin.Controls.MaterialFlatButton confirmBtt;
        private MaterialSkin.Controls.MaterialFlatButton cancelBtt;
        private MaterialSkin.Controls.MaterialLabel resultLbl;
        private MaterialSkin.Controls.MaterialLabel currentLbl;
    }
}