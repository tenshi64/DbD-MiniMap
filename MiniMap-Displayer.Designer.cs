namespace DbD_MiniMap
{
    partial class MiniMap_Displayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniMap_Displayer));
            this.pbMiniMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMiniMap
            // 
            this.pbMiniMap.Location = new System.Drawing.Point(80, 58);
            this.pbMiniMap.Name = "pbMiniMap";
            this.pbMiniMap.Size = new System.Drawing.Size(252, 233);
            this.pbMiniMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMiniMap.TabIndex = 0;
            this.pbMiniMap.TabStop = false;
            this.pbMiniMap.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbMiniMap_LoadCompleted);
            this.pbMiniMap.LocationChanged += new System.EventHandler(this.pbMiniMap_LocationChanged);
            this.pbMiniMap.VisibleChanged += new System.EventHandler(this.pbMiniMap_VisibleChanged);
            // 
            // MiniMap_Displayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(441, 372);
            this.Controls.Add(this.pbMiniMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiniMap_Displayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Displayer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiniMap_Displayer_FormClosing);
            this.Load += new System.EventHandler(this.MiniMap_Displayer_Load);
            this.VisibleChanged += new System.EventHandler(this.MiniMap_Displayer_VisibleChanged);
            this.Move += new System.EventHandler(this.MiniMap_Displayer_Move);
            this.Resize += new System.EventHandler(this.MiniMap_Displayer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal PictureBox pbMiniMap;
    }
}