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
    public partial class ViewForm : Form
    {
        string IDselected = "";
        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            this.pbContainer.Controls.Add(this.pbPokemon);
            this.pbPokemon.Location = new Point(pbContainer.Width / 2 - pbPokemon.Width / 2, pbContainer.Height / 2 - pbPokemon.Height / 2);
            
            
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select * from Pokemon";
            DataSet ds = DBC.SelectDataSet(sql, cnn);

            this.dgvView.DataSource = ds.Tables[0];

            DBC.OpenDB(cnn);
        }
        void Read_data_selected_Pokemon(SqlConnection cnn) {
            string sql = "select top(1) pi.HP, pi.Attack, pi.Defense, pi.SpecialAttack, pi.SpecialDefense, pi.Speed, es.ImgSrc, a.AbilityName, ps.ImgSrc, a.Describe, es.Based";
            sql += " from Pokemon as p inner join PokeInfor as pi on p.pokeId = pi.pokeId and p.pokeId='" + IDselected + "'";
            sql += " inner join PokeType as pt on pt.pokeId=p.pokeId inner join ElementSource as es on pt.eleId=es.eleId";
            sql += " inner join PokeAbility as pb on pb.pokeId=p.pokeId inner join Ability as a on a.abiId=pb.abiId";
            sql += " inner join PokeSource as ps on ps.pokeId=p.pokeId";
            string str = DBC.ReadInforFromDB(sql, cnn, 11);
            var result = str.Split('\n');
            //set Box value
            pbHP.Value = int.Parse(result[0]);
            pbAtk.Value = int.Parse(result[1]);
            pbDef.Value = int.Parse(result[2]);
            pbSpAtk.Value = int.Parse(result[3]);
            pbSpDef.Value = int.Parse(result[4]);
            pbSpd.Value = int.Parse(result[5]);
            pbElement1.ImageLocation = result[6].ToString();
            pbElement1.SizeMode = PictureBoxSizeMode.StretchImage;
            tbAbility.Text = result[7].ToString();
            //set image
            pbContainer.ImageLocation = result[10].ToString();
            pbContainer.SizeMode = PictureBoxSizeMode.Normal;
            pbContainer.Padding = new Padding(30, 130, 0,0);
            pbPokemon.ImageLocation = result[8].ToString() + "Front.gif";
            pbPokemon.BackColor = Color.Transparent;
            pbPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            //Tooltip
            ttProperties.SetToolTip(pbHP, result[0]);
            ttProperties.SetToolTip(pbAtk, result[1]);
            ttProperties.SetToolTip(pbDef, result[2]);
            ttProperties.SetToolTip(pbSpAtk, result[3]);
            ttProperties.SetToolTip(pbSpDef, result[4]);
            ttProperties.SetToolTip(pbSpd, result[5]);
            ttProperties.SetToolTip(tbAbility, result[9]);

            sql = "select es.ImgSrc from PokeType as pt inner join ElementSource as es on es.eleId=pt.eleId and pt.pokeId='"+IDselected+"'";
            str = DBC.ReadInforFromDB(sql, cnn, 1);
            result = str.Split('\n');
            if (result.Length > 1)
            {
                pbElement1.ImageLocation = result[0].ToString();
                pbElement1.SizeMode = PictureBoxSizeMode.StretchImage;
                pbElement2.ImageLocation = result[1].ToString();
                pbElement2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else return;
        } 

        void Read_skills_selected_Pokemon(SqlConnection cnn)
        {
            string sql = "select s.Name, s.Explain, es.ImgSrc ";
            sql += "from Pokemon as p inner join PokeSkill as ps on p.pokeId=ps.pokeId and p.pokeId='" + IDselected + "'";
            sql += " inner join Skill as s on s.skillId=ps.skillId";
            sql += " inner join ElementSource as es on es.eleId=s.eleId";
            string str = DBC.ReadInforFromDB(sql, cnn, 3);
            var result = str.Split('\n');
            tbSkillA.Text = result[0];
            ttSkill.SetToolTip(tbSkillA, result[1]);
            pbSkillA.ImageLocation = result[2].ToString();
            pbSkillA.SizeMode = PictureBoxSizeMode.StretchImage;
            tbSkillB.Text = result[3];
            ttSkill.SetToolTip(tbSkillB, result[4]);
            pbSkillB.ImageLocation = result[5].ToString();
            pbSkillB.SizeMode = PictureBoxSizeMode.StretchImage;
            tbSkillC.Text = result[6];
            ttSkill.SetToolTip(tbSkillC, result[7]);
            pbSkillC.ImageLocation = result[8].ToString();
            pbSkillC.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IDselected==dgvView.Rows[e.RowIndex].Cells[0].Value.ToString()) return;
            IDselected = dgvView.Rows[e.RowIndex].Cells[0].Value.ToString();
            SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
            if (!DBC.OpenDB(cnn)) return;
            try
            {
                Read_data_selected_Pokemon(cnn);
                Read_skills_selected_Pokemon(cnn);
            } 
            catch(Exception ex)
            {
                DBC.CloseDB(cnn);
                return;
            }
            DBC.CloseDB(cnn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (IDselected == "") return;
            string message = "Do you want to remove this pokemon?";
            string title = "Important Caution!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                SqlConnection cnn = DBC.GetConnect("DB_PokeWar");
                if (!DBC.OpenDB(cnn)) return;

                string sql = "delete from Pokemon where pokeId='"+this.IDselected+"'";
                if (DBC.GetAffectiveRows(sql, cnn, "delete") == 0) MessageBox.Show("Delete Fail!");
                else MessageBox.Show("Delete Successful!");

                DBC.CloseDB(cnn);
            }
            else
            {
                // Do something  
            }
        }

        private void btnCheckSkills_Click(object sender, EventArgs e)
        {
            ViewSkills vs = new ViewSkills();
            vs.ShowDialog();
        }
    }
}
