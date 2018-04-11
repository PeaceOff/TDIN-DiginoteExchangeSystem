using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Client
{
    public partial class ConfirmForm : MaterialForm
    {
        private double quote;

        public ConfirmForm(double q)
        {
            quote = q;
            InitializeComponent();
        }

        private void ConfirmForm_Load(object sender, System.EventArgs e)
        {
            infoLbl.Text = "The quote has changed.";
            info1Lbl.Text = "New quote is " + quote + ".";
            info2Lbl.Text = "Do you accept this price?";
        }

        private void confirmBtt_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
