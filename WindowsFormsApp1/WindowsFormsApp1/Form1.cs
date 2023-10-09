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
        bool opto = false;
        double hesab = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txto.Text= "0";
        }

        private void Eded(object sender, EventArgs e)
        {
            if (txto.Text=="0" || opto)
                txto.Clear();
            opto=false;

            Button btn=(Button)sender;
            txto.Text+=btn.Text;
        }

        private void opt1(object sender, EventArgs e)
        {
            opto=true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            lbo.Text=lbo.Text+" "+txto.Text+" "+yeniOpt;
            switch (opt)
            {
                case "+":txto.Text=(hesab+ Double.Parse(txto.Text)).ToString(); break;
                case "-": txto.Text=(hesab- Double.Parse(txto.Text)).ToString(); break;
                case "*": txto.Text=(hesab* Double.Parse(txto.Text)).ToString(); break;
                case "/": txto.Text=(hesab/ Double.Parse(txto.Text)).ToString(); break;
            }
            hesab=Double.Parse(txto.Text);
            txto.Text=hesab.ToString();
            opt=yeniOpt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txto.Text="0";
            lbo.Text= "";
            opt= "";
            hesab=0;
            opto= false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lbo.Text= "";
            opto=true;
            switch (opt)
            {
                case "+": txto.Text=(hesab+ Double.Parse(txto.Text)).ToString(); break;
                case "-": txto.Text=(hesab- Double.Parse(txto.Text)).ToString(); break;
                case "*": txto.Text=(hesab* Double.Parse(txto.Text)).ToString(); break;
                case "/": txto.Text=(hesab/ Double.Parse(txto.Text)).ToString(); break;
            }
            hesab=Double.Parse(txto.Text);
            txto.Text=hesab.ToString();
            opt= "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txto.Text=="0")
            {
                txto.Text="0";
            }
            else if (opto)
            {
                txto.Text="0";
            }
            if (!txto.Text.Contains("."))
            {
                txto.Text+=",";
            }
            opto=false;
        }
    }
}
