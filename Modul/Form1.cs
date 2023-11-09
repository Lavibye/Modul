using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul
{
    public partial class Form1 : Form
    {
        private List<Aviary> aviaries;
        public Form1()
        {
            InitializeComponent();
            aviaries = new List<Aviary>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string birdType = birdNameTextBox.Text;
            Aviary aviary = AviaryFactory.CreateAviary(birdType);
            if (aviary != null)
            {
                aviaries.Add(aviary);
                dataGridView1.Rows.Add(new object[] {
            aviary.BirdType,
            aviary.CalculateTotalArea().ToString() + " м²",
            aviary.WaterArea.ToString() + " м²",
            aviary.TemperatureWater.HasValue ? aviary.TemperatureWater.Value.ToString() + "°C" : "N/A",
            aviary.TemperatureAir.HasValue ? aviary.TemperatureAir.Value.ToString() + "°C" : "N/A"
        });
                birdNameTextBox.Clear();
                UpdateTotalArea();
            }
            else
            {
                MessageBox.Show("Невідомий тип птаха. Потрібно писати з маленької літери", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateTotalArea()
        {
            // Розрахунок сумарної площі для кожного типу вольєра
            var totalAreaByType = aviaries
                .GroupBy(a => a.BirdType)
                .Select(group => new
                {
                    BirdType = group.Key,
                    TotalArea = group.Sum(a => a.CalculateTotalArea())
                })
                .ToList();

            // Розрахунок сумарної площі всіх вольєрів
            double totalArea = totalAreaByType.Sum(t => t.TotalArea);

            aviariesListBox.Items.Clear();

            // Додавання інформації про сумарну площу кожного типу вольєра до ListBox
            foreach (var type in totalAreaByType)
            {
                aviariesListBox.Items.Add($"{type.BirdType}: {type.TotalArea} м²");
            }

            // Додавання загальної сумарної площі всіх вольєрів
            aviariesListBox.Items.Add($"Сумарна площа всіх вольєрів: {totalArea} м²");
        }


    }
}
