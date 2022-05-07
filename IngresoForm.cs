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
    public partial class IngresoForm : Form
    {
        public IngresoForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0G46PM8;Initial Catalog=NacionalPUQ;Integrated Security=True");
        private void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rutTxt.Text == "" || nombre1Txt.Text == "" || apellido1Txt.Text == "" || telefonoTxt.Text == "" || correoTxt.Text == "" || funcionCombo.Text == "")
                {
                    MessageBox.Show("Debe Llenar todos los campos");
                }
                else
                {
                    SqlCommand cmdinsert = new SqlCommand("Insert into personal values( ' " + rutTxt.Text + " ','" + nombre1Txt.Text + "','" + nombre2Txt.Text + "','" + apellido1Txt.Text + "','" + apellido2Txt.Text + "','" + posicionCombo.Text + "','" + funcionCombo.Text + "','" + telefonoTxt.Text + "','" + correoTxt.Text + "' )", con);
                    con.Open();
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
