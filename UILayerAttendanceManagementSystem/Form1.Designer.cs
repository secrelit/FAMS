namespace UILayerAttendanceManagementSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage monthWiseTabPage;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPunchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iptColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awhColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthWiseTabPageHeader = new System.Windows.Forms.Panel();
            this.monthNameButton = new System.Windows.Forms.Button();
            this.ApplicationCloseButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.ApplicationTitleLabel = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.dateWiseTabPage = new System.Windows.Forms.TabPage();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            monthWiseTabPage = new System.Windows.Forms.TabPage();
            monthWiseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.monthWiseTabPageHeader.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.TabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthWiseTabPage
            // 
            monthWiseTabPage.AutoScroll = true;
            monthWiseTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            monthWiseTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            monthWiseTabPage.Controls.Add(this.dataGridView1);
            monthWiseTabPage.Controls.Add(this.monthWiseTabPageHeader);
            monthWiseTabPage.Location = new System.Drawing.Point(4, 42);
            monthWiseTabPage.Name = "monthWiseTabPage";
            monthWiseTabPage.Padding = new System.Windows.Forms.Padding(3);
            monthWiseTabPage.Size = new System.Drawing.Size(1020, 385);
            monthWiseTabPage.TabIndex = 0;
            monthWiseTabPage.Text = "Month-Wise";
            monthWiseTabPage.ToolTipText = "Displays Month \\n Wise Aggregate Status of All Staff Members";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffNameColumn,
            this.deptColumn,
            this.absentColumn,
            this.noPunchColumn,
            this.iptColumn,
            this.lateColumn,
            this.awhColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 332);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // staffNameColumn
            // 
            this.staffNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.staffNameColumn.Frozen = true;
            this.staffNameColumn.HeaderText = "Staff Name";
            this.staffNameColumn.Name = "staffNameColumn";
            this.staffNameColumn.Width = 400;
            // 
            // deptColumn
            // 
            this.deptColumn.HeaderText = "Department";
            this.deptColumn.Name = "deptColumn";
            // 
            // absentColumn
            // 
            this.absentColumn.HeaderText = "ABSENT";
            this.absentColumn.Name = "absentColumn";
            // 
            // noPunchColumn
            // 
            this.noPunchColumn.HeaderText = "NO PUNCH";
            this.noPunchColumn.Name = "noPunchColumn";
            // 
            // iptColumn
            // 
            this.iptColumn.HeaderText = "IPT";
            this.iptColumn.Name = "iptColumn";
            // 
            // lateColumn
            // 
            this.lateColumn.HeaderText = "LATE";
            this.lateColumn.Name = "lateColumn";
            // 
            // awhColumn
            // 
            this.awhColumn.HeaderText = "AVG. WRK HRS.";
            this.awhColumn.Name = "awhColumn";
            // 
            // monthWiseTabPageHeader
            // 
            this.monthWiseTabPageHeader.Controls.Add(this.monthNameButton);
            this.monthWiseTabPageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthWiseTabPageHeader.Location = new System.Drawing.Point(3, 3);
            this.monthWiseTabPageHeader.Name = "monthWiseTabPageHeader";
            this.monthWiseTabPageHeader.Size = new System.Drawing.Size(1014, 47);
            this.monthWiseTabPageHeader.TabIndex = 1;
            // 
            // monthNameButton
            // 
            this.monthNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.monthNameButton.AutoSize = true;
            this.monthNameButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.monthNameButton.FlatAppearance.BorderSize = 2;
            this.monthNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthNameButton.Location = new System.Drawing.Point(372, 2);
            this.monthNameButton.Name = "monthNameButton";
            this.monthNameButton.Size = new System.Drawing.Size(277, 44);
            this.monthNameButton.TabIndex = 0;
            this.monthNameButton.Text = "December 2014";
            this.monthNameButton.UseVisualStyleBackColor = true;
            this.monthNameButton.Click += new System.EventHandler(this.monthNameButton_Click);
            // 
            // ApplicationCloseButton
            // 
            this.ApplicationCloseButton.AutoSize = true;
            this.ApplicationCloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ApplicationCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ApplicationCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ApplicationCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ApplicationCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ApplicationCloseButton.FlatAppearance.BorderSize = 0;
            this.ApplicationCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.ApplicationCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ApplicationCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationCloseButton.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationCloseButton.ForeColor = System.Drawing.Color.White;
            this.ApplicationCloseButton.Location = new System.Drawing.Point(939, 0);
            this.ApplicationCloseButton.Name = "ApplicationCloseButton";
            this.ApplicationCloseButton.Size = new System.Drawing.Size(89, 54);
            this.ApplicationCloseButton.TabIndex = 0;
            this.ApplicationCloseButton.Text = "CLOSE";
            this.ApplicationCloseButton.UseVisualStyleBackColor = false;
            this.ApplicationCloseButton.Click += new System.EventHandler(this.ApplicationCloseButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.headerPanel.Controls.Add(this.ApplicationTitleLabel);
            this.headerPanel.Controls.Add(this.ApplicationCloseButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1028, 54);
            this.headerPanel.TabIndex = 1;
            // 
            // ApplicationTitleLabel
            // 
            this.ApplicationTitleLabel.AutoSize = true;
            this.ApplicationTitleLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationTitleLabel.ForeColor = System.Drawing.Color.White;
            this.ApplicationTitleLabel.Location = new System.Drawing.Point(3, 12);
            this.ApplicationTitleLabel.Name = "ApplicationTitleLabel";
            this.ApplicationTitleLabel.Size = new System.Drawing.Size(405, 30);
            this.ApplicationTitleLabel.TabIndex = 1;
            this.ApplicationTitleLabel.Text = "Staff Attendance Management System";
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabControl.Controls.Add(monthWiseTabPage);
            this.TabControl.Controls.Add(this.dateWiseTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 54);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(20, 3);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1028, 431);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabControl.TabIndex = 2;
            // 
            // dateWiseTabPage
            // 
            this.dateWiseTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateWiseTabPage.Location = new System.Drawing.Point(4, 42);
            this.dateWiseTabPage.Name = "dateWiseTabPage";
            this.dateWiseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dateWiseTabPage.Size = new System.Drawing.Size(1020, 385);
            this.dateWiseTabPage.TabIndex = 1;
            this.dateWiseTabPage.Text = "Date-Wise";
            this.dateWiseTabPage.ToolTipText = "Date Wise Aggregate Status of All Staff Members";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1028, 485);
            this.ControlBox = false;
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.headerPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Staff Attendance Management System";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            monthWiseTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.monthWiseTabPageHeader.ResumeLayout(false);
            this.monthWiseTabPageHeader.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.TabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ApplicationCloseButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label ApplicationTitleLabel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage dateWiseTabPage;
        private System.Windows.Forms.Panel monthWiseTabPageHeader;
        private System.Windows.Forms.Button monthNameButton;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn absentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPunchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iptColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awhColumn;
    }
}

