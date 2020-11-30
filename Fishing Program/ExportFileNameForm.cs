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
    public partial class exportFileNameForm : Form
    {
        public string CSVName;
        public exportFileNameForm()
        {
            InitializeComponent();
        }

        private void exportOKButton_Click(object sender, EventArgs e)
        {
            CSVName = fileNameTextBox.Text;
            this.Close();
        }
    }
}
