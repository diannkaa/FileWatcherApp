namespace FileWatcherApp
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher watcher;
        private List<LogEntry> logList = new List<LogEntry>();
        private LogDataManager dataManager = new LogDataManager();
        private string logFilePath = "file_changes_log.txt";
        public Form1()
        {
            InitializeComponent();
            InitializeWatcher();
        }
        private void InitializeWatcher()
        {
            watcher = new FileSystemWatcher();

            watcher.NotifyFilter = NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.LastWrite;

            watcher.Filter = "*.*";

            watcher.Created += OnChanged;
            watcher.Changed += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnRenamed;
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    textBoxPath.Text = dialog.SelectedPath;
            }
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPath.Text) || !Directory.Exists(textBoxPath.Text))
            {
                MessageBox.Show("Оберіть існуючу папку для моніторингу!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!watcher.EnableRaisingEvents)
            {
                watcher.Path = textBoxPath.Text;
                watcher.EnableRaisingEvents = true;

                buttonStartStop.Text = "Зупинити моніторинг";
                buttonSelectFolder.Enabled = false;

                AddLogRecord("СИСТЕМА", $"Моніторинг розпочато: {watcher.Path}");
            }
            else
            {
                watcher.EnableRaisingEvents = false;

                buttonStartStop.Text = "Запустити моніторинг";
                buttonSelectFolder.Enabled = true;

                AddLogRecord("СИСТЕМА", "Моніторинг зупинено.");
            }
        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string message = $"Файл/папку '{e.Name}' було {GetActionName(e.ChangeType)}.";
            AddLogRecord(e.ChangeType.ToString(), message);
            ShowNotification("Зміни у папці", message);
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            string message = $"Перейменовано: '{e.OldName}' -> '{e.Name}'.";
            AddLogRecord("Renamed", message);
            ShowNotification("Перейменування", message);
        }
        private void AddLogRecord(string eventType, string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => AddLogRecord(eventType, message)));
                return;
            }

            LogEntry entry = new LogEntry();

            entry.Timestamp = DateTime.Now;
            entry.EventType = eventType;
            entry.Message = message;

            logList.Add(entry);
            UpdateLogDisplay();

            try
            {
                dataManager.AppendLog(logFilePath, entry);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка запису логу: {ex.Message}");
            }
        }

        private void UpdateLogDisplay()
        {
            listBoxLogs.Items.Clear();

            foreach (LogEntry entry in logList)
                listBoxLogs.Items.Add(entry.ToString());
        }

        private void ShowNotification(string title, string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ShowNotification(title, message)));
                return;
            }

            if (checkBoxNotify.Checked)
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetActionName(WatcherChangeTypes changeType)
        {
            switch (changeType)
            {
                case WatcherChangeTypes.Created:
                    return "створено";
                case WatcherChangeTypes.Changed:
                    return "змінено";
                case WatcherChangeTypes.Deleted: 
                    return "видалено";
                default: 
                    return changeType.ToString().ToLower();
            }
        }
    }
}
