using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Program
{
    public class Fish
    {
        public string date { get; set; }
        public string time { get; set; }
        public string weather { get; set; }
        public string temperature { get; set; }
        public string barometer { get; set; }
        public string moonPhase { get; set; }
        public string waterClarity { get; set; }
        public string waterTemperature { get; set; }
        public string waterFlow { get; set; }
        public string gageHeight { get; set; }
        public string fishType { get; set; }
        public string length { get; set; }
        public string location { get; set; }
        public string gageLocation { get; set; }
        public string photoName { get; set; }


        public Fish(string date, string time, string weather, string temperature, string barometer, string moonPhase, string waterClarity, string waterTemperature, string waterFlow, string gageHeight, string fishType, string length, string location, string gageLocation, string photoName)
        {
            this.date = date;
            this.time = time;
            this.weather = weather;
            this.temperature = temperature;
            this.barometer = barometer;
            this.moonPhase = moonPhase;
            this.waterClarity = waterClarity;
            this.waterTemperature = waterTemperature;
            this.waterFlow = waterFlow;
            this.gageHeight = gageHeight;
            this.fishType = fishType;
            this.length = length;
            this.location = location;
            this.gageLocation = gageLocation;
            this.photoName = photoName;
        }

        public Fish()
        {

        }

       

    }
}
