using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO : Create config components & implements getter/setter

namespace MangaDownloader
{
    public static class Config
    {
        public static void loadConfig()
        {

        }

        public static void setSavePath(String path)
        {

        }

        public static String getFilenameScheme()
        {
            return "%page%";
        }

        public static void setFilenameScheme(String scheme)
        {

        }

        public static String getSaveOutput()
        {
            return "new.txt";
        }

        public static void setSaveOutput(String path)
        {

        }

        public static Boolean getUseFileOutput()
        {
            return false;
        }

        public static void setUseFileOutput(Boolean use)
        {

        }

        public static String getSavePath()
        {
            return "C:\\Users\\kono\\Desktop\\";
        }

        public static String getPathScheme()
        {
            return "%name%/%chapter%/";
        }

        public static void resetSavePath()
        {

        }

        public static String getVersion()
        {
            return "1.0.0";
        }

        public static String getLicence()
        {
            return "GPL v2";
        }


        public static Boolean getUseWebInterface()
        {
            return false;
        }

        public static void setUseWebInterface(Boolean use)
        {

        }

        public static int getTimeInterval()
        {
            return 3600;
        }

        public static void setTimeInterval(int value)
        {

        }

    }
}
