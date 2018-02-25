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
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
            string query = "SELECT DISTINCT `Make` FROM `MasterSearch`";
            fillCombo(cboMake, query, "Make", null);
            cboMake_SelectedIndexChanged(null, null);
        }
        public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
           // int Bk = ((ItemData)cboMake.SelectedItem).ID;
           // string query = "SELECT DISTINCT `Model` FROM `MasterSearch" + Bk + " ";
            int val;
            Int32.TryParse(cboMake.SelectedValue.ToString(), out val);
            string query = "SELECT DISTINCT `Model` FROM `MasterSearch` = " + val + " ";
            fillCombo(cboModel, query, "Model", null);

        }

    }  public struct ItemData
        {
            public int ID;
            public string EmpName;


        public ItemData(int _ID, string _EMName)
        {

            ID = _ID;
            EmpName = _EMName;

        }

        }
      
}
