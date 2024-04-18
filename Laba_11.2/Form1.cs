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

namespace Laba_11._2
{
    public partial class AEROFLOT : Form
    {
        List<Aeroflot> aeroflotList;

        public AEROFLOT()
        {
            InitializeComponent();
        }
        public class Aeroflot
        {
            public string Destination { get; set; }
            public int FlightNumber { get; set; }
            public string AircraftType { get; set; }
        }


        private void gen_button_Click(object sender, EventArgs e)
        {
            {
                aeroflotList = GenerateAeroflotData(10);
                SaveAeroflotDataToFile(aeroflotList);
            }

            List<Aeroflot> GenerateAeroflotData(int count)
            {
                List<Aeroflot> data = new List<Aeroflot>();
                string[] destinations = { "Париж", "Токио", "Лондон", "Нью-Йорк", "Берлин", "Москва", "Сидней", "Дубай", "Рим", "Пекин" };
                string[] aircraftTypes = { "Киря Лёт", "Вика лёт", "Саша Лёт", "Тёма Лёт", "Миша Лёт", "Никитаоаоаоа Лёт" };

                Random random = new Random();

                for (int i = 0; i < count; i++)
                {
                    Aeroflot aeroflot = new Aeroflot
                    {
                        Destination = destinations[random.Next(destinations.Length)],
                        FlightNumber = random.Next(1000, 2000),
                        AircraftType = aircraftTypes[random.Next(aircraftTypes.Length)]
                    };
                    data.Add(aeroflot);
                }

                return data;
            }

            void SaveAeroflotDataToFile(List<Aeroflot> aeroflotData)
            {
                using (StreamWriter writer = new StreamWriter("Рейсы.txt"))
                {
                    foreach (Aeroflot aeroflot in aeroflotData)
                    {
                        writer.WriteLine($"{aeroflot.Destination} {aeroflot.FlightNumber} {aeroflot.AircraftType}");
                    }
                }
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            string filePath = "Рейсы.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string data = reader.ReadToEnd();
                    textBox1.Text = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
            }
        }

        private List<Aeroflot> FilterFlightsByAircraftType(List<Aeroflot> aeroflotData, string aircraftType)
        {
            return aeroflotData.Where(a => a.AircraftType == aircraftType).ToList();
        }

        private void filtr_button_Click(object sender, EventArgs e)
        {
            string aircraftType = textBox3.Text;
            List<Aeroflot> filteredFlights = FilterFlightsByAircraftType(aeroflotList, aircraftType);

            if (filteredFlights.Count > 0)
            {
                filteredFlights = filteredFlights.OrderBy(f => f.Destination).ToList();

                StringBuilder sb = new StringBuilder();
                foreach (Aeroflot flight in filteredFlights)
                {
                    sb.AppendLine($"{flight.Destination} {flight.FlightNumber} {flight.AircraftType}");
                }
                textBox2.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("Нет рейсов, обслуживаемых указанным типом самолета.");
            }
        }
    }
}
