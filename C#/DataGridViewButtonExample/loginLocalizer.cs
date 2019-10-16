using APS20192;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewButtonExample
{
    public class loginLocalizer
    {

        public string localizer(userInfo userInfo)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\apsImage";
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (Directory.Exists(path))
            {

                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    string fullName = file.Name;
                    string fullPath = file.FullName;
                    string codeName = fullName.Substring(0, 6);

                    if (codeName == userInfo.Code)
                    {
                        return fullPath;
                    }
                }
                return "";
            }
            else
            {
                return "";
            }

        }

    }
}
