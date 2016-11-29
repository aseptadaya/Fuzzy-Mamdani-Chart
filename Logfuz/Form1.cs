using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logfuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aa, bb, cc;
            double alpha;
            aa = int.Parse(textA.Text);
            bb = int.Parse(textB.Text);
            cc = int.Parse(textC.Text);
            try
            {
                double result;
                if( double.TryParse(textBox4.Text,out result))
                {
                    alpha = double.Parse(textBox4.Text);
                }
                else
                {
                    alpha = 0;
                }
                
            }
            catch (Exception)
            {
                alpha = 0;
                throw;
            }
            

            //Delete all chart
            chart1.Series["Fuzzy Number"].Points.Clear();
            chart1.Series["alpha Cut"].Points.Clear();



            if (alpha == 0)
            {
                chart1.Series["Fuzzy Number"].Points.AddXY(aa, 0);
                chart1.Series["Fuzzy Number"].Points.AddXY(bb, 1);
                chart1.Series["Fuzzy Number"].Points.AddXY(cc, 0);
                labelInterval.Text = "[_   _]";
            }
            else
            {
                chart1.Series["Fuzzy Number"].Points.AddXY(aa, 0);
                chart1.Series["Fuzzy Number"].Points.AddXY(bb, 1);
                chart1.Series["Fuzzy Number"].Points.AddXY(cc, 0);
                double x1, x3;
                x1 = alpha * (bb - aa) + aa;
                x3 = -1 * (alpha * (cc - bb)) + cc;
                Console.WriteLine(x1);
                Console.WriteLine(x3);
                //chart1.Series["alpha Cut"].Points.AddXY(x1, 0);
                chart1.Series["alpha Cut"].Points.AddXY(x1, alpha);
                chart1.Series["alpha Cut"].Points.AddXY(x3, alpha);
                //chart1.Series["alpha Cut"].Points.AddXY(x3, 0);
                labelInterval.Text = "["+x1+"   "+x3+"]";
            }
			chart1.Series["Fuzzy Number"].BorderWidth = 4;
            chart1.Series["Fuzzy Number"].Color = Color.Black;
            chart1.Series["alpha Cut"].BorderWidth = 2;
            chart1.Series["alpha Cut"].Color = Color.Red;
            chart1.Series["alpha Cut"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;


            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textA_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
