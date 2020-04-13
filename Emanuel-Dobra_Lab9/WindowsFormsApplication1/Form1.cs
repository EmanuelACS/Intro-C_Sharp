using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{    
    public partial class Form1 : Form
    {
        StudentInformation student = new StudentInformation();
        List<string> addedCourses1 = new List<string>();
        List<string> addedCourses2 = new List<string>();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Visible = false;
            comboBox2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox1.Visible = true;
            listBox1.Items.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            comboBox2.Visible = true;
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student.fullName = this.textBox1.Text;
            student.address = this.textBox2.Text;
            student.city = this.textBox3.Text;
            student.province = this.textBox4.Text;
            student.postalCode = this.textBox5.Text;
            student.phoneNumber = this.textBox6.Text;
            richTextBox2.Text = student.ToString();

            richTextBox2.Text += "Courses: ";
            if (radioButton1.Checked)
            {
                for (int j = 0; j < addedCourses1.Count; j++)
                {
                    richTextBox2.Text += addedCourses1[j] + ", ";
                }
            } else if (radioButton2.Checked)
            {
                for (int j = 0; j < addedCourses2.Count; j++)
                {
                    richTextBox2.Text += addedCourses2[j] + ", ";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool appendToCourses = true;
            if (radioButton1.Checked)
            {
                for (int i = 0; i < addedCourses1.Count; i++)
                {
                    if (addedCourses1[i] == comboBox1.Text)
                    {
                        appendToCourses = false;
                    }
                }

                if (appendToCourses)
                {
                    addedCourses1.Add(comboBox1.Text);
                    listBox1.Items.Add(comboBox1.Text);

                }
            } else if (radioButton2.Checked)
            {
                for (int i = 0; i < addedCourses2.Count; i++)
                {
                    if (addedCourses1[i] == comboBox2.Text)
                    {
                        appendToCourses = false;
                    }
                }

                if (appendToCourses)
                {
                    addedCourses2.Add(comboBox2.Text);
                    listBox1.Items.Add(comboBox2.Text);

                }
            }

        }
    }

    public class StudentInformation
    {
        public String fullName { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String province { get; set; }
        public String postalCode { get; set; }
        public String phoneNumber { get; set; }

        public override string ToString()
        {
            return "Name: " + this.fullName + "\n" +
                "Address: " + this.address + "\n";
        }
    }
}
