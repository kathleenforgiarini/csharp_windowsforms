using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class LottoMax : Form
    {
        public LottoMax()
        {
            InitializeComponent();
        }

        private void maxExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Exit Lotto Max", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void maxGenerate_Click(object sender, EventArgs e)
        {
            Random labelRandom = new Random();
            int labelRandomNumber = 0;
            List<int> labelUniqueNumbers = new List<int>();
            string labelNumbers = "";
            while (labelUniqueNumbers.Count < 7)
            {
                labelRandomNumber = labelRandom.Next(0, 10);
                if (!labelUniqueNumbers.Contains(labelRandomNumber))
                {
                    labelUniqueNumbers.Add(labelRandomNumber);
                    labelNumbers += labelRandomNumber;
                }
            }
            maxLabel.Text = labelNumbers;


            Random boxRandom = new Random();
            int boxRandomNumber = 0;
            List<int> boxUniqueNumbers = new List<int>();
            string boxNumbers = "";
            while (boxUniqueNumbers.Count < 8)
            {
                boxRandomNumber = boxRandom.Next(1, 50);
                if (!boxUniqueNumbers.Contains(boxRandomNumber))
                {
                    boxUniqueNumbers.Add(boxRandomNumber);
                    boxNumbers += boxRandomNumber.ToString() + "\t\t";
                }
            }
            maxTextbox.Text = boxNumbers;


            //Text File
            string fileName = @"LottoNbrs.txt";
            using (FileStream fileStream = new FileStream(fileName, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                string lotteryName = "Max";
                string dateTimeString = DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt");
                int bonusNumber = boxUniqueNumbers[7];
                writer.Write(lotteryName + ", " + dateTimeString + ", ");
                for (int i = 0; i < boxUniqueNumbers.Count-1; i++)
                {
                    writer.Write(boxUniqueNumbers[i]);
                    if (i != boxUniqueNumbers.Count - 1)
                    {
                        writer.Write(",");
                    }
                }
                writer.Write(" Bonus " + bonusNumber);
                writer.WriteLine();
            }
        }

        private void maxRead_Click(object sender, EventArgs e)
        {
            string fileName = "LottoNbrs.txt";
            string fileContent = "";
            
                using (StreamReader reader = new StreamReader(fileName))
                {
                    fileContent = reader.ReadToEnd();
                }
            
            string message = fileContent;
            string title = "Lottery Numbers by Kathleen Forgiarini";
            MessageBox.Show(message, title);
        }
    }
}