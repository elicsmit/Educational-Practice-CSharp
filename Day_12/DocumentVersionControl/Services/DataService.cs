using System;
using System.Collections.ObjectModel;
using DocumentVersionControl.Models;

namespace DocumentVersionControl.Services
{
    public class DataService
    {
        private static DataService _instance;

        public static DataService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataService();
                return _instance;
            }
        }

        public ObservableCollection<Folder> RootFolders { get; set; }

        private DataService()
        {
            RootFolders = new ObservableCollection<Folder>();
            InitializeDemoData();
        }

        private void InitializeDemoData()
        {
            var rootFolder = new Folder { Name = "Мои документы" };
            var projectsFolder = new Folder { Name = "Проекты" };
            var reportsFolder = new Folder { Name = "Отчеты" };

            var doc1 = new Document { Id = 1, Name = "Техническое задание.docx", Path = "Проекты/Техническое задание.docx" };
            doc1.Versions.Add(new DocumentVersion { VersionNumber = 1, Date = DateTime.Now.AddDays(-30), Author = "Иванов И.И.", Description = "Первая версия" });
            doc1.Versions.Add(new DocumentVersion { VersionNumber = 2, Date = DateTime.Now.AddDays(-20), Author = "Петров П.П.", Description = "Правки после ревью" });

            var doc2 = new Document { Id = 2, Name = "Руководство пользователя.doc", Path = "Проекты/Руководство пользователя.doc" };
            doc2.Versions.Add(new DocumentVersion { VersionNumber = 1, Date = DateTime.Now.AddDays(-15), Author = "Иванов И.И.", Description = "Начальная версия" });

            projectsFolder.Documents.Add(doc1);
            projectsFolder.Documents.Add(doc2);

            rootFolder.Subfolders.Add(projectsFolder);
            rootFolder.Subfolders.Add(reportsFolder);

            RootFolders.Add(rootFolder);
        }

        public void AddVersion(Document document, string author, string description)
        {
            int nextVersionNumber = document.Versions.Count + 1;
            var newVersion = new DocumentVersion
            {
                VersionNumber = nextVersionNumber,
                Date = DateTime.Now,
                Author = author,
                Description = description
            };
            document.Versions.Add(newVersion);
        }
    }
}