using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PokeWar
{
    public partial class ViewSkills : Form
    {
        public ViewSkills()
        {
            InitializeComponent();
        }

        private void ViewSkills_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select * from  Skill";
            DataSet ds = DBC.SelectDataSet(sql, cnn);
            dgvSkills.DataSource = ds.Tables[0];
            dgvSkills.Columns[0].Width = 60;
            dgvSkills.Columns[2].Width = 50;
            dgvSkills.Columns[3].Width = 50;
            dgvSkills.Columns[4].Width = 250;
            dgvSkills.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSkills.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSkills.Columns[5].Width = 70;
            dgvSkills.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkills.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DBC.CloseDB(cnn);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
