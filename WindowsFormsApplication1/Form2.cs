using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string str1, string str2, string str3, string str4)
        {
            InitializeComponent();
            pointDisplay.Text = str1;
            uniquePointDisplay.Text = str2;
            uniqueAngleDisplay.Text = str3;
            rayDisplay.Text = str4;
        }
        
    }
}
