using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing_Program
{
    public partial class Form1 : Form
    {
        List<string> weatherTypesList = new List<string>();
        List<string> fishTypesList = new List<string>();
        List<string> waterClarityList = new List<string>();
        List<string> moonPhasesList = new List<string>();
                

        string weather;
        string temperature;
        string waterClarity;
        string fishType;
        string fishLength;
        string date;
        string time;
        string barometer;
        string waterTemperature;
        string waterFlow;
        string gageHeight;
        string moonPhase;

        public Form1()
        {
            InitializeComponent();
            getWeather();
            getFishType();
            getWaterClarity();
            getMoonPhases();

            //Fill ComboBoxes
            for(int i = 0; i < weatherTypesList.Count; i++)
            {
                weatherComboBox.Items.Add(weatherTypesList[i]);
            }
            for (int i = 0; i < fishTypesList.Count; i++)
            {
                fishTypeComboBox.Items.Add(fishTypesList[i]);
            }
            for (int i = 0; i < waterClarityList.Count; i++)
            {
                waterClarityComboBox.Items.Add(waterClarityList[i]);
            }
            for(int i = 0; i < moonPhasesList.Count; i++)
            {
                moonPhaseComboBox.Items.Add(moonPhasesList[i]);
            }
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            weather = this.weatherComboBox.GetItemText(this.weatherComboBox.SelectedItem);
            temperature = temperatureTextBox.Text;
            waterClarity = this.waterClarityComboBox.GetItemText(this.waterClarityComboBox.SelectedItem);
            fishType = this.fishTypeComboBox.GetItemText(this.fishTypeComboBox.SelectedItem);
            moonPhase = this.moonPhaseComboBox.GetItemText(this.moonPhaseComboBox.SelectedItem);
            fishLength = lengthTextBox.Text;
            date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            barometer = barometerTextBox.Text;
            waterTemperature = waterTemperatureTextBox.Text;
            waterFlow = waterFlowTextBox.Text;
            gageHeight = gageHeightTextBox.Text;
            time = dateTimePickerTime.Value.ToString("HH:mm");


            using (StreamWriter sw = File.AppendText("fishdata.data"))
            {
                sw.WriteLine(date + "," + time + "," + weather + "," + temperature + "," + barometer + "," + moonPhase + "," + waterClarity + "," + waterTemperature + "," + waterFlow + "," + gageHeight + "," + fishType + "," + fishLength);
            }

            MessageBox.Show("Recorded");

        }

        private void getWeather()
        {
            string line;
            
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("weather.txt");

                while ((line = file.ReadLine()) != null)
                {
                    weatherTypesList.Add(line);
                }
                file.Close();
            }
            catch(Exception e)
            {
                string message = "weather.txt is empty.";
                string caption = "File Empty";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }            
        }

        private void getFishType()
        {
            string line;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("fishtype.txt");

                while ((line = file.ReadLine()) != null)
                {
                    fishTypesList.Add(line);
                }
                file.Close();
            }
            catch (Exception e)
            {
                string message = "fishtype.txt is empty.";
                string caption = "File Empty";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void getWaterClarity()
        {
            string line;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("waterclarity.txt");

                while ((line = file.ReadLine()) != null)
                {
                    waterClarityList.Add(line);
                }
                file.Close();
            }
            catch (Exception e)
            {
                string message = "waterclarity.txt is empty.";
                string caption = "File Empty";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void getMoonPhases()
        {
            string line;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("moonphases.txt");

                while ((line = file.ReadLine()) != null)
                {
                    moonPhasesList.Add(line);
                }
                file.Close();
            }
            catch (Exception e)
            {
                string message = "moonphases.txt is empty.";
                string caption = "File Empty";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

              

        private void openSearchbutton_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
        }
    }
}
