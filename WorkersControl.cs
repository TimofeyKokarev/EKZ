using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T_L_EKZ.DB_Model;


namespace T_L_EKZ
{
    public partial class WorkersControl : UserControl
    {
        public WorkersControl()
        {
            InitializeComponent();
        }



        public void Fill (Workers Workers)
        {
            label2.Text = Workers.FirstName.ToString();
            label4.Text = Workers.SecondName.ToString();
            label6.Text= Workers.MiddleName.ToString();
            if (File.Exists($@"WorkersPhoto\{Workers.Photo}") == false) Image.FromFile($@"WorkersPhoto\placeholder.png");
            else pictureBox1.Image = Image.FromFile($@"WorkersPhoto\{Workers.Photo}");


        }
    }
}
