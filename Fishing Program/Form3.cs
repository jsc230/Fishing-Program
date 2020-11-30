using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.Json;

namespace Fishing_Program
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        private void getDataButton_Click(object sender, EventArgs e)
        {
            string url = "http://waterservices.usgs.gov/nwis/iv/?format=json&sites=" + "01547200" + "&parameterCd=00060";
            string jsonValue = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = WebRequestMethods.Http.Get;
            request.Accept = "application/json";

            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                jsonValue = sr.ReadToEnd();
            }

            
            var root = JsonSerializer.Deserialize<Rootobject>(jsonValue);

            richTextBox1.Text = root.value.timeSeries[0].values[0].value[0].value.ToString();
           
            
        }
    }
}
