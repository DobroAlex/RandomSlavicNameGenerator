using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RandomNameLastNameGenerator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            maleCB.Checked = true;
        }

        private void maleCB_CheckedChanged(object sender, EventArgs e)
        {
            femaleCB.Checked = !maleCB.Checked;
        }

        private void femaleCB_CheckedChanged(object sender, EventArgs e)
        {
            maleCB.Checked = !femaleCB.Checked;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (maleCB.Checked)
            {

                try
                {
                    string[] names = File.ReadAllLines(@"..\..\sources\firstNamesMale.txt", System.Text.Encoding.Default); /*Если имена фамилии изменятся в рантайме, то это не помещает работе приложения, хотя это и медленный способ*/
                    string[] lastNames = File.ReadAllLines(@"..\..\sources\lastNamesMale.txt", System.Text.Encoding.Default);
                    Random rand = new Random();
                    firstNameTB.Text = names[rand.Next(0, names.Length)];
                    lastNameTB.Text = lastNames[rand.Next(0, lastNames.Length)];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("It appears that some files are missing in sources or files are empty. Check for: firtsNamesFemale, firtsNamesMale, lastNamesFemale, lastNamesMale\nКажется, источники отсутсвуют в sources или они пусты. Проверьте  наличие:firtsNamesFemale, firtsNamesMale, lastNamesFemale, lastNamesMale\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    string[] names = File.ReadAllLines(@"..\..\sources\firstNamesFemale.txt", System.Text.Encoding.Default); /*Если имена фамилии изменятся в рантайме, то это не помещает работе приложения, хотя это и медленный способ*/
                    string[] lastNames = File.ReadAllLines(@"..\..\sources\lastNamesFemale.txt", System.Text.Encoding.Default);
                    Random rand = new Random();
                    firstNameTB.Text = names[rand.Next(0, names.Length)];
                    lastNameTB.Text = lastNames[rand.Next(0, lastNames.Length)];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("It appears that some files are missing in sources or files are empty. Check for: firtsNamesFemale, firtsNamesMale, lastNamesFemale, lastNamesMale\nКажется, источники отсутсвуют в sources или они пусты. Проверьте  наличие:firtsNamesFemale, firtsNamesMale, lastNamesFemale, lastNamesMale\n" + ex.Message);
                }
            }
        }

        private void copyButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(firstNameTB.Text);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("It appears that string is empty\nКажется, строка пуста", ex.Message);
            }
        }

        private void copyButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(lastNameTB.Text);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("It appears that string is empty\nКажется, строка пуста", ex.Message);
            }

        }

        private void copyAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(firstNameTB.Text + " " + lastNameTB.Text);
                if (firstNameTB.Text == "" || lastNameTB.Text == "")
                {
                    throw new ArgumentNullException("text", "It appears that one of the strings is empty\nКажется, одна или обе строки пусты");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show( ex.Message);
            }
        }
    }
}
