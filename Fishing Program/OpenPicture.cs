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
    public partial class OpenPicture : Form
    {
        
        public OpenPicture(string filePath)
        {
            InitializeComponent();
            Console.WriteLine(filePath);
            pictureBox.Image = Image.FromFile(filePath);
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
