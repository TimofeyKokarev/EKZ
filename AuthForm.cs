using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T_L_EKZ.DB_Model;

namespace T_L_EKZ
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        public static Workers Enter_Worker;

        private void AuthButton_Click(object sender, EventArgs e)
        {
            Enter_Worker = null;
            Model model = new Model();
            Enter_Worker = model.Workers.FirstOrDefault(x => x.Login == LoginBox.Text && x.Password == PasswordBox.Text);
            if (Enter_Worker != null)
            {
                switch (Enter_Worker.RoleID)
                {
                    case 1:
                        ChefForm formchef = new ChefForm();
                        formchef.ShowDialog();
                        break;
                    case 2:
                        ChefForm formchef1 = new ChefForm();
                        formchef1.ShowDialog();
                        break;
                    case 3:
                        CookForm formcook = new CookForm();
                        formcook.ShowDialog();
                        break;
                    case 4:
                        AdminForm formadmin = new AdminForm();
                        formadmin.ShowDialog();
                        break;
                    case 5:
                        DirectorForm formdirector = new DirectorForm();
                        formdirector.ShowDialog();
                        break;
                    case 6:
                        WaiterForm formwaiter = new WaiterForm();
                        formwaiter.ShowDialog();
                        break;
                    default: throw new Exception("Роль не найдена!");
                }
            }
        }
    }
}
