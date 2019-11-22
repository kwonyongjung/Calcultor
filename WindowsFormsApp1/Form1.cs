using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string m_sLable1Text = null;
        string m_sLable2Text = null;
        char m_cCalcLable;
        float m_nCalc1 = 0;
        float m_nCalc2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            m_sLable2Text += '1';
            label2.Text = m_sLable2Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_sLable2Text += '2';
            label2.Text = m_sLable2Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m_sLable2Text += '3';
            label2.Text = m_sLable2Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m_sLable2Text += '4';
            label2.Text = m_sLable2Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            m_sLable2Text += '5';
            label2.Text = m_sLable2Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            m_sLable2Text += '6';
            label2.Text = m_sLable2Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            m_sLable2Text += '7';
            label2.Text = m_sLable2Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            m_sLable2Text += '8';
            label2.Text = m_sLable2Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            m_sLable2Text += '9';
            label2.Text = m_sLable2Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (m_sLable2Text == null) { return; }
            m_sLable2Text += '0';
            label2.Text = m_sLable2Text;
        }

        private void buttonPot_Click(object sender, EventArgs e)
        {
            m_sLable2Text += '.';
            label2.Text = m_sLable2Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (m_nCalc1 == 0)
            {
                m_nCalc1 = Convert.ToSingle(m_sLable2Text);
            }
            else
            {
                m_nCalc2 = Convert.ToSingle(m_sLable2Text);
            }
            switch (m_cCalcLable)
            {
                case '+':
                    m_nCalc1 += m_nCalc2;
                    break;
                case '-':
                    m_nCalc1 -= m_nCalc2;
                    break;
                case '*':
                    m_nCalc1 *= m_nCalc2;
                    break;
                case '/':
                    m_nCalc1 /= m_nCalc2;
                    break;
                case '%':
                    m_nCalc1 %= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                default:
                    break;
            }
            m_sLable1Text += m_sLable2Text;
            m_sLable1Text += '+';
            label1.Text = m_sLable1Text;
            m_cCalcLable = '+';
            m_sLable2Text = null;
            label2.Text = Convert.ToString(m_nCalc1);

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (m_nCalc1 == 0)
            {
                m_nCalc1 = Convert.ToSingle(m_sLable2Text);
            }
            else
            {
                m_nCalc2 = Convert.ToSingle(m_sLable2Text);
            }
            switch (m_cCalcLable)
            {
                case '+':
                    m_nCalc1 += m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '-':
                    m_nCalc1 -= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '*':
                    m_nCalc1 *= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '/':
                    m_nCalc1 /= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '%':
                    m_nCalc1 %= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                default:
                    break;
            }
            m_sLable1Text += m_sLable2Text;
            m_sLable1Text += '-';
            label1.Text = m_sLable1Text;
            m_cCalcLable = '-';
            m_sLable2Text = null;
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            m_nCalc2 = 1;
            if (m_nCalc1 == 0)
            {
                m_nCalc1 = Convert.ToSingle(m_sLable2Text);
            }
            else
            {
                m_nCalc2 = Convert.ToSingle(m_sLable2Text);
            }
            switch (m_cCalcLable)
            {
                case '+':
                    m_nCalc1 += m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '-':
                    m_nCalc1 -= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '*':
                    m_nCalc1 *= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '/':
                    m_nCalc1 /= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '%':
                    m_nCalc1 %= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                default:
                    break;
            }
            m_sLable1Text += m_sLable2Text;
            m_sLable1Text += '*';
            label1.Text = m_sLable1Text;
            m_cCalcLable = '*';
            m_sLable2Text = null;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            m_nCalc2 = 1;
            if (m_nCalc1 == 0)
            {
                m_nCalc1 = Convert.ToSingle(m_sLable2Text);
            }
            else
            {
                m_nCalc2 = Convert.ToSingle(m_sLable2Text);
            }
            switch (m_cCalcLable)
            {
                case '+':
                    m_nCalc1 += m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '-':
                    m_nCalc1 -= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '*':
                    m_nCalc1 *= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '/':
                    m_nCalc1 /= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '%':
                    m_nCalc1 %= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                default:
                    break;
            }
            m_sLable1Text += m_sLable2Text;
            m_sLable1Text += '/';
            label1.Text = m_sLable1Text;
            m_cCalcLable = '/';
            m_sLable2Text = null;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            m_nCalc2 = Convert.ToSingle(m_sLable2Text);
            m_sLable2Text = null;
            switch (m_cCalcLable)
            {
                case '+':
                    m_nCalc1 += m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '-':
                    m_nCalc1 -= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '*':
                    m_nCalc1 *= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '/':
                    m_nCalc1 /= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '%':
                    m_nCalc1 %= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                default:
                    break;
            }
            if (label3.Text == null)
            {
                label3.Text = label1.Text;
                label4.Text = label2.Text;
            }
            else if (label5.Text == null)
            {
                label5.Text = label1.Text;
                label6.Text = label2.Text;
            }
            else if (label7.Text == null)
            {
                label7.Text = label1.Text;
                label8.Text = label2.Text;
            }
            else if (label9.Text == null)
            {
                label9.Text = label1.Text;
                label10.Text = label2.Text;
            }
            else if (label11.Text == null)
            {
                label11.Text = label1.Text;
                label12.Text = label2.Text;
            }
            else if (label13.Text == null)
            {
                label13.Text = label1.Text;
                label14.Text = label2.Text;
            }
            else if (label15.Text == null)
            {
                label15.Text = label1.Text;
                label16.Text = label2.Text;
            }
            else if (label17.Text == null)
            {
                label17.Text = label1.Text;
                label18.Text = label2.Text;
            }
            else if (label19.Text == null)
            {
                label19.Text = label1.Text;
                label20.Text = label2.Text;
            }
            m_sLable1Text = null;
            m_nCalc1 = 0;
            m_nCalc2 = 0;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (m_sLable2Text == null) { return; }
            m_sLable2Text = m_sLable2Text.Remove(m_sLable2Text.Length-1,1);
            label2.Text = m_sLable2Text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            m_sLable2Text = null;
            m_sLable1Text = null;
            label2.Text = m_sLable2Text;
            label1.Text = m_sLable1Text;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            m_sLable2Text = null;
            label2.Text = m_sLable2Text;
        }

        private void buttonRemainder_Click(object sender, EventArgs e)
        {
            m_nCalc2 = 1;
            if (m_nCalc1 == 0)
            {
                m_nCalc1 = Convert.ToSingle(m_sLable2Text);
            }
            else
            {
                m_nCalc2 = Convert.ToSingle(m_sLable2Text);
            }
            switch (m_cCalcLable)
            {
                case '+':
                    m_nCalc1 += m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '-':
                    m_nCalc1 -= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '*':
                    m_nCalc1 *= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '/':
                    m_nCalc1 /= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '%':
                    m_nCalc1 %= m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                default:
                    break;
            }
            m_sLable1Text += m_sLable2Text;
            m_sLable1Text += '%';
            label1.Text = m_sLable1Text;
            m_cCalcLable = '%';
            m_sLable2Text = null;
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            if (m_nCalc1 == 0)
            {
                m_nCalc1 = Convert.ToSingle(m_sLable2Text);
            }
            else
            {
                m_nCalc2 = Convert.ToSingle(m_sLable2Text);
            }
            switch (m_cCalcLable)
            {
                case '+':
                    m_nCalc1 += (float)Math.Sqrt(m_nCalc2);
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '-':
                    m_nCalc1 -= (float)Math.Sqrt(m_nCalc2);
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '*':
                    m_nCalc1 *= (float)Math.Sqrt(m_nCalc2);
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '/':
                    m_nCalc1 /= (float)Math.Sqrt(m_nCalc2);
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '%':
                    m_nCalc1 %= (float)Math.Sqrt(m_nCalc2);
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                default:
                    m_nCalc1 = (float)Math.Sqrt(m_nCalc1);
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
            }
            if (m_sLable1Text == null)
            {
                m_sLable1Text = "√(" + m_sLable2Text + ")";
            }
            else
            {
                if(m_cCalcLable == '√')
                    m_sLable1Text = "√(" + m_sLable1Text + ")";
                else
                {
                    m_sLable1Text += "√(" + m_sLable2Text + ")";
                }
            }
            label1.Text = m_sLable1Text;
            m_cCalcLable = '√';
            m_sLable2Text = null;
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (m_nCalc1 == 0)
            {
                m_nCalc1 = Convert.ToSingle(m_sLable2Text);
            }
            else
            {
                m_nCalc2 = Convert.ToSingle(m_sLable2Text);
            }
            switch (m_cCalcLable)
            {
                case '+':
                    m_nCalc1 += m_nCalc2*m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '-':
                    m_nCalc1 -= m_nCalc2 * m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '*':
                    m_nCalc1 *= m_nCalc2 * m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '/':
                    m_nCalc1 /= m_nCalc2 * m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '%':
                    m_nCalc1 %= m_nCalc2 * m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                default:
                    m_nCalc1 *= m_nCalc1;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
            }
            if(m_sLable1Text == null)
            {
                m_sLable1Text = "sqr(" + m_sLable2Text + ")";
            }
            else
            {
                if (m_cCalcLable == '^')
                    m_sLable1Text = "sqr(" + m_sLable1Text + ")";
                else
                    m_sLable1Text += "sqr(" + m_sLable2Text + ")";
            }
            label1.Text = m_sLable1Text;
            m_cCalcLable = '^';
            m_sLable2Text = null;
        }

        private void buttonReciprocal_Click(object sender, EventArgs e)
        {
            if (m_nCalc1 == 0)
            {
                m_nCalc1 = Convert.ToSingle(m_sLable2Text);
            }
            else
            {
                m_nCalc2 = Convert.ToSingle(m_sLable2Text);
            }
            switch (m_cCalcLable)
            {
                case '+':
                    m_nCalc1 += 1 / m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '-':
                    m_nCalc1 -= 1 / m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '*':
                    m_nCalc1 *= 1 / m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '/':
                    m_nCalc1 /= 1 / m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                case '%':
                    m_nCalc1 %= 1 / m_nCalc2;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
                default:
                    m_nCalc1 = 1 / m_nCalc1;
                    label2.Text = Convert.ToString(m_nCalc1);
                    break;
            }
            if(m_sLable1Text == null)
            {
                m_sLable1Text = "1 / (" + m_sLable2Text + ")";
                label1.Text = m_sLable1Text;
            }
            else
            {
                if(m_cCalcLable == '^')
                    m_sLable1Text = "1 / (" + m_sLable1Text + ")";
                else
                {
                    m_sLable1Text += "1 / (" + m_sLable2Text + ")";
                }
            }
            label1.Text = m_sLable1Text;
            m_cCalcLable = '^';
            m_sLable2Text = null;
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            float temp = Convert.ToSingle(m_sLable2Text);
            temp *= -1;
            m_sLable2Text = Convert.ToString(temp);
            label2.Text = m_sLable2Text;
        }
    }
}