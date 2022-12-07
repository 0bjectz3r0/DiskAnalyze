using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace PractWork12
{
    public partial class DiskAnalyzeForm : Form
    {
        public DiskAnalyzeForm()
        {
            InitializeComponent();
        }

        private string GetSize(long bytes)
        {
            return bytes >= (1 << 30) ? $"{bytes >> 30} Gb" : (bytes >= (1 << 20) ? $"{bytes >> 20} Mb" : (bytes >= (1 << 10) ? $"{bytes >> 10} Kb" : $"{bytes} B"));
        }

        private List<FileInfo> GetFiles(string path)
        {
            var files = new List<FileInfo>();
            try
            {
                var directory = new DirectoryInfo(path);
                files.AddRange(directory.GetFiles());
                foreach (var subdirectory in Directory.GetDirectories(path))
                {
                    files.AddRange(GetFiles(subdirectory));
                }
            }
            catch (UnauthorizedAccessException) { }
            return files;
        }

        private List<DirectoryInfo> GetDirectories(string path)
        {
            var dirs = new List<DirectoryInfo>();
            try
            {
                var dir = new DirectoryInfo(path);
                dirs.AddRange(dir.GetDirectories());
                foreach (var subdir in Directory.GetDirectories(path))
                {
                    dirs.AddRange(GetDirectories(subdir));
                }
            }
            catch (UnauthorizedAccessException) { }
            return dirs;
        }

        private void DiskAnalyzeForm_Load(object sender, EventArgs e)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    diskNameHeader.Name = drive.Name,
                    diskTypeHeader.Name = drive.DriveType.ToString(),
                    freeSpaceHeader.Name = GetSize(drive.TotalSize),
                    totalSizeHeader.Name = GetSize(drive.TotalFreeSpace),
                    percentFreeHeader.Name = $"{100.0 * drive.TotalFreeSpace / drive.TotalSize:F}%"
                });
                listView.Items.Add(item);
            }
        }

        private void FolderNameTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Dictionary<string, long> data = new Dictionary<string, long>();
            if (e.KeyCode == Keys.Enter)
            {
                if (Directory.Exists(folderNameTextBox.Text))
                {
                    var files = GetFiles(folderNameTextBox.Text);
                    var directories = GetDirectories(folderNameTextBox.Text);
                    var dirSize = GetSize(GetFiles(folderNameTextBox.Text).Sum(file => file.Length));
                    detailsTextBox.Text = $"Amount of files: {files.Count}\r\nAmount of directories: {directories.Count}" +
                        $"\r\nSize of directory: {dirSize}";
                    var orderedFiles = files.OrderByDescending(file => file.Length);
                    for (int i = 0; i < 10; i++)
                    {
                        ListViewItem item = new ListViewItem(new string[]   
                        {
                            fileNameColumn.Name = orderedFiles.ToArray()[i].Name,
                            fileSizeColumn.Name = GetSize(orderedFiles.ToArray()[i].Length),
                            pathColumn.Name = orderedFiles.ToArray()[i].FullName,
                            lastWriteTimeColumn.Name = orderedFiles.ToArray()[i].LastWriteTime.ToString()
                        });
                        topFilesListView.Items.Add(item);
                    }
                    topFilesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    foreach (var file in GetFiles(folderNameTextBox.Text))
                    {
                        if (data.ContainsKey(file.Extension))
                        {
                            data[file.Extension] += file.Length;
                        }
                        else
                        {
                            data.Add(file.Extension, file.Length);
                        }
                    }
                    if (pieRadioButton.Checked)
                    {
                        chart.Series[0].ChartType = SeriesChartType.Pie;
                    }
                    else
                    {
                        chart.Series[0].ChartType = SeriesChartType.Bar;
                    }
                    
                    foreach (var item in data)
                    {
                        chart.Series[0].Points.AddXY(item.Key, item.Value);
                    }
                }
            }
        }

    }
}
