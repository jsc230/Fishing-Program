using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Net;

namespace Fishing_Program
{
    public partial class GetStreamConditionsForm : Form
    {

        public string flow;
        public string gage;
        public string[] stationName;
        public string flowInfo;
        public string gageInfo;

        List<string> gagesList = new List<string>();
        public GetStreamConditionsForm()
        {
            InitializeComponent();
            getGages();

            //fill comboboxes
            for(int i = 0; i < gagesList.Count; i++)
            {
                gageLocationComboBox.Items.Add(gagesList[i]);
            }
        }

        private void getConditionsButton_Click(object sender, EventArgs e)
        {
            stationName = this.gageLocationComboBox.GetItemText(this.gageLocationComboBox.SelectedItem).Split('-');
            //write to text box
            flowTextBox.Text = getStreamData(stationName[0], "flow");
            gageTextBox.Text = getStreamData(stationName[0], "gage");
        }

        private string getStreamData(string station, string type)
        {
            string parameter = "";
            string value = "";
            string jsonResponse = "";

            if (type == "flow")
                parameter = "00060";
            else if (type == "gage")
                parameter = "00065";

            string url = "http://waterservices.usgs.gov/nwis/iv/?format=json&sites=" + station + "&parameterCd=" + parameter;

            //data data from server
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = WebRequestMethods.Http.Get;
            request.Accept = "application/json";

            var response = (HttpWebResponse)request.GetResponse();

            using(var sr = new StreamReader(response.GetResponseStream()))
            {
                jsonResponse = sr.ReadToEnd();
            }

            var root = JsonSerializer.Deserialize<Rootobject>(jsonResponse);

            value = root.value.timeSeries[0].values[0].value[0].value.ToString();

            return value;
        }

        private void getGages()
        {
            string line;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("gages.txt");

                while ((line = file.ReadLine()) != null)
                {
                    gagesList.Add(line);
                }
                file.Close();
            }
            catch (Exception e)
            {
                string message = "gages.txt is empty.";
                string caption = "File Empty";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void applyAndCloseButton_Click(object sender, EventArgs e)
        {
            gageInfo = gageTextBox.Text;
            flowInfo = flowTextBox.Text;
            this.Close();
        }
    }
}
