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
        //this with richBoxMethod
        public static Dictionary<String, bool> state = new Dictionary<String,bool>();
        //this with listBox method
        BindingList<string> list = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            //this with richBoxMethod mehod
            state.Add("radioButton1",true);
            state.Add("radioButton2",false);
            state.Add("radioButton3",false);
            state.Add("checkBox1",false);
            state.Add("checkBox2",false);
            state.Add("checkBox3",false);
            //this with listBox Method
            listBox1.DataSource = list;
            list.ListChanged += new ListChangedEventHandler(list_ListChanged);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //this with listBox Method
            list.Add(((RadioButton)sender).Name +"="+ ((RadioButton)sender).Checked);
            //this with richTextBox Method
            state[((RadioButton)sender).Name] = ((RadioButton)sender).Checked;
            richTextBox1.Text += " ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //this with listBox Method
            list.Add(((RadioButton)sender).Name + "=" + ((RadioButton)sender).Checked);
            //this with richTextBox Method
            state[((RadioButton)sender).Name] = ((RadioButton)sender).Checked;
            richTextBox1.Text += " ";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //
            list.Add(((RadioButton)sender).Name + "=" + ((RadioButton)sender).Checked);
            
            state[((RadioButton)sender).Name] = ((RadioButton)sender).Checked;
            richTextBox1.Text += " ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            list.Add(((CheckBox)sender).Name + "=" + ((CheckBox)sender).Checked);
            
            state[((CheckBox)sender).Name] = ((CheckBox)sender).Checked;
            richTextBox1.Text += " ";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            list.Add(((CheckBox)sender).Name + "=" + ((CheckBox)sender).Checked);
            
            state[((CheckBox)sender).Name] = ((CheckBox)sender).Checked;
            richTextBox1.Text += " ";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            list.Add(((CheckBox)sender).Name + "=" + ((CheckBox)sender).Checked);
            
            state[((CheckBox)sender).Name] = ((CheckBox)sender).Checked;
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
        
        void list_ListChanged(object sender, ListChangedEventArgs e)
        {
            String text = "";
            foreach (String s in list)
            {
                text += s + "\n";
            }
            File.WriteAllText("../../../log-ListBox.txt", text);
        }

    }
}
