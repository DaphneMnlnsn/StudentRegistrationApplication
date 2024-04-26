using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();

            for (int monthsNum = 1; monthsNum <= 12; monthsNum++)
            {
                comboMonths.Items.Add(monthsNum);
            }

            for (int daysNum = 1; daysNum <= 31; daysNum++)
            {
                comboDays.Items.Add(daysNum);
            }

            for (int yearsNum = 1900; yearsNum <= 2024; yearsNum++)
            {
                comboYears.Items.Add(yearsNum);
            }

            string[] monthsText = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            comboMonths.Items.Clear();

            foreach (string monthName in monthsText)
            {
                
                comboMonths.Items.Add(monthName);
            }

            ArrayList programsList = new ArrayList();
            programsList.Add("Bachelor of Science in Computer Science");
            programsList.Add("Bachelor of Science in Information Technology");
            programsList.Add("Bachelor of Science in Information Systems");
            programsList.Add("Bachelor of Science in Computer Engineering");

            foreach (string programName in programsList)
            {
                comboProgram.Items.Add(programName);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void generateBio(string firstName, string lastName, string program)
        {
            MessageBox.Show(firstName+ " " + lastName + "\n" + program);
        }
        private void generateBio(string firstName, string middleName, string lastName, string program)
        {
            MessageBox.Show(firstName + " " + middleName + " " + lastName + "\n" + program);
        }
        private void generateBio(string firstName, string middleName, string lastName, string gender, string program)
        {
            MessageBox.Show(firstName + " " + middleName + " " + lastName + "\n" + gender + "\n" + program);
        }
        private void generateBio(string firstName, string middleName, string lastName, string birthDate, string month, string year, string program)
        {
            MessageBox.Show(firstName + " " + middleName + " " + lastName + "\n" + birthDate + month + year + "\n" + program);
        }
        private void generateBio(string firstName, string middleName, string lastName, string gender, string birthDate, string month, string year, string program)
        {
            MessageBox.Show(firstName + " " + middleName + " " + lastName + "\n" + gender + "\n" + birthDate + month + year + "\n" + program);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = "Student Name: " + textBox2.Text;
            string middlename = textBox3.Text;
            string lastname = textBox1.Text;
            string gender = "Gender: ";
            string month = "/" + comboMonths.Text + "/";
            string year = comboYears.Text;
            string birthDate = "Date of Birth: " + comboDays.Text;
            string program = "Program: " + comboProgram.Text;
            bool dateAvailable = !(comboDays.Text == "-Day-" || comboDays.Text == "") && !(comboMonths.Text == "-Month-" || comboDays.Text == "") && !(comboYears.Text == "-Year-" || comboDays.Text == "");

            if (radioButton1.Checked == true)
            {
                gender = "Gender: " + radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                gender = "Gender: " + radioButton2.Text;
            }

            if (textBox1.Text != null && textBox2 != null && textBox3 == null && radioButton1 == null && radioButton2 == null && dateAvailable == false && comboProgram.Text != "-Select program-")
            {
                generateBio(firstname, lastname, program);
                
            }
            else if (textBox1 != null && textBox2 != null && textBox3 != null && !radioButton1.Checked && !radioButton2.Checked && dateAvailable == false && comboProgram.Text != "-Select program-")
            {
                generateBio(firstname, middlename, lastname, program);
            }
            else if (textBox1 != null && textBox2 != null && textBox3 != null && !radioButton1.Checked && !radioButton2.Checked && dateAvailable == true && comboProgram.Text != "-Select program-")
            {
                generateBio(firstname, middlename, lastname, birthDate, month, year, program);
            }
            else if (textBox1 != null && textBox2 != null && textBox3 != null && (!radioButton1.Checked || !radioButton2.Checked) && dateAvailable == false && comboProgram.Text != "-Select program-")
            {
                generateBio(firstname, middlename, lastname, gender, program);
            }
            else if (textBox1 != null && textBox2 != null && textBox3 != null && (!radioButton1.Checked || !radioButton2.Checked) && dateAvailable == true && comboProgram.Text != "-Select program-")
            {
                generateBio(firstname, middlename, lastname, gender, birthDate, month, year, program);
            }
            else
            {
                MessageBox.Show("Items with asterisks are required!");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboMonths_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboYears_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFile.Title = "Open Image Files";
            openFile.ShowDialog();

            pictureBox1.Image = Image.FromFile(openFile.FileName);
        }
    }
}
