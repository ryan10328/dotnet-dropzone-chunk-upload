using System.Net.Http;
using System.Net.Http.Headers;

namespace DzChunkUpload.Providers
{
    public class CustomMultipartFormDataStreamProvider : MultipartFormDataStreamProvider
    {
        public readonly string _filename;
        public CustomMultipartFormDataStreamProvider(string path, string filename) : base(path)
        {
            _filename = filename;
        }

        public override string GetLocalFileName(HttpContentHeaders headers)
        {
            return _filename;
        }
    }
}