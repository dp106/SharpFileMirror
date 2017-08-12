namespace SharpFileMirror
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.profileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableConfigItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SharpFileMirror.DataSet1();
            this.progresslabel = new System.Windows.Forms.Label();
            this.copyProgressBar = new System.Windows.Forms.ProgressBar();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonRun = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runOnStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableConfigItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.progresslabel);
            this.tabPage1.Controls.Add(this.copyProgressBar);
            this.tabPage1.Controls.Add(this.statusTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1032, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profileDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.filterDataGridViewTextBoxColumn,
            this.directionDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableConfigItemsBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(9, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 295);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // profileDataGridViewTextBoxColumn
            // 
            this.profileDataGridViewTextBoxColumn.DataPropertyName = "Profile";
            this.profileDataGridViewTextBoxColumn.HeaderText = "Profile";
            this.profileDataGridViewTextBoxColumn.Name = "profileDataGridViewTextBoxColumn";
            this.profileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filterDataGridViewTextBoxColumn
            // 
            this.filterDataGridViewTextBoxColumn.DataPropertyName = "Filter";
            this.filterDataGridViewTextBoxColumn.HeaderText = "Filter";
            this.filterDataGridViewTextBoxColumn.Name = "filterDataGridViewTextBoxColumn";
            this.filterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directionDataGridViewTextBoxColumn
            // 
            this.directionDataGridViewTextBoxColumn.DataPropertyName = "Direction";
            this.directionDataGridViewTextBoxColumn.HeaderText = "Direction";
            this.directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            this.directionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableConfigItemsBindingSource
            // 
            this.tableConfigItemsBindingSource.DataMember = "TableConfigItems";
            this.tableConfigItemsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // progresslabel
            // 
            this.progresslabel.AutoSize = true;
            this.progresslabel.Location = new System.Drawing.Point(700, 322);
            this.progresslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progresslabel.Name = "progresslabel";
            this.progresslabel.Size = new System.Drawing.Size(46, 17);
            this.progresslabel.TabIndex = 3;
            this.progresslabel.Text = "label1";
            // 
            // copyProgressBar
            // 
            this.copyProgressBar.Location = new System.Drawing.Point(771, 310);
            this.copyProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyProgressBar.Name = "copyProgressBar";
            this.copyProgressBar.Size = new System.Drawing.Size(255, 28);
            this.copyProgressBar.TabIndex = 2;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(9, 345);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusTextBox.Size = new System.Drawing.Size(1011, 162);
            this.statusTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1032, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "first";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(1099, 41);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(100, 28);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(1100, 78);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 28);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(1100, 114);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(100, 28);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1100, 151);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1099, 188);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(1100, 225);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(100, 28);
            this.buttonUndo.TabIndex = 6;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1215, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runOnStartupToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem1.Text = "Setup";
            // 
            // runOnStartupToolStripMenuItem
            // 
            this.runOnStartupToolStripMenuItem.CheckOnClick = true;
            this.runOnStartupToolStripMenuItem.Name = "runOnStartupToolStripMenuItem";
            this.runOnStartupToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.runOnStartupToolStripMenuItem.Text = "Run on Startup";
            this.runOnStartupToolStripMenuItem.Click += new System.EventHandler(this.runOnStartupToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 554);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableConfigItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.ProgressBar copyProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label progresslabel;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource tableConfigItemsBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem runOnStartupToolStripMenuItem;
    }
}

