using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kolokwium1
{
    public partial class Form1 : Form
    {
        private List<Present> presents = new List<Present>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtGift.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Wype³nij wszystkie pola!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Cena musi byæ liczb¹!");
                return;
            }

            // dodanie prezentu
            Present p = new Present(txtName.Text, txtGift.Text, price);
            presents.Add(p);

            // odœwie¿enie tabeli
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = presents;

            UpdateSummary();

            // czyœcimy pola
            txtName.Clear();
            txtGift.Clear();
            txtPrice.Clear();
        }

        private void UpdateSummary()
        {
            lblCount.Text =""+ presents.Count;
            decimal total = 0;

            foreach (var p in presents)
                total += p.Price;

            lblTotal.Text = total + " z³";
        }
    }
}

