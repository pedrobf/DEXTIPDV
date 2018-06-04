using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testpim
{
    public partial class SobreDexti : Form
    {
        public SobreDexti()
        {
            InitializeComponent();
          
        }

        private void SobreDexti_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkface.LinkVisited = true;
            System.Diagnostics.Process.Start("CHROME", "https://www.facebook.com/Dexti-115046092709517/");
        }
    }
}
