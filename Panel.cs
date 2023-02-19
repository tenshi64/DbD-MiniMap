using System.IO;
using System.Windows.Forms;

namespace DbD_MiniMap
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private MiniMap_Displayer displayer;
        private List<string> _paths = new List<string>();
        private void ControlPanel_Load(object sender, EventArgs e)
        {
            displayer = new MiniMap_Displayer();

            FileManagement.CreateDirectory();
            FileManagement.CreateFile();

            numX.Maximum = Screen.PrimaryScreen.Bounds.Width/2;
            numX.Minimum = -Screen.PrimaryScreen.Bounds.Width/2;

            numY.Maximum = Screen.PrimaryScreen.Bounds.Height/2;
            numY.Minimum = -Screen.PrimaryScreen.Bounds.Height/2;

            numX.Value = Convert.ToDecimal(FileManagement.GetValue("LocationX: "));
            numY.Value = Convert.ToDecimal(FileManagement.GetValue("LocationY: "));

            numSizeY.Value = Convert.ToDecimal(FileManagement.GetValue("Size: "));

            listMaps.SelectedIndex = 0;
            _paths.AddRange(FileManagement.GetImages(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps").ToArray());
            
            foreach(string path in FileManagement.GetImages(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps").ToArray())
            {
                listMaps.Items.Add(FileManagement.GetFileName(path));
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (String fileName in openFile.FileNames)
                {
                    if (FileManagement.CopyImage(fileName))
                    {
                        listMaps.Items.Add(FileManagement.GetFileName(fileName));
                        _paths.Add(fileName);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            if(listMaps.SelectedIndex != 0 && listMaps.SelectedItem.ToString() != "None")
            {
                if(FileManagement.DeleteImage(listMaps.SelectedItem.ToString()))
                {
                    listMaps.Items.Remove(listMaps.SelectedItem.ToString());
                    listMaps.SelectedIndex = 0;
                }
            }
        }

        private void numX_ValueChanged(object sender, EventArgs e)
        {
            FileManagement.SaveTextInFile("LocationX: ", numX.Value.ToString());
            if (numX.Value == 0 && numY.Value == 0)
            {
                lblCentered.Text = "MiniMap is centered.";
                lblCentered.ForeColor = SystemColors.MenuHighlight;
            }
            else
            {
                lblCentered.Text = "MiniMap is not centered.";
                lblCentered.ForeColor = Color.Crimson;
            }

            displayer.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - displayer.Width / 2 + Convert.ToInt32(numX.Value), Screen.PrimaryScreen.Bounds.Height / 2 - displayer.Height / 2 - Convert.ToInt32(numY.Value));
        }

        private void numY_ValueChanged(object sender, EventArgs e)
        {
            FileManagement.SaveTextInFile("LocationY: ", numY.Value.ToString());
            if (numX.Value == 0 && numY.Value == 0)
            {
                lblCentered.Text = "MiniMap is centered.";
                lblCentered.ForeColor = SystemColors.MenuHighlight;
            }
            else
            {
                lblCentered.Text = "MiniMap is not centered.";
                lblCentered.ForeColor = Color.Crimson;
            }

            displayer.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - displayer.Width / 2 + Convert.ToInt32(numX.Value), Screen.PrimaryScreen.Bounds.Height / 2 - displayer.Height / 2 - Convert.ToInt32(numY.Value));
        }

        private void listMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listMaps.SelectedItem.ToString() != "None")
            {
                displayer.FileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps\" + listMaps.SelectedItem.ToString();
                displayer.pbMiniMap.LoadAsync(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps\" + listMaps.SelectedItem.ToString());
                displayer.pbMiniMap.Show();
            }
            else
            {
                displayer.pbMiniMap.Hide();
                displayer.FileName = listMaps.SelectedItem.ToString();
                displayer.pbMiniMap.Image = null;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            if(displayer.Visible)
            {
                btnRun.Text = "Run";
                displayer.Hide();
            }
            else
            {
                btnRun.Text = "Close";
                displayer.Show();
            }
        }

        

        private void numSizeY_ValueChanged(object sender, EventArgs e)
        {
            FileManagement.SaveTextInFile("Size: ", numSizeY.Value.ToString());

            displayer.pbMiniMap.Size = new Size(100 + Convert.ToInt32(numSizeY.Value), 100 + Convert.ToInt32(numSizeY.Value));
            displayer.Size = displayer.pbMiniMap.Size;
            displayer.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - displayer.Width / 2 + Convert.ToInt32(numX.Value), Screen.PrimaryScreen.Bounds.Height / 2 - displayer.Height / 2 - Convert.ToInt32(numY.Value));
            displayer.pbMiniMap.Location = new Point(displayer.Width / 2 - displayer.pbMiniMap.Width / 2, displayer.Height / 2 - displayer.pbMiniMap.Height / 2);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FileManagement.DefaultContent();
            Application.Restart();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            displayer.pbMiniMap.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
            displayer.pbMiniMap.Refresh();
        }
    }
}