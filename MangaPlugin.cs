using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Chapter
{
    public String Url { get; set; }
    public String Name { get; set; }
    List<String> Images { get; set; }
}

public struct Manga
{
    public String Name { get; set; }
    public String Author { get; set; }
    public List<Chapter> Chapters { get; set; }
}


namespace MangaDownloader
{
    public interface MangaPlugin
    {
        String Name { get; }
        String Creator { get; }
        String Version { get; }
        String Url { get; }

        Manga Manga { get; }
    }
}
