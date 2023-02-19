namespace DbD_MiniMap
{
    partial class ControlPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.gbLocation = new System.Windows.Forms.GroupBox();
            this.lblCentered = new System.Windows.Forms.Label();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.gbMap = new System.Windows.Forms.GroupBox();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.listMaps = new System.Windows.Forms.ComboBox();
            this.lblMaps = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblFocus = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.lblYpx = new System.Windows.Forms.Label();
            this.numSizeY = new System.Windows.Forms.NumericUpDown();
            this.lblSizeY = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.gbLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            this.gbMap.SuspendLayout();
            this.gbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeY)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(-9, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(21, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(298, 65);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Control Panel";
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(45, 31);
            this.numX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(120, 29);
            this.numX.TabIndex = 1;
            this.numX.ValueChanged += new System.EventHandler(this.numX_ValueChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblX.Location = new System.Drawing.Point(6, 28);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(33, 32);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X:";
            // 
            // gbLocation
            // 
            this.gbLocation.Controls.Add(this.lblCentered);
            this.gbLocation.Controls.Add(this.numY);
            this.gbLocation.Controls.Add(this.lblY);
            this.gbLocation.Controls.Add(this.numX);
            this.gbLocation.Controls.Add(this.lblX);
            this.gbLocation.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbLocation.Location = new System.Drawing.Point(12, 108);
            this.gbLocation.Name = "gbLocation";
            this.gbLocation.Size = new System.Drawing.Size(260, 168);
            this.gbLocation.TabIndex = 3;
            this.gbLocation.TabStop = false;
            this.gbLocation.Text = "Location";
            // 
            // lblCentered
            // 
            this.lblCentered.AutoSize = true;
            this.lblCentered.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCentered.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCentered.Location = new System.Drawing.Point(6, 125);
            this.lblCentered.Name = "lblCentered";
            this.lblCentered.Size = new System.Drawing.Size(186, 28);
            this.lblCentered.TabIndex = 5;
            this.lblCentered.Text = "MiniMap is centered.";
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(45, 86);
            this.numY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(120, 29);
            this.numY.TabIndex = 3;
            this.numY.ValueChanged += new System.EventHandler(this.numY_ValueChanged);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblY.Location = new System.Drawing.Point(6, 83);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(32, 32);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y:";
            // 
            // gbMap
            // 
            this.gbMap.Controls.Add(this.btnRotate);
            this.gbMap.Controls.Add(this.btnRemove);
            this.gbMap.Controls.Add(this.btnImport);
            this.gbMap.Controls.Add(this.listMaps);
            this.gbMap.Controls.Add(this.lblMaps);
            this.gbMap.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbMap.Location = new System.Drawing.Point(303, 108);
            this.gbMap.Name = "gbMap";
            this.gbMap.Size = new System.Drawing.Size(333, 168);
            this.gbMap.TabIndex = 5;
            this.gbMap.TabStop = false;
            this.gbMap.Text = "Import/Choose maps";
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.Gray;
            this.btnRotate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRotate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotate.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRotate.ForeColor = System.Drawing.Color.White;
            this.btnRotate.Location = new System.Drawing.Point(45, 73);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(101, 40);
            this.btnRotate.TabIndex = 9;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(6, 119);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(183, 41);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Delete selected";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Teal;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(205, 119);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(116, 41);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // listMaps
            // 
            this.listMaps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listMaps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listMaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.listMaps.DisplayMember = "0";
            this.listMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listMaps.ForeColor = System.Drawing.Color.White;
            this.listMaps.FormattingEnabled = true;
            this.listMaps.Items.AddRange(new object[] {
            "None"});
            this.listMaps.Location = new System.Drawing.Point(85, 34);
            this.listMaps.Name = "listMaps";
            this.listMaps.Size = new System.Drawing.Size(242, 29);
            this.listMaps.TabIndex = 3;
            this.listMaps.SelectedIndexChanged += new System.EventHandler(this.listMaps_SelectedIndexChanged);
            // 
            // lblMaps
            // 
            this.lblMaps.AutoSize = true;
            this.lblMaps.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaps.Location = new System.Drawing.Point(6, 31);
            this.lblMaps.Name = "lblMaps";
            this.lblMaps.Size = new System.Drawing.Size(73, 32);
            this.lblMaps.TabIndex = 2;
            this.lblMaps.Text = "Maps:";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(498, 306);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(133, 43);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(9, -21);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 15);
            this.lblFocus.TabIndex = 1;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.lblYpx);
            this.gbSize.Controls.Add(this.numSizeY);
            this.gbSize.Controls.Add(this.lblSizeY);
            this.gbSize.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbSize.Location = new System.Drawing.Point(12, 282);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(260, 84);
            this.gbSize.TabIndex = 6;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // lblYpx
            // 
            this.lblYpx.AutoSize = true;
            this.lblYpx.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYpx.Location = new System.Drawing.Point(193, 28);
            this.lblYpx.Name = "lblYpx";
            this.lblYpx.Size = new System.Drawing.Size(37, 32);
            this.lblYpx.TabIndex = 6;
            this.lblYpx.Text = "px";
            // 
            // numSizeY
            // 
            this.numSizeY.Location = new System.Drawing.Point(71, 28);
            this.numSizeY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSizeY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSizeY.Name = "numSizeY";
            this.numSizeY.Size = new System.Drawing.Size(120, 29);
            this.numSizeY.TabIndex = 3;
            this.numSizeY.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numSizeY.ValueChanged += new System.EventHandler(this.numSizeY_ValueChanged);
            // 
            // lblSizeY
            // 
            this.lblSizeY.AutoSize = true;
            this.lblSizeY.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSizeY.Location = new System.Drawing.Point(6, 25);
            this.lblSizeY.Name = "lblSizeY";
            this.lblSizeY.Size = new System.Drawing.Size(59, 32);
            this.lblSizeY.TabIndex = 4;
            this.lblSizeY.Text = "Size:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(290, 306);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(189, 43);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset to default";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 376);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.gbMap);
            this.Controls.Add(this.gbLocation);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(663, 415);
            this.MinimumSize = new System.Drawing.Size(663, 415);
            this.Name = "ControlPanel";
            this.Text = "MiniMap | Control Panel";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.gbLocation.ResumeLayout(false);
            this.gbLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            this.gbMap.ResumeLayout(false);
            this.gbMap.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblName;
        private NumericUpDown numX;
        private Label lblX;
        private GroupBox gbLocation;
        private NumericUpDown numY;
        private Label lblY;
        private GroupBox gbMap;
        private ComboBox listMaps;
        private Label lblMaps;
        private Button btnImport;
        private Button btnRun;
        private Button btnRemove;
        private Label lblCentered;
        private Label lblFocus;
        private GroupBox gbSize;
        private NumericUpDown numSizeY;
        private Label lblSizeY;
        private Label lblYpx;
        private Button btnReset;
        private Button btnRotate;
    }
}