using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing_Program
{
    public static class Utility
    {
        public static List<string> getListData(string dataFile)
        {
            List<string> dataList = new List<string>();
            string line;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(dataFile);

                while((line = file.ReadLine()) != null)
                {
                    dataList.Add(line);
                }
                file.Close();
            }
            catch(Exception e)
            {
                string message = dataFile + " is empty.";
                string caption = "File empty";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }

            return dataList;

        }

        public static List<(int, string)> countForAnalysis(List<Fish> fishList, string file)
        {
            List<string> dataList = getListData(file);
            var result = (0, "");
            var results = new List<(int, string)>();
            int[] count = new int[dataList.Count + 1];
            string type = "weather";

            for(int i = 0; i < fishList.Count; i++)
            {
                for(int j = 0; j < dataList.Count; j++)
                {
                    if (fishList[i].type);
                }
            }

            return results;
        }
    }
}
