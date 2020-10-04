using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_01_task_maneger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void GetAllProcess()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                listBox1.Items.Add(p.ProcessName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllProcess();
        }
    }
}
