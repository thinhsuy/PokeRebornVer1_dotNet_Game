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
    public partial class CreateMoveForm : Form
    {
        List<string> AbilityEffects = new List<string>();
        List<string> SkillEffects = new List<string>();
        List<int> AbilityRate = new List<int>();
        List<int> SkillRate = new List<int>();
        public CreateMoveForm()
        {
            InitializeComponent();
        }

        private void LoadEffects()
        {
            tbAbilityEffect.Text = "";
            tbAbilityRate.Text = "";
            foreach (string effect in AbilityEffects)
            {
                tbAbilityEffect.Text += effect + Environment.NewLine ;
                AbilityRate.Add(100);
                tbAbilityRate.Text += "100" + Environment.NewLine ;
            }
            tbSkillEffect.Text = "";
            foreach (string effect in SkillEffects)
            {
                tbSkillEffect.Text += effect + Environment.NewLine;
            }
        }

        private void CreateMoveForm_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            DataSet dsAbilityElement = new DataSet();
            string sql = "select eleId, Name from Element order by Name";
            dsAbilityElement = DBC.SelectDataSet(sql, cnn);
            this.cbAbilityElement.DataSource = dsAbilityElement.Tables[0];
            this.cbAbilityElement.ValueMember = "eleID";
            this.cbAbilityElement.DisplayMember = "Name";

            DataSet dsSkillElement = new DataSet();
            sql = "select eleId, Name from Element order by Name";
            dsSkillElement = DBC.SelectDataSet(sql, cnn);
            this.cbSkillElement.DataSource = dsSkillElement.Tables[0];
            this.cbSkillElement.ValueMember = "eleID";
            this.cbSkillElement.DisplayMember = "Name";

            DataSet dsSkillKind = new DataSet();
            sql = "select distinct Kind from Skill";
            dsSkillKind = DBC.SelectDataSet(sql, cnn);
            this.cbSkillKind.DataSource = dsSkillKind.Tables[0];
            this.cbSkillKind.ValueMember = "Kind";
            this.cbSkillKind.DisplayMember = "Kind";

            DBC.CloseDB(cnn);

            LoadEffects();

        }

        private void Conduct_Ability_Insertion()
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select count(*) from Ability where abiId='" + tbAbilityId.Text.ToString() + "'";
            if (int.Parse(DBC.GetValueReturn(sql, cnn)) != 0)
            {
                MessageBox.Show("PokeId already exsists");
                return;
            }

            try
            {
                //insert into Ability
                sql = "insert into Ability(abiId, AbilityName, eleId, Describe) ";
                sql += "values ('" + tbAbilityId.Text.ToString() + "', '" + tbAbilityName.Text.ToString() + "', '" + cbAbilityElement.SelectedValue.ToString() + "', '" + tbAbilityDescribe.Text.ToString() + "')";
                if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) return;
                //insert into AbilityEffect
                foreach (string effect in AbilityEffects)
                {
                    sql = "insert into AbilityEffect(abiId, Effect) ";
                    sql += "values ('" + tbAbilityId.Text.ToString() + "', '" + effect + "')";
                    if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(DBC.CatchSqlExeption(ex));
                DBC.CloseDB(cnn);
                return;
            }
            MessageBox.Show("Create Ability successfully!");
            DBC.CloseDB(cnn);
        }

        private void btnAddAbility_Click(object sender, EventArgs e)
        {
            if (tbAbilityId.Text == "" || tbAbilityName.Text == "" || tbAbilityDescribe.Text=="")
            {
                MessageBox.Show("Please fill requirement boxes!");
                return;
            }
            string str = tbAbilityRate.Text.ToString();
            AbilityEffects.Clear();
            var values = str.Split('\n');
            foreach (var value in values)
            {
                AbilityRate.Add(int.Parse(value));
            }
            Conduct_Ability_Insertion();
        }

        private void cbAbilityElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select ImgSrc from ElementSource where eleId='" + cbAbilityElement.SelectedValue.ToString() + "'";
            string path = DBC.GetValueReturn(sql, cnn);

            this.pbAbilityElement.ImageLocation = path;
            this.pbAbilityElement.SizeMode = PictureBoxSizeMode.StretchImage;

            DBC.CloseDB(cnn);
        }

        private void btnAddAbilityEffect_Click(object sender, EventArgs e)
        {
            SelectEffect sle = new SelectEffect();
            var result = sle.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.AbilityEffects=sle.selectedEffect;
                LoadEffects();
            }
        }

        private void btnAddSkillEffect_Click(object sender, EventArgs e)
        {
            SelectEffect sle = new SelectEffect();
            var result = sle.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.SkillEffects = sle.selectedEffect;
                LoadEffects();
            }
        }

        private void cbSkillElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select ImgSrc from ElementSource where eleId='" + cbSkillElement.SelectedValue.ToString() + "'";
            string path = DBC.GetValueReturn(sql, cnn);

            this.pbSkillElement.ImageLocation = path;
            this.pbSkillElement.SizeMode = PictureBoxSizeMode.StretchImage;

            DBC.CloseDB(cnn);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Conduct_Insertion_Skill()
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select count(*) from Skill where skillId='" + tbSkillId.Text.ToString() + "'";
            if (int.Parse(DBC.GetValueReturn(sql, cnn)) != 0)
            {
                MessageBox.Show("PokeId already exsists");
                DBC.CloseDB(cnn);
                return;
            }

            try
            {
                //insert into Skill
                sql = "insert into Skill(skillId, Category, Name, Kind, eleId, Explain) ";
                sql += "values ('" + tbSkillId.Text.ToString() + "', '" + tbSkillCategory.Text.ToString() + "', '"+tbSkillName.Text.ToString()+"', '"+cbSkillKind.Text.ToString()+"', '"+cbSkillElement.SelectedValue.ToString()+"', '"+tbSkillDescribe.Text.ToString()+"')";
                if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) return;
                //insert into SkillInfor
                sql = "insert into SkillInfor(skillId, Damage, CountDown) ";
                sql += "values ('" + tbSkillId.Text.ToString() + "', " + int.Parse(tbSkillDamge.Text.ToString()) + ", " + int.Parse(tbSkillCD.Text.ToString()) + ")";
                if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) return;
                //insert into SkillEffect
                if (SkillEffects.Count != SkillRate.Count)
                {
                    MessageBox.Show(SkillEffects.Count.ToString() + " - " + SkillRate.Count.ToString());
                    DBC.CloseDB(cnn);
                    return;
                }
                for (int i = 0; i < SkillEffects.Count; i++)
                {
                    sql = "insert into SkillEffect(skillId, Effect, Rate) ";
                    sql += "values ('" + tbSkillId.Text.ToString() + "', '" + SkillEffects[i] + "', " + SkillRate[i] + ")";
                    if (DBC.GetAffectiveRows(sql, cnn, "insert") == 0) return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(DBC.CatchSqlExeption(ex));
                DBC.CloseDB(cnn);
                return;
            }
            MessageBox.Show("Create Skill successfully!");

            DBC.CloseDB(cnn);
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            string str = tbSkillRate.Text.ToString();
            if (str == "") return;
            SkillRate.Clear();
            var values = str.Split('\n');
            foreach (var value in values)
            {
                try { SkillRate.Add(int.Parse(value.ToString())); }
                catch (Exception ex) { throw; }
            }
            Conduct_Insertion_Skill();
        }

        private void tbSkillRate_KeyDown(object sender, KeyEventArgs e)
        {
            string str = tbSkillRate.Text.ToString();
            int count = str.Split('\n').Length;
            if (count > SkillEffects.Count())
            {
                MessageBox.Show("Out Range of List!");
                tbSkillRate.Text = str.Substring(0, str.Length);
                return;
            } 
        }

        private void tbAbilityRate_KeyDown(object sender, KeyEventArgs e)
        {
            string str = tbAbilityRate.Text.ToString();
            int count = str.Split('\n').Length;
            if (count > AbilityEffects.Count())
            {
                MessageBox.Show("Out Range of List!");
                tbAbilityRate.Text = str.Substring(0, str.Length);
                return;
            } 
        }

        private void btnGetSkillID_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select dbo.GetSKillId()";

            tbSkillId.Text = DBC.GetValueReturn(sql, cnn);

            DBC.CloseDB(cnn);
        }

        private void btnGetAbilityId_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select dbo.GetAbilityId('"+cbAbilityElement.SelectedValue.ToString()+"')";

            tbAbilityId.Text = DBC.GetValueReturn(sql, cnn);

            DBC.CloseDB(cnn);
        }
    }
}
