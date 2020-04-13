using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Pizza_Shop
{
    public partial class Form1 : Form
    {
        UserInformation user = new UserInformation();
        List<PizzaInformation> pizzaList = new List<PizzaInformation>();
        double pizzaSizeCost = 0.00;
        double pizzaToppingsCost = 0.00;
        double orderTotal = 0.00;
        
        public Form1()
        {
            InitializeComponent();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Small")
            {
                pizzaSizeCost = 5;
            }
            else if (comboBox2.Text == "Medium")
            {
                pizzaSizeCost = 6.5;
            }
            else if (comboBox2.Text == "Large")
            {
                pizzaSizeCost = 8;
            }
            else if (comboBox2.Text == "Extra Large")
            {
                pizzaSizeCost = 9.5;
            }
            label5.Text = "$ " + (pizzaToppingsCost + pizzaSizeCost).ToString();  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                pizzaToppingsCost += .75;
            }
            else
            {
                pizzaToppingsCost -= .75;
            }
            label5.Text = "$ " + (pizzaToppingsCost + pizzaSizeCost).ToString();            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                pizzaToppingsCost += .75;
            }
            else
            {
                pizzaToppingsCost -= .75;
            }
            label5.Text = "$ " + (pizzaToppingsCost + pizzaSizeCost).ToString();    
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                pizzaToppingsCost += .75;
            }
            else
            {
                pizzaToppingsCost -= .75;
            }
            label5.Text = "$ " + (pizzaToppingsCost + pizzaSizeCost).ToString();    
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                pizzaToppingsCost += .75;
            }
            else
            {
                pizzaToppingsCost -= .75;
            }
            label5.Text = "$ " + (pizzaToppingsCost + pizzaSizeCost).ToString();    
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                pizzaToppingsCost += .75;
            }
            else
            {
                pizzaToppingsCost -= .75;
            }
            label5.Text = "$ " + (pizzaToppingsCost + pizzaSizeCost).ToString();    

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                pizzaToppingsCost += .75;
            }
            else
            {
                pizzaToppingsCost -= .75;
            }
            label5.Text = "$ " + (pizzaToppingsCost + pizzaSizeCost).ToString();    
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                pizzaToppingsCost += .75;
            }
            else
            {
                pizzaToppingsCost -= .75;
            }
            label5.Text = "$ " + (pizzaToppingsCost + pizzaSizeCost).ToString();    
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                pizzaToppingsCost += .75;
            }
            else
            {
                pizzaToppingsCost -= .75;
            }
            label5.Text = "$ " + (pizzaToppingsCost + pizzaSizeCost).ToString();    
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                pizzaToppingsCost += .75;
            }
            else
            {
                pizzaToppingsCost -= .75;
            }
            label5.Text = "$ " + (pizzaToppingsCost + pizzaSizeCost).ToString();    
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.orderNumber = textBox1.Text;
            user.customerName = textBox2.Text;
            user.phoneNumber = textBox3.Text;
            user.deliveryAddress = textBox4.Text;
            richTextBox1.Text = user.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false; 
            checkBox6.Checked = false; 
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            label5.Text = "$ 0.00";
            pizzaSizeCost = 0;
            pizzaToppingsCost = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PizzaInformation pizza = new PizzaInformation();
            pizza.pizzaShop = comboBox1.Text;
            pizza.pizzaType = comboBox2.Text;
            if (checkBox1.Checked == true)
            {
                pizza.toppings[0] = checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                pizza.toppings[1] = checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                pizza.toppings[2] = checkBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                pizza.toppings[3] = checkBox4.Text;
            }
            if (checkBox5.Checked == true)
            {
                pizza.toppings[4] = checkBox5.Text;
            }
            if (checkBox6.Checked == true)
            {
                pizza.toppings[5] = checkBox6.Text;
            }
            if (checkBox7.Checked == true)
            {
                pizza.toppings[6] = checkBox7.Text;
            }
            if (checkBox8.Checked == true)
            {
                pizza.toppings[7] = checkBox8.Text;
            }
            if (checkBox9.Checked == true)
            {
                pizza.toppings[8] = checkBox9.Text;
            }
            pizza.pizzaCost = pizzaToppingsCost + pizzaSizeCost;
            orderTotal += pizza.pizzaCost;
            pizzaList.Add(pizza);
            richTextBox2.Text += pizza.ToString();
            pizza = new PizzaInformation();
            label10.Text = "$ " + orderTotal.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            user = new UserInformation();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pizzaList = new List<PizzaInformation>();
            richTextBox2.Text = "";
            orderTotal = 0;
            label10.Text = "$ 0.00";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

    public class UserInformation
    {
        public string orderNumber { get; set; }
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string deliveryAddress { get; set; }

        public override string ToString()
        {
 	         return "Order Number: " + orderNumber + "\n" +
                    "Name: " + customerName + "\n" + 
                    "Phone Numebr: " + phoneNumber + "\n" +
                    "Address: " + deliveryAddress + "\n"; 
        }
    }

    public class PizzaInformation
    {
        public string pizzaShop { get; set; }
        public string pizzaType { get; set; }
        public string[] toppings = {"", "", "", "", "", "", "", "", ""};
        public double pizzaCost { get; set;}

        public double toppingsCost()
        {
            return (toppings.Length) * .75;
        }

        public string printToppings()
        {
            string tops = "";
            for (int i = 0; i < toppings.Length; i++)
            {
                if (!(toppings[i] == "")) 
                {
                    tops += toppings[i] + ", ";
                }
            }
            return tops;
        }

        public override string ToString()
        {
            return "Shop: " + pizzaShop + ", Type: " +
                   pizzaType + ", Toppings: " + printToppings() +
                   "Cost: " + pizzaCost + "\n";
        }
    }
}
