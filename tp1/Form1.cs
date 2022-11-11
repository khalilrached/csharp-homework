using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpMaisonExercice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(element.Text.Trim());
            element.Clear();
            btnDel1.Enabled = true;
            btnSwipeR.Enabled = true;
            element.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = element.Text.Trim() != "";
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            btnDel1.Enabled = false;
            btnSwipeR.Enabled = false;
        }

        private void btnSwipeR_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndices.Count == 0) { return; }
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int Position = listBox1.SelectedIndices[i];
                listBox2.Items.Add(listBox1.Items[Position]);
                listBox1.Items.RemoveAt(Position);
            }
            btnDel1.Enabled     = listBox1.Items.Count != 0;
            btnDel2.Enabled     = true;
            btnSwipeR.Enabled   = listBox1.Items.Count != 0;
            btnSwipeL.Enabled   = true;

        }

        private void btSwipeL_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndices.Count == 0) { return; }
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int Position = listBox2.SelectedIndices[i];
                listBox1.Items.Add(listBox2.Items[Position]);
                listBox2.Items.RemoveAt(Position);
            }
            btnDel1.Enabled     = true;
            btnDel2.Enabled     = listBox2.Items.Count != 0;
            btnSwipeR.Enabled   = true;
            btnSwipeL.Enabled   = listBox2.Items.Count != 0;

        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
            btnDel2.Enabled     = false;
            btnDel1.Enabled     = true;
            btnSwipeL.Enabled   = false;
            btnSwipeR.Enabled   = true;
        }
    }
}

