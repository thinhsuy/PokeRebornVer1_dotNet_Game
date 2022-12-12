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
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            this.btnView.Location = new Point(this.Width / 2 - this.btnView.Width / 2, this.Height / 2 - this.btnView.Height);
            this.btnBack.Location = new Point(this.Width / 2 - this.btnBack.Width / 2, btnView.Location.Y + 50);
            this.btnCreate.Location = new Point(this.Width / 2 - this.btnCreate.Width / 2, btnView.Location.Y - 50);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GeneratingForm frm = new GeneratingForm();
            frm.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewForm vf = new ViewForm();
            vf.ShowDialog();
        }
    }
}
