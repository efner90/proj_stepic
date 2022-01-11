using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Работа_с_файлами
{
    public class CaesarStream : Stream
    {
        int shift;
        Stream underlayingStream;
        public CaesarStream(Stream underlayingStream, int shift)
        {
            this.underlayingStream = underlayingStream;
            this.shift = shift;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            var read = underlayingStream.Read(buffer, offset, count);
            for (int i = offset; i < offset + read; i++)
                buffer[i] = (byte)((buffer[i] - shift + 256) % 256);
            return read;
        }


        public override void Write(byte[] buffer, int offset, int count)
        {
            var toWrite = new byte[count];
            for (int i = offset; i < offset + count; i++)
                toWrite[i - offset] = (byte)((buffer[i] + shift) % 256);
            underlayingStream.Write(toWrite, offset, count);
        }

        #region Другие унаследованные методы
        public override bool CanRead
        {
            get { return underlayingStream.CanRead; }
        }

        public override bool CanSeek
        {
            get { return underlayingStream.CanSeek; }
        }

        public override bool CanWrite
        {
            get { return underlayingStream.CanWrite; }
        }

        public override void Flush()
        {
            underlayingStream.Flush();
        }

        public override long Length
        {
            get { return underlayingStream.Length; }
        }

        public override long Position
        {
            get
            {
                return underlayingStream.Position;
            }
            set
            {
                underlayingStream.Position = value;
            }
        }



        public override long Seek(long offset, SeekOrigin origin)
        {
            return underlayingStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            underlayingStream.SetLength(value);
        }
        #endregion
    }

    class SelfStream
    {
        public static void MainX()
        {
            var memoryStream = new MemoryStream();
            var textWriter = new StreamWriter(new CaesarStream(memoryStream, 1));
            textWriter.WriteLine("Hello, world!");
            textWriter.Flush();

            var buffer = memoryStream.GetBuffer();
            for (int i = 0; i < memoryStream.Position; i++)
                Console.Write((char)(buffer[i]));
            Console.WriteLine();
        }
    }
}
