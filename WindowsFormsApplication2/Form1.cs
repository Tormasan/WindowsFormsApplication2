using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        string _dataPath  = "leszokás.xml" ;


        public Form1()
        {
            InitializeComponent();
            this.dataSet11.ReadXml(_dataPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataSet11.WriteXml(_dataPath);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = ""+this.dataSet11.leszokás.Rows[0][1];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // fasz =dataSet11.leszokás.Rows[1].ToString;

        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int[] inputs;
            for (int i = 1; i <= 5; i++)
            {
                inputs = dataSet11.leszokás.Rows[i][0];
            }
            
        }
    }
}
