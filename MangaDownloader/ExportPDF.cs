using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp;
using PdfSharp.Pdf;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel.Shapes;

namespace MangaDownloader
{
    class ExportPDF
    {
        private string fileOut = "";
        private string pathIn = "";
        private Document document = new Document();
        private PdfDocument pdfDocument = new PdfDocument();

        public ExportPDF(string pathIn, string fileOut)
        {
            Document document = new Document();

            this.pathIn = pathIn;
            this.fileOut = fileOut;

            createPdf();
        }

        private void writeDocument()
        {
            PdfDocumentRenderer renderer = new PdfDocumentRenderer();

            renderer.Document = document;

            renderer.PdfDocument = pdfDocument;

            renderer.RenderDocument();

            renderer.PdfDocument.Save(fileOut);
        }

        private void createPdf()
        {
            String[] filters = {"png", "jpg", "jpeg", "bmp", "gif"};
            String[] chapters = Directory.GetDirectories(pathIn);

            for(int i = 0; i < chapters.Length; i++)
            {
                Section section = document.AddSection();
                String[] pages = GetFilesFrom(chapters[i], filters, false);

                for(int j = 0; j < pages.Length; j++)
                {
                    addPage(section, pages[j]);

                    if(j != pages.Length-1)
                    {
                        section.AddPageBreak();
                    }
                }
            }

            writeDocument();
        }

        private void addPage(Section section, string imgPaths)
        {
            Image image = section.AddImage(imgPaths);
            image.Width = "21cm";
            image.LockAspectRatio = true;
            image.RelativeVertical = RelativeVertical.Page;
            image.RelativeHorizontal = RelativeHorizontal.Page;
            image.WrapFormat.Style = WrapStyle.Through;
        }

        private String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }
    }
}
