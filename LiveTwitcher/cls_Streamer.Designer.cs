namespace LiveTwitcher
{
    partial class cls_Streamer
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbx_Preview = new System.Windows.Forms.PictureBox();
            this.g_TlpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.rightClickStreamOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startWithADifferentQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Stream = new HueTest.CommandLink();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Preview)).BeginInit();
            this.rightClickStreamOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbx_Preview
            // 
            this.pbx_Preview.Location = new System.Drawing.Point(3, 2);
            this.pbx_Preview.Name = "pbx_Preview";
            this.pbx_Preview.Size = new System.Drawing.Size(105, 58);
            this.pbx_Preview.TabIndex = 0;
            this.pbx_Preview.TabStop = false;
            // 
            // g_TlpInfo
            // 
            this.g_TlpInfo.AutoPopDelay = 15000;
            this.g_TlpInfo.InitialDelay = 500;
            this.g_TlpInfo.ReshowDelay = 100;
            // 
            // rightClickStreamOptions
            // 
            this.rightClickStreamOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWithADifferentQualityToolStripMenuItem});
            this.rightClickStreamOptions.Name = "rightClickStreamOptions";
            this.rightClickStreamOptions.Size = new System.Drawing.Size(154, 48);
            // 
            // startWithADifferentQualityToolStripMenuItem
            // 
            this.startWithADifferentQualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestToolStripMenuItem,
            this.highToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.lowToolStripMenuItem,
            this.mobileToolStripMenuItem,
            this.audioToolStripMenuItem});
            this.startWithADifferentQualityToolStripMenuItem.Name = "startWithADifferentQualityToolStripMenuItem";
            this.startWithADifferentQualityToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.startWithADifferentQualityToolStripMenuItem.Text = "Choose quality";
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
            // btn_Stream
            // 
            this.btn_Stream.ContextMenuStrip = this.rightClickStreamOptions;
            this.btn_Stream.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Stream.Location = new System.Drawing.Point(116, 1);
            this.btn_Stream.Name = "btn_Stream";
            this.btn_Stream.Size = new System.Drawing.Size(264, 60);
            this.btn_Stream.TabIndex = 1;
            this.btn_Stream.Text = "commandLink1";
            this.btn_Stream.UseVisualStyleBackColor = true;
            this.btn_Stream.Click += new System.EventHandler(this.btn_Stream_Click);
            // 
            // cls_Streamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Stream);
            this.Controls.Add(this.pbx_Preview);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "cls_Streamer";
            this.Size = new System.Drawing.Size(383, 62);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Preview)).EndInit();
            this.rightClickStreamOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Preview;
        private HueTest.CommandLink btn_Stream;
        private System.Windows.Forms.ToolTip g_TlpInfo;
        private System.Windows.Forms.ContextMenuStrip rightClickStreamOptions;
        private System.Windows.Forms.ToolStripMenuItem startWithADifferentQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestToolStripMenuItem;
    }
}
