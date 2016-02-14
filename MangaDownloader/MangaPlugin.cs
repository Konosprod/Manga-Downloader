using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QAD;

public class Chapter : IEquatable<Chapter>
{
    public String Url { get; set; }
    public String Name { get; set; }
    public List<String> Pages { get; set; }

    public Chapter()
    {
        Pages = new List<String>();
    }

    public bool Equals(Chapter other)
    {
        return (other.Url == Url && other.Name == Name);
    }
}

public class Manga
{
    public String Name { get; set; }
    public String Author { get; set; }
    public List<Chapter> Chapters { get; set; }

    public Manga()
    {
        Chapters = new List<Chapter>();
    }
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

        Manga getMangaInfo(String htmlSource);

        List<Chapter> getChapters(String htmlSource);

        List<String> getPages(String htmlSource);

        File getImage(String htmlSource);

        void Clear();
    }
}
