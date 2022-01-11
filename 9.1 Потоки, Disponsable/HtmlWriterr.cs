using System;
using System.IO;
using System.Web;
using static System.Console;
using static System.Text.Encodings.Web.HtmlEncoder;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic._9._1_Потоки__Disponsable
{
    class HtmlWriterr : IDisposable
    {
        StreamWriter destination;

        public HtmlWriterr(StreamWriter destination)
        {
            this.destination = destination;
        }

        public void Write(string content)
        {
            destination.WriteLine(content);
        }

        #region Disposable pattern

        private bool isDisposed = false;

        ~HtmlWriterr()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); //деструктор не будет вызываться
        }

        protected virtual void Dispose (bool fromDisposeMethod)
        {
            if (!isDisposed)
            {
                if (fromDisposeMethod)
                {
                    destination.Dispose();
                }
                isDisposed = true;
            }
        }

        #endregion

        public TagToken Tag(string tagName)
        {
            destination.WriteLine("<{0}>", tagName);
            return new TagToken(this, tagName);
        }

        public class TagToken : IDisposable
        {
            readonly HtmlWriterr writer;
            readonly string tag;
            public TagToken(HtmlWriterr writer, string tag)
            {
                this.writer = writer;
                this.tag = tag;
            }

            public void Dispose()
            {
                writer.destination.WriteLine("</{0}>", tag);
            }
        }
    }

    class HtmlWriter
    {
        static void MainX ()
        {
            using (var htmlWriter = new HtmlWriterr(new StreamWriter("text")))
            {
                using (htmlWriter.Tag("body"))
                {
                    htmlWriter.Write("some contetnt");
                }
            }
        }
    }
}
