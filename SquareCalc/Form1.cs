using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int lower_limit = 0;
            int upper_limit = 10;
            int countBy = 1;
            listBox1.Items.Clear();
            try
            {
                lower_limit = int.Parse(txt_lowerLimit.Text);
                upper_limit = int.Parse(txt_upperLimit.Text);
                countBy = int.Parse(txt_countBy.Text);

                if(lower_limit > upper_limit)
                {
                    //swap
                    int temp = lower_limit;
                    lower_limit = upper_limit;
                    upper_limit = temp;
                }
            }
            catch { MessageBox.Show("Only numbers"); }

            for (int i = lower_limit; i <= upper_limit; i = i + countBy)
            {
                listBox1.Items.Add("i = " + i + " squared = " + i * i);
            }

        }
    }
}
