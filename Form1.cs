using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDEMO
{
    public partial class Form1 : Form
    {
        public string testResults = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Runs the simulation once button is clicked
            MessageBox.Show("Simulation Running...");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //As the simulation runs this moves forward

            //delegates 
            //asycronis -- wait task 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = $"{testResults}";
        }
    }
}
