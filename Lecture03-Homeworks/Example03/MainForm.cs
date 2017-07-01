using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStationLibrary;

namespace Example03
{
    public partial class MainForm : Form
    {
        public WeatherData data;

        public MainForm()
        {
            InitializeComponent();
            data = new WeatherData()
            {
                Temperature = 30,
                Humidity = 90,
                Pressure = 1
            };
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            temperatureLabel.Text = "溫度: " + data.Temperature.ToString();
            humidityLabel.Text = "濕度: " + data.Humidity.ToString("#.##");
            pressureLabel.Text = "壓力: " + data.Pressure.ToString("#.##");
        }
    }
}