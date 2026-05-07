using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using DocumentVersionControl.Models;
using DocumentVersionControl.Services;
using DocumentVersionControl.Helpers;
using System.Windows.Input;
using DocumentVersionControl;

namespace DocumentVersionControl.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private DataService _dataService;

        public MainViewModel()
        {
            _dataService = DataService.Instance;
            AddVersionCommand = new RelayCommand(AddVersion, CanAddVersion);
        }

        public ObservableCollection<Folder> Folders
        {
            get { return _dataService.RootFolders; }
        }

        private Folder _selectedFolder;
        public Folder SelectedFolder
        {
            get { return _selectedFolder; }
            set
            {
                _selectedFolder = value;
                OnPropertyChanged();
            }
        }

        private Document _selectedDocument;
        public Document SelectedDocument
        {
            get { return _selectedDocument; }
            set
            {
                _selectedDocument = value;
                OnPropertyChanged();
                (AddVersionCommand as RelayCommand)?.RaiseCanExecuteChanged();
            }
        }

        public ICommand AddVersionCommand { get; }

        private bool CanAddVersion()
        {
            return SelectedDocument != null;
        }

        private void AddVersion()
        {
            if (SelectedDocument == null) return;

            var dialog = new VersionDialog();
            if (dialog.ShowDialog() == true)
            {
                _dataService.AddVersion(SelectedDocument, dialog.Author, dialog.Description);
                OnPropertyChanged(nameof(SelectedDocument));
                MessageBox.Show("Версия добавлена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}