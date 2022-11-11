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
        public static Dictionary<String, bool> state = new Dictionary<String,bool>();
        public Form1()
        {
            InitializeComponent();
            state.Add("radioButton1",true);
            state.Add("radioButton2",false);
            state.Add("radioButton3",false);
            state.Add("checkBox1",false);
            state.Add("checkBox2",false);
            state.Add("checkBox3",false);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            state["radioButton1"] = radioButton1.Checked;
            richTextBox1.Text += " ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            state["radioButton2"] = radioButton2.Checked;
            richTextBox1.Text += " ";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            state["radioButton3"] = radioButton3.Checked;
            richTextBox1.Text += " ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            state["checkBox1"] = checkBox1.Checked;
            richTextBox1.Text += " ";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            state["checkBox2"] = checkBox2.Checked;
            richTextBox1.Text += " ";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            state["checkBox3"] = checkBox3.Checked;
            richTextBox1.Text += " ";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //whenever the text of richTextBox1 change this method will be called
            //saving logic will be here
            String text = "";
            foreach(KeyValuePair<String,bool> s in state.ToList())
            {
                text += s.Key + "=" + s.Value.ToString() + "\n";
            }
            File.WriteAllText("../../../log.txt", text);
            richTextBox1.Text = text;
        }
    }
}
