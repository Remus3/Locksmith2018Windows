using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Locksmith2018
{

    public partial class Form1 : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=sql3.freemysqlhosting.net;port=3306;Initial Catalog='sql3223004';username=sql3223004;password=LmYlAkCZMl");
       // MySqlCommand command;
        //MySqlDataAdapter adapter;
       // DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cboMake.Items.Clear();
            cboModel.Items.Clear();
            connection.Open();
            string qloadstate = "SELECT DISTINCT Make FROM MasterSearch";
            MySqlCommand cmd = new MySqlCommand(qloadstate, connection);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cboMake.Items.Add(dr["Make"]).ToString();
                }

            }
            
            connection.Close();
        }

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on change of info for Make dropdownlist, load cities
            //clear selection
            cboModel.Items.Clear();
            cboModel.Text = "Select Model";
            connection.Open();
            string loadmodel ="SELECT DISTINCT Model FROM MasterSearch where Make='"+cboMake.Text+"' ";
            MySqlCommand cmds = new MySqlCommand(loadmodel, connection);
            MySqlDataReader dr1 = cmds.ExecuteReader();
            if (dr1.HasRows)
            {
                while (dr1.Read())
                {
                    cboModel.Items.Add(dr1["Model"]).ToString();
                }

            }
            connection.Close();
        }
      
    }
}