using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaDownloader
{
    public interface MangaPlugin
    {
        String Name { get; }
        String Author { get; }
        String Version { get; }
    }
}
