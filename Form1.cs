using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        ICalculate cal;
        public Form1()
        {
            InitializeComponent();
            cal = new Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool valiInput()
        {
            bool isValid = true;
            if (txtNum01.Value == 0)
            {
                isValid = false;
                MessageBox.Show("please enter Number 01");
            }
            else
            {
                if (txtNum02.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("please enter Number 02");

                }
                else
                {
                    isValid = true;
                }

            }

            return isValid;

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if(valiInput())
            {
                int sum = cal.Sum((int)txtNum01.Value, (int)txtNum02.Value);
                MessageBox.Show("Sum is ="+ sum);

            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (valiInput())
            {
                int minus = cal.Minus((int)txtNum01.Value, (int)txtNum02.Value);
                MessageBox.Show("Minus is =" + minus);

            }

        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (valiInput())
            {
                int multiple = cal.Multiple((int)txtNum01.Value, (int)txtNum02.Value);
                MessageBox.Show("Multiple is =" + multiple);

            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (valiInput())
            {
                int multiple = cal.Multiple((int)txtNum01.Value, (int)txtNum02.Value);
                MessageBox.Show("Multiple is =" + multiple);

            }

        }
    }
}
