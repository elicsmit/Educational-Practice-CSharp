using System;

namespace DocumentVersionControl.Models
{
    public class DocumentVersion
    {
        public int VersionNumber { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public DocumentVersion()
        {
            Date = DateTime.Now;
        }
    }
}