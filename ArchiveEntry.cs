namespace Arc
{
    public class ArchiveEntry
    {
        //FileName stores the file's name without its extension.
        public required string FileName { get; set; }

        // Extension stores the file's extension with dot (.).
        private string extension;

        // Path stores the file's path in the archive
        private string path;

        // Creation date stores the file's creation date.
        public DateTime CreationDate { get; set; }

        // Size stores the file's size.
        public long Size { get; set; }

        public ArchiveEntry()
        {
            extension = "";
            path = "";
        }

        // Reads file's contents by byte.
        public byte[] GetContent()
        {
            throw new NotImplementedException();
        }

        public string Extension
        {
            get { return extension; }
            set
            {
                if (string.IsNullOrEmpty(value)) extension = "";
            }
        }

        public string Path
        {
            get { return path; }
            set
            {
                if (string.IsNullOrEmpty(value)) path = @"\";
            }
        }
    }
}
