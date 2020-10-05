using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class Form1_rendszam : Form
    {
        public Form1_rendszam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox1_rendszam.Text))
            {
                MessageBox.Show("Nem töltötte ki a rendszám mezőt!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1_rendszam.Focus();
            }

            else if (String.IsNullOrEmpty(comboBox1_gepjarmuTipusa.Text))
            {
                MessageBox.Show("Nem választotta ki a gépjármű típusát!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1_gepjarmuTipusa.Focus();
            }

            else if (String.IsNullOrEmpty(textBox2_gyartasiIdo.Text))
            {
                MessageBox.Show("Nem töltötte ki a gyártási idő mezőt!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2_gyartasiIdo.Focus();
            }

            else if (String.IsNullOrEmpty(textBox3_teljesitmeny.Text))
            {
                MessageBox.Show("Nem töltötte ki a teljesítmény mezőt!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3_teljesitmeny.Focus();
            }

            else
            {
                Gepjarmu gepjarmu = new Gepjarmu();
                gepjarmu.rendszam = textBox1_rendszam.Text;
                gepjarmu.tipus = comboBox1_gepjarmuTipusa.Text;
                gepjarmu.gyartasEv = Convert.ToInt32(textBox2_gyartasiIdo.Text);
                gepjarmu.teljesitmeny = Convert.ToInt32(textBox3_teljesitmeny.Text);

                listBox1_rogzitettAdatok.Items.Add(gepjarmu);
            }
        }

        class Gepjarmu
        {
            public string rendszam;
            public string tipus;
            public int gyartasEv;
            public int teljesitmeny;

            public override string ToString()
            {
                return "Rendszám: " + rendszam + " " + "Típus: " + tipus + " " + "Gyártási év: " + gyartasEv + " " + "Teljesítmény: " + teljesitmeny;
            }
        }

        private void listBox1_rogzitettAdatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gepjarmu gepjarmu = (Gepjarmu) listBox1_rogzitettAdatok.Items[listBox1_rogzitettAdatok.SelectedIndex];
            textBox1_rendszam.Text = gepjarmu.rendszam;
            comboBox1_gepjarmuTipusa.Text = gepjarmu.tipus;
            textBox2_gyartasiIdo.Text = Convert.ToString(gepjarmu.gyartasEv);
            textBox3_teljesitmeny.Text = Convert.ToString(gepjarmu.teljesitmeny);
        }
    }
}
