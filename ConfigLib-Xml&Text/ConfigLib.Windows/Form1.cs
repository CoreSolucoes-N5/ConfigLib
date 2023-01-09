using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigLib.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuration config = new Configuration();
            config.Setting1 = textBox1.Text;

            // Save the configuration data to the file.
            ConfigurationHelper.SaveText(config, "config.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Configuration config = new Configuration();
            try
            {
                config = ConfigurationHelper.LoadText("config.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            MessageBox.Show(config.Setting1);
        }
    }
}
