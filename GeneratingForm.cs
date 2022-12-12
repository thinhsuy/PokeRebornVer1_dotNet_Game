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
    public partial class GeneratingForm : Form
    {
        public GeneratingForm()
        {
            InitializeComponent();
        }

        private void btnCreateSkill_Click(object sender, EventArgs e)
        {
            CreateMoveForm createMove = new CreateMoveForm();
            createMove.ShowDialog();
        }

        private void btnCreatePokemon_Click(object sender, EventArgs e)
        {
            CreatePokemonForm createPokemon = new CreatePokemonForm();
            createPokemon.ShowDialog();
        }

        private void GeneratingForm_Load(object sender, EventArgs e)
        {
            btnCreatePokemon.Height = this.Height;
            btnCreatePokemon.Width = this.Width/2;
            btnCreateSkill.Height = this.Height;
            btnCreateSkill.Width = this.Width / 2;
        }
    }
}
