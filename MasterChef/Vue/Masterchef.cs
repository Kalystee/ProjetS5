using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vue
{
    public partial class Masterchef : Form
    {
        public Masterchef()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string nbr_client;
            nbr_client = comboBox2.Text;
            int nbr_clientint = Convert.ToInt32(nbr_client);
            string nom_client = textBox2.Text;
            switch (nbr_clientint)
            {
                case 1:
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    break;

                case 2:
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    break;

                case 3:
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    break;

                case 4:
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;

                    break;

                case 5:
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    break;

                case 6:
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    break;

                case 7:
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = false;
                    break;

                case 8:
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    break;



            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int secondInt = Convert.ToInt32(second.Text);
            if (secondInt < 59)
            {
                second.Text = Convert.ToString(secondInt + 1);
            }
            else
            {
                second.Text = "0";
                int minuteInt = Convert.ToInt32(minute.Text);
                if (minuteInt < 59)
                {
                    minute.Text = Convert.ToString(minuteInt + 1);
                }
                else
                {
                    minute.Text = "0";
                    int hourInt = Convert.ToInt32(hour.Text);
                    if (hourInt < 23)
                    {
                        hour.Text = Convert.ToString(hourInt + 1);
                    }
                    else
                    {
                        hour.Text = "0";
                        int dayInt = Convert.ToInt32(day.Text);
                        if (dayInt < 7)
                        {
                            day.Text = Convert.ToString(dayInt + 1);
                        }
                        else
                        {
                            day.Text = "0";
                        }
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void second_TextChanged(object sender, EventArgs e)
        {

        }

        private void day_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void minute_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Lunch")
            {
                timer1.Stop();
                second.Text = "0";
                minute.Text = "0";
                hour.Text = "12";
                day.Text = "0";
            }
            if (comboBox1.SelectedItem == "Dinner")
            {
                timer1.Stop();
                second.Text = "0";
                minute.Text = "0";
                hour.Text = "19";
                day.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Lunch")
            {
                second.Text = "0";
                minute.Text = "0";
                hour.Text = "12";
                day.Text = "0";
            }
            if (comboBox1.SelectedItem == "Dinner")
            {
                second.Text = "0";
                minute.Text = "0";
                hour.Text = "19";
                day.Text = "0";
            }
        }

        private void Masterchef_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
