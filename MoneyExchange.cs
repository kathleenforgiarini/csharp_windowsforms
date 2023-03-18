using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
// Site used to get the exchange factor: https://www.oanda.com/currency-converter/en/?from=CAD&to=USD&amount=1
// 2023-03-18

namespace finalProject
{
    public partial class MoneyExchange : Form
    {
        private const double cadRate = 1.0;
        private const double usdRate = 0.7289;
        private const double eurRate = 0.6845;
        private const double gbpRate = 0.5997;
        private const double brlRate = 3.8265;
        public MoneyExchange()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want \nto quit the application \nMoney Exchange?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            double amount;
            double result;

            string amountStr = fromTextbox.Text.Trim();
            if (Regex.IsMatch(amountStr, @"^\d{1,3}(,\d{3})*(\.\d+)?$"))
            {
                try
                {
                    amount = Convert.ToDouble(fromTextbox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input amount.");
                    return;
                }

                string from = GetSelectedCurrency(cad, usd, eur, gbp, brl);
                if (from == null)
                {
                    MessageBox.Show("Please select a FROM currency.");
                    return;
                }

                string to = GetSelectedCurrency(toCad, toUsd, toEur, toGbp, toBrl);
                if (to == null)
                {
                    MessageBox.Show("Please select a TO currency.");
                    return;
                }

                switch (to)
                {
                    case "CAD":
                        result = amount * cadRate / GetCurrencyRate(from);
                        break;
                    case "USD":
                        result = amount * usdRate / GetCurrencyRate(from);
                        break;
                    case "EUR":
                        result = amount * eurRate / GetCurrencyRate(from);
                        break;
                    case "GBP":
                        result = amount * gbpRate / GetCurrencyRate(from);
                        break;
                    case "BRL":
                        result = amount * brlRate / GetCurrencyRate(from);
                        break;
                    default:
                        MessageBox.Show("Invalid currency selection.");
                        return;
                }

                toTextbox.Text = result.ToString("0.00");

            }
            else
            {
                MessageBox.Show("Invalid amount entered. Please enter a valid amount with a comma or dot as decimal separator.");
            }
        }

        private string GetSelectedCurrency(params RadioButton[] radioButtons)
        {
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.Checked)
                {
                    return rb.Text;
                }
            }
            return null;
        }

        private double GetCurrencyRate(string currency)
        {
            switch (currency)
            {
                case "CAD":
                    return cadRate;
                case "USD":
                    return usdRate;
                case "EUR":
                    return eurRate;
                case "GBP":
                    return gbpRate;
                case "BRL":
                    return brlRate;
                default:
                    return 0.0;
            }
        }
    }
}
