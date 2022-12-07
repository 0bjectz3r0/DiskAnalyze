namespace PractWork12
{
    partial class DiskAnalyzeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView = new System.Windows.Forms.ListView();
            this.diskNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diskTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.freeSpaceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percentFreeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.detailsPage = new System.Windows.Forms.TabPage();
            this.topFilesPage = new System.Windows.Forms.TabPage();
            this.chartPage = new System.Windows.Forms.TabPage();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topFilesListView = new System.Windows.Forms.ListView();
            this.fileNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieRadioButton = new System.Windows.Forms.RadioButton();
            this.barRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.detailsPage.SuspendLayout();
            this.topFilesPage.SuspendLayout();
            this.chartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.folderNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.diskNameHeader,
            this.diskTypeHeader,
            this.totalSizeHeader,
            this.freeSpaceHeader,
            this.percentFreeHeader});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1067, 94);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // diskNameHeader
            // 
            this.diskNameHeader.Text = "Name";
            // 
            // diskTypeHeader
            // 
            this.diskTypeHeader.Text = "Type";
            this.diskTypeHeader.Width = 52;
            // 
            // totalSizeHeader
            // 
            this.totalSizeHeader.Text = "Total size";
            // 
            // freeSpaceHeader
            // 
            this.freeSpaceHeader.Text = "Free space";
            this.freeSpaceHeader.Width = 75;
            // 
            // percentFreeHeader
            // 
            this.percentFreeHeader.Text = "% free";
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(144, 4);
            this.folderNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(260, 22);
            this.folderNameTextBox.TabIndex = 2;
            this.folderNameTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FolderNameTextBox_PreviewKeyDown);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.detailsPage);
            this.tabControl.Controls.Add(this.topFilesPage);
            this.tabControl.Controls.Add(this.chartPage);
            this.tabControl.Location = new System.Drawing.Point(8, 36);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1046, 406);
            this.tabControl.TabIndex = 1;
            // 
            // detailsPage
            // 
            this.detailsPage.Controls.Add(this.detailsTextBox);
            this.detailsPage.Location = new System.Drawing.Point(4, 25);
            this.detailsPage.Margin = new System.Windows.Forms.Padding(4);
            this.detailsPage.Name = "detailsPage";
            this.detailsPage.Padding = new System.Windows.Forms.Padding(4);
            this.detailsPage.Size = new System.Drawing.Size(1048, 389);
            this.detailsPage.TabIndex = 0;
            this.detailsPage.Text = "Details";
            this.detailsPage.UseVisualStyleBackColor = true;
            // 
            // topFilesPage
            // 
            this.topFilesPage.Controls.Add(this.topFilesListView);
            this.topFilesPage.Location = new System.Drawing.Point(4, 25);
            this.topFilesPage.Margin = new System.Windows.Forms.Padding(4);
            this.topFilesPage.Name = "topFilesPage";
            this.topFilesPage.Padding = new System.Windows.Forms.Padding(4);
            this.topFilesPage.Size = new System.Drawing.Size(1038, 377);
            this.topFilesPage.TabIndex = 1;
            this.topFilesPage.Text = "Top 10 Files";
            this.topFilesPage.UseVisualStyleBackColor = true;
            // 
            // chartPage
            // 
            this.chartPage.Controls.Add(this.barRadioButton);
            this.chartPage.Controls.Add(this.pieRadioButton);
            this.chartPage.Controls.Add(this.chart);
            this.chartPage.Location = new System.Drawing.Point(4, 25);
            this.chartPage.Margin = new System.Windows.Forms.Padding(4);
            this.chartPage.Name = "chartPage";
            this.chartPage.Size = new System.Drawing.Size(1038, 377);
            this.chartPage.TabIndex = 2;
            this.chartPage.Text = "Chart";
            this.chartPage.UseVisualStyleBackColor = true;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.detailsTextBox.Location = new System.Drawing.Point(3, 3);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.ReadOnly = true;
            this.detailsTextBox.Size = new System.Drawing.Size(1042, 383);
            this.detailsTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a folder name:";
            // 
            // topFilesListView
            // 
            this.topFilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topFilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameColumn,
            this.fileSizeColumn,
            this.pathColumn,
            this.lastWriteTimeColumn});
            this.topFilesListView.HideSelection = false;
            this.topFilesListView.Location = new System.Drawing.Point(3, 3);
            this.topFilesListView.Name = "topFilesListView";
            this.topFilesListView.Size = new System.Drawing.Size(1028, 371);
            this.topFilesListView.TabIndex = 0;
            this.topFilesListView.UseCompatibleStateImageBehavior = false;
            this.topFilesListView.View = System.Windows.Forms.View.Details;
            // 
            // fileNameColumn
            // 
            this.fileNameColumn.Text = "File name";
            // 
            // fileSizeColumn
            // 
            this.fileSizeColumn.Text = "File size";
            // 
            // pathColumn
            // 
            this.pathColumn.Text = "Path";
            // 
            // lastWriteTimeColumn
            // 
            this.lastWriteTimeColumn.Text = "Last write time";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(508, 371);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // pieRadioButton
            // 
            this.pieRadioButton.AutoSize = true;
            this.pieRadioButton.Checked = true;
            this.pieRadioButton.Location = new System.Drawing.Point(590, 42);
            this.pieRadioButton.Name = "pieRadioButton";
            this.pieRadioButton.Size = new System.Drawing.Size(48, 20);
            this.pieRadioButton.TabIndex = 1;
            this.pieRadioButton.TabStop = true;
            this.pieRadioButton.Text = "Pie";
            this.pieRadioButton.UseVisualStyleBackColor = true;
            // 
            // barRadioButton
            // 
            this.barRadioButton.AutoSize = true;
            this.barRadioButton.Location = new System.Drawing.Point(590, 68);
            this.barRadioButton.Name = "barRadioButton";
            this.barRadioButton.Size = new System.Drawing.Size(49, 20);
            this.barRadioButton.TabIndex = 2;
            this.barRadioButton.Text = "Bar";
            this.barRadioButton.UseVisualStyleBackColor = true;
            // 
            // DiskAnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DiskAnalyzeForm";
            this.Text = "DiskAnalyzeForm";
            this.Load += new System.EventHandler(this.DiskAnalyzeForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.detailsPage.ResumeLayout(false);
            this.detailsPage.PerformLayout();
            this.topFilesPage.ResumeLayout(false);
            this.chartPage.ResumeLayout(false);
            this.chartPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader diskNameHeader;
        private System.Windows.Forms.ColumnHeader diskTypeHeader;
        private System.Windows.Forms.ColumnHeader totalSizeHeader;
        private System.Windows.Forms.ColumnHeader freeSpaceHeader;
        private System.Windows.Forms.ColumnHeader percentFreeHeader;
        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage detailsPage;
        private System.Windows.Forms.TabPage topFilesPage;
        private System.Windows.Forms.TabPage chartPage;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView topFilesListView;
        private System.Windows.Forms.ColumnHeader fileNameColumn;
        private System.Windows.Forms.ColumnHeader fileSizeColumn;
        private System.Windows.Forms.ColumnHeader pathColumn;
        private System.Windows.Forms.ColumnHeader lastWriteTimeColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.RadioButton barRadioButton;
        private System.Windows.Forms.RadioButton pieRadioButton;
    }
}

