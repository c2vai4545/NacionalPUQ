using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NacionalPUQ
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            IngresoForm ingresoForm = new IngresoForm();

            this.Hide();
            ingresoForm.ShowDialog();
            this.Show();
        }

        private void verBtn_Click(object sender, EventArgs e)
        {
            VerInfo verInfo = new VerInfo();
            this.Hide();
            verInfo.ShowDialog();
            this.Show();
        }
    }
}
