using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fishing_Program
{
    public partial class SearchForm : Form
    {
        List<Fish> fishSearchResultList = new List<Fish>();
        List<string> fishTypesList = new List<string>();
        StringBuilder searchsb = new StringBuilder();

        public SearchForm()
        {
            InitializeComponent();

            //get the lists that will fill the comboboxes
            fishTypesList = Utility.getListData("fishtype.txt");

            //fill comboboxes
            for(int i = 0; i < fishTypesList.Count; i++)
            {
                fishTypeSearchComboBox.Items.Add(fishTypesList[i]);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string line;
            Fish fish;
            string searchType = this.fishTypeSearchComboBox.GetItemText(this.fishTypeSearchComboBox.SelectedItem);

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

            for (int i = 0; i < fishSearchResultList.Count; i++)
            {
                Console.WriteLine(fishSearchResultList[i].barometer + " " + fishSearchResultList[i].fishType);

                searchsb.AppendLine(fishSearchResultList[i].barometer + " " + fishSearchResultList[i].fishType);
            }

            searchRichTextBox.Text = searchsb.ToString();
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

       
        private void exportCSVButton_Click(object sender, EventArgs e)
        {
            exportFileNameForm efnf = new exportFileNameForm();

            efnf.ShowDialog();

            using (StreamWriter sw = File.AppendText(efnf.CSVName + ".csv"))
            {
                sw.WriteLine("Date" + "," + "Time" + "," + "Weather" + "," + "Temperature" + "," + "Barometer" + "," + "Moon Phase" + "," + "Water Clarity" + "," + "Water Temperature" + "," + "Water Flow" + "," + "Gage Height" + "," + "Fish Type" + "," + "Length" + "," + "Location" + "," + "Gage Location");

                for(int i = 0; i < fishSearchResultList.Count; i++)
                {
                    sw.WriteLine(fishSearchResultList[i].date + "," + fishSearchResultList[i].time + "," + fishSearchResultList[i].weather + "," + fishSearchResultList[i].temperature + "," + fishSearchResultList[i].barometer + "," + fishSearchResultList[i].moonPhase + "," + fishSearchResultList[i].waterClarity + "," + fishSearchResultList[i].waterTemperature + "," + fishSearchResultList[i].waterFlow + "," + fishSearchResultList[i].gageHeight + "," + fishSearchResultList[i].fishType + "," + fishSearchResultList[i].length + "," + fishSearchResultList[i].location + "," + fishSearchResultList[i].gageLocation);

                }
            }
        }

        
    }
}
