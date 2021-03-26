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

namespace HASH_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable()
            {
                {"Id", int.Parse(tb_ID.Text)},
                {"Name", tb_name.Text},
                {"Designation", tb_des.Text},
                {"Salary", int.Parse(tb_sal.Text)}

            };
            ICollection keys = ht.Keys;

            
            foreach (string k in keys)
            {
                MessageBox.Show(k + ":" + ht[k]);
            }
            MessageBox.Show("Inserted Sucessfully");

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (cb_show.SelectedIndex == 0) {
                MessageBox.Show(tb_ID.Text);
            }
            else if (cb_show.SelectedIndex == 1)
            {
                MessageBox.Show(tb_name.Text);
            }
            else if (cb_show.SelectedIndex == 2)
            {
                MessageBox.Show(tb_des.Text);
            }
            else if (cb_show.SelectedIndex == 3)
            {
                MessageBox.Show(tb_sal.Text);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
