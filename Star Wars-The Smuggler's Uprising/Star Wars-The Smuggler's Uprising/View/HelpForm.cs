using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheGame
{
    public partial class HelpForm : Form
    {
        InfoManager info;
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            info = new InfoManager();
        }
        private void helpMenuView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {           
            try
            {
                int pos = Convert.ToInt32(e.Node.Tag);
                info.Display(pos, infoBox);
            }
            catch
            {

            }
        }
    }
}
