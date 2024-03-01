﻿using System;
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

            
            for(int daysNum = 1; daysNum <= 31; daysNum++)
            {
                comboDays.Items.Add(daysNum);
            }

            for (int monthsNum = 1; monthsNum <= 12; monthsNum++)
            {
                comboMonths.Items.Add(monthsNum);
            }

            for (int yearsNum = 1900; yearsNum <= 2024; yearsNum++)
            {
                comboYears.Items.Add(yearsNum);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1 != null && textBox2 != null && textBox3 != null && radioButton1 != null && radioButton2 != null && comboDays.Text != "-Day-" && comboMonths.Text != "-Month-" && comboYears.Text != "-Year-")
            {
                string studentName = "Student Name: " + textBox3.Text + " " + textBox1.Text + " " + textBox2.Text;
                string gender = "Gender: ";
                string birthDate = "Date of Birth: " + comboDays.Text + "/" + comboMonths.Text + "/" + comboYears.Text;

                if (radioButton1.Checked == true)
                {
                    gender = "Gender: " + radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    gender = "Gender: " + radioButton2.Text;
                }

                MessageBox.Show(studentName + "\n" + gender + "\n" + birthDate);
            }
            else
            {
                MessageBox.Show("Items with asterisks are required! Please try again.");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }
    }
}