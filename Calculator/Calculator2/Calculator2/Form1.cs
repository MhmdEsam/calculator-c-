
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class DesignCalculator : Form
    {
        string first = "";
        string second = "";
        string userinput = "";
        char function;
        double result = 0.0;
        
        public DesignCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userinput;
            userinput = "";
        }

        private void DesignDivide_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userinput;
            userinput = "";
        }

        private void Design1_Click(object sender, EventArgs e)
        {
            CalculatorDesign.Text = "";
            userinput += "1";
            CalculatorDesign.Text += userinput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Design2_Click(object sender, EventArgs e)
        {
            CalculatorDesign.Text = "";
            userinput += "2";
            CalculatorDesign.Text += userinput;
        }

        private void DesignDot_Click(object sender, EventArgs e)
        {
            
            userinput += ".";
            
        }

        private void Design3_Click(object sender, EventArgs e)
        {
            CalculatorDesign.Text = "";
            userinput += "3";
            CalculatorDesign.Text += userinput;
        }

        private void Design4_Click(object sender, EventArgs e)
        {
            CalculatorDesign.Text = "";
            userinput += "4";
            CalculatorDesign.Text += userinput;
        }

        private void Design5_Click(object sender, EventArgs e)
        {
            CalculatorDesign.Text = "";
            userinput += "5";
            CalculatorDesign.Text += userinput;
        }

        private void Design6_Click(object sender, EventArgs e)
        {
            CalculatorDesign.Text = "";
            userinput += "6";
            CalculatorDesign.Text += userinput;
        }

        private void Design7_Click(object sender, EventArgs e)
        {
            CalculatorDesign.Text = "";
            userinput += "7";
            CalculatorDesign.Text += userinput;
        }

        private void Design8_Click(object sender, EventArgs e)
        {
            CalculatorDesign.Text = "";
            userinput += "8";
            CalculatorDesign.Text += userinput;
        }

        private void Design9_Click(object sender, EventArgs e)
        {
            CalculatorDesign.Text = "";
            userinput += "9";
            CalculatorDesign.Text += userinput;
        }

        private void DesignMinus_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userinput;
            userinput = "";
        }

        private void Design0_Click(object sender, EventArgs e)
        {
            CalculatorDesign.Text = "";
            userinput += "0";
            CalculatorDesign.Text += userinput;
        }

        private void DesignPlus_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userinput;
            userinput = "";
        }

        private void DesignEqual_Click(object sender, EventArgs e)
        {
            second = userinput;
            double firstnum, secondnum;
            firstnum = Convert.ToDouble(first);
            secondnum = Convert.ToDouble(second);
            switch (function)
            {
                //plus
                case '+':
                    result = firstnum + secondnum;
                    CalculatorDesign.Text = result.ToString();
                    break;
                //minus
                case '-':
                     result = firstnum - secondnum;
                    CalculatorDesign.Text = result.ToString();
                    break;
                //muliyply
                case '*':
                    result = firstnum * secondnum;
                    CalculatorDesign.Text = result.ToString();
                    break;
                //divide
                case '/':
                    result = firstnum / secondnum;
                    CalculatorDesign.Text = result.ToString();
                    break;
            }

        }

        private void DesignDelete_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userinput = "";
            result = 0.0;
            CalculatorDesign.Text = "Calculator";

        }
    }
}
