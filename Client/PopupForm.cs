using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Client
{
    public partial class PopupForm : MaterialForm
    {
        private double currentQuote;
        private bool isDecrease;
        public double newValue;

        public PopupForm(double q, bool d)
        {
            currentQuote = q;
            isDecrease = d;
            InitializeComponent();
        }

        private void confirmBtt_Click(object sender, EventArgs e)
        {
            newValue = (double)newValueUD.Value;

            if (isDecrease)
            {
                if (newValue > currentQuote)
                {
                    resultLbl.ForeColor = System.Drawing.Color.Red;
                    resultLbl.Text = "New value must be lower than " + currentQuote.ToString();
                    resultLbl.Show();
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            else {
                if (newValue < currentQuote)
                {
                    resultLbl.ForeColor = System.Drawing.Color.Red;
                    resultLbl.Text = "New value must be higher than " + currentQuote.ToString();
                    resultLbl.Show();
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void cancelBtt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopupForm_Load(object sender, EventArgs e)
        {
            currentLbl.Text = "Current quote is " + currentQuote.ToString();
        }
    }
}
