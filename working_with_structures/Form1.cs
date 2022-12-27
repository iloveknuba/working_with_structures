using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace working_with_structures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rab[] r = new Rab[10];
        int cout = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                r[cout].Fah = textBox1.Text;
                r[cout].Dekan_PIB = textBox2.Text;
                r[cout].phone_number = Convert.ToInt32(textBox3.Text);
                r[cout].adress = textBox4.Text;


                dataGridView1.Rows.Add(r[cout].Fah, r[cout].Dekan_PIB, r[cout].phone_number.ToString(), r[cout].adress);
                cout++;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string f = textBox5.Text;
            foreach (Rab rr in r)
            {
                if (rr.Fah == f)
                    dataGridView2.Rows.Add(rr.Fah, rr.Dekan_PIB, rr.phone_number.ToString(), rr.adress);


            }
        }
        struct Rab
        {
            public string Fah;
            public string Dekan_PIB;
            public int phone_number;
            public string adress;
            public Rab(string f, string d, int p, string a)
            {
                Fah = f;
                Dekan_PIB = d;
                phone_number = p;
                adress = a;
            }


        }
    }
}
