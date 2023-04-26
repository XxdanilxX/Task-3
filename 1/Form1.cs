using System;

namespace _1
{

    public partial class formClasses : Form
    {
        Country country1;
        Country country2;
        Country country3;
        public string name;
        public int amount, medal;

        public formClasses()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void NameBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void AmountBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void MedalBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


            if (NameBox1.Text == "" || AmountBox1.Text == "" || MedalBox1.Text == "")
            {
                MessageBox.Show("Всі дані мають бути введені!");
            }
            if (NameBox2.Text == "" || AmountBox2.Text == "" || MedalBox2.Text == "")
            {
                MessageBox.Show("Всі дані мають бути введені!");
            }
            if (NameBox3.Text == "" || AmountBox3.Text == "" || MedalBox3.Text == "")
            {
                MessageBox.Show("Всі дані мають бути введені!");
            }
            country1 = new Country(NameBox1.Text, Convert.ToInt32(AmountBox1.Text), Convert.ToInt32(MedalBox1.Text));
            country2 = new Country(NameBox2.Text, Convert.ToInt32(AmountBox2.Text), Convert.ToInt32(MedalBox2.Text));
            country3 = new Country(NameBox3.Text, Convert.ToInt32(AmountBox3.Text), Convert.ToInt32(MedalBox3.Text));
            ResultBox.Text += country1.GetInformation()+ Environment.NewLine;
            ResultBox.Text += country2.GetInformation()+ Environment.NewLine; 
            ResultBox.Text += country3.GetInformation()+ Environment.NewLine; 

        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}