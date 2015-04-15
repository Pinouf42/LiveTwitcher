using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTwitcher
{
    public partial class frm_Username : Form
    {
        string g_Nickname;
        public frm_Username(string pNickname)
        {
            InitializeComponent();
            tbx_Username.Text = pNickname;
            g_Nickname = pNickname;
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            g_Nickname = tbx_Username.Text;
            this.Hide();
        }

        public string Nickname
        {
            get
            {
                return g_Nickname;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
