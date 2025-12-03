using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kolokwium1
{
    public partial class Form1 : Form
    {
        private BindingList<Present> presents = new BindingList<Present>();
        private string saveFile = "prezenty.json";

        public Form1()
        {
            InitializeComponent();

            // ustawienia DataGridView
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            LoadData();
            dataGridView1.DataSource = presents;

            UpdateSummary();

            // podpiêcie eventów
            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtGift.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Wype³nij wszystkie pola.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Cena musi byæ liczb¹!");
                return;
            }

            presents.Add(new Present(txtName.Text, txtGift.Text, price));

            SaveData();
            UpdateSummary();

            txtName.Clear();
            txtGift.Clear();
            txtPrice.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz prezent do usuniêcia.");
                return;
            }

            var selected = dataGridView1.SelectedRows[0].DataBoundItem as Present;

            if (selected == null)
                return;

            var dialog = MessageBox.Show(
                $"Czy na pewno chcesz usun¹æ prezent:\n\n" +
                $"{selected.PersonName} - {selected.GiftName} ({selected.Price} z³)?",
                "Potwierdzenie usuniêcia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                presents.Remove(selected);
                SaveData();
                UpdateSummary();
            }
        }

        private void SaveData()
        {
            var json = JsonSerializer.Serialize(presents, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(saveFile, json);
        }

        private void LoadData()
        {
            if (File.Exists(saveFile))
            {
                string json = File.ReadAllText(saveFile);
                var list = JsonSerializer.Deserialize<List<Present>>(json);
                if (list != null)
                    presents = new BindingList<Present>(list);
            }
            else
            {
                presents = new BindingList<Present>();
            }
        }

        private void UpdateSummary()
        {
            lblCount.Text = "" + presents.Count;

            decimal total = 0;
            foreach (var p in presents)
                total += p.Price;

            lblTotal.Text = total + " z³";
        }
    }
}
