using System.IO;
using System.Threading.Tasks;
using MvvmCross.Platform;
using MvvmCross.Plugins.File;
using EbupVanilla = VersFx.Formats.Text.Epub;


namespace EpubReader.MvvmCross
{
	public class MvxEpubReader : IMvxEpubReader
	{
		/// <summary>
		/// Opens the book synchronously without reading its content. Holds the handle to the EPUB file.
		/// </summary>
		/// <param name="stream">stream from the EPUB file</param>
		/// <returns></returns>
		public EbupVanilla.EpubBookRef OpenBook(Stream stream)
		{
            return EbupVanilla.EpubReader.OpenBook(stream);
		}

		/// <summary>
		/// Opens the book synchronously without reading its content. Holds the handle to the EPUB file.
		/// </summary>
		/// <param name="path">path to the EPUB file</param>
		/// <returns></returns>
		public EbupVanilla.EpubBookRef OpenBook(string path)
		{
            using(var stream = Mvx.Resolve<IMvxFileStore>().OpenRead(path))
            {
                return OpenBook(stream);    
            }
		}

		/// <summary>
		/// Opens the book asynchronously without reading its content. Holds the handle to the EPUB file.
		/// </summary>
		/// <param name="stream">stream from the EPUB file</param>
		/// <returns></returns>
		public async Task<EbupVanilla.EpubBookRef> OpenBookAsync(Stream stream)
		{
            return await EbupVanilla.EpubReader.OpenBookAsync(stream).ConfigureAwait(false);
		}

		/// <summary>
		/// Opens the book asynchronously without reading its content. Holds the handle to the EPUB file.
		/// </summary>
		/// <param name="path">path to the EPUB file</param>
		/// <returns></returns>
		public Task<EbupVanilla.EpubBookRef> OpenBookAsync(string path)
		{
			using (var stream = Mvx.Resolve<IMvxFileStore>().OpenRead(path))
			{
				return OpenBookAsync(stream);
			}
		}

		/// <summary>
		/// Opens the book synchronously and reads all of its content into the memory. Does not hold the handle to the EPUB file.
		/// </summary>
		/// <param name="stream">stream from the EPUB file</param>
		/// <returns></returns>
		public EbupVanilla.EpubBook ReadBook(Stream stream)
		{
            return EbupVanilla.EpubReader.ReadBook(stream);
		}

		/// <summary>
		/// Opens the book synchronously and reads all of its content into the memory. Does not hold the handle to the EPUB file.
		/// </summary>
		/// <param name="path">path to the EPUB file</param>
		/// <returns></returns>
		public EbupVanilla.EpubBook ReadBook(string path)
		{
			using (var stream = Mvx.Resolve<IMvxFileStore>().OpenRead(path))
			{
				return ReadBook(stream);
			}
		}

		/// <summary>
		/// Opens the book asynchronously and reads all of its content into the memory. Does not hold the handle to the EPUB file.
		/// </summary>
		/// <param name="stream">stream from the EPUB file</param>
		/// <returns></returns>
		public async Task<EbupVanilla.EpubBook> ReadBookAsync(Stream stream)
		{
			return await EbupVanilla.EpubReader.ReadBookAsync(stream).ConfigureAwait(false);
		}

		/// <summary>
		/// Opens the book asynchronously and reads all of its content into the memory. Does not hold the handle to the EPUB file.
		/// </summary>
		/// <param name="path">path to the EPUB file</param>
		/// <returns></returns>
		public Task<EbupVanilla.EpubBook> ReadBookAsync(string path)
		{
			using (var stream = Mvx.Resolve<IMvxFileStore>().OpenRead(path))
			{
                return ReadBookAsync(stream);
			}
		}
	}
}
