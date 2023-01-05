using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigLib.Windows
{
    public partial class Form1 : Form
    {
        // Create a new Configuration object and load the data from a file.
        Configuration configuration = new Configuration("config.xml");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Modify the configuration data.
            configuration.vData.Path = textBox1.Text;

            // Save the configuration data to the file.
            configuration.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            configuration.Load();

            MessageBox.Show(configuration.vData.Path);
        }
    }
}
