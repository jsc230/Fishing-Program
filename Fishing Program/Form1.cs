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
        List<string> locationList = new List<string>();
                

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
        string location;
        string gageLocation;
        string photoName;

        string photoDirectory;

        bool inputValidated;

        public Form1()
        {
            
            InitializeComponent();
            
            //get the lists that will fill the combo boxes
            //todo: add lure type
            weatherTypesList = Utility.getListData("weather.txt");
            fishTypesList = Utility.getListData("fishtype.txt");
            waterClarityList = Utility.getListData("waterclarity.txt");
            moonPhasesList = Utility.getListData("moonphases.txt");
            locationList = Utility.getListData("location.txt");

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
            for(int i = 0; i < locationList.Count; i++)
            {
                locationComboBox.Items.Add(locationList[i]);
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
            location = this.locationComboBox.GetItemText(this.locationComboBox.SelectedItem);
            gageLocation = gageLocationTextBox.Text;
            photoName = photoDirectory;

            inputValidated = validateInput();

            if (inputValidated)
            {
                using (StreamWriter sw = File.AppendText("fishdata.data"))
                {
                    sw.WriteLine(date + "," + time + "," + weather + "," + temperature + "," + barometer + "," + moonPhase + "," + waterClarity + "," + waterTemperature + "," + waterFlow + "," + gageHeight + "," + fishType + "," + fishLength + "," + location + "," + gageLocation + "," + photoName);
                }
                MessageBox.Show("Recorded");
            }
            else
            {
                MessageBox.Show("Error in input data.", "Error!");
            }
           

        }    
        
        private bool validateInput()
        {
            if(this.weatherComboBox.SelectedIndex == -1 || this.waterClarityComboBox.SelectedIndex == -1 || this.fishTypeComboBox.SelectedIndex == -1 || this.moonPhaseComboBox.SelectedIndex == -1 || this.locationComboBox.SelectedIndex == -1)
            {
                return false;
            }

            try
            {
                int.Parse(temperature);
                double.Parse(fishLength);
                double.Parse(barometer);
                int.Parse(waterTemperature);
                double.Parse(waterFlow);
                double.Parse(gageHeight);
            }
            catch
            {
                return false;
            }

            return true;
            
        }

        private void openSearchbutton_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
        }

        private void getCurrentStreamConditionsButton_Click(object sender, EventArgs e)
        {
            GetStreamConditionsForm gcscf = new GetStreamConditionsForm();
            gcscf.ShowDialog();
            if(gcscf.flowInfo != null && gcscf.gageInfo != null)
            {
                this.gageHeightTextBox.Text = gcscf.gageInfo;
                this.waterFlowTextBox.Text = gcscf.flowInfo;
                this.gageLocationTextBox.Text = gcscf.gageLocation;
            }
        }

        private void dataAnalysisButton_Click(object sender, EventArgs e)
        {
            DataAnalysisForm daf = new DataAnalysisForm();
            daf.ShowDialog();
        }

        private void openSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
        }

        private void dataAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAnalysisForm daf = new DataAnalysisForm();
            daf.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                   
                }
           
        }

        private void addToDataTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDataForm adf = new AddDataForm();
            adf.ShowDialog();
        }

        private void includePhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(open.ShowDialog() == DialogResult.OK)
            {
                string time = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
                System.IO.File.Copy(open.FileName, @"photos\" + time + ".jpg");
                photoDirectory = @"\\photos\" + time + ".jpg";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm ab = new AboutForm();
            ab.ShowDialog();
        }
    }
}
