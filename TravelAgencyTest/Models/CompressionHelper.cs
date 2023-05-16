using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System.IO;
using System.Text;

namespace TravelAgencyTest.Models
{
    public static class CompressionHelper
    {
        public static byte[] CompressString(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            using (MemoryStream outputStream = new MemoryStream())
            {
                using (DeflaterOutputStream compressor = new DeflaterOutputStream(outputStream, new Deflater(Deflater.BEST_COMPRESSION)))
                {
                    compressor.Write(inputBytes, 0, inputBytes.Length);
                }

                return outputStream.ToArray();
            }
        }

        public static string DecompressString(byte[] input)
        {
            using (MemoryStream inputStream = new MemoryStream(input))
            {
                using (InflaterInputStream decompressor = new InflaterInputStream(inputStream))
                {
                    using (StreamReader reader = new StreamReader(decompressor))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }
    }
}
