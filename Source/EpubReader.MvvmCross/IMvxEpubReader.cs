using System;
using System.IO;
using System.Threading.Tasks;
using VersFx.Formats.Text.Epub;

namespace EpubReader.MvvmCross
{
    public interface IMvxEpubReader
    {
        EpubBookRef OpenBook(Stream stream);
        EpubBookRef OpenBook(string path);
        Task<EpubBookRef> OpenBookAsync(Stream stream);
        Task<EpubBookRef> OpenBookAsync(string path);
        EpubBook ReadBook(Stream stream);
        EpubBook ReadBook(string path);
        Task<EpubBook> ReadBookAsync(Stream stream);
        Task<EpubBook> ReadBookAsync(string path);
    }
}
