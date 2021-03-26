using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Token_Generate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            string input = tb_inp.Text;
            
            char[] whitespace = new char[] { ' '};
            string[] ssizes = input.Split(whitespace);

            //int a1 = ssizes.Length.ToString();
            Hashtable ht = new Hashtable();
            int iter = 0;
            listBox1.Items.Clear();

            foreach (string i in ssizes) {
               listBox1.Items.Add(i);
                ht.Add(iter, i);
                iter++;
            }

            ICollection val = ht.Values;
            
            foreach (string values in val)
            {
                MessageBox.Show(values + ":" + ht[values]);
            }
            MessageBox.Show("Record inserted into HasshTable SuccessFully");
            


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
