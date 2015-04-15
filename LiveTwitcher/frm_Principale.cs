using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using Ini;
using System.Threading;
using System.Net.Http;

namespace LiveTwitcher
{
    public partial class frm_Principale : Form
    {
        int g_IterationNb = 0;
        string g_User;
        int g_LastNbOfFollow = 300;
        IniFile g_IniFile;
        bool g_Hide = true;
        bool g_OrderByViewers;
        bool g_AlwaysShowCmd;
        string g_StreamQuality;
        List<cls_Streamer> g_StreamerList;
        HttpClient g_HttpClient;
        public frm_Principale()
        {
            InitializeComponent();
            g_IniFile = new IniFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LiveTwitcher", "config.ini"));
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LiveTwitcher")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LiveTwitcher"));
            }
            g_User = g_IniFile.IniReadValue("config", "username");
            try
            {
                g_OrderByViewers = Convert.ToBoolean(g_IniFile.IniReadValue("config", "orderbyviewers"));
                if (g_OrderByViewers)
                {
                    OrderByViewerMenu.Checked = true;
                }
                else
                {
                    OrderByViewerMenu.Checked = false;
                }
            }
            catch (Exception)
            {
                g_IniFile.IniWriteValue("config", "orderbyviewers", "false");
                OrderByViewerMenu.Checked = false;
                g_OrderByViewers = false;
            }
            try
            {
                g_AlwaysShowCmd = Convert.ToBoolean(g_IniFile.IniReadValue("config", "alwaysshowcmd"));
                if (g_AlwaysShowCmd)
                {
                    AlwaysShowCmdMenu.Checked = true;
                }
                else
                {
                    AlwaysShowCmdMenu.Checked = false;
                }
            }
            catch (Exception)
            {
                g_IniFile.IniWriteValue("config", "orderbyviewers", "false");
                OrderByViewerMenu.Checked = false;
                g_OrderByViewers = false;
            }
            try
            {
                g_StreamQuality = g_IniFile.IniReadValue("config", "streamquality");
                if(g_StreamQuality == "")
                {
                    g_IniFile.IniWriteValue("config", "streamquality", "best");
                    bestToolStripMenuItem.Checked = true;
                    g_StreamQuality = "best";
                }
                switch(g_StreamQuality)
                {
                    case "audio":
                        audioToolStripMenuItem.Checked = true;
                        break;
                    case "mobile":
                        mobileToolStripMenuItem.Checked = true;
                        break;
                    case "low":
                        lowToolStripMenuItem.Checked = true;
                        break;
                    case "medium":
                        mediumToolStripMenuItem.Checked = true;
                        break;
                    case "high":
                        highToolStripMenuItem.Checked = true;
                        break;
                    case "best":
                        bestToolStripMenuItem.Checked = true;
                        break;
                    default:
                        bestToolStripMenuItem.Checked = true;
                        break;
                }
            }
            catch (Exception)
            {
                g_IniFile.IniWriteValue("config", "streamquality", "best");
                bestToolStripMenuItem.Checked = true;
                g_StreamQuality = "best";
            }
            CheckNickname();
            g_StreamerList = new List<cls_Streamer>();
            g_HttpClient = new HttpClient();
        }

        private void CheckNickname()
        {
            if (g_User != "")
            {
                g_IniFile.IniWriteValue("config", "username", g_User);
            }
            else
            {
                frm_Username l_ChangeNickname = new frm_Username(g_User);
                l_ChangeNickname.ShowDialog();
                g_User = l_ChangeNickname.Nickname;
                l_ChangeNickname.Close();
                CheckNickname();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlaceLowerRight();
        }

        private void PlaceLowerRight()
        {
            Screen rightmost = Screen.AllScreens[0];
            this.Left = rightmost.WorkingArea.Right - this.Width - 8;
            this.Top = rightmost.WorkingArea.Bottom - this.Height - 8;
        }

        private async void RequestData(string uri)
        {
            try
            {
                string l_Data;
                using (var u_Response = await g_HttpClient.GetAsync(uri))
                {
                    l_Data = await u_Response.Content.ReadAsStringAsync();
                }
                GetStream(l_Data);
            }
            catch(Exception)
            {

            }
        }

        public void GetStream(string pStreamer)
        {
            try
            {
                dynamic l_Obj = JsonConvert.DeserializeObject(pStreamer);
                if (l_Obj.stream != null)
                {
                    string l_User = l_Obj.stream.channel.display_name;
                    string l_Title = l_Obj.stream.channel.status;
                    string l_PreviewPic = "http://static-cdn.jtvnw.net/previews-ttv/live_user_" + l_Obj.stream.channel.name + "-105x58.jpg";
                    cls_Streamer l_ObjStreamer = new cls_Streamer(g_AlwaysShowCmd, g_StreamQuality);
                    l_ObjStreamer.Viewers = Convert.ToInt32(l_Obj.stream.viewers.ToString()) * -1;
                    l_ObjStreamer.Texte = l_Title;
                    l_ObjStreamer.Image = l_PreviewPic;
                    l_ObjStreamer.ID = l_Obj.stream.channel.name;
                    l_ObjStreamer.DescriptionLongue = l_Title;
                    l_ObjStreamer.Description = l_User;
                    if (g_OrderByViewers)
                    {
                        g_StreamerList.Add(l_ObjStreamer);
                        g_StreamerList = g_StreamerList.OrderBy(o => o.Viewers).ToList();
                        foreach (cls_Streamer fe_Streamer in g_StreamerList)
                        {
                            flp_Streams.Controls.Add(fe_Streamer);
                        }
                    }
                    else
                    {
                        flp_Streams.Controls.Add(l_ObjStreamer);
                    }

                }
                g_IterationNb--;
                if (g_IterationNb < 1)
                {
                    pbx_Loading.Visible = false;
                    lbl_Reload.Enabled = true;
                    lbl_Reload.Text = "Reload";
                }
            }
            catch (Exception)
            {

            }
        }

        public void GetStreamerInfo(string pStreamer)
        {
            try
            {
                RequestData("https://api.twitch.tv/kraken/streams/" + pStreamer);
                g_IterationNb++;
            }
            catch (Exception)
            {

            }
        }

        private void frm_Principale_Deactivate(object sender, EventArgs e)
        {
            if (g_Hide)
            {
                this.Hide();
                g_HttpClient.CancelPendingRequests();
            }
            else
            {
                foreach(cls_Streamer fe_Streamer in flp_Streams.Controls)
                {
                    fe_Streamer.ResetDefaultText();
                }
            }
        }

        private async void RequestFollow(string uri)
        {
            try
            {
                string data;
                using (var response = await g_HttpClient.GetAsync(uri))
                {
                    data = await response.Content.ReadAsStringAsync();
                }
                ProcessFollow(data);
            }
            catch(Exception)
            {

            }
        }

        private void ProcessFollow(string pData)
        {
            string l_Stream = pData.Replace(@"\r\n", "");
            dynamic l_Obj = JsonConvert.DeserializeObject(l_Stream);
            foreach (var fe_Item in l_Obj.follows)
            {
                GetStreamerInfo(fe_Item.channel.name.ToString());
            }
            int.TryParse(l_Obj._total.ToString(), out g_LastNbOfFollow); // NB OF FOLLOWED
        }

        private void LoadStreams()
        {
            flp_Streams.SuspendLayout();
            g_StreamerList.Clear();
            flp_Streams.Controls.Clear();
            flp_Streams.ResumeLayout();
            this.Show();
            this.TopMost = true;
            this.Activate();
            this.Focus();
            pbx_Loading.Visible = true;
            lbl_StayTop.Visible = true;
            g_IterationNb = 0;
            lbl_Reload.Enabled = false;
            lbl_Reload.Text = "Please wait...";
            flp_Streams.Focus();
            try
            {
                for (int i = 0; i < g_LastNbOfFollow; i += 100)
                {
                    RequestFollow("https://api.twitch.tv/kraken/users/" + g_User + "/follows/channels/?limit=100&offset=" + i);

                }
            }
            catch (Exception)
            {

            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if(!this.Visible)
                {
                    LoadStreams();
                }
            }
        }

        private void frm_Principale_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbl_Reload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadStreams();
        }

        private void lbl_ChangeUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Username l_ChangeNickname = new frm_Username(g_User);
            l_ChangeNickname.ShowDialog();
            g_User = l_ChangeNickname.Nickname;
            l_ChangeNickname.Close();
            CheckNickname();
            LoadStreams();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            g_Hide = true;
            lbl_Close.Visible = false;
        }

        private void AlwaysShowCmdMenu_Click(object sender, EventArgs e)
        {
            if (g_AlwaysShowCmd)
            {
                g_IniFile.IniWriteValue("config", "alwaysshowcmd", "false");
                AlwaysShowCmdMenu.Checked = false;
                g_AlwaysShowCmd = false;
            }
            else
            {
                g_IniFile.IniWriteValue("config", "alwaysshowcmd", "true");
                AlwaysShowCmdMenu.Checked = true;
                g_AlwaysShowCmd = true;
            }
        }

        private void OrderByViewerMenu_Click(object sender, EventArgs e)
        {
            if (g_OrderByViewers)
            {
                g_IniFile.IniWriteValue("config", "orderbyviewers", "false");
                OrderByViewerMenu.Checked = false;
                g_OrderByViewers = false;
            }
            else
            {
                g_IniFile.IniWriteValue("config", "orderbyviewers", "true");
                OrderByViewerMenu.Checked = true;
                g_OrderByViewers = true;
            }
        }

        private void showPermanentlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g_Hide = false;
            lbl_Close.Visible = true;
            lbl_StayTop.Visible = false;
            LoadStreams();
        }

        private void lbl_StayTop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            g_Hide = false;
            lbl_Close.Visible = true;
            lbl_StayTop.Visible = false;
            lbl_Close.BringToFront();
        }

        private void flp_Streams_Leave(object sender, EventArgs e)
        {
            flp_Streams.Focus();
        }

        private void audioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioToolStripMenuItem.Checked = true;
            mobileToolStripMenuItem.Checked = false;
            lowToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            highToolStripMenuItem.Checked = false;
            bestToolStripMenuItem.Checked = false;
            g_IniFile.IniWriteValue("config", "streamquality", "audio");
            g_StreamQuality = "audio";
        }

        private void mobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioToolStripMenuItem.Checked = false;
            mobileToolStripMenuItem.Checked = true;
            lowToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            highToolStripMenuItem.Checked = false;
            bestToolStripMenuItem.Checked = false;
            g_IniFile.IniWriteValue("config", "streamquality", "mobile");
            g_StreamQuality = "mobile";
        }

        private void lowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioToolStripMenuItem.Checked = false;
            mobileToolStripMenuItem.Checked = false;
            lowToolStripMenuItem.Checked = true;
            mediumToolStripMenuItem.Checked = false;
            highToolStripMenuItem.Checked = false;
            bestToolStripMenuItem.Checked = false;
            g_IniFile.IniWriteValue("config", "streamquality", "low");
            g_StreamQuality = "low";
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioToolStripMenuItem.Checked = false;
            mobileToolStripMenuItem.Checked = false;
            lowToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = true;
            highToolStripMenuItem.Checked = false;
            bestToolStripMenuItem.Checked = false;
            g_IniFile.IniWriteValue("config", "streamquality", "medium");
            g_StreamQuality = "medium";
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioToolStripMenuItem.Checked = false;
            mobileToolStripMenuItem.Checked = false;
            lowToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            highToolStripMenuItem.Checked = true;
            bestToolStripMenuItem.Checked = false;
            g_IniFile.IniWriteValue("config", "streamquality", "high");
            g_StreamQuality = "high";
        }

        private void bestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioToolStripMenuItem.Checked = false;
            mobileToolStripMenuItem.Checked = false;
            lowToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            highToolStripMenuItem.Checked = false;
            bestToolStripMenuItem.Checked = true;
            g_IniFile.IniWriteValue("config", "streamquality", "best");
            g_StreamQuality = "best";
        }
    }
}
