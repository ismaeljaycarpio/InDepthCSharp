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
        //[System.Runtime.InteropServices.DllImport("kernel32.dll")]
        //private static extern bool AllocConsole();

        public Form1()
        {
            //AllocConsole();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strInput = Console.ReadLine();
            label1.Text = strInput;
        }
    }
}
