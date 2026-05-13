using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contfy
{
    public partial class UsuarioContainerForm : Form
    {
        public UsuarioContainerForm()
        {
            InitializeComponent();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            BackColor = Color.FromArgb(30, 30, 45);
        }
    }
}
