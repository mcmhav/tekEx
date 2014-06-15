using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DB;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private Peeps pe;

        public Form1()
        {
            InitializeComponent();

            pe = Peeps.Ins();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.textBox1.Text.Trim();
            
            ArrayList sp = pe.searcher(s);

            this.listBox1.Items.Clear();

            foreach (Person p in sp)
            {
                this.listBox1.Items.Add(p.toString());
            }
        }
    }
}
