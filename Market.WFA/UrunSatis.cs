using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class UrunSatis : Form
    {
        public UrunSatis()
        {
            InitializeComponent();
        }

        private void lstSatis_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void cbPoset_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPoset.CheckState == CheckState.Checked) nudPoset.Enabled = true;
            else nudPoset.Enabled = false;
        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNakit.Checked == true) pnlNakit.Visible = true;
            else pnlNakit.Visible = false;
        }

        private void rbKrediKarti_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
