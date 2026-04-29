using System;
using System.IO;
using System.Linq;

namespace FileMonitoringApp
{
    public class FileWatcher
    {
        private readonly FileSystemWatcher _watcher;
        private readonly string _logFilePath = "files_list.txt";
        private readonly string[] _targetExtensions = { ".txt", ".csv", ".xml" };

        public FileWatcher(string directoryPath)
        {
            if (string.IsNullOrWhiteSpace(directoryPath) || !Directory.Exists(directoryPath))
            {
                throw new ArgumentException("Указан некорректный путь к директории.");
            }

            _watcher = new FileSystemWatcher(directoryPath);

            _watcher.NotifyFilter = NotifyFilters.FileName

                                  | NotifyFilters.LastWrite
                                  | NotifyFilters.Size;

            _watcher.Created += OnCreated;
            _watcher.Deleted += OnDeleted;
            _watcher.Changed += OnChanged;
            _watcher.Renamed += OnRenamed;

            _watcher.EnableRaisingEvents = true;
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            ProcessFile(e.FullPath);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            ProcessFile(e.FullPath);
        }

        private void ProcessFile(string filePath)
        {
            try
            {
                string extension = Path.GetExtension(filePath).ToLower();

                if (_targetExtensions.Contains(extension))
                {
                    LogFileName(Path.GetFileName(filePath));
                }
            }
            catch
            {
            }
        }

        private void LogFileName(string fileName)
        {
            try
            {
                File.AppendAllText(_logFilePath, fileName + Environment.NewLine);
            }
            catch (IOException)
            {
            }
        }
    }

    internal class Program
    {
        private static void Main()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            var watcher = new FileWatcher(path);

            Console.WriteLine($"Мониторинг запущен в: {path}");
            Console.WriteLine("Нажмите Enter для завершения...");
            Console.ReadLine();
        }
    }
}
