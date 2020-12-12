using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing_Program
{
    public partial class DataAnalysisForm : Form
    {
        List<string> fishTypesList = new List<string>();
        List<string> dataTypesList = new List<string>();
        List<string> gageLocationsWNames = new List<string>();
        List<Fish> fishSearchResultList = new List<Fish>();
        StringBuilder searchsb = new StringBuilder();
        public DataAnalysisForm()
        {
            InitializeComponent();

            //get the lists that will fill the combo boxes
            fishTypesList = Utility.getListData("fishtype.txt");
            dataTypesList = Utility.getListData("datatypes.txt");
            //fill combobox
            for (int i = 0; i < fishTypesList.Count; i++)
            {
                fishTypeComboBox.Items.Add(fishTypesList[i]);
            }
            for(int i = 0; i < dataTypesList.Count; i++)
            {
                dataTypesComboBox.Items.Add(dataTypesList[i]);
            }
        }
               

        private static Fish ParseFishFromLine(string line)
        {
            string[] parts = line.Split(',');
            return new Fish
            {
                date = parts[0],
                time = parts[1],
                weather = parts[2],
                temperature = parts[3],
                barometer = parts[4],
                moonPhase = parts[5],
                waterClarity = parts[6],
                waterTemperature = parts[7],
                waterFlow = parts[8],
                gageHeight = parts[9],
                fishType = parts[10],
                length = parts[11],
                location = parts[12],
                gageLocation = parts[13]
            };
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            string line;
            Fish fish;
            string searchType = this.fishTypeComboBox.GetItemText(this.fishTypeComboBox.SelectedItem);
            int dataType = this.dataTypesComboBox.SelectedIndex;
            var dataSet = new List<(int, string)>(); //tuple list
            dataSet.Clear();

            fishSearchResultList.Clear();
            searchsb.Clear();

            System.IO.StreamReader file = new System.IO.StreamReader("fishdata.data");

            while ((line = file.ReadLine()) != null)
            {
                fish = ParseFishFromLine(line);

                if (fish.fishType == searchType)
                {
                    fishSearchResultList.Add(fish);
                }
            }

            switch (dataType)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    dataSet = countWeather(fishSearchResultList);
                    break;
                case 3:
                    dataSet = countTemperature(fishSearchResultList);
                    break;
                case 4:
                    dataSet = countBarometer(fishSearchResultList);
                    break;
                case 5:
                    dataSet = countMoonPhases(fishSearchResultList);
                    break;
                case 6:
                    dataSet = countWaterClarity(fishSearchResultList);
                    break;
                case 7:
                    dataSet = countWaterTemperature(fishSearchResultList);
                    break;
                case 8:
                    dataSet = countWaterFlow(fishSearchResultList);
                    break;
                case 9:
                    dataSet = countGageHeight(fishSearchResultList);
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                default:
                    MessageBox.Show("Select a data type.");
                    break;
            }

            fillChart(dataSet);

        }

        private List<(int, string)> countMoonPhases(List<Fish> fishList)
        {
            List<string> Phases = Utility.getListData("moonphases.txt");
            var result = (0, "a");
            var results = new List<(int, string)>();
            int[] count = new int[Phases.Count + 1];
            

            for (int i = 0; i < fishList.Count; i++)
            {
                for (int j = 0; j < Phases.Count; j++)
                {
                    if (fishList[i].moonPhase == Phases[j])
                    {
                        count[j]++;
                    }
                }
            }

            for(int i = 0; i < Phases.Count; i++)
            {
                result = (count[i], Phases[i]);
                results.Add(result);
            }

            return results;
        }

        private List<(int, string)> countWeather(List<Fish> fishList)
        {
            List<string> Weather = Utility.getListData("weather.txt");
            var result = (0, "a");
            var results = new List<(int, string)>();
            int[] count = new int[Weather.Count + 1];

            for(int i = 0; i < fishList.Count; i++)
            {
                for(int j = 0; j < Weather.Count; j++)
                {
                    if(fishList[i].weather == Weather[j])
                    {
                        count[j]++;
                    }
                }
            }

            for(int i = 0; i < Weather.Count; i++)
            {
                result = (count[i], Weather[i]);
                results.Add(result);
            }

            return results;
        }

        private List<(int, string)> countWaterClarity(List<Fish> fishList)
        {
            List<string> WaterClarity = Utility.getListData("waterclarity.txt");
            var result = (0, "a");
            var results = new List<(int, string)>();
            int[] count = new int[WaterClarity.Count + 1];

            for (int i = 0; i < fishList.Count; i++)
            {
                for (int j = 0; j < WaterClarity.Count; j++)
                {
                    if (fishList[i].waterClarity == WaterClarity[j])
                    {
                        count[j]++;
                    }
                }
            }

            for (int i = 0; i < WaterClarity.Count; i++)
            {
                result = (count[i], WaterClarity[i]);
                results.Add(result);
            }

            return results;
        }

        
        private List<(int, string)> countTemperature(List<Fish> fishList)
        {
            var result = (0, "a");
            var results = new List<(int, string)>();
            var temperaturesList = new List<int>();
            int roundedNum;


            for (int i = 0; i < 20; i++)
            {
                temperaturesList.Add(i * 5);
            }

            int[] count = new int[temperaturesList.Count + 1];

            for(int i = 0; i < fishList.Count; i++)
            {
                roundedNum = (int)(Math.Round(Int32.Parse(fishList[i].temperature) / 5.0) * 5);

                for(int j = 0; j < temperaturesList.Count; j++)
                {
                    if(roundedNum == temperaturesList[j])
                    {
                        count[j]++;
                    }
                }
            }

            for(int i = 0; i < temperaturesList.Count; i++)
            {
                result = (count[i], temperaturesList[i].ToString());
                results.Add(result);
            }
                       

            return results;
        }

        private List<(int, string)> countWaterTemperature(List<Fish> fishList)
        {
            var result = (0, "a");
            var results = new List<(int, string)>();
            var waterTemperaturesList = new List<int>();
            int roundedNum;


            for (int i = 0; i < 20; i++)
            {
                waterTemperaturesList.Add(i * 5);
            }

            int[] count = new int[waterTemperaturesList.Count + 1];

            for (int i = 0; i < fishList.Count; i++)
            {
                roundedNum = (int)(Math.Round(Int32.Parse(fishList[i].waterTemperature) / 5.0) * 5);

                for (int j = 0; j < waterTemperaturesList.Count; j++)
                {
                    if (roundedNum == waterTemperaturesList[j])
                    {
                        count[j]++;
                    }
                }
            }

            for (int i = 0; i < waterTemperaturesList.Count; i++)
            {
                result = (count[i], waterTemperaturesList[i].ToString());
                results.Add(result);
            }


            return results;
        }

        private List<(int, string)> countBarometer(List<Fish> fishList)
        {
            var result = (0, "");
            var results = new List<(int, string)>();
            var barometer = new List<double>();
            double barometerMin;
            double barometerMax;
            double bucketSize;
            List<double> buckets = new List<double>();
            int[] count = new int[20];

            //clean out lists
            results.Clear();
            barometer.Clear();
            buckets.Clear();

            //load barometers into list
            for(int i = 0; i < fishList.Count; i++)
            {
                barometer.Add(double.Parse(fishList[i].barometer));
            }

            //get min and max
            barometerMax = barometer.Max();
            barometerMin = barometer.Min();

            //find bucket sizes
            bucketSize = (barometerMax - barometerMin) / 20;

            //fill in bucket list
            for(int i = 0; i < 21; i++)
            {
                buckets.Add(barometerMin + (i * bucketSize));
            }

            //take the barometers and put them into the buckets
            for (int i = 0; i < buckets.Count - 1; i++)
            {
                for (int j = 0; j < barometer.Count; j++)
                {
                    if ((barometer[j] > buckets[i]) && (barometer[j] <= buckets[i + 1]))
                    {
                        count[i]++;
                    }
                }
            }

            //put results into results list
            for (int i = 0; i < count.Length; i++)
            {
                result = (count[i], buckets[i] + "->" + buckets[i + 1]);
                results.Add(result);
            }

            return results;
        }

                
        private List<(int, string)> countWaterFlow(List<Fish> fishList)
        {
            var result = (0, "");
            var results = new List<(int, string)>();
            var flows = new List<double>();
            //var roundedFlowList = new List<int>();
            string[] station;
            int stationNum;
            double flowMin;
            double flowMax;
            double bucketSize;
            List<double> buckets = new List<double>();
            int[] count = new int[20];

            station = this.alternateDataComboBox.GetItemText(this.alternateDataComboBox.SelectedItem).Split('-');
            stationNum = int.Parse(station[0]);

            //clean out lists for new items
            results.Clear();
            flows.Clear();
            buckets.Clear();
          
            
            //need to find the high and low flow rates, then break it into even buckets (maybe 15 or 20)

            //load flows from selected station into a list
            for(int i = 0; i < fishList.Count; i++)
            {
                if(int.Parse(fishList[i].gageLocation) == stationNum)
                {
                    flows.Add(double.Parse(fishList[i].waterFlow));
                }
                
            }

            //find min and max
            flowMax = flows.Max();
            flowMin = flows.Min();

            
            //find bucket ranges

            bucketSize = (flowMax - flowMin) / 20;

            //fill in buckets list
           
            for(int i = 0; i < 21; i++)
            {
                buckets.Add(flowMin + (i * bucketSize));
            }

            //take the fish flows and put them intothe flow rate buckets

            for(int i = 0; i < buckets.Count - 1; i++)
            {
                for(int j = 0; j < flows.Count; j++)
                {
                    if((flows[j] > buckets[i]) && (flows[j] <= buckets[i + 1]))
                    {
                        count[i]++;
                    }
                }
            }

            //put results into results list
            for(int i = 0; i < count.Length; i++)
            {
                result = (count[i], buckets[i] + "->" + buckets[i + 1]);
                results.Add(result);
            }

            return results;
        }

        private List<(int, string)> countGageHeight(List<Fish> fishList)
        {

            var result = (0, "");
            var results = new List<(int, string)>();
            var gages = new List<double>();
            //var roundedGageList = new List<int>();
            string[] station;
            int stationNum;
            double gageMin;
            double gageMax;
            double bucketSize;
            List<double> buckets = new List<double>();
            int[] count = new int[20];

            station = this.alternateDataComboBox.GetItemText(this.alternateDataComboBox.SelectedItem).Split('-');
            stationNum = int.Parse(station[0]);

            //clean out lists for new items
            results.Clear();
            gages.Clear();
            buckets.Clear();

            //load gages from selected station into a list
            for(int i = 0; i < fishList.Count; i++)
            {
                if(int.Parse(fishList[i].gageLocation) == stationNum)
                {
                    gages.Add(double.Parse(fishList[i].gageHeight));
                }
            }

            //find min and max
            gageMin = gages.Min();
            gageMax = gages.Max();

            //find bucket ranges
            bucketSize = (gageMax - gageMin) / 20;

            //fill in buckets List
            for(int i = 0; i < 21; i++)
            {
                buckets.Add(gageMin + (i * bucketSize));
            }

            //take the fish gage height and put them into the gage height bckets
            for(int i = 0; i < buckets.Count - 1; i++)
            {
                for(int j = 0; j < gages.Count; j++)
                {
                    if((gages[j] > buckets[i]) && (gages[j] <= buckets[i + 1]))
                    {
                        count[i]++;
                    }
                }
            }

            //put results into results list
            for(int i = 0; i < count.Length; i++)
            {
                result = (count[i], buckets[i] + "->" + buckets[i + 1]);
                results.Add(result);
            }

            return results;
        }

        private void fillChart(List<(int, string)> dataSet)
        {
            chart1.Series["Series"].Points.Clear();
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dataSet.Count; i++)
            {
                chart1.Series["Series"].Points.AddXY(dataSet[i].Item2, dataSet[i].Item1);
            }
            
        }

        private void dataTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //make sure combobox is clear
            alternateDataComboBox.Items.Clear();

            if(dataTypesComboBox.SelectedIndex == 8 || dataTypesComboBox.SelectedIndex == 9)
            {
                alternateDataComboBox.Visible = true;

                gageLocationsWNames = Utility.getListData("gages.txt");

                //fill alternate data combo box
                for (int i = 0; i < gageLocationsWNames.Count; i++)
                {
                    alternateDataComboBox.Items.Add(gageLocationsWNames[i]);
                }
            }
            else
            {
                alternateDataComboBox.Visible = false;
            }
        }
    }
}
