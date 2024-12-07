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

namespace WinFormsApp1
{
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void submtbtn_Click(object sender, EventArgs e)
        {

            resultlbl.Text = nametxt.Text;


        }

        private void Controls_Load(object sender, EventArgs e)
        {
            ContrylistBox.Items.Add("Japan");
            ContrylistBox.SelectionMode = SelectionMode.One;
            //ContrylistBox.SelectedIndex = 0;
            //resultlbl.Text = ContrylistBox.SelectedItems.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToString();
        }

        private void Goglelbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start("https://www.google.co.in/");

            From2 fromobj = new From2();
            fromobj.Show();
        }
    }
}
