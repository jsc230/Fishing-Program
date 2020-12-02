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
                location = parts[12]
            };
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            string line;
            Fish fish;
            string searchType = this.fishTypeComboBox.GetItemText(this.fishTypeComboBox.SelectedItem);

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
        }
    }
}
