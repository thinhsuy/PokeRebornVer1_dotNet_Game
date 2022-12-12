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
    public partial class SelectEffect : Form
    {
        public List<string> selectedEffect = new List<string>();
        public SelectEffect()
        {
            InitializeComponent();
        }

        private void SelectEffect_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select * from Effect";
            DataSet ds = DBC.SelectDataSet(sql, cnn);
            
            this.dgvEffect.DataSource = ds.Tables[0];
            this.dgvEffect.Columns[0].Width = 120;
            this.dgvEffect.Columns[1].Width = 340;

            DBC.OpenDB(cnn);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int selectedCellCount = dgvEffect.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dgvEffect.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                    return;
                }
                else
                {
                    for (int i = 0;i < selectedCellCount; i++)
                    {
                        selectedEffect.Add(dgvEffect
                            .Rows[dgvEffect.SelectedCells[i].RowIndex]
                            .Cells[0].Value.ToString());
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }


    }
}
