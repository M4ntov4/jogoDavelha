using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btJogar_Click(object sender, EventArgs e)
        {
            btnum1.Enabled = true;
            btnum2.Enabled = true;
            btnum3.Enabled = true;
            btnum4.Enabled = true;
            btnum5.Enabled = true;
            btnum6.Enabled = true;
            btnum7.Enabled = true;
            btnum8.Enabled = true;
            btnum9.Enabled = true;
        }

        private void btselcX_Click(object sender, EventArgs e)
        {
            EscolherAvatar escolha = new EscolherAvatar();
            this.Hide();
            escolha.ShowDialog();
            this.Show();

        }
    }
}
