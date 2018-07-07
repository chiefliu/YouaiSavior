using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YouaiSavior
{
    class Utils
    {
        public const string NGA_TIE_LINK = "http://bbs.ngacn.cc/read.php?tid=11817959";
        public const string WEB_PARSER_LINK1 = "https://code.aliyun.com/allan.jiang/CNHDT_NEW/tags";
        public const string WEB_PARSER_LINK2 = "https://code.aliyun.com/allan.jiang/CNHDT_NEW/tags";

        public static bool IsWowPath(string path) {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fileInfoArray = dir.GetFiles();
            int hasWowCount = 0;

            foreach (FileInfo info in fileInfoArray)
            {
                if ("Wow.exe".Equals(info.Name) || "Wow-64.exe".Equals(info.Name))
                {
                    hasWowCount++;
                    if (hasWowCount == 2)
                    {
                        break;
                    }
                }
            }
            if (hasWowCount == 2) {
                return true;
            }
            return false;
        }
    }
}
