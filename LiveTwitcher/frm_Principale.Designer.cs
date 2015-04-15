namespace LiveTwitcher
{
    partial class frm_Principale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principale));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.rightClick_Icon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlwaysShowCmdMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderByViewerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.streamQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPermanentlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Bot = new System.Windows.Forms.Panel();
            this.lbl_StayTop = new System.Windows.Forms.LinkLabel();
            this.lbl_ChangeUser = new System.Windows.Forms.LinkLabel();
            this.lbl_Reload = new System.Windows.Forms.LinkLabel();
            this.line_bot = new System.Windows.Forms.Panel();
            this.flp_Streams = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_LiveTwitcher = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lbl_Close = new System.Windows.Forms.LinkLabel();
            this.pbx_Loading = new System.Windows.Forms.PictureBox();
            this.line_top = new System.Windows.Forms.Panel();
            this.rightClick_Icon.SuspendLayout();
            this.panel_Bot.SuspendLayout();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.rightClick_Icon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LiveTwitcher";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // rightClick_Icon
            // 
            this.rightClick_Icon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.showPermanentlyToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.rightClick_Icon.Name = "rightClick_Icon";
            this.rightClick_Icon.Size = new System.Drawing.Size(174, 92);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlwaysShowCmdMenu,
            this.OrderByViewerMenu,
            this.streamQualityToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // AlwaysShowCmdMenu
            // 
            this.AlwaysShowCmdMenu.Name = "AlwaysShowCmdMenu";
            this.AlwaysShowCmdMenu.Size = new System.Drawing.Size(254, 22);
            this.AlwaysShowCmdMenu.Text = "Always show livestreamer window";
            this.AlwaysShowCmdMenu.Click += new System.EventHandler(this.AlwaysShowCmdMenu_Click);
            // 
            // OrderByViewerMenu
            // 
            this.OrderByViewerMenu.Name = "OrderByViewerMenu";
            this.OrderByViewerMenu.Size = new System.Drawing.Size(254, 22);
            this.OrderByViewerMenu.Text = "Order by viewers";
            this.OrderByViewerMenu.Click += new System.EventHandler(this.OrderByViewerMenu_Click);
            // 
            // streamQualityToolStripMenuItem
            // 
            this.streamQualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestToolStripMenuItem,
            this.highToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.lowToolStripMenuItem,
            this.mobileToolStripMenuItem,
            this.audioToolStripMenuItem});
            this.streamQualityToolStripMenuItem.Name = "streamQualityToolStripMenuItem";
            this.streamQualityToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.streamQualityToolStripMenuItem.Text = "Default stream quality";
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.audioToolStripMenuItem.Text = "Audio";
            this.audioToolStripMenuItem.Click += new System.EventHandler(this.audioToolStripMenuItem_Click);
            // 
            // mobileToolStripMenuItem
            // 
            this.mobileToolStripMenuItem.Name = "mobileToolStripMenuItem";
            this.mobileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mobileToolStripMenuItem.Text = "Mobile";
            this.mobileToolStripMenuItem.Click += new System.EventHandler(this.mobileToolStripMenuItem_Click);
            // 
            // lowToolStripMenuItem
            // 
            this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
            this.lowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lowToolStripMenuItem.Text = "Low";
            this.lowToolStripMenuItem.Click += new System.EventHandler(this.lowToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.highToolStripMenuItem_Click);
            // 
            // bestToolStripMenuItem
            // 
            this.bestToolStripMenuItem.Name = "bestToolStripMenuItem";
            this.bestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bestToolStripMenuItem.Text = "Best";
            this.bestToolStripMenuItem.Click += new System.EventHandler(this.bestToolStripMenuItem_Click);
            // 
            // showPermanentlyToolStripMenuItem
            // 
            this.showPermanentlyToolStripMenuItem.Name = "showPermanentlyToolStripMenuItem";
            this.showPermanentlyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showPermanentlyToolStripMenuItem.Text = "Show permanently";
            this.showPermanentlyToolStripMenuItem.Click += new System.EventHandler(this.showPermanentlyToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // panel_Bot
            // 
            this.panel_Bot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Bot.Controls.Add(this.lbl_StayTop);
            this.panel_Bot.Controls.Add(this.lbl_ChangeUser);
            this.panel_Bot.Controls.Add(this.lbl_Reload);
            this.panel_Bot.Location = new System.Drawing.Point(-4, 469);
            this.panel_Bot.Name = "panel_Bot";
            this.panel_Bot.Size = new System.Drawing.Size(416, 42);
            this.panel_Bot.TabIndex = 3;
            // 
            // lbl_StayTop
            // 
            this.lbl_StayTop.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbl_StayTop.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbl_StayTop.Location = new System.Drawing.Point(163, 8);
            this.lbl_StayTop.Name = "lbl_StayTop";
            this.lbl_StayTop.Size = new System.Drawing.Size(93, 23);
            this.lbl_StayTop.TabIndex = 7;
            this.lbl_StayTop.TabStop = true;
            this.lbl_StayTop.Text = "Stay on top";
            this.lbl_StayTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_StayTop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_StayTop_LinkClicked);
            // 
            // lbl_ChangeUser
            // 
            this.lbl_ChangeUser.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbl_ChangeUser.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbl_ChangeUser.Location = new System.Drawing.Point(16, 8);
            this.lbl_ChangeUser.Name = "lbl_ChangeUser";
            this.lbl_ChangeUser.Size = new System.Drawing.Size(93, 23);
            this.lbl_ChangeUser.TabIndex = 6;
            this.lbl_ChangeUser.TabStop = true;
            this.lbl_ChangeUser.Text = "Change user";
            this.lbl_ChangeUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ChangeUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_ChangeUser_LinkClicked);
            // 
            // lbl_Reload
            // 
            this.lbl_Reload.Enabled = false;
            this.lbl_Reload.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbl_Reload.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Reload.Location = new System.Drawing.Point(301, 8);
            this.lbl_Reload.Name = "lbl_Reload";
            this.lbl_Reload.Size = new System.Drawing.Size(100, 23);
            this.lbl_Reload.TabIndex = 5;
            this.lbl_Reload.TabStop = true;
            this.lbl_Reload.Text = "Reload";
            this.lbl_Reload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Reload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Reload_LinkClicked);
            // 
            // line_bot
            // 
            this.line_bot.BackColor = System.Drawing.Color.LightGray;
            this.line_bot.Location = new System.Drawing.Point(-2, 468);
            this.line_bot.Name = "line_bot";
            this.line_bot.Size = new System.Drawing.Size(416, 1);
            this.line_bot.TabIndex = 4;
            // 
            // flp_Streams
            // 
            this.flp_Streams.AutoScroll = true;
            this.flp_Streams.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Streams.Location = new System.Drawing.Point(0, 68);
            this.flp_Streams.Name = "flp_Streams";
            this.flp_Streams.Size = new System.Drawing.Size(409, 400);
            this.flp_Streams.TabIndex = 7;
            this.flp_Streams.WrapContents = false;
            this.flp_Streams.Leave += new System.EventHandler(this.flp_Streams_Leave);
            // 
            // lbl_LiveTwitcher
            // 
            this.lbl_LiveTwitcher.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LiveTwitcher.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LiveTwitcher.ForeColor = System.Drawing.Color.White;
            this.lbl_LiveTwitcher.Location = new System.Drawing.Point(19, 5);
            this.lbl_LiveTwitcher.Name = "lbl_LiveTwitcher";
            this.lbl_LiveTwitcher.Size = new System.Drawing.Size(382, 60);
            this.lbl_LiveTwitcher.TabIndex = 8;
            this.lbl_LiveTwitcher.Text = "LiveTwitcher";
            this.lbl_LiveTwitcher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(165)))));
            this.panel_Top.Controls.Add(this.lbl_Close);
            this.panel_Top.Controls.Add(this.pbx_Loading);
            this.panel_Top.Controls.Add(this.lbl_LiveTwitcher);
            this.panel_Top.Controls.Add(this.line_top);
            this.panel_Top.Location = new System.Drawing.Point(-4, -2);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(416, 69);
            this.panel_Top.TabIndex = 7;
            // 
            // lbl_Close
            // 
            this.lbl_Close.AutoSize = true;
            this.lbl_Close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Close.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbl_Close.LinkColor = System.Drawing.Color.White;
            this.lbl_Close.Location = new System.Drawing.Point(376, 29);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(12, 13);
            this.lbl_Close.TabIndex = 7;
            this.lbl_Close.TabStop = true;
            this.lbl_Close.Text = "x";
            this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Close.Visible = false;
            this.lbl_Close.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Close_LinkClicked);
            // 
            // pbx_Loading
            // 
            this.pbx_Loading.Image = global::LiveTwitcher.Properties.Resources.loading;
            this.pbx_Loading.Location = new System.Drawing.Point(361, 14);
            this.pbx_Loading.Name = "pbx_Loading";
            this.pbx_Loading.Size = new System.Drawing.Size(40, 43);
            this.pbx_Loading.TabIndex = 9;
            this.pbx_Loading.TabStop = false;
            this.pbx_Loading.Visible = false;
            // 
            // line_top
            // 
            this.line_top.BackColor = System.Drawing.Color.LightGray;
            this.line_top.Location = new System.Drawing.Point(2, 68);
            this.line_top.Name = "line_top";
            this.line_top.Size = new System.Drawing.Size(416, 1);
            this.line_top.TabIndex = 5;
            // 
            // frm_Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 508);
            this.ControlBox = false;
            this.Controls.Add(this.line_bot);
            this.Controls.Add(this.panel_Bot);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.flp_Streams);
            this.MaximumSize = new System.Drawing.Size(425, 524);
            this.MinimumSize = new System.Drawing.Size(425, 524);
            this.Name = "frm_Principale";
            this.ShowInTaskbar = false;
            this.Deactivate += new System.EventHandler(this.frm_Principale_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frm_Principale_Shown);
            this.rightClick_Icon.ResumeLayout(false);
            this.panel_Bot.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel panel_Bot;
        private System.Windows.Forms.Panel line_bot;
        private System.Windows.Forms.LinkLabel lbl_Reload;
        private System.Windows.Forms.LinkLabel lbl_ChangeUser;
        private System.Windows.Forms.FlowLayoutPanel flp_Streams;
        private System.Windows.Forms.Label lbl_LiveTwitcher;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.ContextMenuStrip rightClick_Icon;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lbl_Close;
        private System.Windows.Forms.PictureBox pbx_Loading;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlwaysShowCmdMenu;
        private System.Windows.Forms.ToolStripMenuItem OrderByViewerMenu;
        private System.Windows.Forms.ToolStripMenuItem showPermanentlyToolStripMenuItem;
        private System.Windows.Forms.Panel line_top;
        private System.Windows.Forms.LinkLabel lbl_StayTop;
        private System.Windows.Forms.ToolStripMenuItem streamQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestToolStripMenuItem;



    }
}

