using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LiveTwitcher
{
    public partial class cls_Streamer : UserControl
    {
        private string id;
        private string g_DescriptionLongue;
        private int g_NbViewers;
        private string g_DefaultTexte;
        private bool g_AlwaysShowCmd;
        private string g_StreamQuality;
        public cls_Streamer(bool pAlwaysShowCmd, string pStreamQuality)
        {
            InitializeComponent();
            g_AlwaysShowCmd = pAlwaysShowCmd;
            g_StreamQuality = pStreamQuality;
        }

        public void ResetDefaultText()
        {
            Texte = g_DefaultTexte;
            this.Enabled = true;
        }

        public string Texte
        {
            get
            {
                return btn_Stream.Text;
            }
            set
            {
                g_DefaultTexte = value;
                string l_Texte = value;
                if (l_Texte.Length > 30)
                    l_Texte = l_Texte.Substring(0, 20) + "...";
                btn_Stream.Text = l_Texte;
            }
        }

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Description
        {
            get
            {
                return btn_Stream.Note;
            }
            set
            {
                string l_Description;
                l_Description = String.Format("{0:n0}", (Viewers * -1)) + " viewers on " + value;
                btn_Stream.Note = l_Description;
            }
        }

        public string DescriptionLongue
        {
            get
            {
                return g_DescriptionLongue;
            }
            set
            {
                g_DescriptionLongue = value;
                g_TlpInfo.SetToolTip(btn_Stream, value);
            }
        }

        public string Image
        {
            set
            {
                pbx_Preview.Load(value);
            }
        }

        public int Viewers
        {
            get
            {
                return g_NbViewers;
            }
            set
            {
                g_NbViewers = value; ;
            }
        }

        private void btn_Stream_Click(object sender, EventArgs e)
        {
            StartStream(g_StreamQuality);
        }

        public void StartStream(string pQuality)
        {
            ProcessStartInfo l_StartInfo = new ProcessStartInfo();
            l_StartInfo.FileName = "livestreamer";
            l_StartInfo.Arguments = " http://www.twitch.tv/" + id + " " + pQuality;
            l_StartInfo.RedirectStandardOutput = true;
            l_StartInfo.RedirectStandardError = true;
            l_StartInfo.UseShellExecute = false;
            if (g_AlwaysShowCmd)
            {
                l_StartInfo.CreateNoWindow = false;
            }
            else
            {
                l_StartInfo.CreateNoWindow = true;
            }
            Process processTemp = new Process();
            processTemp.StartInfo = l_StartInfo;
            processTemp.EnableRaisingEvents = true;
            try
            {
                processTemp.Start();
                this.Enabled = false;
                btn_Stream.Text = "Please wait...";
            }
            catch (Exception)
            {

            }
        }

        private void audioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartStream("audio");
        }

        private void mobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartStream("mobile");
        }

        private void lowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartStream("low");
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartStream("medium");
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartStream("high");
        }

        private void bestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartStream("best");
        }
    }
}
