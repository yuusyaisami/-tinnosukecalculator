using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Form1 : Form
    {
        double[] value = new double[30];
        int count=0;
        string CanViewValue = null;
        bool s = false, d = false, m = false, p = false,dot = false;
        double Answer;
        public Form1()
        {
            InitializeComponent();
        }
        bool CanEnzan()
        {
            if (s == true) return false;
            else if (d == true) return false;
            else if (m == true) return false;
            else if (p == true) return false;
            else return true;

        }
        void ifzerof()
        {
            if(CanViewValue == "0" || CanViewValue == "00")
            {
                CanViewValue = null;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ifzerof();
            CanViewValue = CanViewValue + "1";
            numbers.Text = CanViewValue;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            ifzerof();
            CanViewValue = CanViewValue + "2";
            numbers.Text = CanViewValue;
        }

        private void nunber3_Click(object sender, EventArgs e)
        {
            ifzerof();
            CanViewValue = CanViewValue + "3";
            numbers.Text = CanViewValue;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            ifzerof();
            CanViewValue = CanViewValue + "4";
            numbers.Text = CanViewValue;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            ifzerof();
            CanViewValue = CanViewValue + "5";
            numbers.Text = CanViewValue;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            ifzerof();
            CanViewValue = CanViewValue + "6";
            numbers.Text = CanViewValue;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            ifzerof();
            CanViewValue = CanViewValue + "7";
            numbers.Text = CanViewValue;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            ifzerof();
            CanViewValue = CanViewValue + "8";
            numbers.Text = CanViewValue;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            ifzerof();
            CanViewValue = CanViewValue + "9";
            numbers.Text = CanViewValue;
        }
        

        private void number0_Click(object sender, EventArgs e)
        {
            ifzerof();
            CanViewValue = CanViewValue + "0";
            numbers.Text = CanViewValue;
        }

        private void number00_Click(object sender, EventArgs e)
        {
            ifzerof();
            if (CanViewValue != null ) CanViewValue = CanViewValue + "00";
            else CanViewValue = "0";
            numbers.Text = CanViewValue;
        }

        private void numberdot_Click(object sender, EventArgs e)
        {
            if (dot == false)
            {
                CanViewValue = CanViewValue + ".";
                numbers.Text = CanViewValue;
                dot = true;
            }

        }

        private void numberslash_Click(object sender, EventArgs e)
        {
            if (CanEnzan() == true)
            {
                dot = false;
                value[count] = Convert.ToDouble(CanViewValue);
                CanViewValue = "0";
                s = true;
                count++;
            }
        }

        private void numberX_Click(object sender, EventArgs e)
        {
            if (CanEnzan() == true)
            {
                dot = false;
                value[count] = Convert.ToDouble(CanViewValue);
                CanViewValue = "0";
                d = true;
                count++;
            }
        }

        private void numberplus_Click(object sender, EventArgs e)
        {
            if (CanEnzan() == true)
            {
                dot = false;
                value[count] = Convert.ToDouble(CanViewValue);
                CanViewValue = "0";
                p = true;
                count++;
            }
        }

        private void numberminus_Click(object sender, EventArgs e)
        {
            if (CanEnzan() == true)
            {
                dot = false;
                value[count] = Convert.ToDouble(CanViewValue);
                CanViewValue = "0";
                m = true;
                count++;
            }
        }

        private void numberequal_Click(object sender, EventArgs e)
        {
            value[count] = Convert.ToDouble(CanViewValue);
            if (s == true && value[count] == 0)
            {
                MessageBox.Show("この数値は割り切れません　値をリセットします - Error");
                for (int i = 0; i < 30; i++) value[i] = 0;
                CanViewValue = "0";
                numbers.Text = CanViewValue;
                count = 0;
                s = d = m = p = false;
                dot = false;
            }
            else
            {
                if (s == true) value[count + 1] = value[count - 1] / value[count];
                if (d == true) value[count + 1] = value[count - 1] * value[count];
                if (m == true) value[count + 1] = value[count - 1] - value[count];
                if (p == true) value[count + 1] = value[count - 1] + value[count];

                CanViewValue = value[count + 1].ToString();
                numbers.Text = CanViewValue;
                count++;
                s = d = m = p = false;
                dot = false;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numbersave_Click(object sender, EventArgs e)
        {
            if (pullupnumber.Value == 1) Savebox1.Text = CanViewValue;
            if (pullupnumber.Value == 2) Savebox2.Text = CanViewValue;
            if (pullupnumber.Value == 3) Savebox3.Text = CanViewValue;
            if (pullupnumber.Value == 4) Savebox4.Text = CanViewValue;
            if (pullupnumber.Value == 5) Savebox5.Text = CanViewValue;
        }

        private void pullupnumber_ValueChanged(object sender, EventArgs e)
        {
            if(pullupnumber.Value <= 0) pullupnumber.Value = 1;
            if(pullupnumber.Value > 5) pullupnumber.Value = 5;
            Savenumber.Text = pullupnumber.Value.ToString();
        }
        //-------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------
        private void Savenumber_Click(object sender, EventArgs e)
        {
            

        }

        private void Savebox1_Click(object sender, EventArgs e)
        {

        }

        private void Savebox2_Click(object sender, EventArgs e)
        {

        }

        private void Savebox3_Click(object sender, EventArgs e)
        {

        }

        private void Savebox4_Click(object sender, EventArgs e)
        {

        }

        private void Savebox5_Click(object sender, EventArgs e)
        {

        }

        private void numberClear_Click(object sender, EventArgs e)
        {
            CanViewValue = "0";
            numbers.Text = CanViewValue;
            dot = false;
        }

        private void numberAllClear_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 30; i++) value[i] = 0;
            CanViewValue = "0";
            numbers.Text = CanViewValue;
            count = 0;
            s = d = m = p = false;
            dot = false;
        }
        private void numbers_Click(object sender, EventArgs e)
        {

        }
    }
}
