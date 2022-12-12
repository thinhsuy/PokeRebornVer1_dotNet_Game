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
    public partial class CreatePokemonForm : Form
    {
        public CreatePokemonForm()
        {
            InitializeComponent();
        }

        private void CreatePokemonForm_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            DataSet ds = new DataSet();
            string sql = "select eleId, Name from Element order by Name";
            ds = DBC.SelectDataSet(sql, cnn);

            this.cbElement.DataSource = ds.Tables[0];
            this.cbElement.ValueMember = "eleID";
            this.cbElement.DisplayMember = "Name";

            sql = "select abiId, AbilityName from Ability order by AbilityName";
            ds = DBC.SelectDataSet(sql, cnn);

            this.cbAbility.DataSource = ds.Tables[0];
            this.cbAbility.ValueMember = "abiId";
            this.cbAbility.DisplayMember = "AbilityName";

            sql = "select skillId, Name from Skill where Category='A' order by Name";
            ds = DBC.SelectDataSet(sql, cnn);
            this.cbMoveA.DataSource = ds.Tables[0];
            this.cbMoveA.ValueMember = "skillId";
            this.cbMoveA.DisplayMember = "Name";

            sql = "select skillId, Name from Skill where Category='B' order by Name";
            ds = DBC.SelectDataSet(sql, cnn);
            this.cbMoveB.DataSource = ds.Tables[0];
            this.cbMoveB.ValueMember = "skillId";
            this.cbMoveB.DisplayMember = "Name";

            sql = "select skillId, Name from Skill where Category='C' order by Name";
            ds = DBC.SelectDataSet(sql, cnn);
            this.cbMoveC.DataSource = ds.Tables[0];
            this.cbMoveC.ValueMember = "skillId";
            this.cbMoveC.DisplayMember = "Name";

            DBC.CloseDB(cnn);
        }
        private void Conduct_Insertion()
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select count(*) from Pokemon where pokeId='" + tbID.Text.ToString() + "'";
            if (int.Parse(DBC.GetValueReturn(sql, cnn)) != 0)
            {
                MessageBox.Show("PokeId already exsists");
                return;
            }
            try
            {
                //insert into Pokemon
                sql = "insert into Pokemon(pokeId, Name) values ('" + tbID.Text.ToString() + "', '" + tbName.Text.ToString() + "')";
                if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) MessageBox.Show("Insert fail!");
                //insert into PokeInfor
                sql = "insert into PokeInfor(pokeId, HP, Attack, Defense, SpecialAttack, SpecialDefense, Speed)";
                sql += " values ('" + tbID.Text.ToString() + "', " + int.Parse(tbHP.Text.ToString()) + ", " + int.Parse(tbAtk.Text.ToString()) + " , " + int.Parse(tbDef.Text.ToString());
                sql += ", " + int.Parse(tbSpAtk.Text.ToString()) + ", " + int.Parse(tbSpDef.Text.ToString()) + ", " + int.Parse(tbSpd.Text.ToString()) + ")";
                if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) MessageBox.Show("Insert fail!");
                //insert into PokeType
                sql = "insert into PokeType(pokeId, eleId) ";
                sql += "values ('" + tbID.Text.ToString() + "', '" + cbElement.SelectedValue.ToString() + "')";
                if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) MessageBox.Show("Insert fail!");
                //insert into PokeAbility
                sql = "insert into PokeAbility(pokeId, abiId) ";
                sql += "values ('" + tbID.Text.ToString() + "', '" + cbAbility.SelectedValue.ToString() + "')";
                if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) MessageBox.Show("Insert fail!");
                //insert into PokeSkill
                sql = "insert into PokeSkill(pokeId, skillId) ";
                sql += "values ('" + tbID.Text.ToString() + "', '" + cbMoveA.SelectedValue.ToString() + "')";
                sql += ", ('" + tbID.Text.ToString() + "', '" + cbMoveB.SelectedValue.ToString() + "')";
                sql += ", ('" + tbID.Text.ToString() + "', '" + cbMoveC.SelectedValue.ToString() + "')";
                if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) MessageBox.Show("Insert fail!");
                //insert into PokeSource
                sql = "insert into PokeSource(pokeId, ImgSrc) ";
                sql += "value ('" + tbID.Text.ToString() + "', '" + tbSourcePath.Text.ToString() + "')";
                if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) MessageBox.Show("Insert fail!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(DBC.CatchSqlExeption(ex));
                DBC.CloseDB(cnn);
                return;
            }
            MessageBox.Show("Insert successfully! ");
            DBC.CloseDB(cnn);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbID.Text=="" || tbName.Text=="" || tbAtk.Text=="" || tbHP.Text=="" || tbSpAtk.Text == "" || tbDef.Text == "" || tbSpDef.Text == "" || tbSpd.Text == "")
            {
                MessageBox.Show("Pleas fill all requirement boxes!");
                return;
            }
            Conduct_Insertion();
        }

        private void cbElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select ImgSrc from ElementSource where eleId='"+cbElement.SelectedValue.ToString()+"'";
            string path  = DBC.GetValueReturn(sql, cnn);

            this.pbElement.ImageLocation = path;
            this.pbElement.SizeMode = PictureBoxSizeMode.StretchImage;

            DBC.CloseDB(cnn);
        }

        private void cbMoveA_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select ImgSrc from ElementSource as es inner join Element as e on es.eleId = e.eleId inner join Skill as s on s.eleId = e.eleId and s.skillId = '"+cbMoveA.SelectedValue.ToString()+"'";
            string path = DBC.GetValueReturn(sql, cnn);

            this.pbMoveA.ImageLocation = path;
            this.pbMoveA.SizeMode = PictureBoxSizeMode.StretchImage;

            DBC.CloseDB(cnn);
        }

        private void cbMoveB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select ImgSrc from ElementSource as es inner join Element as e on es.eleId = e.eleId inner join Skill as s on s.eleId = e.eleId and s.skillId = '" + cbMoveB.SelectedValue.ToString() + "'";
            string path = DBC.GetValueReturn(sql, cnn);

            this.pbMoveB.ImageLocation = path;
            this.pbMoveB.SizeMode = PictureBoxSizeMode.StretchImage;

            DBC.CloseDB(cnn);
        }

        private void cbMoveC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select ImgSrc from ElementSource as es inner join Element as e on es.eleId = e.eleId inner join Skill as s on s.eleId = e.eleId and s.skillId = '" + cbMoveC.SelectedValue.ToString() + "'";
            string path = DBC.GetValueReturn(sql, cnn);

            this.pbMoveC.ImageLocation = path;
            this.pbMoveC.SizeMode = PictureBoxSizeMode.StretchImage;

            DBC.CloseDB(cnn);
        }

        private void cbAbility_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select es.ImgSrc from Ability as a inner join Element as e on e.eleId = a.eleId inner join ElementSource as es on es.eleId = e.eleId and a.abiId = '" + cbAbility.SelectedValue.ToString() + "'";
            string path = DBC.GetValueReturn(sql, cnn);

            this.pbAbility.ImageLocation = path;
            this.pbAbility.SizeMode = PictureBoxSizeMode.StretchImage;

            DBC.CloseDB(cnn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
