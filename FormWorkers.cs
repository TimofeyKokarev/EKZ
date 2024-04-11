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
    public partial class FormWorkers : Form
    {
        public FormWorkers()
        {
            InitializeComponent();
        }

        private void leftbutton_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void rigthbutton_Click(object sender, EventArgs e)
        {
            Loading(true);
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            Loading();
        }

        public static Model Model = new Model();
        List<Workers> Models = Model.Workers.ToList();
        int Accnumber = 0;
        private void Loading()
        {
            workersControl1.Fill(Models[Accnumber]);
            workersControl2.Fill(Models[Accnumber+1]);
            workersControl3.Fill(Models[Accnumber+2]);
            workersControl4.Fill(Models[Accnumber+3]);
        }
        private void Loading (bool Incr)
        {
            if (Incr == true && Models.Count > Accnumber + 4) Accnumber++;
            else if (Incr == false && 0 <= Accnumber - 1) Accnumber--;
            else return;
            Loading();
        }
    }
}
