using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T_L_EKZ.DB_Model;

namespace T_L_EKZ
{
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        private void FormDirectorLoad(object sender, EventArgs e)
        {
            Model model = new Model();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormWorkers formWorkers = new FormWorkers();
            formWorkers.ShowDialog();
        }
    }
}
