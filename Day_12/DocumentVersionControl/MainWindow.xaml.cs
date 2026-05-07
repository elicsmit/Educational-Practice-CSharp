using System.Windows;
using System.Windows.Controls;
using DocumentVersionControl.Models;
using DocumentVersionControl.Services;

namespace DocumentVersionControl
{
    public partial class MainWindow : Window
    {
        private DataService _dataService;
        private Document _currentDocument;

        public MainWindow()
        {
            InitializeComponent();
            _dataService = DataService.Instance;

            LoadFolders();
        }

        private void LoadFolders()
        {
            foreach (var folder in _dataService.RootFolders)
            {
                var treeItem = CreateTreeViewItem(folder);
                FoldersTreeView.Items.Add(treeItem);
            }
        }

        private TreeViewItem CreateTreeViewItem(Folder folder)
        {
            var item = new TreeViewItem();
            item.Header = "📁 " + folder.Name;
            item.Tag = folder;

            foreach (var subfolder in folder.Subfolders)
            {
                item.Items.Add(CreateTreeViewItem(subfolder));
            }

            foreach (var doc in folder.Documents)
            {
                var docItem = new TreeViewItem();
                docItem.Header = "📄 " + doc.Name;
                docItem.Tag = doc;
                docItem.MouseDoubleClick += DocumentDoubleClick;
                item.Items.Add(docItem);
            }

            return item;
        }

        private void DocumentDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var docItem = sender as TreeViewItem;
            _currentDocument = docItem?.Tag as Document;

            if (_currentDocument != null)
            {
                SelectedDocumentInfo.Text = "Текущий документ: " + _currentDocument.Name;
                VersionsGrid.ItemsSource = null;
                VersionsGrid.ItemsSource = _currentDocument.Versions;
            }
        }

        private void AddVersionButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentDocument == null)
            {
                MessageBox.Show("Сначала выберите документ (дважды кликните на документе)",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var dialog = new VersionDialog();
            if (dialog.ShowDialog() == true)
            {
                _dataService.AddVersion(_currentDocument, dialog.Author, dialog.Description);
                VersionsGrid.ItemsSource = null;
                VersionsGrid.ItemsSource = _currentDocument.Versions;
                MessageBox.Show("Версия добавлена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}