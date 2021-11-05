using System.IO;
using System.IO.Compression;
using System.Text;

namespace QCService.Helpers.Extensions
{
    public static class GZipExtensions
    {
        public static byte[] Compress(this byte[] data)
        {
            using (var compressedStream = new MemoryStream())
            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Compress))
            {
                zipStream.Write(data, 0, data.Length);
                zipStream.Close();
                return compressedStream.ToArray();
            }
        }

        public static byte[] Compress(this string data)
        {
            if (string.IsNullOrEmpty(data)) return new byte[0];
            var bytes = Encoding.Unicode.GetBytes(data);
            //var bytes =  Encoding.UTF8.GetBytes(data);
            return bytes.Compress();
        }

        public static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        public static string Decompress(this byte[] data)
        {
            using (var compressedStream = new MemoryStream(data))
            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
            using (var resultStream = new MemoryStream())
            {
                zipStream.CopyTo(resultStream);

                return Encoding.Unicode.GetString(resultStream.ToArray());
            }
        }
    }
}
