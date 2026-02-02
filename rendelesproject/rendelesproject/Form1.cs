using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rendelesproject
{
    public partial class Form1 : Form
    {
        static List<string> rendelesek = new List<string>();
        static int vegosszeg = 0;

        public Form1()
        {
            InitializeComponent();
        }
        int hamburgerAra = 0;
        

        private void rendeles_Click(object sender, EventArgs e)
        {
            // 4 fajta burger közül lehet választani és mindegyiknek van egy ára és mérete valamint hogy milyen zöldséget kér hozzá az ügyfél és önteteket is választhat hozzá, lehet többet is rendelni, ahányszor a megrendelem gombot nyomom le és a végén pedig kiírja a vég összeget és a megrendelő nevét valamint van egy kezdem elölről gomb ami mindent kitöröl és elölről kezdi a rendelést

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile("csirkes.png");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile("marhas.jpg");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Image.FromFile("jobbsertes.png");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = Image.FromFile("halas.jpg");


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                hamburgerAra = 1000;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                hamburgerAra = 1500;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                hamburgerAra = 2000;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hamburgerAra += Convert.ToInt32(checkedListBox1.CheckedItems.Count) * 100;
        }

        private void kalkulal_Click(object sender, EventArgs e)
        {
            hamburgerAra += Convert.ToInt32(checkedListBox1.CheckedItems.Count) * 100;
            hamburgerAra += Convert.ToInt32(checkedListBox2.CheckedItems.Count) * 100;
            vegosszeg += hamburgerAra;
            rendelesek.Add(textBox1.Text + " - " + comboBox1.SelectedItem.ToString() + " - " + comboBox2.SelectedItem.ToString()  + " - Ár: " + hamburgerAra + " Ft");
            hamburgerAra = 0;
            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, false);
            checkedListBox1.SetItemChecked(3, false);
            checkedListBox1.SetItemChecked(4, false);
            checkedListBox2.SetItemChecked(0, false);
            checkedListBox2.SetItemChecked(1, false);
            checkedListBox2.SetItemChecked(2, false);
            checkedListBox2.SetItemChecked(3, false);
            checkedListBox2.SetItemChecked(4, false);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            label8.Text = vegosszeg + " Ft";
            nev.Text = textBox1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vegosszeg = 0;
            rendelesek.Clear();
            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, false);
            checkedListBox1.SetItemChecked(3, false);
            checkedListBox1.SetItemChecked(4, false);
            checkedListBox2.SetItemChecked(0, false);
            checkedListBox2.SetItemChecked(1, false);
            checkedListBox2.SetItemChecked(2, false);
            checkedListBox2.SetItemChecked(3, false);
            checkedListBox2.SetItemChecked(4, false);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            label8.Text = "0 Ft";
            nev.Text = "";
            hamburgerAra = 0;
        }
    }
}
