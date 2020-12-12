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
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();

            //fill in combobox
            dataToAddComboBox.Items.Add("Fish Type");
            dataToAddComboBox.Items.Add("Location");
            dataToAddComboBox.Items.Add("Gage Location");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (dataToAddComboBox.SelectedIndex)
            {
                case 0:
                    addFish();
                    break;
                case 1:
                    addLocation();
                    break;
                case 2:
                    addGage();
                    break;
            }
        }

        private void dataToAddComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dataToAddComboBox.SelectedIndex == 0)
            {
                dataTypeLabel.Visible = true;
                dataTypeLabel.Text = "Name Of Fish";
                alternateLabel.Visible = false;
                alternateDataTextBox.Visible = false;
            }
            
            if(dataToAddComboBox.SelectedIndex == 1)
            {
                dataTypeLabel.Visible = true;
                dataTypeLabel.Text = "Location To Add";
                alternateLabel.Visible = false;
                alternateDataTextBox.Visible = false;
            }

            if(dataToAddComboBox.SelectedIndex == 2)
            {
                dataTypeLabel.Visible = true;
                dataTypeLabel.Text = "Gage Station Number";
                alternateLabel.Visible = true;
                alternateLabel.Text = "Gage Location Name";
                alternateDataTextBox.Visible = true;
            }
        }

        private void addFish()
        {
            using (StreamWriter sw = File.AppendText("fishtype.txt"))
            {
                sw.WriteLine(dataToAddTextBox.Text);
            }
            Utility.Alphabetize("fishtype.txt");
        }

        private void addLocation()
        {
            using (StreamWriter sw = File.AppendText("location.txt"))
            {
                sw.WriteLine(dataToAddTextBox.Text);
            }
            Utility.Alphabetize("location.txt");
        }

        private void addGage()
        {
            using (StreamWriter sw = File.AppendText("gages.txt"))
            {
                sw.WriteLine(dataToAddTextBox.Text + "-" + alternateDataTextBox.Text);
            }
            Utility.Alphabetize("gages.txt");
        }
    }
}
