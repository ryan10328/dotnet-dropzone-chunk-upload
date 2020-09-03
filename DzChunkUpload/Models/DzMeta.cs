using System.Collections.Generic;
using System.Collections.Specialized;

namespace DzChunkUpload.Models
{
    public class DzMeta
    {
        public int intChunkNumber = 0;
        public string dzChunkNumber { get; set; }
        public string dzChunkSize { get; set; }
        public string dzCurrentChunkSize { get; set; }
        public string dzTotalSize { get; set; }
        public string dzIdentifier { get; set; }
        public string dzFilename { get; set; }
        public string dzTotalChunks { get; set; }
        public string dzCurrentChunkByteOffset { get; set; }
        public string userID { get; set; }

        public DzMeta(Dictionary<string, string> values)
        {
            dzChunkNumber = values["dzChunkIndex"];
            dzChunkSize = values["dzChunkSize"];
            dzCurrentChunkSize = values["dzCurrentChunkSize"];
            dzTotalSize = values["dzTotalFileSize"];
            dzIdentifier = values["dzUuid"];
            dzFilename = values["dzFileName"];
            dzTotalChunks = values["dzTotalChunkCount"];
            dzCurrentChunkByteOffset = values["dzChunkByteOffset"];
            userID = values["userID"];
            int.TryParse(dzChunkNumber, out intChunkNumber);
        }

        public DzMeta(NameValueCollection values)
        {
            dzChunkNumber = values["dzChunkIndex"];
            dzChunkSize = values["dzChunkSize"];
            dzCurrentChunkSize = values["dzCurrentChunkSize"];
            dzTotalSize = values["dzTotalFileSize"];
            dzIdentifier = values["dzUuid"];
            dzFilename = values["dzFileName"];
            dzTotalChunks = values["dzTotalChunkCount"];
            dzCurrentChunkByteOffset = values["dzChunkByteOffset"];
            userID = values["userID"];
            int.TryParse(dzChunkNumber, out intChunkNumber);
        }
    }
}