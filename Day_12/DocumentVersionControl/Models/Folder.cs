using System.Collections.ObjectModel;

namespace DocumentVersionControl.Models
{
    public class Folder
    {
        public string Name { get; set; }
        public ObservableCollection<Folder> Subfolders { get; set; }
        public ObservableCollection<Document> Documents { get; set; }

        public Folder()
        {
            Subfolders = new ObservableCollection<Folder>();
            Documents = new ObservableCollection<Document>();
        }
    }
}