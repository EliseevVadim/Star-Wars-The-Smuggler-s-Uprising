using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheGame
{
    public partial class GetAmountForm : Form
    {
        uint credits_, amount_;
        public GetAmountForm()
        {
            InitializeComponent();
        }
        public GetAmountForm(uint credits)
        {
            InitializeComponent();
            credits_ = credits;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(22, 22, 255);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(80, 113, 254);
        }
        public uint GetAmount()
        {
            return amount_;
        }

        private void commitAmountButton_Click(object sender, EventArgs e)
        {
            uint amount=0;
            if (String.IsNullOrEmpty(amountField.Text) || !(uint.TryParse(amountField.Text, out amount))||uint.Parse(amountField.Text)<=0)
            {
                MessageBox.Show("Ставка была введена неверно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (amount > credits_)
            {
                MessageBox.Show("Не хватает кредитов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                amount_ = amount;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
