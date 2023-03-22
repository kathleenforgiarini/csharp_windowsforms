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

namespace finalProject
{
    public partial class IPValidator : Form
    {
        public IPValidator()
        {
            InitializeComponent();
        }

        private DateTime startTime;
        private DateTime endTime;

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the IP4 Validator??", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }

        }

        private void IPValidator_Load(object sender, EventArgs e)
        {
            labelDate.Text += "Today: " + DateTime.Today.ToLongDateString().ToString();
            startTime = DateTime.Now;
        }

        private void validate_Click(object sender, EventArgs e)
        {
            string ip = textBox.Text.Trim();
            Regex ipRegex = new Regex(@"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)\.?\b){4}$");

            try
            {
                if (ip == "")
                {
                    MessageBox.Show("Enter an IP to validate!");
                } else
                {
                    if (ipRegex.IsMatch(ip))
                    {
                        MessageBox.Show(ip + "\nThe IP is correct", "Valid IP");
                    }
                    else
                    {
                        MessageBox.Show(ip + "\nThe IP must have 4 bytes \ninteger number between 0 to 255 \nseparated by a dot (255.255.255.255)", "Error");
                    }
                }

                textBox.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured, try again!\n" + ex.Message);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            textBox.Focus();
        }

        private void IPValidator_FormClosing(object sender, FormClosingEventArgs e)
        {
            endTime = DateTime.Now;
            TimeSpan interval = endTime - startTime;
            int totalSeconds = Convert.ToInt32(interval.TotalSeconds);
            int totalMinutes = totalSeconds / 60;
            totalSeconds %= 60;
            if (totalMinutes >= 2)
            {
                MessageBox.Show($"You used the IP4 validator for {totalMinutes} minutes and {totalSeconds} seconds", "Time Spent");
            }
            else if (totalMinutes == 0)
            {
                MessageBox.Show($"You used the IP4 validator for {totalSeconds} seconds", "Time Spent");
            }
            else
            {
                MessageBox.Show($"You used the IP4 validator for {totalMinutes} minute and {totalSeconds} seconds", "Time Spent");
            }

        }
    }
}
