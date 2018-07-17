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
            if (maleCB.Checked)
            {
                
                femaleCB.Checked = false;
            }
            else
            {
                
                femaleCB.Checked = true;
            }
        }

        private void femaleCB_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleCB.Checked)
            {
                
                maleCB.Checked = false;
            }
            else
            {
                
                maleCB.Checked = true;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (maleCB.Checked)
            {
                string[] names = File.ReadAllLines(@"..\..\firstNamesMale.txt", System.Text.Encoding.Default); /*Если имена фамилии изменятся в рантайме, то это не помещает работе приложения, хотя это и медленный способ*/
                string[] lastNames = File.ReadAllLines(@"..\..\lastNamesMale.txt", System.Text.Encoding.Default);
                Random rand = new Random();
                firstNameTB.Text = names[rand.Next(0, names.Length)];
                lastNameTB.Text = lastNames[rand.Next(0, lastNames.Length)];
            }
            else
            {
                string[] names = File.ReadAllLines(@"..\..\firstNamesFemale.txt", System.Text.Encoding.Default); /*Если имена фамилии изменятся в рантайме, то это не помещает работе приложения, хотя это и медленный способ*/
                string[] lastNames = File.ReadAllLines(@"..\..\lastNamesFemale.txt", System.Text.Encoding.Default);
                Random rand = new Random();
                firstNameTB.Text = names[rand.Next(0, names.Length)];
                lastNameTB.Text = lastNames[rand.Next(0, lastNames.Length)];

            }
        }
    }
}
