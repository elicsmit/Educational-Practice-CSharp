using System;
using System.Collections.Generic;

namespace DocumentVersionControl.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public List<DocumentVersion> Versions { get; set; }

        public Document()
        {
            Versions = new List<DocumentVersion>();
        }
    }
}