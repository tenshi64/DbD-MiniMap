using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbD_MiniMap
{
    public partial class MiniMap_Displayer : Form
    {
        public MiniMap_Displayer()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private void MiniMap_Displayer_VisibleChanged(object sender, EventArgs e)
        {
            int locationX = int.Parse(FileManagement.GetValue("LocationX"));
            int locationY = int.Parse(FileManagement.GetValue("LocationY"));
            
            int size = int.Parse(FileManagement.GetValue("Size"));

            pbMiniMap.Size = new Size(100 + size, 100 + size);
            this.Size = pbMiniMap.Size;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2 + locationX, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2 - locationY);

            pbMiniMap.Location = new Point(this.Width/2 - pbMiniMap.Width/2, this.Height / 2 - pbMiniMap.Height / 2);

            if (_fileName != "None" && _fileName != null)
            {
                pbMiniMap.LoadAsync(_fileName);
                pbMiniMap.Show();
            }
            else
            {
                pbMiniMap.Hide();
            }
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private void MiniMap_Displayer_Move(object sender, EventArgs e)
        {
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private void MiniMap_Displayer_Resize(object sender, EventArgs e)
        {
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private void MiniMap_Displayer_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.HotTrack;
            this.TransparencyKey = SystemColors.HotTrack;
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private void pbMiniMap_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private void pbMiniMap_LocationChanged(object sender, EventArgs e)
        {
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private void pbMiniMap_VisibleChanged(object sender, EventArgs e)
        {
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private void MiniMap_Displayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
