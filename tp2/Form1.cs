using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2
{
    public partial class Form1 : Form
    {
        BindingList<string> list = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = list;
            list.ListChanged += new ListChangedEventHandler(list_ListChanged);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            list.Add(((RadioButton)sender).Name +"="+ ((RadioButton)sender).Checked);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            list.Add(((RadioButton)sender).Name + "=" + ((RadioButton)sender).Checked);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            list.Add(((RadioButton)sender).Name + "=" + ((RadioButton)sender).Checked);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            list.Add(((CheckBox)sender).Name + "=" + ((CheckBox)sender).Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            list.Add(((CheckBox)sender).Name + "=" + ((CheckBox)sender).Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            list.Add(((CheckBox)sender).Name + "=" + ((CheckBox)sender).Checked);
        }
 
        void list_ListChanged(object sender, ListChangedEventArgs e)
        {
            String text = "";
            foreach (String s in list)
            {
                text += s + "\n";
            }
            File.WriteAllText("../../../log.txt", text);
        }

    }
}
