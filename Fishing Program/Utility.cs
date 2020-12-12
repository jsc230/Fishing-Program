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

        public static void Alphabetize(string dataFile)
        {
            List<string> fileLines = new List<string>();
            string line;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(dataFile);

                while((line = file.ReadLine()) != null)
                {
                    fileLines.Add(line);
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

            fileLines.Sort();

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(dataFile))
            {
                foreach(string l in fileLines)
                {
                    sw.WriteLine(l);
                }
            }

        }

        
    }
}
