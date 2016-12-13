using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dizi_Sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] poem = {"Zannetme ki şöyle böyle bir söz",
"Gel sen dahi söyle böyle bir söz",
"Güzel yüzden ne şöyle böyle bir söz",
"Ne böyle kuru, neyle böyle bir söz"};
        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < poem.Length; i++)
            {
                string hacker = poem[i].IndexOf("söz").ToString();
                if (hacker!="-1")
                {
                    listBox1.Items.Add(hacker);
                }
            }
        }
        string asd = "www.ebubekirbastama.com";
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poem.Length; i++)
            {
                int sayi = int.Parse(listBox1.Items[i].ToString());
                listBox2.Items.Add(poem[i].Substring(0, sayi)+""+asd);
            }
        }
    }
}
