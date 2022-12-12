using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeWar
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnPlay.Location = new Point(this.Width / 2 - this.btnPlay.Width / 2, this.Height/2-this.btnPlay.Height);
            this.btnQuit.Location = new Point(this.Width/2 - this.btnQuit.Width/2, btnPlay.Location.Y + 50);
            this.btnManage.Location = new Point(this.Width / 2 - this.btnManage.Width / 2, btnPlay.Location.Y-50);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageForm frm = new ManageForm();
            frm.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            List<string> teamA = new List<string>();
            List<string> teamB = new List<string>();
            teamA.Add("212");
            teamA.Add("241");
            teamA.Add("807");
            teamB.Add("003");
            teamB.Add("006");
            teamB.Add("009");
            BattleField bf = new BattleField(teamA, teamB);
            bf.ShowDialog();
        }
    }
}
