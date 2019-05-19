using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro re = new Registro();
            re.Show();
        }
    }
}
