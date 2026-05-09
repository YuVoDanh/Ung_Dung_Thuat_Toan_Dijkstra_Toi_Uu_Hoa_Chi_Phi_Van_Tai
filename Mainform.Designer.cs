namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tableLayout = new TableLayoutPanel();
            groupBoxDistance = new GroupBox();
            dgvDistance = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            lblStatus = new StatusStrip();
            groupBoxOptions = new GroupBox();
            btnCalculate = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblTime = new Label();
            lblCosts = new Label();
            lblKilometers = new Label();
            lblGasoline = new Label();
            label4 = new Label();
            comboDestination = new ComboBox();
            label2 = new Label();
            comboStartPoint = new ComboBox();
            groupBoxMap = new GroupBox();
            picmap = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            tableLayout.SuspendLayout();
            groupBoxDistance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistance).BeginInit();
            groupBoxOptions.SuspendLayout();
            groupBoxMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picmap).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(22, 22);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1924, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(51, 27);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(176, 30);
            saveToolStripMenuItem.Text = "Save";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(176, 30);
            openFileToolStripMenuItem.Text = "Open File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(55, 27);
            editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(143, 30);
            clearToolStripMenuItem.Text = "Clear";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(61, 27);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(151, 30);
            aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(31, 27);
            toolStripMenuItem1.Text = " ";
            // 
            // tableLayout
            // 
            tableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayout.ColumnCount = 3;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.77725F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8308182F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.4502869F));
            tableLayout.Controls.Add(groupBoxDistance, 0, 0);
            tableLayout.Controls.Add(groupBoxOptions, 1, 0);
            tableLayout.Controls.Add(groupBoxMap, 2, 0);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 31);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 1;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout.Size = new Size(1924, 1141);
            tableLayout.TabIndex = 2;
            tableLayout.Paint += tableLayoutPanel1_Paint;
            // 
            // groupBoxDistance
            // 
            groupBoxDistance.Controls.Add(dgvDistance);
            groupBoxDistance.Controls.Add(lblStatus);
            groupBoxDistance.Dock = DockStyle.Fill;
            groupBoxDistance.Location = new Point(6, 6);
            groupBoxDistance.Name = "groupBoxDistance";
            groupBoxDistance.Size = new Size(754, 1129);
            groupBoxDistance.TabIndex = 0;
            groupBoxDistance.TabStop = false;
            groupBoxDistance.Text = "Distance";
            // 
            // dgvDistance
            // 
            dgvDistance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDistance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistance.Columns.AddRange(new DataGridViewColumn[] { Column0, Column1, Column2 });
            dgvDistance.Dock = DockStyle.Fill;
            dgvDistance.Location = new Point(3, 26);
            dgvDistance.Name = "dgvDistance";
            dgvDistance.ReadOnly = true;
            dgvDistance.RowHeadersWidth = 57;
            dgvDistance.Size = new Size(748, 1078);
            dgvDistance.TabIndex = 3;
            dgvDistance.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column0
            // 
            Column0.HeaderText = "Path";
            Column0.MinimumWidth = 7;
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Điểm đi";
            Column1.MinimumWidth = 7;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Distance";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // lblStatus
            // 
            lblStatus.ImageScalingSize = new Size(22, 22);
            lblStatus.Location = new Point(3, 1104);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(748, 22);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Ready";
            lblStatus.ItemClicked += lblStatus_ItemClicked;
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Controls.Add(btnCalculate);
            groupBoxOptions.Controls.Add(textBox5);
            groupBoxOptions.Controls.Add(textBox4);
            groupBoxOptions.Controls.Add(textBox2);
            groupBoxOptions.Controls.Add(textBox1);
            groupBoxOptions.Controls.Add(lblTime);
            groupBoxOptions.Controls.Add(lblCosts);
            groupBoxOptions.Controls.Add(lblKilometers);
            groupBoxOptions.Controls.Add(lblGasoline);
            groupBoxOptions.Controls.Add(label4);
            groupBoxOptions.Controls.Add(comboDestination);
            groupBoxOptions.Controls.Add(label2);
            groupBoxOptions.Controls.Add(comboStartPoint);
            groupBoxOptions.Dock = DockStyle.Fill;
            groupBoxOptions.Font = new Font("Sitka Banner", 16.1194019F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxOptions.Location = new Point(769, 6);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Size = new Size(468, 1129);
            groupBoxOptions.TabIndex = 1;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Options";
            groupBoxOptions.Enter += groupBoxOptions_Enter;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ActiveCaption;
            btnCalculate.Font = new Font("Showcard Gothic", 22.02985F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = SystemColors.ButtonHighlight;
            btnCalculate.Location = new Point(6, 905);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(285, 156);
            btnCalculate.TabIndex = 22;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(275, 439);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(180, 45);
            textBox5.TabIndex = 19;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(275, 370);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 45);
            textBox4.TabIndex = 18;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(275, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 45);
            textBox2.TabIndex = 16;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 45);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(11, 439);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(152, 43);
            lblTime.TabIndex = 14;
            lblTime.Text = "Time(hour)";
            lblTime.Click += label8_Click;
            // 
            // lblCosts
            // 
            lblCosts.AutoSize = true;
            lblCosts.Location = new Point(11, 372);
            lblCosts.Name = "lblCosts";
            lblCosts.Size = new Size(195, 43);
            lblCosts.TabIndex = 13;
            lblCosts.Text = "Transport costs";
            lblCosts.Click += label7_Click;
            // 
            // lblKilometers
            // 
            lblKilometers.AutoSize = true;
            lblKilometers.Location = new Point(11, 309);
            lblKilometers.Name = "lblKilometers";
            lblKilometers.Size = new Size(226, 43);
            lblKilometers.TabIndex = 12;
            lblKilometers.Text = "Kilometers (Total)";
            lblKilometers.Click += label6_Click;
            // 
            // lblGasoline
            // 
            lblGasoline.AutoSize = true;
            lblGasoline.Location = new Point(0, 249);
            lblGasoline.Name = "lblGasoline";
            lblGasoline.Size = new Size(273, 43);
            lblGasoline.TabIndex = 11;
            lblGasoline.Text = "Gasoline consumption\r\n";
            lblGasoline.Click += label5_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 105);
            label4.Name = "label4";
            label4.Size = new Size(178, 43);
            label4.TabIndex = 7;
            label4.Text = "Starting point";
            label4.Click += label4_Click;
            // 
            // comboDestination
            // 
            comboDestination.FormattingEnabled = true;
            comboDestination.Location = new Point(275, 177);
            comboDestination.Name = "comboDestination";
            comboDestination.Size = new Size(186, 51);
            comboDestination.TabIndex = 3;
            comboDestination.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 177);
            label2.Name = "label2";
            label2.Size = new Size(157, 43);
            label2.TabIndex = 2;
            label2.Text = "Destination:";
            label2.Click += label2_Click;
            // 
            // comboStartPoint
            // 
            comboStartPoint.FormattingEnabled = true;
            comboStartPoint.Location = new Point(275, 102);
            comboStartPoint.Name = "comboStartPoint";
            comboStartPoint.Size = new Size(187, 51);
            comboStartPoint.TabIndex = 1;
            comboStartPoint.SelectedIndexChanged += comboStartPoint_SelectedIndexChanged;
            // 
            // groupBoxMap
            // 
            groupBoxMap.Controls.Add(picmap);
            groupBoxMap.Dock = DockStyle.Fill;
            groupBoxMap.Location = new Point(1246, 6);
            groupBoxMap.Name = "groupBoxMap";
            groupBoxMap.Size = new Size(672, 1129);
            groupBoxMap.TabIndex = 2;
            groupBoxMap.TabStop = false;
            groupBoxMap.Text = "Map of VietNam";
            groupBoxMap.Enter += groupBox3_Enter;
            // 
            // picmap
            // 
            picmap.Dock = DockStyle.Fill;
            picmap.Image = (Image)resources.GetObject("picmap.Image");
            picmap.Location = new Point(3, 26);
            picmap.Name = "picmap";
            picmap.Size = new Size(666, 1100);
            picmap.SizeMode = PictureBoxSizeMode.StretchImage;
            picmap.TabIndex = 2;
            picmap.TabStop = false;
            picmap.Click += picmap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1172);
            Controls.Add(tableLayout);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayout.ResumeLayout(false);
            groupBoxDistance.ResumeLayout(false);
            groupBoxDistance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistance).EndInit();
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
            groupBoxMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picmap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TableLayoutPanel tableLayout;
        private GroupBox groupBoxDistance;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxOptions;
        private ComboBox comboStartPoint;
        private ComboBox comboDestination;
        private Label label2;
 
        private Label label4;
        private Label lblTime;
        private Label lblCosts;
        private Label lblKilometers;
        private Label lblGasoline;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button btnCalculate;
        private GroupBox groupBoxMap;
        private PictureBox picmap;
        private StatusStrip lblStatus;
        private ToolStripMenuItem toolStripMenuItem1;
        private DataGridView dgvDistance;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    
    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lblStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
    }
}
    
