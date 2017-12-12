using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTran_Click(object sender, EventArgs e)
        {
            int r = int.Parse(tbR.Text);
            int g = int.Parse(tbG.Text);
            int b = int.Parse(tbB.Text);
            int min = Math.Min(r, Math.Min(g, b));
            int max = Math.Max(r, Math.Max(g, b));

            int h=0, s, v;
            if (max == min)
                h = 0;
            else if (max == r && g >= b)
                h = 60 * (g - b) / (max - min);
            else if (max == r && g < b)
                h = 60 * (g - b) / (max - min) + 360;
            else if (max == g)
                h = 60 * (b - r) / (max - min) + 120;
            else if (max == b)
                h = 60 * (r - g) / (max - min) + 240;

            if (max == 0)
                s = 0;
            else
                s = (max - min) / max;

            v = max;

            lbH.Text = h.ToString();
            lbS.Text = s.ToString();
            lbV.Text = v.ToString();
        }
    }
}
