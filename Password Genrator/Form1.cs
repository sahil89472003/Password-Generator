using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Genrator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string allvalid = "qwertyuiopadsfjklanvzxmcnvb732238782951745137=19379734304357=3777][\',.,.mQWERTYUIOASDFGHJKLZXCVBNM,.KL;.,<>:";
            string result = "";
            Random random = new Random();
            for (int i = 0; i < 9; i++) 
            {
                result += allvalid[random.Next(0, Convert.ToInt32(allvalid.Length))];
            }
            label1.Text = result;
        }
    }
}
