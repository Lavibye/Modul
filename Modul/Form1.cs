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
        private readonly IBirdReader birdReader;
        private readonly IAviaryWriter aviaryWriter;
        private List<Aviary> aviaries;
        public Form1()
        {
            InitializeComponent();
            birdReader = new BirdReader();
            aviaryWriter = new AviaryWriter();
            aviaries = new List<Aviary>();
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            this.WriteDataButton.Click += new System.EventHandler(this.WriteDataButton_Click);
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
        private void ReadButton_Click(object sender, EventArgs e)
        {
            var birdNames = birdReader.ReadBirds(@"bird_file.txt");

            aviaries.Clear();
            dataGridView1.Rows.Clear();

            // Створення вольєрів для кожного птаха та додавання їх до списку і DataGridView
            foreach (var birdName in birdNames)
            {
                Aviary aviary = AviaryFactory.CreateAviary(birdName);
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
                }
            }
            UpdateTotalArea();
        }
        private void WriteDataButton_Click(object sender, EventArgs e)
        {
            aviaryWriter.WriteAviaries(@"output.txt", aviaries);
            aviaryWriter.WriteCalculations(@"output.txt", GenerateCalculationsText());
        }
        private void UpdateTotalArea()
        {
            // Групування вольєрів за типом і розрахунок сумарної площі для кожної групи
            var totalAreaByType = aviaries
                .GroupBy(a => a.BirdType)
                .Select(group => new
                {
                    BirdType = group.Key,
                    TotalArea = group.Sum(a => a.CalculateTotalArea())
                })
                .ToList();

            aviariesListBox.Items.Clear();

            foreach (var type in totalAreaByType)
            {
                aviariesListBox.Items.Add($"{type.BirdType}: {type.TotalArea} м²");
            }

            double totalArea = totalAreaByType.Sum(group => group.TotalArea);
            aviariesListBox.Items.Add("");
            aviariesListBox.Items.Add($"Сумарна площа всіх вольєрів: {totalArea} м²");
        }
        private string GenerateCalculationsText()
        {
            return string.Join(Environment.NewLine, aviariesListBox.Items.Cast<string>());
        }

    }
}
